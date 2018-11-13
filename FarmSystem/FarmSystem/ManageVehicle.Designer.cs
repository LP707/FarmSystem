namespace FarmSystem
{
    partial class ManageVehicle
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
            this.managmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labourersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vahiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewT = new System.Windows.Forms.DataGridView();
            this.dataViewC = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewC)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
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
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managmentToolStripMenuItem
            // 
            this.managmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labourersToolStripMenuItem,
            this.vahiclesToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            this.managmentToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.managmentToolStripMenuItem.Text = "Managment";
            // 
            // labourersToolStripMenuItem
            // 
            this.labourersToolStripMenuItem.Name = "labourersToolStripMenuItem";
            this.labourersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labourersToolStripMenuItem.Text = "Labourers";
            this.labourersToolStripMenuItem.Click += new System.EventHandler(this.labourersToolStripMenuItem_Click);
            // 
            // vahiclesToolStripMenuItem
            // 
            this.vahiclesToolStripMenuItem.Name = "vahiclesToolStripMenuItem";
            this.vahiclesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vahiclesToolStripMenuItem.Text = "Vahicles";
            this.vahiclesToolStripMenuItem.Click += new System.EventHandler(this.vahiclesToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // dataViewT
            // 
            this.dataViewT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewT.Location = new System.Drawing.Point(12, 59);
            this.dataViewT.Name = "dataViewT";
            this.dataViewT.Size = new System.Drawing.Size(338, 379);
            this.dataViewT.TabIndex = 2;
            // 
            // dataViewC
            // 
            this.dataViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewC.Location = new System.Drawing.Point(356, 59);
            this.dataViewC.Name = "dataViewC";
            this.dataViewC.Size = new System.Drawing.Size(338, 379);
            this.dataViewC.TabIndex = 3;
            // 
            // ManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.dataViewC);
            this.Controls.Add(this.dataViewT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageVehicle";
            this.Text = "ManageVehicle";
            this.Load += new System.EventHandler(this.ManageVehicle_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labourersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vahiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataViewT;
        private System.Windows.Forms.DataGridView dataViewC;
    }
}