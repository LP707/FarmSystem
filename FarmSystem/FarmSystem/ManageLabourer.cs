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
        MetaLayer ma = MetaLayer.instance();
        DataAccess da = DataAccess.instance();
        string fn, ln, p, dob, phone;
        int id;

        BindingList<Employee.Labourer> Man = new BindingList<Employee.Labourer>();

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
            Man = da.returnLabourerList();
            dataView.DataSource = Man;
            dataView.Update();
        }

        private void dataView_MouseClick(object sender, MouseEventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            txtFirstN.Text = lb.Forename;
            txtLastN.Text = lb.Surname;
            txtDOB.Text = lb.DOB;
            txtPhone.Text = lb.Phone;            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            fn = txtFirstN.Text;
            ln = txtLastN.Text;
            id = lb.ID;
            dob = txtDOB.Text;
            phone = txtPhone.Text;
            ma.updateLabourer(fn, ln, id, dob, phone);
            refreshData();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            fn = txtFirstN.Text;
            ln = txtLastN.Text;
            dob = txtDOB.Text;
            phone = txtPhone.Text;
            ma.addLabourer(fn, ln, p, dob, phone);
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
            this.Show();
        }

        private void ManageLabourer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
