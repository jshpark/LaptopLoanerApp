using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace LaptopLoaner
{
    public partial class MainForm : Form
    {
        private OleDbConnection connectionOle = new OleDbConnection();
        public MainForm()
        {
            InitializeComponent();
            connectionOle.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=L:\SHARED\laptopEUS\DataSources\LoanerLaptop.accdb; Persist Security Info=False;";
        }

        private void ViewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string absolutePath = @"L:\SHARED\laptopEUS\DataSources\LoanerLaptop.accdb";
            Process.Start(absolutePath);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyCheckOut()) //checks empty fields
            { 
                if (CheckLaptopExistence("SELECT LaptopID FROM LaptopInventory WHERE InInventory = -1 AND LaptopInventory.LaptopID = " + laptopInput.Text, laptopInput.Text)) //checks if laptop exists in inventory
                {  
                    if (CheckLoanerExistence()) //checks if a loaner has already borrowed before and therefore he/she is the database
                    {
                        string previousLaptops = GetPreviousLoanersLaptopInfo();
                        ReturningLoanerUpdate(previousLaptops);
                    }
                    else
                    {
                        NewLoanerUpdate();
                    }
                }
                else
                {
                    laptopInput.Text = "";
                    System.Windows.Forms.MessageBox.Show("Laptop is not avaiable. \n Please check out a different laptop", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private bool CheckEmptyCheckOut()
        {
            if ((laptopInput.Text.Equals("")) || (loanerInput.Text.Equals("")) || (eusInitials.Text.Equals("")))
            {
                System.Windows.Forms.MessageBox.Show("Please do not enter empty fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private bool CheckLaptopExistence(string query, string text)
        {
            connectionOle.Open();
            string checkLaptopQuery = query;
            OleDbCommand checkLaptopCommand = new OleDbCommand(checkLaptopQuery, connectionOle);
            OleDbDataReader checkLaptopReader;
            try
            {
                checkLaptopReader = checkLaptopCommand.ExecuteReader();
                while (checkLaptopReader.Read())
                {
                    if (checkLaptopReader.GetValue(0).ToString().Equals(text))
                    {
                        connectionOle.Close();
                        return true;
                    }
                }
            }
            catch
            {
                connectionOle.Close();
                return false;
            }
            connectionOle.Close();
            return false;
        }

        private bool CheckLoanerExistence()
        {
            connectionOle.Open();
            string checkLoanerQuery = "SELECT Name FROM Loaners"; //Query to check names from the loaner table 
            OleDbCommand checkLoanerCommand = new OleDbCommand(checkLoanerQuery, connectionOle);
            OleDbDataReader checkLoanerReader;
            try
            {
                checkLoanerReader = checkLoanerCommand.ExecuteReader();
                while (checkLoanerReader.Read())
                {
                    if (checkLoanerReader.GetString(0).ToString().Equals(loanerInput.Text))
                    {
                        connectionOle.Close();
                        return true;
                    }
                }
            }
            catch
            {
                connectionOle.Close();
                return false;
            }
            connectionOle.Close();
            return false;
        }

        private string ReturnLoaner(string laptopID)
        {
            string query = "SELECT Name FROM Loaners WHERE Loaners.LaptopID = '" + laptopID + "'";
            OleDbCommand command = new OleDbCommand(query, connectionOle);
            OleDbDataReader reader;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                return reader.GetString(0);
            }
            return "";
        }

        private string GetPreviousLoanersLaptopInfo() //this function is for loaners who borrow more than 1 laptop
        {
            connectionOle.Open();
            string previousLaptopQuery = "SELECT Loaners.LaptopID FROM Loaners WHERE Name = '" + loanerInput.Text + "'";
            OleDbCommand previousLaptopCommand = new OleDbCommand(previousLaptopQuery, connectionOle);
            OleDbDataReader previousLaptopReader;
            string previousLaptops = "";
            try
            {
                previousLaptopReader = previousLaptopCommand.ExecuteReader();
                while (previousLaptopReader.Read())
                {
                    if (!previousLaptopReader.GetString(0).ToString().Equals(""))
                    {
                        previousLaptops = previousLaptopReader.GetString(0).ToString() + ", " + laptopInput.Text;
                        connectionOle.Close();
                        return previousLaptops;
                    }
                }
            }
            catch
            {
                connectionOle.Close();
                return "";
            }
            connectionOle.Close();
            return "";
        }

        private void ClearCheckOutFields()
        {
            laptopInput.Text = "";
            loanerInput.Text = "";
            eusInitials.Text = "";
        }

        private void ReturningLoanerUpdate(string previousLaptops)
        {
            if (previousLaptops.Equals("")) //if existing loaner is not borrowing anything
            {
                //update tables
                UpdateDatabase("UPDATE LaptopInventory SET InInventory = 0 WHERE LaptopInventory.LaptopID = " + laptopInput.Text + ";");

                UpdateDatabase("UPDATE Loaners SET Borrowing = -1, Loaners.LaptopID = '" + laptopInput.Text + "', ExpectedReturnDate = '" + dateTimeReturn.Value.Date + "', EUSInitials = '" + eusInitials.Text + "' WHERE name = '" + loanerInput.Text + "'");

                //user feedback for successful transaction
                WriteToLogCheckOut();
                ClearCheckOutFields();
                System.Windows.Forms.MessageBox.Show("Laptop has been successfully checked out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //update tables
                UpdateDatabase("UPDATE LaptopInventory SET InInventory = 0 WHERE LaptopID = " + laptopInput.Text + ";");

                UpdateDatabase("UPDATE Loaners SET Loaners.LaptopID = '" + previousLaptops + "', ExpectedReturnDate = '" + dateTimeReturn.Value.Date + "', EUSInitials = '" + eusInitials.Text + "' WHERE Name = '" + loanerInput.Text + "'");

                //user feedback for successful transaction
                WriteToLogCheckOut();
                ClearCheckOutFields();
                System.Windows.Forms.MessageBox.Show("Laptop has been successfully checked out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateDatabase(string query)
        {
            connectionOle.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connectionOle;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connectionOle.Close();
        }

        private void NewLoanerUpdate()
        {
            UpdateDatabase("UPDATE LaptopInventory SET InInventory = 0 WHERE LaptopID = " + laptopInput.Text + ";");
            UpdateDatabase("INSERT INTO Loaners(Name, Borrowing, LaptopID, ExpectedReturnDate, EUSInitials) VALUES ('" + loanerInput.Text + "',1,'" + laptopInput.Text + "','" + dateTimeReturn.Value.Date + "', '" + eusInitials.Text + "')");

            //user feedback for successful transaction
            WriteToLogCheckOut();
            ClearCheckOutFields();
            System.Windows.Forms.MessageBox.Show("Laptop has been successfully checked out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetNewLaptops(string previousLaptops)
        {
            if (previousLaptops.Contains(",")) //multiple laptops
            {
                string tempPreviousLaptops = "";
                if (previousLaptops.Contains(", " + laptopReturnInput.Text))
                {
                    tempPreviousLaptops = previousLaptops.Replace(", " + laptopReturnInput.Text, "");
                }
                else if (previousLaptops.Contains(laptopReturnInput.Text + ","))
                {
                    tempPreviousLaptops = previousLaptops.Replace(laptopReturnInput.Text + ", ", "");
                }
                return tempPreviousLaptops;
            }
            else
            {
                return previousLaptops;
            }
        }

        private void ReturnLaptop(string newLaptops, string oldLaptops)
        {
            if (oldLaptops.Contains(",")) //change multiple laptops to less
            {
                WriteToLogReturn(laptopReturnInput.Text);
                UpdateDatabase("UPDATE LaptopInventory SET InInventory = -1 WHERE LaptopInventory.LaptopID = " + laptopReturnInput.Text);
                UpdateDatabase("UPDATE Loaners SET Loaners.LaptopID = '" + newLaptops + "' WHERE Loaners.LaptopID = '" + oldLaptops + "'");

                //user feedback for successful transaction
                laptopReturnInput.Text = "";
                returnInitial.Text = "";
                System.Windows.Forms.MessageBox.Show("Laptop has been successfully returned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //change only one laptop
            {
                if(CheckLaptopExistence("SELECT LaptopInventory.LaptopID FROM LaptopInventory WHERE InInventory = 0 AND LaptopInventory.LaptopID = " + laptopReturnInput.Text, laptopReturnInput.Text))
                {
                    WriteToLogReturn(laptopReturnInput.Text);
                    UpdateDatabase("UPDATE LaptopInventory SET InInventory = -1 WHERE LaptopInventory.LaptopID = " + laptopReturnInput.Text);
                    UpdateDatabase("UPDATE Loaners SET ExpectedReturnDate = NULL, Borrowing = 0, EUSInitials = '', Loaners.LaptopID = '' WHERE Loaners.LaptopID = '" + laptopReturnInput.Text + "'");
                    laptopReturnInput.Text = "";
                    returnInitial.Text = "";
                    System.Windows.Forms.MessageBox.Show("Laptop has been successfully returned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //user feedback for unsuccessful transcation
                    laptopInput.Text = "";
                    System.Windows.Forms.MessageBox.Show("Laptop either does not exist or is already in inventory. \n Please enter a valid laptop ID number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string GetPreviousReturnedLaptopInfo()
        {
            connectionOle.Open();
            string previousLaptopQuery = "SELECT Loaners.LaptopID From Loaners";
            OleDbCommand previousLaptopCommand = new OleDbCommand(previousLaptopQuery, connectionOle);
            OleDbDataReader previousLaptopReader;
            try
            {
                previousLaptopReader = previousLaptopCommand.ExecuteReader();
                while (previousLaptopReader.Read())
                {
                    if (previousLaptopReader.GetValue(0).ToString().Contains(laptopReturnInput.Text))
                    {
                        string newLaptops = previousLaptopReader.GetValue(0).ToString();
                        connectionOle.Close();
                        return newLaptops;
                    }
                }
            }
            catch
            {
                connectionOle.Close();
                return "";
            }
            connectionOle.Close();
            return "";
        }

        private bool checkEmptyReturn()
        {
            if ((laptopReturnInput.Text.Equals("")) || (returnInitial.Text.Equals("")))
            {
                System.Windows.Forms.MessageBox.Show("Please do not enter empty fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (!checkEmptyReturn())
            {
                if (CheckLaptopExistence("SELECT LaptopInventory.LaptopID FROM LaptopInventory", laptopReturnInput.Text))
                {
                    string previousLaptopInfo = GetPreviousReturnedLaptopInfo();

                    string newLaptopinfo = GetNewLaptops(previousLaptopInfo);
                    ReturnLaptop(newLaptopinfo, previousLaptopInfo);
                }
                else
                {
                    laptopInput.Text = "";
                    returnInitial.Text = "";
                    System.Windows.Forms.MessageBox.Show("Laptop either does not exist. \n Please enter a valid laptop ID number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            this.Hide();
            inventoryForm.StartPosition = FormStartPosition.CenterScreen;
            inventoryForm.ShowDialog();
            this.Close();
        }

        private void WriteToExcel(string fileName, string query, bool writeColumns)
        {
            try
            {
                connectionOle.Open();
                OleDbCommand command = new OleDbCommand(query, connectionOle);
                OleDbDataReader reader;
                reader = command.ExecuteReader();
                AttachData(reader, fileName, writeColumns);
                connectionOle.Close();
            }
            catch
            {
            }

        }

        private void AttachInventoryHeaders(string fileName)
        {
            try
            {
                File.WriteAllText(fileName, "Laptop ID");
                File.AppendAllText(fileName, ",");
                File.AppendAllText(fileName, "Asset Tag");
                File.AppendAllText(fileName, ",");
                File.AppendAllText(fileName, "Model");
                File.AppendAllText(fileName, ",");
                File.AppendAllText(fileName, "In Inventory?");
                File.AppendAllText(fileName, "\n");
            }
            catch
            {
            }
        }

        private void AttachLoanedLaptopHeaders(string fileName)
        {
            try
            {
                File.WriteAllText(fileName, "Name");
                File.AppendAllText(fileName, ",");
                File.AppendAllText(fileName, "Laptop ID");
                File.AppendAllText(fileName, ",");
                File.AppendAllText(fileName, "Expected Return Date");
                File.AppendAllText(fileName, "\n");
            }
            catch //do nothing to open excel
            {
            }
        }

        private void AttachData(OleDbDataReader reader, string fileName, bool showColumns) //write to csv
        {
            while (reader.Read())
            {
                File.AppendAllText(fileName, reader.GetValue(0).ToString());
                File.AppendAllText(fileName, ",");
                if (showColumns)
                {
                    File.AppendAllText(fileName, reader.GetValue(1).ToString());
                    File.AppendAllText(fileName, ",");
                }
                if (!showColumns)
                {
                    File.AppendAllText(fileName, '"' + reader.GetValue(2).ToString() + '"');
                    File.AppendAllText(fileName, ",");
                }
                else
                {
                    File.AppendAllText(fileName, reader.GetValue(2).ToString());
                    File.AppendAllText(fileName, ",");
                }
                File.AppendAllText(fileName, reader.GetValue(3).ToString());
                File.AppendAllText(fileName, "\n");

            }
        }

        private void ViewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttachInventoryHeaders("Inventory.csv");
            WriteToExcel("Inventory.csv", "SELECT * FROM LaptopInventory", true);
            try
            {
                Process.Start("Inventory.csv");
            }
            catch //do nothing to open excel
            {
            }
        }

        private void ViewLoanedLaptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttachLoanedLaptopHeaders("LoanedLaptops.csv");
            WriteToExcel("LoanedLaptops.csv", "SELECT * FROM Loaners WHERE ExpectedReturnDate IS NOT NULL", false);
            try
            {
                Process.Start("LoanedLaptops.csv");
            }
            catch //do nothing to open excel
            {
            }
        }

        private void LaptopReturnInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                returnButton_Click(this, new EventArgs());
            }
        }

        


        private void WriteToLogReturn(string laptopID)
        {
            //Save the file path as a string.
            string path = @"L:\SHARED\laptopEUS\DataSources\DataSourcesLog.txt";

            connectionOle.Open(); //Open a connection to the MS Access Database 

            FileStream generate_log = new FileStream(path, FileMode.Append, FileAccess.Write); //Open filestream , File mode will append data to existing file.
            StreamWriter log = new StreamWriter(generate_log); // Open Streamwrite
            var check_in_date_and_time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt"); //Write The Current Date and Time To String Format in Months, Days, Years, Hours, Minutes, Seconds
      
            //Write the information to the .txt log file
            log.WriteLine(new string('-', 100));
            log.WriteLine("Laptop ID: " + laptopID);
            log.WriteLine("Return Date/Time: <" + check_in_date_and_time + ">  ");
            string loaner = ReturnLoaner(laptopID);
            log.WriteLine("Borrower: " + loaner);
            log.WriteLine("Employee: " + returnInitial.Text);
            log.WriteLine("");
            connectionOle.Close(); //Close the connection to the database
            log.Close(); //Close StreamWriter
            generate_log.Close(); //Close FileStream
            connectionOle.Close();
        }

        private void WriteToLogCheckOut()
        {
            //Save the file path as a string.
            string path = @"L:\SHARED\laptopEUS\DataSources\DataSourcesLog.txt";

            connectionOle.Open(); //Open a connection to the MS Access Database 

            FileStream generate_log = new FileStream(path, FileMode.Append, FileAccess.Write); //Open filestream , File mode will append data to existing file.
            StreamWriter log = new StreamWriter(generate_log); // Open Streamwrite
            var check_in_date_and_time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt"); //Write The Current Date and Time To String Format in Months, Days, Years, Hours, Minutes, Seconds

            //Write the information to the .txt log file
            log.WriteLine(new string('-', 100)); //Allocate 100 '-' characters to the txt file.
            log.WriteLine("Laptop ID: " + laptopInput.Text);
            log.WriteLine("Check in Time: <" + check_in_date_and_time + ">");
            log.WriteLine("Borrower: " + loanerInput.Text);
            log.WriteLine("Employee: " + eusInitials.Text);
            log.WriteLine("");
            connectionOle.Close(); //Close the connection to the database
            log.Close(); //Close StreamWriter
            generate_log.Close(); //Close FileStream
        }

        private void LogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string absolutePath = @"L:\SHARED\laptopEUS\DataSources\DataSourcesLog.txt";
            Process.Start(absolutePath);
        }

        private void DataVisualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Features features = new Features();
            this.Hide();
            features.StartPosition = FormStartPosition.CenterScreen;
            features.ShowDialog();
            this.Close();
        }
    }
}
