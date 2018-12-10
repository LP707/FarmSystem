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
            this.fieldsToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.lblID.Location = new System.Drawing.Point(89, 503);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 17);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "Task Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 606);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "End Date/Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 571);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Start Date/Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 502);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Employee:";
            // 
            // dgvTask
            // 
            this.dgvTask.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(16, 171);
            this.dgvTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTask.MultiSelect = false;
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.Size = new System.Drawing.Size(460, 306);
            this.dgvTask.TabIndex = 13;
            this.dgvTask.Click += new System.EventHandler(this.dataView_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1169, 28);
            this.menuStrip1.TabIndex = 12;
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
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labourersToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.cropsToolStripMenuItem,
            this.fieldsToolStripMenu,
            this.homeToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // labourersToolStripMenuItem
            // 
            this.labourersToolStripMenuItem.Name = "labourersToolStripMenuItem";
            this.labourersToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.labourersToolStripMenuItem.Text = "Labourers";
            this.labourersToolStripMenuItem.Click += new System.EventHandler(this.labourersToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // cropsToolStripMenuItem
            // 
            this.cropsToolStripMenuItem.Name = "cropsToolStripMenuItem";
            this.cropsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cropsToolStripMenuItem.Text = "Crops";
            this.cropsToolStripMenuItem.Click += new System.EventHandler(this.cropsToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // fieldsToolStripMenu
            // 
            this.fieldsToolStripMenu.Name = "fieldsToolStripMenu";
            this.fieldsToolStripMenu.Size = new System.Drawing.Size(216, 26);
            this.fieldsToolStripMenu.Text = "Fields";
            this.fieldsToolStripMenu.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(177, 500);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(203, 24);
            this.cmbType.TabIndex = 24;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(584, 500);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(213, 24);
            this.cmbEmployee.TabIndex = 25;
            // 
            // cmbVeh
            // 
            this.cmbVeh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVeh.FormattingEnabled = true;
            this.cmbVeh.Location = new System.Drawing.Point(912, 500);
            this.cmbVeh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVeh.Name = "cmbVeh";
            this.cmbVeh.Size = new System.Drawing.Size(213, 24);
            this.cmbVeh.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 503);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Vehicle:";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(177, 567);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(203, 22);
            this.startDate.TabIndex = 33;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(177, 603);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(203, 22);
            this.endDate.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 95);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(480, 171);
            this.dgvEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(348, 306);
            this.dgvEmp.TabIndex = 48;
            this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick);
            this.dgvEmp.Click += new System.EventHandler(this.dgvTest_Click);
            // 
            // cmbMP
            // 
            this.cmbMP.FormattingEnabled = true;
            this.cmbMP.Location = new System.Drawing.Point(177, 534);
            this.cmbMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMP.Name = "cmbMP";
            this.cmbMP.Size = new System.Drawing.Size(203, 24);
            this.cmbMP.TabIndex = 49;
            this.cmbMP.SelectedIndexChanged += new System.EventHandler(this.cmbFS_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(128, 539);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 17);
            this.lblType.TabIndex = 50;
            this.lblType.Text = "Field:";
            // 
            // dgvVeh
            // 
            this.dgvVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeh.Location = new System.Drawing.Point(832, 171);
            this.dgvVeh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVeh.Name = "dgvVeh";
            this.dgvVeh.Size = new System.Drawing.Size(320, 306);
            this.dgvVeh.TabIndex = 51;
            this.dgvVeh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeh_CellClick);
            // 
            // btnRemEmp
            // 
            this.btnRemEmp.Enabled = false;
            this.btnRemEmp.Location = new System.Drawing.Point(584, 606);
            this.btnRemEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemEmp.Name = "btnRemEmp";
            this.btnRemEmp.Size = new System.Drawing.Size(156, 28);
            this.btnRemEmp.TabIndex = 52;
            this.btnRemEmp.Text = "Remove Employee";
            this.btnRemEmp.UseVisualStyleBackColor = true;
            this.btnRemEmp.Click += new System.EventHandler(this.btnRemEmp_Click);
            // 
            // btnRemVeh
            // 
            this.btnRemVeh.Enabled = false;
            this.btnRemVeh.Location = new System.Drawing.Point(928, 606);
            this.btnRemVeh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemVeh.Name = "btnRemVeh";
            this.btnRemVeh.Size = new System.Drawing.Size(156, 28);
            this.btnRemVeh.TabIndex = 53;
            this.btnRemVeh.Text = "Remove Vehicle";
            this.btnRemVeh.UseVisualStyleBackColor = true;
            this.btnRemVeh.Click += new System.EventHandler(this.btnRemVeh_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(60, 758);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(109, 28);
            this.btnAddTask.TabIndex = 54;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnUpdTask
            // 
            this.btnUpdTask.Enabled = false;
            this.btnUpdTask.Location = new System.Drawing.Point(229, 758);
            this.btnUpdTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdTask.Name = "btnUpdTask";
            this.btnUpdTask.Size = new System.Drawing.Size(109, 28);
            this.btnUpdTask.TabIndex = 55;
            this.btnUpdTask.Text = "Update Task";
            this.btnUpdTask.UseVisualStyleBackColor = true;
            this.btnUpdTask.Click += new System.EventHandler(this.btnUpdTask_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1052, 758);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear Input";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(584, 539);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(156, 28);
            this.btnAddEmp.TabIndex = 57;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnAddVeh
            // 
            this.btnAddVeh.Location = new System.Drawing.Point(928, 539);
            this.btnAddVeh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddVeh.Name = "btnAddVeh";
            this.btnAddVeh.Size = new System.Drawing.Size(156, 28);
            this.btnAddVeh.TabIndex = 58;
            this.btnAddVeh.Text = "Add Vehicle";
            this.btnAddVeh.UseVisualStyleBackColor = true;
            this.btnAddVeh.Click += new System.EventHandler(this.btnAddVeh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Assigned Employees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(924, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Assigned Vehicles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tasks:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(177, 635);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(203, 22);
            this.txtQty.TabIndex = 62;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(105, 638);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(65, 17);
            this.lblQty.TabIndex = 63;
            this.lblQty.Text = "Quantity:";
            // 
            // chkStat
            // 
            this.chkStat.AutoSize = true;
            this.chkStat.Location = new System.Drawing.Point(201, 719);
            this.chkStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStat.Name = "chkStat";
            this.chkStat.Size = new System.Drawing.Size(132, 21);
            this.chkStat.TabIndex = 64;
            this.chkStat.Text = "Task Completed";
            this.chkStat.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(177, 667);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(203, 43);
            this.txtReason.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 671);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
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
            this.cmbTskDisp.Location = new System.Drawing.Point(16, 138);
            this.cmbTskDisp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTskDisp.Name = "cmbTskDisp";
            this.cmbTskDisp.Size = new System.Drawing.Size(160, 24);
            this.cmbTskDisp.TabIndex = 67;
            this.cmbTskDisp.Text = "All";
            this.cmbTskDisp.SelectedIndexChanged += new System.EventHandler(this.cmbTskDisp_SelectedIndexChanged);
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(389, 534);
            this.cmbField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(85, 24);
            this.cmbField.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Fertiliser for the week";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 717);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "Storage for the week";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 758);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 71;
            this.button3.Text = "Harvesting for the week";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 820);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.CheckBox chkStat;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTskDisp;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.ToolStripMenuItem fieldsToolStripMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}