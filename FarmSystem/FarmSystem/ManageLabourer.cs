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

        
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataView_MouseClick(object sender, MouseEventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            
            txtFirstN.Text = lb.FName;
            txtLastN.Text = lb.LName;
            txtSpec.Text = lb.Role;
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Employee.Labourer lb = (Employee.Labourer)dataView.CurrentRow.DataBoundItem;
            fn = txtFirstN.Text;
            ln = txtLastN.Text;
            rl = txtSpec.Text;
            id = lb.theID;
            string query = "UPDATE Labourers SET FirstName = '"+fn+ "', LastName = '" + ln + "', Task = '" + rl + "' WHERE LabourerID = " + id + ";";

            da.ExecuteNonQuery(query, con);
            da.connectionToDB();
            dataView.Refresh();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            fn = txtFirstN.Text;
            ln = txtLastN.Text;
            rl = txtSpec.Text;
            string query = "INSERT INTO Labourers (LabourerID, FirstName, LastName, Task) VALUES ('"+fn+"', '"+ln+"', '"+rl+"');";

            da.ExecuteNonQuery(query, con);
            da.connectionToDB();
            dataView.Refresh();
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
