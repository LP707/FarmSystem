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
        DataAccess da = DataAccess.instance();

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
            List<Employee.Manager> Man = new List<Employee.Manager>();
            Man = da.returnManageList();
            dataView.DataSource = Man;
            dataView.Refresh();
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
            Employee.Manager lb = (Employee.Manager)dataView.CurrentRow.DataBoundItem;
            txtID.Text = lb.ID.ToString();
            txtFirstN.Text = lb.Forename;
            txtLastN.Text = lb.Surname;
        }

        private void containersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManager ta = new TaskManager();
            this.Hide();
            ta.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
