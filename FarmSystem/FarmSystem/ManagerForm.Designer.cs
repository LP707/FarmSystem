﻿namespace FarmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labourersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.fieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // managmentToolStripMenuItem
            // 
            this.managmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labourersToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.cropsToolStripMenuItem,
            this.containersToolStripMenuItem,
            this.containersToolStripMenuItem1,
            this.fieldsToolStripMenuItem});
            this.managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            this.managmentToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.managmentToolStripMenuItem.Text = "Managment";
            this.managmentToolStripMenuItem.Click += new System.EventHandler(this.managmentToolStripMenuItem_Click);
            // 
            // labourersToolStripMenuItem
            // 
            this.labourersToolStripMenuItem.Name = "labourersToolStripMenuItem";
            this.labourersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labourersToolStripMenuItem.Text = "Labourers";
            this.labourersToolStripMenuItem.Click += new System.EventHandler(this.labourersToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // cropsToolStripMenuItem
            // 
            this.cropsToolStripMenuItem.Name = "cropsToolStripMenuItem";
            this.cropsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cropsToolStripMenuItem.Text = "Crops";
            this.cropsToolStripMenuItem.Click += new System.EventHandler(this.cropsToolStripMenuItem_Click);
            // 
            // containersToolStripMenuItem
            // 
            this.containersToolStripMenuItem.Name = "containersToolStripMenuItem";
            this.containersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.containersToolStripMenuItem.Text = "Task Manager";
            this.containersToolStripMenuItem.Click += new System.EventHandler(this.containersToolStripMenuItem_Click);
            // 
            // containersToolStripMenuItem1
            // 
            this.containersToolStripMenuItem1.Name = "containersToolStripMenuItem1";
            this.containersToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.containersToolStripMenuItem1.Text = "Containers";
            this.containersToolStripMenuItem1.Click += new System.EventHandler(this.containersToolStripMenuItem1_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 115);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(846, 445);
            this.dataView.TabIndex = 10;
            this.dataView.Click += new System.EventHandler(this.dataView_Click);
            this.dataView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataView_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(877, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(878, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name:";
            // 
            // txtLastN
            // 
            this.txtLastN.Location = new System.Drawing.Point(945, 361);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(100, 20);
            this.txtLastN.TabIndex = 15;
            // 
            // txtFirstN
            // 
            this.txtFirstN.Location = new System.Drawing.Point(945, 335);
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.Size = new System.Drawing.Size(100, 20);
            this.txtFirstN.TabIndex = 14;
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(874, 508);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 13;
            this.btnUpd.Text = "Add";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(873, 537);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Update";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 62);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(945, 413);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 24;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(945, 439);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(897, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(904, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "DOB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(945, 466);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(895, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Status:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(945, 387);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(102, 20);
            this.dtpDOB.TabIndex = 31;
            // 
            // fieldsToolStripMenuItem
            // 
            this.fieldsToolStripMenuItem.Name = "fieldsToolStripMenuItem";
            this.fieldsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fieldsToolStripMenuItem.Text = "Fields";
            this.fieldsToolStripMenuItem.Click += new System.EventHandler(this.fieldsToolStripMenuItem_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1075, 583);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastN);
            this.Controls.Add(this.txtFirstN);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.Click += new System.EventHandler(this.ManagerForm_Click);
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
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.ToolStripMenuItem managmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labourersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.TextBox txtFirstN;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fieldsToolStripMenuItem;
    }
}