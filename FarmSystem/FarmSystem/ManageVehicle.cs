using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FarmSystem
{
    public partial class ManageVehicle : Form
    {
        DataAccess da = DataAccess.instance();
        DbConection con = DBCheck.instance();
        string vType;
        string vAtt;
        string vReg;
        int id;
        public ManageVehicle()
        {
            InitializeComponent();
        }

        private void ManageVehicle_Load(object sender, EventArgs e)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles = da.returnVehicleList();
            dataView.DataSource = vehicles;
            dataView.Refresh();
        }

        private void labourersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLabourer mf = new ManageLabourer();
            this.Hide();
            mf.Show();
        }

        private void vahiclesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataViewT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataViewT_Click(object sender, EventArgs e)
        {
            Vehicle vh = (Vehicle)dataView.CurrentRow.DataBoundItem;

            txtReg.Text = vh.reg;
            txtName.Text = vh.name;
            txtAtch.Text = vh.type;

        }

        //private void dataViewC_Click(object sender, EventArgs e)
        //{
        //    Vehicle.Cmbhrv cm = (Vehicle.Cmbhrv)dataViewC.CurrentRow.DataBoundItem;
        //    txtReg.Text = cm.theID.ToString();
        //    txtName.Text = cm.name;
        //    txtAtch.Text = cm.type;

        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            vReg = txtReg.Text;
            vType = txtName.Text;
            vAtt = txtAtch.Text;

            string query = "INSERT INTO Vehicles  (VehicleRegistration, VehicleType, VehicleAttachments ) VALUES ('" + vReg + "', '" + vType + "', '" + vAtt + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            dataView.Refresh();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            Vehicle vehi = (Vehicle)dataView.CurrentRow.DataBoundItem;
            vType = txtName.Text;
            vReg = txtReg.Text;
            vAtt = txtAtch.Text;
            id = vehi.theID;
            string query = "UPDATE Vehicles SET VehicleType = '" + vType + "', VehicleAttachments = '" + vAtt + "', VehicleRegistration = '" + vReg + "' WHERE VehicleID = " + id + ";";

            con.ExecuteNonQuery(query);
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
            tm.Show();
        }

        private void ManageVehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
