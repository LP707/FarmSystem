namespace FarmSystem
{
    partial class TaskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManager));
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labourersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbVeh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.cmbMP = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dgvVeh = new System.Windows.Forms.DataGridView();
            this.btnRemEmp = new System.Windows.Forms.Button();
            this.btnRemVeh = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnUpdTask = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnAddVeh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.chkStat = new System.Windows.Forms.CheckBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTskDisp = new System.Windows.Forms.ComboBox();
            this.cmbField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(67, 409);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "Task Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "End Date/Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Start Date/Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Employee:";
            // 
            // dgvTask
            // 
            this.dgvTask.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(12, 139);
            this.dgvTask.MultiSelect = false;
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.Size = new System.Drawing.Size(345, 249);
            this.dgvTask.TabIndex = 13;
            this.dgvTask.Click += new System.EventHandler(this.dataView_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 12;
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
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labourersToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.cropsToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.containersToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // labourersToolStripMenuItem
            // 
            this.labourersToolStripMenuItem.Name = "labourersToolStripMenuItem";
            this.labourersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.labourersToolStripMenuItem.Text = "Labourers";
            this.labourersToolStripMenuItem.Click += new System.EventHandler(this.labourersToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // cropsToolStripMenuItem
            // 
            this.cropsToolStripMenuItem.Name = "cropsToolStripMenuItem";
            this.cropsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cropsToolStripMenuItem.Text = "Crops";
            this.cropsToolStripMenuItem.Click += new System.EventHandler(this.cropsToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // containersToolStripMenuItem
            // 
            this.containersToolStripMenuItem.Name = "containersToolStripMenuItem";
            this.containersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.containersToolStripMenuItem.Text = "Containers";
            this.containersToolStripMenuItem.Click += new System.EventHandler(this.containersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(133, 406);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(153, 21);
            this.cmbType.TabIndex = 24;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(438, 406);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(161, 21);
            this.cmbEmployee.TabIndex = 25;
            // 
            // cmbVeh
            // 
            this.cmbVeh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVeh.FormattingEnabled = true;
            this.cmbVeh.Location = new System.Drawing.Point(684, 406);
            this.cmbVeh.Name = "cmbVeh";
            this.cmbVeh.Size = new System.Drawing.Size(161, 21);
            this.cmbVeh.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Vehicle:";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(133, 461);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(153, 20);
            this.startDate.TabIndex = 33;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(133, 490);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(153, 20);
            this.endDate.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 77);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(360, 139);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(261, 249);
            this.dgvEmp.TabIndex = 48;
            this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick);
            this.dgvEmp.Click += new System.EventHandler(this.dgvTest_Click);
            // 
            // cmbMP
            // 
            this.cmbMP.FormattingEnabled = true;
            this.cmbMP.Location = new System.Drawing.Point(133, 434);
            this.cmbMP.Name = "cmbMP";
            this.cmbMP.Size = new System.Drawing.Size(153, 21);
            this.cmbMP.TabIndex = 49;
            this.cmbMP.SelectedIndexChanged += new System.EventHandler(this.cmbFS_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(96, 438);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(32, 13);
            this.lblType.TabIndex = 50;
            this.lblType.Text = "Field:";
            // 
            // dgvVeh
            // 
            this.dgvVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeh.Location = new System.Drawing.Point(624, 139);
            this.dgvVeh.Name = "dgvVeh";
            this.dgvVeh.Size = new System.Drawing.Size(240, 249);
            this.dgvVeh.TabIndex = 51;
            this.dgvVeh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeh_CellClick);
            // 
            // btnRemEmp
            // 
            this.btnRemEmp.Enabled = false;
            this.btnRemEmp.Location = new System.Drawing.Point(438, 492);
            this.btnRemEmp.Name = "btnRemEmp";
            this.btnRemEmp.Size = new System.Drawing.Size(117, 23);
            this.btnRemEmp.TabIndex = 52;
            this.btnRemEmp.Text = "Remove Employee";
            this.btnRemEmp.UseVisualStyleBackColor = true;
            this.btnRemEmp.Click += new System.EventHandler(this.btnRemEmp_Click);
            // 
            // btnRemVeh
            // 
            this.btnRemVeh.Enabled = false;
            this.btnRemVeh.Location = new System.Drawing.Point(696, 492);
            this.btnRemVeh.Name = "btnRemVeh";
            this.btnRemVeh.Size = new System.Drawing.Size(117, 23);
            this.btnRemVeh.TabIndex = 53;
            this.btnRemVeh.Text = "Remove Vehicle";
            this.btnRemVeh.UseVisualStyleBackColor = true;
            this.btnRemVeh.Click += new System.EventHandler(this.btnRemVeh_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(45, 616);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(82, 23);
            this.btnAddTask.TabIndex = 54;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnUpdTask
            // 
            this.btnUpdTask.Enabled = false;
            this.btnUpdTask.Location = new System.Drawing.Point(172, 616);
            this.btnUpdTask.Name = "btnUpdTask";
            this.btnUpdTask.Size = new System.Drawing.Size(82, 23);
            this.btnUpdTask.TabIndex = 55;
            this.btnUpdTask.Text = "Update Task";
            this.btnUpdTask.UseVisualStyleBackColor = true;
            this.btnUpdTask.Click += new System.EventHandler(this.btnUpdTask_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(789, 616);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear Input";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(438, 438);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(117, 23);
            this.btnAddEmp.TabIndex = 57;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnAddVeh
            // 
            this.btnAddVeh.Location = new System.Drawing.Point(696, 438);
            this.btnAddVeh.Name = "btnAddVeh";
            this.btnAddVeh.Size = new System.Drawing.Size(117, 23);
            this.btnAddVeh.TabIndex = 58;
            this.btnAddVeh.Text = "Add Vehicle";
            this.btnAddVeh.UseVisualStyleBackColor = true;
            this.btnAddVeh.Click += new System.EventHandler(this.btnAddVeh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Assigned Employees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Assigned Vehicles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tasks:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(133, 516);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(153, 20);
            this.txtQty.TabIndex = 62;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(79, 518);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 13);
            this.lblQty.TabIndex = 63;
            this.lblQty.Text = "Quantity:";
            // 
            // chkStat
            // 
            this.chkStat.AutoSize = true;
            this.chkStat.Location = new System.Drawing.Point(151, 584);
            this.chkStat.Name = "chkStat";
            this.chkStat.Size = new System.Drawing.Size(103, 17);
            this.chkStat.TabIndex = 64;
            this.chkStat.Text = "Task Completed";
            this.chkStat.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(133, 542);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(153, 36);
            this.txtReason.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Reason:";
            // 
            // cmbTskDisp
            // 
            this.cmbTskDisp.FormattingEnabled = true;
            this.cmbTskDisp.Items.AddRange(new object[] {
            "All",
            "Completed",
            "Incomplete"});
            this.cmbTskDisp.Location = new System.Drawing.Point(12, 112);
            this.cmbTskDisp.Name = "cmbTskDisp";
            this.cmbTskDisp.Size = new System.Drawing.Size(121, 21);
            this.cmbTskDisp.TabIndex = 67;
            this.cmbTskDisp.Text = "All";
            this.cmbTskDisp.SelectedIndexChanged += new System.EventHandler(this.cmbTskDisp_SelectedIndexChanged);
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(292, 434);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(65, 21);
            this.cmbField.TabIndex = 68;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(877, 666);
            this.Controls.Add(this.cmbField);
            this.Controls.Add(this.cmbTskDisp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.chkStat);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddVeh);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnRemVeh);
            this.Controls.Add(this.btnRemEmp);
            this.Controls.Add(this.dgvVeh);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbMP);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.cmbVeh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskManager";
            this.Text = "Task manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskManager_FormClosing);
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.Click += new System.EventHandler(this.TaskManager_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labourersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbVeh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbMP;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView dgvVeh;
        private System.Windows.Forms.Button btnRemEmp;
        private System.Windows.Forms.Button btnRemVeh;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnUpdTask;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnAddVeh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.CheckBox chkStat;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTskDisp;
        private System.Windows.Forms.ComboBox cmbField;
    }
}