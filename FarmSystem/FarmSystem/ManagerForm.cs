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
    public partial class ManagerForm : Form
    {
        MetaLayer ml = MetaLayer.instance();
        DataAccess da = DataAccess.instance();

        List<Employee.Labourer> Man = new List<Employee.Labourer>();

        string firstN, lastN, pass, phone, stat;
        DateTime dob;
        int empID;

        public ManagerForm()
        {
            InitializeComponent();
            
        }

            private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstManager1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewManRoster_Click(object sender, EventArgs e)
        {
           
        }

        private void labourersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLabourer ml = new ManageLabourer();
            ml.Show();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageVehicle ml = new ManageVehicle();
            ml.Show();
        }

        private void cropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCrops mc = new ManageCrops();
            this.Hide();
            mc.Show();
        }

        private void dataView_Click(object sender, EventArgs e)
        {

        }

        private void dataView_MouseClick(object sender, MouseEventArgs e)
        {
            Employee.Manager mg = (Employee.Manager)dataView.CurrentRow.DataBoundItem;

            txtFirstN.Text = mg.Forename;
            txtLastN.Text = mg.Surname;
            dtpDOB.Value = mg.DOB;
            txtPhone.Text = mg.Phone;
            txtPass.Text = mg.Pass;
            txtStatus.Text = mg.Pos;

        }

        private void containersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManager ta = new TaskManager();
            this.Hide();
            ta.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Employee.Manager mg = (Employee.Manager)dataView.CurrentRow.DataBoundItem;
            empID = mg.ID;
            firstN = txtFirstN.Text;
            lastN = txtLastN.Text;
            dob = dtpDOB.Value;
            phone = txtPhone.Text;
            pass = txtPass.Text;
            stat = txtStatus.Text;
            ml.updateEmployee(firstN, lastN, empID, dob, phone, pass, stat);
            refreshData();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void managmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void containersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Containers Cn = new Containers();
            this.Hide();
            Cn.Show();

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            List<Employee.Manager> Man = new List<Employee.Manager>();
            Man = da.returnManageList();
            dataView.DataSource = Man;
            dataView.Refresh();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public void refreshData()
        {
            dataView.DataSource = null;
            Man = da.returnLabourerList();
            dataView.DataSource = Man;
            dataView.Update();
        }

        private void ManagerForm_Click(object sender, EventArgs e)
        {
            
        }
    }
}
