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
    public partial class ManageCrops : Form
    {
        DataAccess da = new DataAccess();
        string cName;
        int price;
        int qty;
        int id;
        public ManageCrops()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManageCrops_Load(object sender, EventArgs e)
        {
            refreshForm();
        }

        public void refreshForm()
        {
            List<Crops> cr = new List<Crops>();
            cr = da.returnCropList();
            dataView.DataSource = cr;
            dataView.Refresh();
        }

        private void ManageCrops_Click(object sender, EventArgs e)
        {
            
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
            ManageVehicle ml = new ManageVehicle();
            this.Hide();
            ml.Show();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManager tm = new TaskManager();
            this.Hide();
            tm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm mf = new ManagerForm();
            this.Hide();
            mf.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;" +
                @"Data source= C:\Users\365541\Source\Repos\FarmSystem\FarmSystem\FarmSystem\bin\Debug\FarmDB.accdb";

            Crops crop = (Crops)dataView.CurrentRow.DataBoundItem;
            cName = txtName.Text;
            price = int.Parse(txtPrice.Text);
            qty = int.Parse(txtQuant.Text);
            id = crop.theID;
            string query = "INSERT INTO Crops (CropName, Price, Quantity) VALUES ('" + cName + "', " + price + ", " + qty + ");";

            da.ExecuteNonQuery(query, con);
            da.connectionToDB();
            dataView.Refresh();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;" +
                @"Data source= C:\Users\365541\Source\Repos\FarmSystem\FarmSystem\FarmSystem\bin\Debug\FarmDB.accdb";

            Crops crop = (Crops)dataView.CurrentRow.DataBoundItem;
            cName = txtName.Text;
            price = int.Parse(txtPrice.Text);
            qty = int.Parse(txtQuant.Text);
            id = crop.theID;
            string query = "UPDATE Crops SET CropName = '" + cName + "', Price = '" + price + "', Quantity = '" + qty + "' WHERE CropID = " + id + ";";

            da.ExecuteNonQuery(query, con);
            da.connectionToDB();
            dataView.Refresh();
        }

        private void dataView_Click(object sender, EventArgs e)
        {
            Crops crop = (Crops)dataView.CurrentRow.DataBoundItem;
            txtName.Text = crop.cropName;
            txtPrice.Text = crop.cropPrice.ToString();
            txtQuant.Text = crop.Quant.ToString();
        }
    }
}
