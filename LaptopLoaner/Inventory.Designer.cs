namespace LaptopLoaner
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewLaptopSubmit = new System.Windows.Forms.Button();
            this.NewModelInput = new System.Windows.Forms.TextBox();
            this.newModelLabel = new System.Windows.Forms.Label();
            this.newAssetInput = new System.Windows.Forms.TextBox();
            this.newAssetLabel = new System.Windows.Forms.Label();
            this.newLaptopLabel = new System.Windows.Forms.Label();
            this.newLaptopPic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemTab = new System.Windows.Forms.ToolStripMenuItem();
            this.dataVisualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsTab = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLoanedLaptopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removLaptopPic = new System.Windows.Forms.PictureBox();
            this.removeBut = new System.Windows.Forms.Button();
            this.idRem = new System.Windows.Forms.TextBox();
            this.laptopIDLabel = new System.Windows.Forms.Label();
            this.removeLaptopLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newLaptopPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removLaptopPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewLaptopSubmit);
            this.panel1.Controls.Add(this.NewModelInput);
            this.panel1.Controls.Add(this.newModelLabel);
            this.panel1.Controls.Add(this.newAssetInput);
            this.panel1.Controls.Add(this.newAssetLabel);
            this.panel1.Controls.Add(this.newLaptopLabel);
            this.panel1.Controls.Add(this.newLaptopPic);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 389);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // NewLaptopSubmit
            // 
            this.NewLaptopSubmit.Location = new System.Drawing.Point(123, 266);
            this.NewLaptopSubmit.Name = "NewLaptopSubmit";
            this.NewLaptopSubmit.Size = new System.Drawing.Size(106, 24);
            this.NewLaptopSubmit.TabIndex = 21;
            this.NewLaptopSubmit.Text = "Submit";
            this.NewLaptopSubmit.UseVisualStyleBackColor = true;
            this.NewLaptopSubmit.Click += new System.EventHandler(this.NewLaptopSubmit_Click);
            // 
            // NewModelInput
            // 
            this.NewModelInput.Location = new System.Drawing.Point(87, 217);
            this.NewModelInput.Name = "NewModelInput";
            this.NewModelInput.Size = new System.Drawing.Size(172, 20);
            this.NewModelInput.TabIndex = 20;
            this.NewModelInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewModelInput_KeyDown);
            // 
            // newModelLabel
            // 
            this.newModelLabel.AutoSize = true;
            this.newModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newModelLabel.Location = new System.Drawing.Point(145, 194);
            this.newModelLabel.Name = "newModelLabel";
            this.newModelLabel.Size = new System.Drawing.Size(57, 20);
            this.newModelLabel.TabIndex = 24;
            this.newModelLabel.Text = "Model";
            // 
            // newAssetInput
            // 
            this.newAssetInput.Location = new System.Drawing.Point(87, 141);
            this.newAssetInput.Name = "newAssetInput";
            this.newAssetInput.Size = new System.Drawing.Size(172, 20);
            this.newAssetInput.TabIndex = 19;
            // 
            // newAssetLabel
            // 
            this.newAssetLabel.AutoSize = true;
            this.newAssetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAssetLabel.Location = new System.Drawing.Point(129, 104);
            this.newAssetLabel.Name = "newAssetLabel";
            this.newAssetLabel.Size = new System.Drawing.Size(90, 20);
            this.newAssetLabel.TabIndex = 23;
            this.newAssetLabel.Text = "Asset Tag";
            // 
            // newLaptopLabel
            // 
            this.newLaptopLabel.AutoSize = true;
            this.newLaptopLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLaptopLabel.Location = new System.Drawing.Point(101, 29);
            this.newLaptopLabel.Name = "newLaptopLabel";
            this.newLaptopLabel.Size = new System.Drawing.Size(128, 26);
            this.newLaptopLabel.TabIndex = 22;
            this.newLaptopLabel.Text = "New Laptop";
            // 
            // newLaptopPic
            // 
            this.newLaptopPic.Image = ((System.Drawing.Image)(resources.GetObject("newLaptopPic.Image")));
            this.newLaptopPic.Location = new System.Drawing.Point(249, 13);
            this.newLaptopPic.Name = "newLaptopPic";
            this.newLaptopPic.Size = new System.Drawing.Size(70, 56);
            this.newLaptopPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newLaptopPic.TabIndex = 26;
            this.newLaptopPic.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemTab,
            this.dataVisualizationToolStripMenuItem,
            this.logToolStripMenuItem,
            this.recordsTab});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemTab
            // 
            this.systemTab.Name = "systemTab";
            this.systemTab.Size = new System.Drawing.Size(90, 20);
            this.systemTab.Text = "Check In/Out";
            this.systemTab.Click += new System.EventHandler(this.InventoryToolStripMenuItem_Click);
            // 
            // dataVisualizationToolStripMenuItem
            // 
            this.dataVisualizationToolStripMenuItem.Name = "dataVisualizationToolStripMenuItem";
            this.dataVisualizationToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dataVisualizationToolStripMenuItem.Text = "Stats";
            this.dataVisualizationToolStripMenuItem.Click += new System.EventHandler(this.DataVisualizationToolStripMenuItem_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.removLaptopPic);
            this.panel2.Controls.Add(this.removeBut);
            this.panel2.Controls.Add(this.idRem);
            this.panel2.Controls.Add(this.laptopIDLabel);
            this.panel2.Controls.Add(this.removeLaptopLabel);
            this.panel2.Location = new System.Drawing.Point(344, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 389);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // removLaptopPic
            // 
            this.removLaptopPic.Image = ((System.Drawing.Image)(resources.GetObject("removLaptopPic.Image")));
            this.removLaptopPic.Location = new System.Drawing.Point(268, 13);
            this.removLaptopPic.Name = "removLaptopPic";
            this.removLaptopPic.Size = new System.Drawing.Size(55, 56);
            this.removLaptopPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removLaptopPic.TabIndex = 27;
            this.removLaptopPic.TabStop = false;
            // 
            // removeBut
            // 
            this.removeBut.Location = new System.Drawing.Point(139, 225);
            this.removeBut.Name = "removeBut";
            this.removeBut.Size = new System.Drawing.Size(106, 24);
            this.removeBut.TabIndex = 22;
            this.removeBut.Text = "Submit";
            this.removeBut.UseVisualStyleBackColor = true;
            this.removeBut.Click += new System.EventHandler(this.RemoveBut_Click);
            // 
            // idRem
            // 
            this.idRem.Location = new System.Drawing.Point(104, 176);
            this.idRem.Name = "idRem";
            this.idRem.Size = new System.Drawing.Size(172, 20);
            this.idRem.TabIndex = 21;
            this.idRem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdRem_KeyDown);
            // 
            // laptopIDLabel
            // 
            this.laptopIDLabel.AutoSize = true;
            this.laptopIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laptopIDLabel.Location = new System.Drawing.Point(145, 139);
            this.laptopIDLabel.Name = "laptopIDLabel";
            this.laptopIDLabel.Size = new System.Drawing.Size(89, 20);
            this.laptopIDLabel.TabIndex = 24;
            this.laptopIDLabel.Text = "Laptop ID";
            // 
            // removeLaptopLabel
            // 
            this.removeLaptopLabel.AutoSize = true;
            this.removeLaptopLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLaptopLabel.Location = new System.Drawing.Point(86, 29);
            this.removeLaptopLabel.Name = "removeLaptopLabel";
            this.removeLaptopLabel.Size = new System.Drawing.Size(162, 26);
            this.removeLaptopLabel.TabIndex = 23;
            this.removeLaptopLabel.Text = "Remove Laptop";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryForm";
            this.Text = "LTP Console";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newLaptopPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removLaptopPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordsTab;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewLaptopSubmit;
        private System.Windows.Forms.TextBox NewModelInput;
        private System.Windows.Forms.Label newModelLabel;
        private System.Windows.Forms.TextBox newAssetInput;
        private System.Windows.Forms.Label newAssetLabel;
        private System.Windows.Forms.Label newLaptopLabel;
        private System.Windows.Forms.Button removeBut;
        private System.Windows.Forms.TextBox idRem;
        private System.Windows.Forms.Label laptopIDLabel;
        private System.Windows.Forms.Label removeLaptopLabel;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLoanedLaptopsToolStripMenuItem;
        private System.Windows.Forms.PictureBox newLaptopPic;
        private System.Windows.Forms.PictureBox removLaptopPic;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataVisualizationToolStripMenuItem;
    }
}