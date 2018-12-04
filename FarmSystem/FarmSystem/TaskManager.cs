﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem
{
    public partial class TaskManager : Form
    {
        DbConection con = DBCheck.instance();
        DataAccess da = DataAccess.instance();
        Task ta = new Task();
        Employee.Labourer lb = new Employee.Labourer();
        //Vehicle.Tractor tr = new Vehicle.Tractor();
        
        public TaskManager()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labourersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLabourer ml = new ManageLabourer();
            this.Hide();
            ml.Show();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVehicle mv = new ManageVehicle();
            this.Hide();
            mv.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm mf = new ManagerForm();
            this.Hide();
            mf.Show();
        }

        private void cropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCrops mc = new ManageCrops();
            this.Hide();
            mc.Show();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            BindingList<Employee.Labourer> Labourers = da.returnLabourerList();
            List<Task> Task = da.returnTaskList();
            List<Vehicle> Veh = da.returnVehicleList();
            dgvTask.DataSource = Task;
            dgvTask.Refresh();
            cmbType.DataSource = ta.returnList();
            cmbEmployee.DataSource = Labourers;
            cmbEmployee.DisplayMember = "DName";
            cmbVeh.DataSource = Veh;
            cmbVeh.DisplayMember = "DName";
            hideColumns();
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void hideColumns()
        {
            dgvTask.Columns["taskID"].Visible = false;
            dgvTask.Columns["vehID"].Visible = false;
            dgvTask.Columns["fertID"].Visible = false;
            dgvTask.Columns["treatID"].Visible = false;
            dgvTask.Columns["fieldID"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Task> Task = da.returnTaskList();

            string name, employeeN, VehicleN, VehicleA;
            int TaskID;
            DateTime start, end;

            name = this.cmbType.GetItemText(this.cmbType.SelectedItem);
            employeeN = this.cmbEmployee.GetItemText(this.cmbEmployee.SelectedItem);
            VehicleN = this.cmbVeh.GetItemText(this.cmbVeh.SelectedItem);
            VehicleA = this.cmbVehA.GetItemText(this.cmbVehA.SelectedItem);
            start = startDate.Value;
            end = endDate.Value;
            string query = "INSERT INTO Tasks (TaskType, Name, VehicleName, Attachment, startDate, endDate) VALUES " + "('" + name + "','" + employeeN + "','" + VehicleN + "', '" + VehicleA + "', '" + start + "', '" + end + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            RefreshMeth();
        }

        public void RefreshMeth()
        {
            da.connectionToDB();
            dgvTask.DataSource = null;
            dgvTask.DataSource = da.returnTaskList();
            dgvTask.Refresh();
        }

        private void dataView_Click(object sender, EventArgs e)
        {
    
            BindingList<Employee.Labourer> Labourers = da.returnLabourerList();
            List<Task> Task = da.returnTaskList();
            List<Vehicle> Veh = da.returnVehicleList();



            dgvTask.DataSource = Task;
            dgvTask.Refresh();
            cmbType.DataSource = ta.returnList();
            cmbType.DisplayMember = " ";
            cmbEmployee.DataSource = Labourers;
            cmbEmployee.DisplayMember = "ID = 1";
            cmbVeh.DataSource = Veh;
            cmbVeh.DisplayMember = "ID = 1";
        }

        private void TaskManager_Click(object sender, EventArgs e)
        {

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            List<Task> Task = da.returnTaskList();

            string name, taskType, employeeN, VehicleN, VehicleA;
            int TaskID, EmID, VhID;
            DateTime start, end;

            name = this.cmbVT.GetItemText(this.cmbVT.SelectedItem);
            //TaskID = Task.Count + 1;
            employeeN = this.cmbVE.GetItemText(this.cmbVE.SelectedItem);
            VehicleN = this.cmbVV.GetItemText(this.cmbVV.SelectedItem);
            VehicleA = this.cmbVVA.GetItemText(this.cmbVVA.SelectedItem);
            EmID = 2;
            VhID = 2;
            start = startV.Value;
            end = endV.Value;
            string query = "INSERT INTO Tasks (TaskName, LabourerID, Name, VehicleName, Attachment, VhID, startDate, endDate) VALUES ('" + name + "', '" + EmID + "''" + employeeN + "','" + VehicleN + "', '" + VehicleA + "', '" + VhID + "', '" + start + "', '" + end + "';";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            dgvTask.Refresh();
        }

        private void TaskManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
