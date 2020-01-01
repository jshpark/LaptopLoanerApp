namespace LaptopLoaner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryTab = new System.Windows.Forms.ToolStripMenuItem();
            this.dataVisualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLoanedLaptopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eusInitialLabel = new System.Windows.Forms.Label();
            this.eusInitials = new System.Windows.Forms.ComboBox();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.loanerInput = new System.Windows.Forms.TextBox();
            this.loanerNameLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.laptopInput = new System.Windows.Forms.TextBox();
            this.laptopOutLabel = new System.Windows.Forms.Label();
            this.checkOut = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.initialLabel = new System.Windows.Forms.Label();
            this.returnInitial = new System.Windows.Forms.ComboBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.laptopReturnInput = new System.Windows.Forms.TextBox();
            this.laptopInLabel = new System.Windows.Forms.Label();
            this.returnPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOut)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryTab,
            this.dataVisualizationToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.recordsTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryTab
            // 
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(69, 20);
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.Click += new System.EventHandler(this.InventoryToolStripMenuItem_Click);
            // 
            // dataVisualizationToolStripMenuItem
            // 
            this.dataVisualizationToolStripMenuItem.Name = "dataVisualizationToolStripMenuItem";
            this.dataVisualizationToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dataVisualizationToolStripMenuItem.Text = "Stats";
            this.dataVisualizationToolStripMenuItem.Click += new System.EventHandler(this.DataVisualizationToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logsToolStripMenuItem.Text = "Log";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.LogsToolStripMenuItem_Click);
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
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            this.viewRecordsToolStripMenuItem.Click += new System.EventHandler(this.ViewRecordsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.viewLoanedLaptopsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportsToolStripMenuItem.Text = "Reports ";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.eusInitialLabel);
            this.panel1.Controls.Add(this.eusInitials);
            this.panel1.Controls.Add(this.dateTimeReturn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loanerInput);
            this.panel1.Controls.Add(this.loanerNameLabel);
            this.panel1.Controls.Add(this.checkOutLabel);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.laptopInput);
            this.panel1.Controls.Add(this.laptopOutLabel);
            this.panel1.Controls.Add(this.checkOut);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 450);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // eusInitialLabel
            // 
            this.eusInitialLabel.AutoSize = true;
            this.eusInitialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eusInitialLabel.Location = new System.Drawing.Point(322, 202);
            this.eusInitialLabel.Name = "eusInitialLabel";
            this.eusInitialLabel.Size = new System.Drawing.Size(62, 20);
            this.eusInitialLabel.TabIndex = 26;
            this.eusInitialLabel.Text = "Initials";
            // 
            // eusInitials
            // 
            this.eusInitials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eusInitials.FormattingEnabled = true;
            this.eusInitials.Items.AddRange(new object[] {
            "TP",
            "JG",
            "AD",
            "EL",
            "CP"});
            this.eusInitials.Location = new System.Drawing.Point(313, 226);
            this.eusInitials.Name = "eusInitials";
            this.eusInitials.Size = new System.Drawing.Size(84, 21);
            this.eusInitials.TabIndex = 4;
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(51, 227);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(151, 20);
            this.dateTimeReturn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Expected Return Date";
            // 
            // loanerInput
            // 
            this.loanerInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loanerInput.Location = new System.Drawing.Point(253, 148);
            this.loanerInput.Name = "loanerInput";
            this.loanerInput.Size = new System.Drawing.Size(207, 20);
            this.loanerInput.TabIndex = 2;
            // 
            // loanerNameLabel
            // 
            this.loanerNameLabel.AutoSize = true;
            this.loanerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanerNameLabel.Location = new System.Drawing.Point(292, 127);
            this.loanerNameLabel.Name = "loanerNameLabel";
            this.loanerNameLabel.Size = new System.Drawing.Size(129, 20);
            this.loanerNameLabel.TabIndex = 22;
            this.loanerNameLabel.Text = "Loaner\'s Name";
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.AutoSize = true;
            this.checkOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutLabel.Location = new System.Drawing.Point(195, 49);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(102, 24);
            this.checkOutLabel.TabIndex = 21;
            this.checkOutLabel.Text = "CheckOut";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitButton.Location = new System.Drawing.Point(190, 301);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(95, 25);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // laptopInput
            // 
            this.laptopInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.laptopInput.Location = new System.Drawing.Point(22, 148);
            this.laptopInput.Name = "laptopInput";
            this.laptopInput.Size = new System.Drawing.Size(207, 20);
            this.laptopInput.TabIndex = 1;
            // 
            // laptopOutLabel
            // 
            this.laptopOutLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.laptopOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laptopOutLabel.Location = new System.Drawing.Point(3, 99);
            this.laptopOutLabel.Name = "laptopOutLabel";
            this.laptopOutLabel.Size = new System.Drawing.Size(241, 46);
            this.laptopOutLabel.TabIndex = 18;
            this.laptopOutLabel.Text = "Laptop ID";
            this.laptopOutLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // checkOut
            // 
            this.checkOut.Image = ((System.Drawing.Image)(resources.GetObject("checkOut.Image")));
            this.checkOut.Location = new System.Drawing.Point(238, 18);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(146, 78);
            this.checkOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkOut.TabIndex = 26;
            this.checkOut.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.initialLabel);
            this.panel2.Controls.Add(this.returnInitial);
            this.panel2.Controls.Add(this.returnLabel);
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Controls.Add(this.laptopReturnInput);
            this.panel2.Controls.Add(this.laptopInLabel);
            this.panel2.Controls.Add(this.returnPicture);
            this.panel2.Location = new System.Drawing.Point(478, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 450);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // initialLabel
            // 
            this.initialLabel.AutoSize = true;
            this.initialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialLabel.Location = new System.Drawing.Point(211, 204);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new System.Drawing.Size(62, 20);
            this.initialLabel.TabIndex = 29;
            this.initialLabel.Text = "Initials";
            // 
            // returnInitial
            // 
            this.returnInitial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.returnInitial.FormattingEnabled = true;
            this.returnInitial.Items.AddRange(new object[] {
            "TP",
            "JG",
            "AD",
            "EL",
            "CP"});
            this.returnInitial.Location = new System.Drawing.Point(197, 235);
            this.returnInitial.Name = "returnInitial";
            this.returnInitial.Size = new System.Drawing.Size(84, 21);
            this.returnInitial.TabIndex = 21;
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(204, 49);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(72, 24);
            this.returnLabel.TabIndex = 18;
            this.returnLabel.Text = "Return";
            // 
            // returnButton
            // 
            this.returnButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.returnButton.Location = new System.Drawing.Point(194, 301);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(95, 25);
            this.returnButton.TabIndex = 22;
            this.returnButton.Text = "Submit";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // laptopReturnInput
            // 
            this.laptopReturnInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.laptopReturnInput.Location = new System.Drawing.Point(135, 158);
            this.laptopReturnInput.Name = "laptopReturnInput";
            this.laptopReturnInput.Size = new System.Drawing.Size(207, 20);
            this.laptopReturnInput.TabIndex = 20;
            this.laptopReturnInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaptopReturnInput_KeyDown);
            // 
            // laptopInLabel
            // 
            this.laptopInLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.laptopInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laptopInLabel.Location = new System.Drawing.Point(95, 102);
            this.laptopInLabel.Name = "laptopInLabel";
            this.laptopInLabel.Size = new System.Drawing.Size(279, 46);
            this.laptopInLabel.TabIndex = 15;
            this.laptopInLabel.Text = "Laptop ID";
            this.laptopInLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // returnPicture
            // 
            this.returnPicture.Image = ((System.Drawing.Image)(resources.GetObject("returnPicture.Image")));
            this.returnPicture.Location = new System.Drawing.Point(237, 18);
            this.returnPicture.Name = "returnPicture";
            this.returnPicture.Size = new System.Drawing.Size(128, 78);
            this.returnPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnPicture.TabIndex = 27;
            this.returnPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LTP Console";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordsTab;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loanerInput;
        private System.Windows.Forms.Label loanerNameLabel;
        private System.Windows.Forms.Label checkOutLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox laptopInput;
        private System.Windows.Forms.Label laptopOutLabel;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox laptopReturnInput;
        private System.Windows.Forms.Label laptopInLabel;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLoanedLaptopsToolStripMenuItem;
        private System.Windows.Forms.Label eusInitialLabel;
        private System.Windows.Forms.PictureBox checkOut;
        private System.Windows.Forms.PictureBox returnPicture;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataVisualizationToolStripMenuItem;
        private System.Windows.Forms.Label initialLabel;
        private System.Windows.Forms.ComboBox returnInitial;
        private System.Windows.Forms.ComboBox eusInitials;
    }
}