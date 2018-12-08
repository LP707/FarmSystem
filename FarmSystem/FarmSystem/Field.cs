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

    /* 
     SID: 1812419

     Date: 04/12/18

     Version: 1
     */

    public partial class Field : Form
    {
        int fieldID;
        string fieldName;
        string growthStatus;
        string soilType;
        int cropID;

        public Field()
        {
            InitializeComponent();
        }
        MetaLayer ml = MetaLayer.instance();
        DbConection con = DBCheck.instance();
        DataAccess da = DataAccess.instance();
        //List<Field> fiel;


        private void Fields_Load(object sender, EventArgs e)
        {
            refreshData();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fields fiel = (Fields)dgvField.CurrentRow.DataBoundItem;
            
            fieldName = textBox4fieldName.Text;
            growthStatus = textBox3growthstat.Text;
            soilType = textBox1soiltype.Text;
            

            
            dgvField.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Fields fiel = (Fields)dgvField.CurrentRow.DataBoundItem;
           
            fieldName = textBox4fieldName.Text;
            growthStatus = textBox3growthstat.Text;
            soilType = textBox1soiltype.Text;
            

            
            dgvField.Refresh();
        }

        public void refreshData()
        {
            List<Fields> fiel = da.returnField();
            dgvField.DataSource = fiel;
            dgvField.Update();
        }

        private void labourersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLabourer ml = new ManageLabourer();
            this.Hide();
            ml.Show();
        }

        private void Field_Load(object sender, EventArgs e)
        {
            List<Fields> fiel = da.returnField();
            dgvField.DataSource = fiel;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerForm mf = new ManagerForm();
            this.Hide();
            mf.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
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

        private void containersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Containers Cn = new Containers();
            this.Hide();
            Cn.Show();
        }

        private void cropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCrops mc = new ManageCrops();
            this.Hide();
            mc.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            this.Hide();
            rp.Show();
        }
    }
}
