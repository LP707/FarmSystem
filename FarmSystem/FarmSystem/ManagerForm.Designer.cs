namespace FarmSystem
{
    partial class ManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLabourerByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstManager1 = new System.Windows.Forms.ListBox();
            this.btnsowing = new System.Windows.Forms.Button();
            this.btncrops = new System.Windows.Forms.Button();
            this.btnvehicles = new System.Windows.Forms.Button();
            this.btnharvest = new System.Windows.Forms.Button();
            this.btncontainers = new System.Windows.Forms.Button();
            this.btnfertiliser = new System.Windows.Forms.Button();
            this.btnstorage = new System.Windows.Forms.Button();
            this.btnmnglbr = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLabourerByNameToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // viewLabourerByNameToolStripMenuItem
            // 
            this.viewLabourerByNameToolStripMenuItem.Name = "viewLabourerByNameToolStripMenuItem";
            this.viewLabourerByNameToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.viewLabourerByNameToolStripMenuItem.Text = "View Labourer by name";
            // 
            // lstManager1
            // 
            this.lstManager1.FormattingEnabled = true;
            this.lstManager1.Location = new System.Drawing.Point(22, 226);
            this.lstManager1.Name = "lstManager1";
            this.lstManager1.Size = new System.Drawing.Size(488, 212);
            this.lstManager1.TabIndex = 1;
            this.lstManager1.SelectedIndexChanged += new System.EventHandler(this.lstManager1_SelectedIndexChanged);
            // 
            // btnsowing
            // 
            this.btnsowing.Location = new System.Drawing.Point(34, 100);
            this.btnsowing.Name = "btnsowing";
            this.btnsowing.Size = new System.Drawing.Size(96, 23);
            this.btnsowing.TabIndex = 2;
            this.btnsowing.Text = "Manage Sewing";
            this.btnsowing.UseVisualStyleBackColor = true;
            // 
            // btncrops
            // 
            this.btncrops.Location = new System.Drawing.Point(160, 45);
            this.btncrops.Name = "btncrops";
            this.btncrops.Size = new System.Drawing.Size(97, 23);
            this.btncrops.TabIndex = 3;
            this.btncrops.Text = "Manage Crops";
            this.btncrops.UseVisualStyleBackColor = true;
            // 
            // btnvehicles
            // 
            this.btnvehicles.Location = new System.Drawing.Point(275, 45);
            this.btnvehicles.Name = "btnvehicles";
            this.btnvehicles.Size = new System.Drawing.Size(107, 23);
            this.btnvehicles.TabIndex = 4;
            this.btnvehicles.Text = "Manage Vehicles";
            this.btnvehicles.UseVisualStyleBackColor = true;
            // 
            // btnharvest
            // 
            this.btnharvest.Location = new System.Drawing.Point(398, 45);
            this.btnharvest.Name = "btnharvest";
            this.btnharvest.Size = new System.Drawing.Size(120, 23);
            this.btnharvest.TabIndex = 5;
            this.btnharvest.Text = "Manage Harvest Time";
            this.btnharvest.UseVisualStyleBackColor = true;
            // 
            // btncontainers
            // 
            this.btncontainers.Location = new System.Drawing.Point(150, 100);
            this.btncontainers.Name = "btncontainers";
            this.btncontainers.Size = new System.Drawing.Size(107, 23);
            this.btncontainers.TabIndex = 6;
            this.btncontainers.Text = "Manage Containers";
            this.btncontainers.UseVisualStyleBackColor = true;
            // 
            // btnfertiliser
            // 
            this.btnfertiliser.Location = new System.Drawing.Point(275, 100);
            this.btnfertiliser.Name = "btnfertiliser";
            this.btnfertiliser.Size = new System.Drawing.Size(105, 23);
            this.btnfertiliser.TabIndex = 7;
            this.btnfertiliser.Text = "Manage Fertilisers";
            this.btnfertiliser.UseVisualStyleBackColor = true;
            // 
            // btnstorage
            // 
            this.btnstorage.Location = new System.Drawing.Point(409, 100);
            this.btnstorage.Name = "btnstorage";
            this.btnstorage.Size = new System.Drawing.Size(101, 23);
            this.btnstorage.TabIndex = 8;
            this.btnstorage.Text = "Manage Storage";
            this.btnstorage.UseVisualStyleBackColor = true;
            // 
            // btnmnglbr
            // 
            this.btnmnglbr.Location = new System.Drawing.Point(12, 45);
            this.btnmnglbr.Name = "btnmnglbr";
            this.btnmnglbr.Size = new System.Drawing.Size(118, 23);
            this.btnmnglbr.TabIndex = 9;
            this.btnmnglbr.Text = "Manage Labourers";
            this.btnmnglbr.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.btnmnglbr);
            this.Controls.Add(this.btnstorage);
            this.Controls.Add(this.btnfertiliser);
            this.Controls.Add(this.btncontainers);
            this.Controls.Add(this.btnharvest);
            this.Controls.Add(this.btnvehicles);
            this.Controls.Add(this.btncrops);
            this.Controls.Add(this.btnsowing);
            this.Controls.Add(this.lstManager1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLabourerByNameToolStripMenuItem;
        private System.Windows.Forms.ListBox lstManager1;
        private System.Windows.Forms.Button btnsowing;
        private System.Windows.Forms.Button btncrops;
        private System.Windows.Forms.Button btnvehicles;
        private System.Windows.Forms.Button btnharvest;
        private System.Windows.Forms.Button btncontainers;
        private System.Windows.Forms.Button btnfertiliser;
        private System.Windows.Forms.Button btnstorage;
        private System.Windows.Forms.Button btnmnglbr;
    }
}