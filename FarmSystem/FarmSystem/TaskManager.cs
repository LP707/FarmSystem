/* 
     SID: 1719547

     Description: Allows the user to create new tasks and add vehicles, employees and items which may be used with the specfic task type.

     Version: 1

*/
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
            cmbMP.DataSource = fl;
            cmbMP.DisplayMember = "DName";
            cmbEmployee.DataSource = lab;
            cmbEmployee.DisplayMember = "DName";
            cmbVeh.DataSource = Veh;
            cmbVeh.DisplayMember = "DName";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            cmbField.Visible = false;
            cmbField.DataSource = fl;
            cmbField.DisplayMember = "fieldName";
            clearInput();
            hideColumns();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Storage> sto = da.returnStorage();
            List<Fertilisers> fer = da.returnFertiliser();
            List<Treatments> tre = da.returnTreatments();
            List<Fields> fie = da.returnField();

            //Sets the information to display depending on the task type.
            if (cmbType.SelectedValue == "Storing")
            {
                lblType.Text = "Storage:";
                lblType.Location = new Point(81, 438);
                cmbMP.DataSource = sto;
                cmbMP.DisplayMember = "StoreName";
                cmbField.Visible = true;

            }
            else if (cmbType.SelectedValue == "Treating")
            {
                lblType.Text = "Treatment:";
                lblType.Location = new Point(76, 438);
                cmbMP.DataSource = tre;
                cmbMP.DisplayMember = "TreatmentName";
                cmbField.Visible = true;
            }
            else if (cmbType.SelectedValue == "Fertilising")
            {
                lblType.Text = "Fertiliser:";
                lblType.Location = new Point(81, 438);
                cmbMP.DataSource = fer;
                cmbMP.DisplayMember = "FertiliserName";
                cmbField.Visible = true;
            }
            else 
            {
                lblType.Text = "Field:";
                lblType.Location = new Point(96, 438);
                cmbMP.DataSource = fie;
                cmbMP.DisplayMember = "DName";
                cmbField.Visible = false;
            }
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
        
        

        //Used to refresh the data within the data grids.
        public void RefreshMeth()
        {

            dgvTask.DataSource = null;
            dgvTask.DataSource = da.returnTaskList();
            dgvTask.Refresh();

            dgvEmp.DataSource = null;
            dgvEmp.DataSource = findEmployees();
            dgvEmp.Refresh();

            dgvVeh.DataSource = null;
            dgvVeh.DataSource = findVehicles();
            dgvVeh.Refresh();

            hideColumns();
        }

        private void dataView_Click(object sender, EventArgs e)
        {
            List<Fields> fl = da.returnField();
            List<Storage> sto = da.returnStorage();
            List<Treatments> tr = da.returnTreatments();
            List<Fertilisers> fr = da.returnFertiliser();
            Task ta = (Task)dgvTask.CurrentRow.DataBoundItem;
            List<string> taskType = ta.returnList();

            tID = ta.taskID;
            dgvEmp.DataSource = findEmployees();
            cmbType.SelectedIndex = taskType.FindIndex(x => x == ta.taskType);

            //Sets the combo box to an appropriate value when a task is selected
            if (cmbMP.DataSource == fl)
            {
                cmbMP.SelectedIndex = fl.FindIndex(x => x.fieldID == ta.fieldID);
            }
            else if (cmbMP.DataSource == tr)
            {
                cmbMP.SelectedIndex = tr.FindIndex(x => x.treatID == ta.treatID);
            }
            else if (cmbMP.DataSource == fr)
            {
                cmbMP.SelectedIndex = fr.FindIndex(x => x.fertID == ta.fertID);
            }


            dgvVeh.DataSource = findVehicles();
            txtQty.Text = ta.quantity.ToString();
            txtReason.Text = ta.reason;
            
            //Sets check box depending on the selected tasks status value.
            if (ta.status == "Complete")
            {
                chkStat.Checked = true;
            }
            else
            {
                chkStat.Checked = false;
            }

            startDate.Value = ta.theStart;
            endDate.Value = ta.theEnd;
            btnUpdTask.Enabled = true;
            cmbField.SelectedIndex = fl.FindIndex(a => a.fieldID == ta.fieldID);

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

            dgvVeh.DataSource = null;
            vh.Clear();

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

            dgvEmp.DataSource = null;
            em.Clear();
            

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
            RefreshMeth();
        }

        private void btnRemVeh_Click(object sender, EventArgs e)
        {
            Vehicle veh = (Vehicle)dgvVeh.CurrentRow.DataBoundItem;
            int vID = veh.vehID;
            ml.removeVeh(tID, vID);
            RefreshMeth();
        }


        //Resets the combo boxes, date/time picker values and dgv selections.
        public void clearInput()
        {
            dgvTask.ClearSelection();
            dgvEmp.ClearSelection();
            dgvVeh.ClearSelection();
            cmbType.SelectedIndex = -1;
            cmbMP.SelectedIndex = -1;
            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today;
            cmbEmployee.SelectedIndex = -1;
            cmbVeh.SelectedIndex = -1;
            txtQty.Clear();
            txtReason.Clear();
            chkStat.Checked = false;
            btnUpdTask.Enabled = false;
            btnRemVeh.Enabled = false;
            btnRemEmp.Enabled = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {

            int eID = aEmp[cmbEmployee.SelectedIndex].ID;
            ml.addEmp(tID, eID);
            RefreshMeth();
            
        }

        private void btnAddVeh_Click(object sender, EventArgs e)
        {
            int vID = aVeh[cmbVeh.SelectedIndex].vehID;
            ml.addVeh(tID, vID);
            RefreshMeth();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //When the button is clicked, the tasks table will be updated with the entered information.
        private void btnUpdTask_Click(object sender, EventArgs e)
        {
            Task ta = (Task)dgvTask.CurrentRow.DataBoundItem;
            List<Task> task = da.returnTaskList();
            List<Storage> sto = da.returnStorage();
            List<Fertilisers> fer = da.returnFertiliser();
            List<Treatments> tre = da.returnTreatments();
            List<Fields> fie = da.returnField();
            List<CropStorage> crSto = da.returnCropStorage();
            List<Crops> cro = da.returnCropList();

            string type;
            int fID = 0;
            int stoID = 0;
            int quant = int.Parse(txtQty.Text);
            int newQty = 0;
            int ferID = ta.fertID;
            int treID = ta.treatID;
            int croID = 0;
            string details = txtReason.Text;
            string status;

            DateTime start, end;

            type = this.cmbType.GetItemText(this.cmbType.SelectedItem);

            fID = fie[cmbField.SelectedIndex].fieldID;
            start = startDate.Value;
            end = endDate.Value;

            //Sets the status to complete if the check box is checked.
            if (chkStat.Checked)
            {
                status = "Complete";
                //Only updates the fertiliser, treatment and storage quantities if the task is complete.
                if (cmbMP.DataSource == sto)
                {
                    stoID = sto[cmbMP.SelectedIndex].storeID;
                    foreach (var s in crSto.Where(s => stoID == s.sID))
                    {
                        croID = s.cID;
                        newQty = s.qtyStored + quant;
                    }

                    ml.updStorageTask(stoID, croID, newQty);
                }
                else if (cmbMP.DataSource == fer)
                {
                    ferID = fer[cmbMP.SelectedIndex].fertID;
                    newQty = fer[cmbMP.SelectedIndex].quant - quant;
                    ml.updFertTask(ferID, newQty);
                }
                else if (cmbMP.DataSource == tre)
                {
                    treID = tre[cmbMP.SelectedIndex].treatID;
                    newQty = tre[cmbMP.SelectedIndex].quant - quant;
                    ml.updTreatTask(treID, newQty);
                }
                else if (cmbType.SelectedValue == "Sowing")
                {

                    int cID = fie[cmbField.SelectedIndex].cropID;

                    newQty = cro.Find(x => x.cropID == cID).seedQuant - quant;
                    ml.updCropTask(cID, newQty);
                }
            }
            else
            {
                status = "Incomplete";
            }
            //Sets the results to DB
            ml.updTask(tID, start, end, fID, type, ferID, treID, quant, details, status);

            clearInput();
            RefreshMeth();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            
            List<Task> task = da.returnTaskList();
            List<Storage> sto = da.returnStorage();
            List<Fertilisers> fer = da.returnFertiliser();
            List<Treatments> tre = da.returnTreatments();
            List<Fields> fie = da.returnField();
            List<CropStorage> crSto = da.returnCropStorage();
            List<Crops> cro = da.returnCropList();

            string type;
            int taskID;
            int fID = 0;
            int stoID = 0;
            int quant = int.Parse(txtQty.Text);
            int newQty = 0;
            int ferID = 0;
            int treID = 0;
            int croID = 0;
            //int qty = ta.quantity;
            string details = txtReason.Text;
            string status = "Incomplete";

            DateTime start, end;

            //Finds the highes taskID number and adds 1 to it.
            taskID = task.Max(i => i.taskID) + 1;
            type = this.cmbType.GetItemText(this.cmbType.SelectedItem);
            
            start = startDate.Value;
            end = endDate.Value;

            //Adds the appropriate IDs depending on the task type and combo box selection.
            if (cmbMP.DataSource == sto)
            {
                fID = fie[cmbField.SelectedIndex].fieldID;
                stoID = sto[cmbMP.SelectedIndex].storeID;
                foreach (var s in crSto.Where(s => stoID == s.sID))
                {
                    croID = s.cID;
                }
            }
            else if (cmbMP.DataSource == fer)
            {
                fID = fie[cmbField.SelectedIndex].fieldID;
                ferID = fer[cmbMP.SelectedIndex].fertID;
                newQty = fer[cmbMP.SelectedIndex].quant - quant;
                if (newQty <= 0)
                {
                    MessageBox.Show("Not enough Fertiliser", "Error");
                    return;
                }
            }
            else if (cmbMP.DataSource == tre)
            {
                fID = fie[cmbField.SelectedIndex].fieldID;
                treID = tre[cmbMP.SelectedIndex].treatID;
                newQty = tre[cmbMP.SelectedIndex].quant - quant;
                if (newQty <= 0)
                {
                    MessageBox.Show("Not enough Treatment", "Error");
                    return;
                }
            }
            else if (cmbMP.SelectedValue == "Sowing")
            {
                fID = fie[cmbField.SelectedIndex].fieldID;
                
                newQty = cro[cmbMP.SelectedIndex].seedQuant - quant;
                if (newQty <= 0)
                {
                    MessageBox.Show("Not enough Seeds", "Error");
                    return;
                }
            }
            else
            {
                fID = fie[cmbMP.SelectedIndex].fieldID;
            }

            ml.addTask(taskID, start, end, fID,  type,  ferID,  treID,  quant,  details,  status);

            clearInput();
            RefreshMeth();
        }

        private void cmbTskDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Task> task = da.returnTaskList();
            List<Task> dispTsk = new List<Task>();

            dispTsk.Clear();

            if (cmbTskDisp.SelectedIndex == 0) 
            {
                dgvTask.DataSource = task;
            }
            else if (cmbTskDisp.SelectedIndex == 1)
            {
                foreach (var x  in task.Where(x => x.status == "Complete"))
                {
                    dispTsk.Add(x);
                }
                dgvTask.DataSource = dispTsk;
            }
            else
            {
                foreach (var x in task.Where(x => x.status == "Incomplete"))
                {
                    dispTsk.Add(x);
                }
                dgvTask.DataSource = dispTsk;
            }
            
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemEmp.Enabled = true;
        }

        private void dgvVeh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemVeh.Enabled = true;
        }

        private void cmbFS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Field fl = new Field();
            this.Hide();
            fl.Show();
        }
    }
}