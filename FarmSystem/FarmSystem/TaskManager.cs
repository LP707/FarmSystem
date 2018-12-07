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
        MetaLayer ml = MetaLayer.instance();
        Task tsk = new Task();
        Employee.Labourer lb = new Employee.Labourer();
        List<Employee.Labourer> em = new List<Employee.Labourer>();
        List<Employee.Labourer> aEmp = new List<Employee.Labourer>();
        List<Vehicle> aVeh = new List<Vehicle>();
        
        int tID;
        
        

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

        private void containersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Containers cn = new Containers();
            this.Hide();
            cn.Show();
        }



        private void TaskManager_Load(object sender, EventArgs e)
        {
            List<Employee.Labourer> lab = da.returnLabourerList();
            List<Task> taskList = da.returnTaskList();
            List<Vehicle> Veh = da.returnVehicleList();
            List<Fields> fl = da.returnField();

            dgvTask.DataSource = taskList;
            dgvTask.Refresh();
            cmbType.DataSource = tsk.returnList();
            cmbField.DataSource = fl;
            cmbEmployee.DataSource = lab;
            cmbEmployee.DisplayMember = "DName";
            cmbVeh.DataSource = Veh;
            cmbVeh.DisplayMember = "DName";
            hideColumns();



        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Hides columns which aren't useful for the user.
        public void hideColumns()
        {
            dgvTask.Columns["taskID"].Visible = false;
            dgvTask.Columns["vehID"].Visible = false;
            dgvTask.Columns["fertID"].Visible = false;
            dgvTask.Columns["treatID"].Visible = false;
            dgvTask.Columns["fieldID"].Visible = false;

            //Hides columns if the data grid has a data source.
            if (dgvEmp.DataSource != null)
            {
                dgvEmp.Columns[0].Visible = false;
                dgvEmp.Columns[1].Visible = false;
                dgvEmp.Columns[2].Visible = false;
                dgvEmp.Columns[3].Visible = false;
                dgvEmp.Columns[4].Visible = false;
                dgvEmp.Columns[5].Visible = false;
                dgvEmp.Columns[6].Visible = false;
                dgvEmp.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dgvVeh.DataSource != null)
            {
                dgvVeh.Columns[0].Visible = false;
                dgvVeh.Columns[1].Visible = false;
                dgvVeh.Columns[2].Visible = false;
                dgvVeh.Columns[3].Visible = false;
                dgvVeh.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Task> Task = da.returnTaskList();

            string name, employeeN, vehicleN;
            int taskID;
            DateTime start, end;
            taskID = Task.Count + 1;
            name = this.cmbType.GetItemText(this.cmbType.SelectedItem);
            employeeN = this.cmbEmployee.GetItemText(this.cmbEmployee.SelectedItem);
            vehicleN = this.cmbVeh.GetItemText(this.cmbVeh.SelectedItem);
            
            start = startDate.Value;
            end = endDate.Value;
            
            //ml.addTask(taskID, name, employeeN, vehicleN, start, end);
            //con.ExecuteNonQuery(query);
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

            //List<Employee.Labourer> lab = da.returnLabourerList();
            //List<Task> task = da.returnTaskList();
            //List<Vehicle> veh = da.returnVehicleList();
            //List<Scheduler> sch = da.returnSchedule();
            Task ta = (Task)dgvTask.CurrentRow.DataBoundItem;
            List<string> taskType = ta.returnList();

            //dgvTask.DataSource = task;
            //dgvTask.Refresh();

            tID = ta.taskID;
            dgvEmp.DataSource = findEmployees();
            dgvEmp.Refresh();

            cmbType.SelectedIndex = taskType.FindIndex(a => a == ta.taskType);

            dgvVeh.DataSource = findVehicles();

            dgvVeh.Refresh();
            //cmbVeh.SelectedIndex = findVehicle();
            //cmbVeh.DataSource = Veh;

            hideColumns();

        }

        private void TaskManager_Click(object sender, EventArgs e)
        {

        }

        //Compares the values of the taskvehicles list and vehicles list and creates a new list of the vehicles assigned to the selected task.
        public List<Vehicle> findVehicles()
        {
            List<Vehicle> veh = da.returnVehicleList();
            List<TaskVehicles> tv = da.returnTaskVehicles();
            List<Task> ta = da.returnTaskList();
            List<Vehicle> vh = new List<Vehicle>();

            int i = 0;

            //Compares the IDs of vehicle and taskvehicles lists and eliminates the values missing in both lists.
            foreach (var e in tv.Where(e => veh.Select(c => c.vehID).Contains(e.taskVehID)))
            {
                //Adds the matching values in to a new list if the schedule list task ID matches the selected task ID.
                if (e.vehTaskID == tID)
                {
                    i = veh.FindIndex(a => a.vehID == e.taskVehID);
                    vh.Add(veh[i]);
                }

            }

            //Compares the IDs of vehicle and assigned vehicle lists to find values that are not matching - adds them to another list.
            foreach (var e in veh.Where(e => !tv.Select(c => c.taskVehID).Contains(e.vehID)))
            {

                i = veh.FindIndex(a => a.vehID == e.vehID);
                aVeh.Add(veh[i]);
            }


            cmbVeh.DataSource = aVeh;

            return vh;


        }

        //Compares the values of the schedule list and labourer list and creates a new list of the labourers assigned to the selected task.
        public List<Employee.Labourer> findEmployees()
        {
            List<Employee.Labourer> lab = da.returnLabourerList();
            List<Scheduler> sch = da.returnSchedule();
            List<Task> ta = da.returnTaskList();
            

            int i = 0;

            //Compares the IDs of labourer and schedule lists and eliminates the values missing in both lists.
            foreach (var e in sch.Where(e => lab.Select(c => c.ID).Contains(e.empID)))
            {
                //Adds the matching values in to a new list if the schedule list task ID matches the selected task ID.
                if (e.taskID == tID)
                {
                    i = lab.FindIndex(a => a.ID == e.empID);
                    em.Add(lab[i]);
                }
                
            }

            //Compares the IDs of labourer and assigned employee lists to find values that are not matching - adds them to another list.
            foreach (var e in lab.Where(e => !em.Select(c => c.ID).Contains(e.ID)))
            {
                i = lab.FindIndex(a => a.ID == e.ID);
                aEmp.Add(lab[i]);
            }

            cmbEmployee.DataSource = aEmp;
            return em;
        }


        private void btnUpd_Click(object sender, EventArgs e)
        {
            List<Task> Task = da.returnTaskList();

            string name, employeeN, VehicleN;
            int TaskID;
            DateTime start, end;
            TaskID = Task.Count + 1;
            name = this.cmbType.GetItemText(this.cmbType.SelectedItem);
            employeeN = this.cmbEmployee.GetItemText(this.cmbEmployee.SelectedItem);
            VehicleN = this.cmbVeh.GetItemText(this.cmbVeh.SelectedItem);
            
            start = startDate.Value;
            end = endDate.Value;
            string query = "INSERT INTO Tasks (TaskID, TaskType, Name, VehicleName, startDate, endDate) VALUES " +
            "('" + TaskID + "', '" + name + "','" + employeeN + "','" + VehicleN + "', '" + start + "', '" + end + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            RefreshMeth();
        }

        private void TaskManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dgvTest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemEmp_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)dgvEmp.CurrentRow.DataBoundItem;
            
            int eID = emp.ID;

            ml.removeEmp(tID, eID);

            //dgvEmp.DataSource = da.returnLabourerList();
        }

        private void btnRemVeh_Click(object sender, EventArgs e)
        {
            Vehicle veh = (Vehicle)dgvVeh.CurrentRow.DataBoundItem;

            int vID = veh.vehID;

            ml.removeVeh(tID, vID);
        }

        //Resets the combo boxes and date/time picker values.
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = -1;
            cmbField.SelectedIndex = -1;
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today;
            cmbEmployee.SelectedIndex = -1;
            cmbVeh.SelectedIndex = -1;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)dgvEmp.CurrentRow.DataBoundItem;
            

            int eID = em.FindIndex(a => a.ID == emp.ID);

            ml.addEmp(tID, eID);
        }

        private void btnAddVeh_Click(object sender, EventArgs e)
        {
            Vehicle veh = (Vehicle)dgvVeh.CurrentRow.DataBoundItem;

            int vID = veh.vehID;

            ml.addVeh(tID, vID);
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            this.Hide();
            rp.Show();
        }
    }
}