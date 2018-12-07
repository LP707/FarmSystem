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
        MetaLayer ml = MetaLayer.instance();
        DataAccess da = DataAccess.instance();
        DbConection con = DBCheck.instance();
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
            ManageVehicle mv = new ManageVehicle();
            this.Hide();
            mv.Show();
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
            Crops crop = (Crops)dataView.CurrentRow.DataBoundItem;
            cName = txtName.Text;
            price = int.Parse(txtPrice.Text);
            qty = int.Parse(txt.Text);
            id = crop.cropID;
            ml.addCrop(cName, price, qty);
            dataView.Refresh();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            Crops crop = (Crops)dataView.CurrentRow.DataBoundItem;
            cName = txtName.Text;
            price = int.Parse(txtPrice.Text);
            qty = int.Parse(txt.Text);
            id = crop.cropID;
            ml.updateCrop(cName, price, qty, id);
            dataView.Refresh();
        }

        private void dataView_Click(object sender, EventArgs e)
        {
            Crops crop = (Crops)dataView.CurrentRow.DataBoundItem;
            txtName.Text = crop.cropName;
            txtPrice.Text = crop.cropPrice.ToString();
            //txt.Text = crop.Quant.ToString();
        }

        private void ManageCrops_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void containersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Containers Cn = new Containers();
            this.Hide();
            Cn.Show();
        }

        private void fieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Field fl = new Field();
            this.Hide();
            fl.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            this.Hide();
            rp.Show();
        }
    }
}
