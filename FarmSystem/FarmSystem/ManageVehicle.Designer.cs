﻿namespace FarmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageVehicle));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labourersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vahiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAtch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1433, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managmentToolStripMenuItem
            // 
            this.managmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labourersToolStripMenuItem,
            this.vahiclesToolStripMenuItem,
            this.cropsToolStripMenuItem,
            this.taskManagerToolStripMenuItem,
            this.fieldsToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            this.managmentToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.managmentToolStripMenuItem.Text = "Managment";
            // 
            // labourersToolStripMenuItem
            // 
            this.labourersToolStripMenuItem.Name = "labourersToolStripMenuItem";
            this.labourersToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.labourersToolStripMenuItem.Text = "Labourers";
            this.labourersToolStripMenuItem.Click += new System.EventHandler(this.labourersToolStripMenuItem_Click);
            // 
            // vahiclesToolStripMenuItem
            // 
            this.vahiclesToolStripMenuItem.Name = "vahiclesToolStripMenuItem";
            this.vahiclesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.vahiclesToolStripMenuItem.Text = "Vahicles";
            this.vahiclesToolStripMenuItem.Click += new System.EventHandler(this.vahiclesToolStripMenuItem_Click);
            // 
            // cropsToolStripMenuItem
            // 
            this.cropsToolStripMenuItem.Name = "cropsToolStripMenuItem";
            this.cropsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cropsToolStripMenuItem.Text = "Crops";
            this.cropsToolStripMenuItem.Click += new System.EventHandler(this.cropsToolStripMenuItem_Click);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.taskManagerToolStripMenuItem.Text = "Task Manager";
            this.taskManagerToolStripMenuItem.Click += new System.EventHandler(this.taskManagerToolStripMenuItem_Click);
            // 
            // fieldsToolStripMenuItem
            // 
            this.fieldsToolStripMenuItem.Name = "fieldsToolStripMenuItem";
            this.fieldsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fieldsToolStripMenuItem.Text = "Fields";
            this.fieldsToolStripMenuItem.Click += new System.EventHandler(this.fieldsToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(16, 135);
            this.dataView.Margin = new System.Windows.Forms.Padding(4);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(1037, 567);
            this.dataView.TabIndex = 2;
            this.dataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataViewT_CellMouseClick);
            this.dataView.Click += new System.EventHandler(this.dataViewT_Click);
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(1290, 428);
            this.txtReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(132, 22);
            this.txtReg.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1185, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vehicle Reg.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1185, 469);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vehicle Name";
            // 
            // txtAtch
            // 
            this.txtAtch.Location = new System.Drawing.Point(1290, 492);
            this.txtAtch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAtch.Name = "txtAtch";
            this.txtAtch.Size = new System.Drawing.Size(132, 22);
            this.txtAtch.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1290, 460);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1075, 644);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(1074, 680);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(100, 28);
            this.btnUpd.TabIndex = 12;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1185, 501);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vehicle Atch.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(633, 79);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1433, 718);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageVehicle_FormClosing);
            this.Load += new System.EventHandler(this.ManageVehicle_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAtch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem cropsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fieldsToolStripMenuItem;
    }
}