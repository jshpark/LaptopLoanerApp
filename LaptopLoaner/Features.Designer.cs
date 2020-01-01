namespace LaptopLoaner
{
    partial class Features
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loanerLaptopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanerLaptopDataSet = new LaptopLoaner.LoanerLaptopDataSet();
            this.laptopInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laptop_InventoryTableAdapter = new LaptopLoaner.LoanerLaptopDataSetTableAdapters.Laptop_InventoryTableAdapter();
            this.mainData = new System.Windows.Forms.DataGridView();
            this.inventoryChoice = new System.Windows.Forms.RadioButton();
            this.loanersChoice = new System.Windows.Forms.RadioButton();
            this.overdueChoice = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemTab = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLoanedLaptopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryVisibleLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loanerLaptopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanerLaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanerLaptopDataSetBindingSource
            // 
            this.loanerLaptopDataSetBindingSource.DataSource = this.loanerLaptopDataSet;
            this.loanerLaptopDataSetBindingSource.Position = 0;
            // 
            // loanerLaptopDataSet
            // 
            this.loanerLaptopDataSet.DataSetName = "LoanerLaptopDataSet";
            this.loanerLaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laptopInventoryBindingSource
            // 
            this.laptopInventoryBindingSource.DataMember = "Laptop Inventory";
            this.laptopInventoryBindingSource.DataSource = this.loanerLaptopDataSetBindingSource;
            // 
            // laptop_InventoryTableAdapter
            // 
            this.laptop_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // mainData
            // 
            this.mainData.AllowUserToAddRows = false;
            this.mainData.AllowUserToDeleteRows = false;
            this.mainData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mainData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainData.Location = new System.Drawing.Point(78, 189);
            this.mainData.Name = "mainData";
            this.mainData.ReadOnly = true;
            this.mainData.Size = new System.Drawing.Size(900, 282);
            this.mainData.TabIndex = 0;
            // 
            // inventoryChoice
            // 
            this.inventoryChoice.AutoSize = true;
            this.inventoryChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryChoice.Location = new System.Drawing.Point(166, 105);
            this.inventoryChoice.Name = "inventoryChoice";
            this.inventoryChoice.Size = new System.Drawing.Size(118, 29);
            this.inventoryChoice.TabIndex = 5;
            this.inventoryChoice.Text = "Inventory";
            this.inventoryChoice.UseVisualStyleBackColor = true;
            this.inventoryChoice.CheckedChanged += new System.EventHandler(this.InventoryChoice_CheckedChanged);
            // 
            // loanersChoice
            // 
            this.loanersChoice.AutoSize = true;
            this.loanersChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanersChoice.Location = new System.Drawing.Point(425, 105);
            this.loanersChoice.Name = "loanersChoice";
            this.loanersChoice.Size = new System.Drawing.Size(204, 29);
            this.loanersChoice.TabIndex = 1;
            this.loanersChoice.Text = "Borrowed Laptops";
            this.loanersChoice.UseVisualStyleBackColor = true;
            this.loanersChoice.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // overdueChoice
            // 
            this.overdueChoice.AutoSize = true;
            this.overdueChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueChoice.Location = new System.Drawing.Point(736, 105);
            this.overdueChoice.Name = "overdueChoice";
            this.overdueChoice.Size = new System.Drawing.Size(195, 29);
            this.overdueChoice.TabIndex = 2;
            this.overdueChoice.Text = "Overdue Laptops";
            this.overdueChoice.UseVisualStyleBackColor = true;
            this.overdueChoice.CheckedChanged += new System.EventHandler(this.OverdueChoice_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemTab,
            this.inventoryToolStripMenuItem,
            this.logToolStripMenuItem,
            this.recordsTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemTab
            // 
            this.systemTab.Name = "systemTab";
            this.systemTab.Size = new System.Drawing.Size(90, 20);
            this.systemTab.Text = "Check In/Out";
            this.systemTab.Click += new System.EventHandler(this.SystemTab_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.InventoryToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.LogToolStripMenuItem_Click);
            // 
            // recordsTab
            // 
            this.recordsTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRecordsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.recordsTab.Name = "recordsTab";
            this.recordsTab.Size = new System.Drawing.Size(61, 20);
            this.recordsTab.Text = "Records";
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            this.viewRecordsToolStripMenuItem.Click += new System.EventHandler(this.ViewRecordsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.viewLoanedLaptopsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.ViewInventoryToolStripMenuItem_Click);
            // 
            // viewLoanedLaptopsToolStripMenuItem
            // 
            this.viewLoanedLaptopsToolStripMenuItem.Name = "viewLoanedLaptopsToolStripMenuItem";
            this.viewLoanedLaptopsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewLoanedLaptopsToolStripMenuItem.Text = "View Loaned Laptops";
            this.viewLoanedLaptopsToolStripMenuItem.Click += new System.EventHandler(this.ViewLoanedLaptopsToolStripMenuItem_Click);
            // 
            // inventoryVisibleLabel
            // 
            this.inventoryVisibleLabel.AutoSize = true;
            this.inventoryVisibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryVisibleLabel.Location = new System.Drawing.Point(125, 514);
            this.inventoryVisibleLabel.Name = "inventoryVisibleLabel";
            this.inventoryVisibleLabel.Size = new System.Drawing.Size(0, 20);
            this.inventoryVisibleLabel.TabIndex = 7;
            this.inventoryVisibleLabel.Visible = false;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(284, 514);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(0, 20);
            this.inventoryLabel.TabIndex = 8;
            this.inventoryLabel.Visible = false;
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 575);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.inventoryVisibleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.overdueChoice);
            this.Controls.Add(this.loanersChoice);
            this.Controls.Add(this.inventoryChoice);
            this.Controls.Add(this.mainData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Features";
            this.Text = "LTP Console";
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanerLaptopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanerLaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource loanerLaptopDataSetBindingSource;
        private LoanerLaptopDataSet loanerLaptopDataSet;
        private System.Windows.Forms.BindingSource laptopInventoryBindingSource;
        private LoanerLaptopDataSetTableAdapters.Laptop_InventoryTableAdapter laptop_InventoryTableAdapter;
        private System.Windows.Forms.DataGridView mainData;
        private System.Windows.Forms.RadioButton inventoryChoice;
        private System.Windows.Forms.RadioButton loanersChoice;
        private System.Windows.Forms.RadioButton overdueChoice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordsTab;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLoanedLaptopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemTab;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.Label inventoryVisibleLabel;
        private System.Windows.Forms.Label inventoryLabel;
    }
}