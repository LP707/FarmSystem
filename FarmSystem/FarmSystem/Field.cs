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
        List<Crops> cl = new List<Crops>();
        List<Storage> cs = new List<Storage>();
        List<Storage> stoList = new List<Storage>();
        //List<Field> fiel;

        private void button1_Click(object sender, EventArgs e)
        {
            //Fields fiel = (Fields)dgvField.CurrentRow.DataBoundItem;
            
            //fieldName = textBox4fieldName.Text;
            //growthStatus = textBox3growthstat.Text;
            //soilType = textBox1soiltype.Text;
            

            
            dgvField.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Fields fiel = (Fields)dgvField.CurrentRow.DataBoundItem;
           
            //fieldName = textBox4fieldName.Text;
            //growthStatus = textBox3growthstat.Text;
            //soilType = textBox1soiltype.Text;
            

            
            dgvField.Refresh();
        }

        public void refreshData()
        {
            List<Fields> fiel = da.returnField();
            dgvField.DataSource = fiel;
            dgvField.Refresh();

            dgvCrop.DataSource = null;
            dgvCrop.DataSource = cl;
            dgvCrop.Refresh();

            dgvStorage.DataSource = null;
            dgvStorage.DataSource = stoList;
            dgvStorage.Refresh();

            hideColumns();
        }

        public void hideColumns()
        {
            dgvField.Columns[0].Visible = false;
            dgvField.Columns[2].Visible = false;
            dgvField.Columns[4].Visible = false;
            dgvField.Columns[5].Visible = false;

            dgvCrop.Columns[0].Visible = false;
            dgvStorage.Columns[0].Visible = false;
            dgvStorage.Columns[3].Visible = false;
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
            dgvCrop.DataSource = da.returnCropList(); 
            dgvStorage.DataSource = da.returnStorage();
            hideColumns();


        }

        public void retriveData()
        {
            List<Fields> fieldlist = da.returnField();
            List<Crops> cropList = da.returnCropList();
            List<CropStorage> cropStoList = da.returnCropStorage();
            Fields selectedField = (Fields)dgvField.CurrentRow.DataBoundItem;

            int i = 0;
            cl.Clear();
            cs.Clear();

            foreach (var c in cropList.Where(c => c.cropID == selectedField.cropID))
            {   
                cl.Add(c);
            }

            stoList = da.returnStorage();

            //dgvCrop.DataSource = cl;
            refreshData();
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

        }

        private void cmbCrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            retriveData();
        }
    }
}
