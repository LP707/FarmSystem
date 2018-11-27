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
    public partial class ManageVehicle : Form
    {
        DataAccess da = new DataAccess();
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
            List<Vehicle.Tractor> Tractor = new List<Vehicle.Tractor>();
            List<Vehicle.Cmbhrv> Combine = new List<Vehicle.Cmbhrv>();
            Tractor = da.returnTVehicleList();
            Combine = da.returnCVehicleList();
            dataViewC.DataSource = Combine;
            dataViewT.DataSource = Tractor;
            dataViewC.Refresh();
            dataViewT.Refresh();
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
            Vehicle.Tractor tr = (Vehicle.Tractor)dataViewT.CurrentRow.DataBoundItem;

            txtReg.Text = tr.theID.ToString();
            txtName.Text = tr.name;
            txtAtch.Text = tr.type;

        }

        private void dataViewC_Click(object sender, EventArgs e)
        {
            Vehicle.Cmbhrv cm = (Vehicle.Cmbhrv)dataViewC.CurrentRow.DataBoundItem;
            txtReg.Text = cm.theID.ToString();
            txtName.Text = cm.name;
            txtAtch.Text = cm.type;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;" +
                @"Data source= C:\Users\365541\Source\Repos\FarmSystem\FarmSystem\FarmSystem\bin\Debug\FarmDB.accdb";
           
            Vehicle.Tractor trac = (Vehicle.Tractor)dataViewT.CurrentRow.DataBoundItem;
            vType = txtName.Text;
            vReg = txtReg.Text;
            vAtt = txtAtch.Text;
            id = trac.theID;
            string query = "UPDATE Vehicles SET VehicleType = '" + vType + "', VehicleAttachments = '" + vAtt + "', VehicleRegistration = '" + vReg + "' WHERE VehicleID = " + id + ";";

            da.ExecuteNonQuery(query, con);
            da.connectionToDB();
            dataViewT.Refresh();
        }
    }
}
