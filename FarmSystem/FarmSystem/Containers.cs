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

    public partial class Containers : Form
    {
        public Containers()
        {
            InitializeComponent();
        }

        MetaLayer ml = MetaLayer.instance();
        DbConection con =  DBCheck.instance();
        DataAccess da = DataAccess.instance(); 
        int cID;
        string cType;
        string cAval;
        List<Storage> Cont;

        private void Containers_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Storage stor = (Storage)dataGridViewCont.CurrentRow.DataBoundItem;
            cID = int.Parse(textBox4.Text);
            cType = textBox5.Text;
            cAval = textBox6.Text;

           
            dataGridViewCont.Refresh();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Storage stor = (Storage)dataGridViewCont.CurrentRow.DataBoundItem;
            cID = int.Parse(textBox4.Text);
            cType = textBox5.Text;
            cAval = textBox6.Text;
           
           
            dataGridViewCont.Refresh();
        }

       
        public void refreshData()
        {
            dataGridViewCont.DataSource = null;
            Cont = da.returnStorage();
            dataGridViewCont.DataSource = Cont;
            dataGridViewCont.Update();
        }

        

        private void labourersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLabourer ml = new ManageLabourer();
            this.Hide();
            ml.Show();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageVehicle mf = new ManageVehicle();
            this.Hide();
            mf.Show();
        }

        private void taskmanagerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void fieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Field fl = new Field();
            this.Hide();
            fl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
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

        private void dataGridViewCont_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }








}
