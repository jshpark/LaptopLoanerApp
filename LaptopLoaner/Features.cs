using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopLoaner
{
    public partial class Features : Form
    {

        private OleDbConnection connectionOle = new OleDbConnection();

        public Features() //not used
        {
            InitializeComponent();
            connectionOle.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=L:\SHARED\laptopEUS\DataSources\LoanerLaptop.accdb; Persist Security Info=False;";
        }

        private void ShowData(string query)
        {
            try
            {
                connectionOle.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connectionOle;
                command.CommandText = query;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                mainData.DataSource = dataTable;
                connectionOle.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error" + e);
                connectionOle.Close();
            }
        }

        private void InventoryChoice_CheckedChanged(object sender, EventArgs e)
        {
            ShowData("SELECT * FROM LaptopInventory");

            connectionOle.Open();
            string countLaptopQuery = "SELECT COUNT (*) FROM LaptopInventory"; //Query that counts the total number of entries
            OleDbCommand count_asset_Command = new OleDbCommand(countLaptopQuery, connectionOle); //Creates a new OleDbCommand object
            int num_borrowed = Convert.ToInt32(count_asset_Command.ExecuteScalar()); //Execute the query and returns a value and saved as an integer
            inventoryLabel.Text = num_borrowed.ToString(); //Take integer value and save to text

            inventoryVisibleLabel.Text = "Total Inventory:"; //Total Inventory

            //When Inventory Radio Button is Selected Execute the Following 

            if (inventoryChoice.Checked) { 
            
                inventoryVisibleLabel.Visible = true; //Makes label visible once this option is selected
                inventoryLabel.Visible = true; //Show the values
            }

            else {

                inventoryVisibleLabel.Visible = false; //Otherwise leave it false.
                inventoryLabel.Visible = false; //Otherwise do not show the results
            }

            connectionOle.Close();
        
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ShowData("SELECT Name, Loaners.LaptopID, ExpectedReturnDate, EUSInitials FROM Loaners WHERE Borrowing = -1"); //if loaner is borrowing, show

            connectionOle.Open();

            string countBorrowedQuery = "SELECT COUNT (*) FROM LaptopInventory WHERE InInventory = NO"; //Count total number of entries
            OleDbCommand count_borrowed_Command = new OleDbCommand(countBorrowedQuery, connectionOle);
            int num_borrowed = Convert.ToInt32(count_borrowed_Command.ExecuteScalar());
            inventoryLabel.Text = num_borrowed.ToString();

            inventoryVisibleLabel.Text = "Number Borrowed:";

            //When loanersChoice radio button is selected

            if (loanersChoice.Checked)
            {

                inventoryVisibleLabel.Visible = true; //Makes label visible once this option is selected
                inventoryLabel.Visible = true; //Show the values
            }

            else
            {

                inventoryVisibleLabel.Visible = false; //Otherwise leave it false.
                inventoryLabel.Visible = false; //Otherwise do not show the results
            }

            connectionOle.Close();
        }

        private void OverdueChoice_CheckedChanged(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Today.Date;
            ShowData("SELECT Name, Loaners.LaptopID, ExpectedReturnDate, EUSInitials FROM Loaners WHERE ExpectedReturnDate < Date()");
            connectionOle.Open();

            string countOverdueQuery = "SELECT COUNT (*) FROM Loaners WHERE ExpectedReturnDate < Date()"; //Count total number of entries of overdue laptops
            OleDbCommand count_Overdue_Command = new OleDbCommand(countOverdueQuery, connectionOle);
            int num_borrowed = Convert.ToInt32(count_Overdue_Command.ExecuteScalar());
            inventoryLabel.Text = num_borrowed.ToString(); 

            inventoryVisibleLabel.Text = "Overdue Laptops:";

            if (overdueChoice.Checked)
            {

                inventoryVisibleLabel.Visible = true; //Makes label visible once this option is selected
                inventoryLabel.Visible = true; //Show the values
            }

            else
            {

                inventoryVisibleLabel.Visible = false; //Otherwise leave it false.
                inventoryLabel.Visible = false; //Otherwise do not show the results
            }

            connectionOle.Close();
        }

        //REWRITTEN FUNCTIONS FROM HERE TO OTHER COMMENT
        //COULD NOT FIGURE OUT IF PARTIAL BASE CLASS CAN INHERIT FROM PARENT AND USE INTERFACE
        //REWRITTEN FUNCTIONS ARE FROM 'MAIN.CS'
        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            this.Hide();
            inventoryForm.StartPosition = FormStartPosition.CenterScreen;
            inventoryForm.ShowDialog();
            this.Close();
        }

        private void SystemTab_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.ShowDialog();
            this.Close();
        }

        
        private void ViewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string absolutePath = @"L:\SHARED\laptopEUS\DataSources\LoanerLaptop.accdb";
            Process.Start(absolutePath);
        }

        private void ViewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttachInventoryHeaders("Inventory.csv");
            WriteToExcel("Inventory.csv", "SELECT * FROM LaptopInventory", true);
            Process.Start("Inventory.csv");
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

        private void ViewLoanedLaptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttachLoanedLaptopHeaders("LoanedLaptops.csv");
            WriteToExcel("LoanedLaptops.csv", "SELECT * FROM Loaners WHERE ExpectedReturnDate IS NOT NULL", false);
            Process.Start("LoanedLaptops.csv");
        }
        private void AttachLoanedLaptopHeaders(string fileName)
        {
            File.WriteAllText(fileName, "Name");
            File.AppendAllText(fileName, ",");
            File.AppendAllText(fileName, "Laptop ID");
            File.AppendAllText(fileName, ",");
            File.AppendAllText(fileName, "Expected Return Date");
            File.AppendAllText(fileName, ",");
            File.AppendAllText(fileName, "EUSInitials");
            File.AppendAllText(fileName, "\n");
        }
        //CODE DUPLICATION ENDS HERE
        //NEED CODE CLEANUP IF TIME ALLOWS
        //REWRITTEN FUNCTIONS ARE FROM 'MAIN.CS'

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string absolutePath = @"L:\SHARED\laptopEUS\DataSources\DataSourcesLog.txt";
            Process.Start(absolutePath);
        }

        private void Features_Load(object sender, EventArgs e)
        {
            
        }
    }
}
