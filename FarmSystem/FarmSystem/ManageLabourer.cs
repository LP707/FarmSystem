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
        DataAccess da = DataAccess.instance();
        DbConection con = DBCheck.instance();
        string fn;
        string ln;
        string rl;
        int id;

        List<Employee.Labourer> Man = new List<Employee.Labourer>();

        public ManageLabourer()
        {
            InitializeComponent();
        }

        private void ManageLabourer_Load(object sender, EventArgs e)
        {
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

        
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refreshData()
        {
            this.Refresh();
        }

        private void dataView_MouseClick(object sender, MouseEventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            
            txtFirstN.Text = lb.Forename;
            txtLastN.Text = lb.Surname;
            txtSpec.Text = lb.Role;
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            fn = txtFirstN.Text;
            ln = txtLastN.Text;
            rl = txtSpec.Text;
            id = lb.ID;
            string query = "UPDATE Labourers SET FirstName = '"+fn+ "', LastName = '" + ln + "', Task = '" + rl + "' WHERE LabourerID = " + id + ";";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
            refreshData();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            fn = txtFirstN.Text;
            ln = txtLastN.Text;
            rl = txtSpec.Text;
            int i = Man.Count + 1;
            string p = "password1";
            string query = "INSERT INTO Labourers (LabourerID, FirstName, LastName, Task, Password1) VALUES ('"+i+"', '"+fn+"', '"+ln+"', '"+rl+ "', '" + p + "');";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
            refreshData();
        }

        private void cropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCrops mc = new ManageCrops();
            this.Hide();
            mc.Show();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManager tm = new TaskManager();
            this.Hide();
            this.Show();
        }

        private void ManageLabourer_Click(object sender, EventArgs e)
        {

        }
    }
}
