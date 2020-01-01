using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;

namespace LaptopLoaner
{
    public partial class InventoryForm : Form
    {
        private OleDbConnection connectionOle = new OleDbConnection();
        public InventoryForm()
        {
            InitializeComponent();
            connectionOle.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=L:\SHARED\laptopEUS\DataSources\LoanerLaptop.accdb; Persist Security Info=False;";

        }

        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.ShowDialog();
            this.Close();
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

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
           e.Graphics.DrawRectangle(Pens.Black,
           e.ClipRectangle.Left,
           e.ClipRectangle.Top,
           e.ClipRectangle.Width - 1,
           e.ClipRectangle.Height - 1);
           base.OnPaint(e);
        }

        private void NewLaptopSubmit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyField()) //method to check if asset tag is empty
            {
                if (CheckExistingAssetTag(connectionOle)) //if laptop is in inventory
                {
                    NewAssetTagExists();
                }
                else
                {
                    AddNewLaptop(connectionOle);
                }
            }
        }

        private bool CheckEmptyField()
        {
            if (newAssetInput.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Asset tag cannot be empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool CheckExistingAssetTag(OleDbConnection connection)
        {
            connection.Open();
            OleDbDataReader readerObject;

            bool assetBool = true; //assuming that the laptop does not exist in the inventory
            string assetSQL = "SELECT AssetTag FROM LaptopInventory;";
            OleDbCommand commandObject = new OleDbCommand(assetSQL, connection);
            try
            {
                readerObject = commandObject.ExecuteReader();
                while (readerObject.Read())
                {
                    if (readerObject.GetString(0).ToString().Equals(newAssetInput.Text)) //laptop already exists in the inventory
                    {
                        connectionOle.Close();
                        return true;
                    }
                }
            }
            catch
            {
                //if fails, continue
            }

            if (assetBool)
            {
                connectionOle.Close();
                return false;
            }
            else
            {
                connectionOle.Close();
                return true;
            }
            
        }


        private void NewAssetTagExists()
        {
            newAssetInput.Text = "";
            NewModelInput.Text = "";
            System.Windows.Forms.MessageBox.Show("Laptop already exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddNewLaptop(OleDbConnection connection)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO LaptopInventory(AssetTag, Model, InInventory) VALUES ('" + newAssetInput.Text + "','" + NewModelInput.Text + "',1)";
            command.ExecuteNonQuery();
            newAssetInput.Text = "";
            NewModelInput.Text = "";

            string highestID = "";
            string highestIDQuery = "SELECT TOP 1 LaptopID FROM LaptopInventory ORDER BY LaptopID DESC;";
            OleDbCommand highestIDCommand = new OleDbCommand(highestIDQuery, connectionOle);
            OleDbDataReader highestIDReader = highestIDCommand.ExecuteReader();
            while (highestIDReader.Read())
            {
                highestID = highestIDReader.GetValue(0).ToString();
            }
            System.Windows.Forms.MessageBox.Show("Laptop added. This laptop's ID is: \n\n\t" + "       " + highestID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void RemoveBut_Click(object sender, EventArgs e)
        {
            if (CheckExistingLaptopID(connectionOle)) //checks to see if laptop exists in the inventory
            {
                DeleteLaptopSubmit(connectionOle);          //REFERENTIAL INTEGRITY  ... if deleted from inventory, user cannot be borrowing it
                RemoveLaptopFromLoaner();                   //remove from loaner's borrowing list
            }
        }

        //REWRITTEN FUNCTIONS FROM HERE TO OTHER COMMENT
        //COULD NOT FIGURE OUT IF PARTIAL BASE CLASS CAN INHERIT FROM PARENT AND USE INTERFACE
        //REWRITTEN FUNCTIONS ARE FROM 'MAIN.CS'
        private void RemoveLaptopFromLoaner()
        {
            string previousLaptopInfo = GetPreviousReturnedLaptopInfo();

            string newLaptopinfo = GetNewLaptops(previousLaptopInfo);
            ReturnLaptop(newLaptopinfo, previousLaptopInfo);
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
                    if (previousLaptopReader.GetValue(0).ToString().Contains(idRem.Text))
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

        private string GetNewLaptops(string previousLaptops)
        {
            if (previousLaptops.Contains(",")) //multiple laptops
            {
                string tempPreviousLaptops = "";
                if (previousLaptops.Contains(", " + idRem.Text)) //66, 67
                {
                    tempPreviousLaptops = previousLaptops.Replace(", " + idRem.Text, "");
                }
                else if (previousLaptops.Contains(idRem.Text + ","))
                {
                    tempPreviousLaptops = previousLaptops.Replace(idRem.Text + ", ", "");
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
                UpdateDatabase("UPDATE Loaners SET Loaners.LaptopID = '" + newLaptops + "' WHERE Loaners.LaptopID = '" + oldLaptops + "'");

                //user feedback for successful transaction
                idRem.Text = "";
            }
            else //change only one laptop
            {
                UpdateDatabase("UPDATE Loaners SET ExpectedReturnDate = NULL, Borrowing = 0, Loaners.LaptopID = '' , EUSInitials = '' WHERE Loaners.LaptopID = '" + idRem.Text + "'");
                idRem.Text = "";
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
        //CODE DUPLICATION ENDS HERE
        //NEED CODE CLEANUP IF TIME ALLOWS
        //REWRITTEN FUNCTIONS ARE FROM 'MAIN.CS'

        private bool CheckExistingLaptopID(OleDbConnection connection)
        {
            connection.Open();
            string getIDQuery = "SELECT LaptopID FROM LaptopInventory";
            OleDbCommand commandObject = new OleDbCommand(getIDQuery, connection);
            OleDbDataReader readerObject;
            readerObject = commandObject.ExecuteReader();
            while (readerObject.Read())
            {
                if (readerObject.GetValue(0).ToString().Equals(idRem.Text)) //if laptop exists then return true
                {

                    connection.Close();
                    return true;
                }
            }
            ReturnUnsuccessfulUserFeedback();
            connection.Close();
            return false;
        }

        private void ReturnUnsuccessfulUserFeedback()
        {
            idRem.Text = "";
            System.Windows.Forms.MessageBox.Show("Laptop does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteLaptopSubmit(OleDbConnection connection)
        {
            connection.Open();
            OleDbCommand removeCommand = new OleDbCommand();
            removeCommand.Connection = connection;
            removeCommand.CommandText = "DELETE FROM LaptopInventory WHERE LaptopID = " + idRem.Text + ";";
            removeCommand.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Laptop has been successfully removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void ViewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string absolutePath = @"L:\SHARED\laptopEUS\DataSources\LoanerLaptop.accdb";
            Process.Start(absolutePath);
        }

        private void WriteToExcel(string fileName, string query, bool writeColumns)
        {
            connectionOle.Open();
            OleDbCommand command = new OleDbCommand(query, connectionOle);
            OleDbDataReader reader;
            reader = command.ExecuteReader();
            AttachData(reader, fileName, writeColumns);
            connectionOle.Close();
        }

        private void AttachInventoryHeaders(string fileName)
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

        private void AttachLoanedLaptopHeaders(string fileName)
        {
            File.WriteAllText(fileName, "Name");
            File.AppendAllText(fileName, ",");
            File.AppendAllText(fileName, "Laptop ID");
            File.AppendAllText(fileName, ",");
            File.AppendAllText(fileName, "Expected Return Date");
            File.AppendAllText(fileName, "\n");
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
            Process.Start("Inventory.csv");
        }

        private void ViewLoanedLaptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttachLoanedLaptopHeaders("LoanedLaptops.csv");
            WriteToExcel("LoanedLaptops.csv", "SELECT * FROM Loaners WHERE ExpectedReturnDate<>''", false);
            Process.Start("LoanedLaptops.csv");
        }

        private void NewModelInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NewLaptopSubmit_Click(this, new EventArgs());
            }
        }

        private void IdRem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RemoveBut_Click(this, new EventArgs());
            }
        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
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
