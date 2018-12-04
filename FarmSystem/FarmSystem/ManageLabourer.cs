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
    public partial class ManageLabourer : Form
    {
        MetaLayer ml = MetaLayer.instance();
        DataAccess da = DataAccess.instance();
        string firstN, lastN, pass, phone, stat;
        DateTime dob;
        int empID;

        BindingList<Employee.Labourer> Lab = new BindingList<Employee.Labourer>();

        public ManageLabourer()
        {
            InitializeComponent();
        }

        private void ManageLabourer_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void labourersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLabourer mf = new ManageLabourer();
            this.Hide();
            mf.Show();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVehicle mf = new ManageVehicle();
            this.Hide();
            mf.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm mf = new ManagerForm();
            this.Hide();
            mf.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void refreshData()
        {
            dataView.DataSource = null;
            Lab = da.returnLabourerList();
            dataView.DataSource = Lab;
            dataView.Update();
        }

        private void dataView_MouseClick(object sender, MouseEventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            txtFirstN.Text = lb.Forename;
            txtLastN.Text = lb.Surname;
            dtpDOB.Value = lb.DOB;
            txtPhone.Text = lb.Phone;
            txtPass.Text = lb.Pass;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            empID = lb.ID;
            firstN = txtFirstN.Text;
            lastN = txtLastN.Text;
            dob = dtpDOB.Value;
            phone = txtPhone.Text;
            pass = txtPass.Text;
            stat = lb.Pos;
            ml.updateEmployee(firstN, lastN, empID, dob, phone, pass, stat);
            refreshData();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstN = txtFirstN.Text;
            lastN = txtLastN.Text;
            dob = dtpDOB.Value;
            phone = txtPhone.Text;
            pass = txtPass.Text;
            stat = "Labourer";
            ml.addEmployee(firstN, lastN, dob, phone, pass, stat);
            refreshData();
        }

        private void cropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCrops mc = new ManageCrops();
            this.Hide();
            mc.Show();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManager tm = new TaskManager();
            this.Hide();
            tm.Show();
        }

        private void ManageLabourer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
