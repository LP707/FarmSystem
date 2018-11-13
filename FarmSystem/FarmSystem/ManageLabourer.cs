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
        DataAccess da = new DataAccess();

        public ManageLabourer()
        {
            InitializeComponent();
        }

        private void ManageLabourer_Load(object sender, EventArgs e)
        {
            List<Employee.Labourer> Man = new List<Employee.Labourer>();
            Man = da.returnLabourerList();
            dataView.DataSource = Man;
            dataView.Refresh();
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            int ID = lb.theID;
            da.Delete(ID);
            da.connectionToDB();
            dataView.Refresh();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataView_MouseClick(object sender, MouseEventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            txtID.Text = lb.theID.ToString();
            txtFirstN.Text = lb.FName;
            txtLastN.Text = lb.LName;
            txtSpec.Text = lb.Role;
        }
    }
}
