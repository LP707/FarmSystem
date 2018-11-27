using System;
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
        Vehicle.Tractor tr = new Vehicle.Tractor();

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
            List<Employee.Labourer> Labourers = da.returnLabourerList();
            List<Task> Task = da.returnTaskList();
            List<Vehicle> Veh = da.returnVehicleList();
            dataView.DataSource = Task;
            dataView.Refresh();
            cmbType.DataSource = ta.returnList();
            cmbEmployee.DataSource = Labourers;
            cmbEmployee.DisplayMember = "DName";
            cmbVeh.DataSource = Veh;
            cmbVeh.DisplayMember = "DName";
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, taskType, employeeN, VehicleN, VehicleA;
            int TaskID, EmID, VhID;
            DateTime start, end;

            name = cmbType.ToString();
            TaskID = 2;
            employeeN = cmbEmployee.ToString();
            VehicleN = cmbVeh.ToString();
            VehicleA = cmbVehA.ToString();
            EmID = 2;
            VhID = 2;
            start = startDate.Value;
            end = endDate.Value;
            string query = "INSERT INTO Tasks (TaskID, TaskName, LabourerID, Name, VehicleName, Attachment, VhID, startDate, endDate) VALUES ('" + TaskID + "', '" + name + "', '" + EmID + "''" + employeeN + "','" + VehicleN + "', '" + VehicleA + "', '" + VhID + "', '" + start + "', '" + end + "';";

            da.ExecuteNonQuery(query, con);
            da.connectionToDB();
            dataView.Refresh();
        }

        private void dataView_Click(object sender, EventArgs e)
        {
            List<Employee.Labourer> Labourers = da.returnLabourerList();
            List<Task> Task = da.returnTaskList();
            List<Vehicle> Veh = da.returnVehicleList();
            dataView.DataSource = Task;
            dataView.Refresh();
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
            //NEEDS TO BE EDITED TO WORK FOR UPDATE
            //
            //
            //
            //
            //string name, taskType, employeeN, VehicleN, VehicleA;
            //int TaskID, EmID, VhID;
            //DateTime start, end;

            //System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;" +
            //    @"Data source= C:\Users\398019\Source\Repos\FarmSystem\FarmSystem\FarmSystem\bin\Debug\FarmDB.accdb";
            //name = cmbType.ToString();
            //TaskID = 2;
            //employeeN = cmbEmployee.ToString();
            //VehicleN = cmbVeh.ToString();
            //VehicleA = cmbVehA.ToString();
            //EmID = 2;
            //VhID = 2;
            //start = startDate.Value;
            //end = endDate.Value;
            //string query = "INSERT INTO Tasks (TaskID, TaskName, LabourerID, Name, VehicleName, Attachment, VhID, startDate, endDate) VALUES ('" + TaskID + "', '" + name + "', '" + EmID + "''" + employeeN + "','" + VehicleN + "', '" + VehicleA + "', '" + VhID + "', '" + start + "', '" + end + "';";

            //da.ExecuteNonQuery(query, con);
            //da.connectionToDB();
            //dataView.Refresh();
        }
    }
}
