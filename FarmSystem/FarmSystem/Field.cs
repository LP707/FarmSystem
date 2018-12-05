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
        public Field()
        {
            InitializeComponent();
        }
        MetaLayer ml = MetaLayer.instance();
        DbConection con = DBCheck.instance();
        DataAccess da = DataAccess.instance();

        int fieldID;
        string fieldName;
        string growthStatus;
        string soilType;
        int cropID;
        List<Field> fiel;
        private void button1_Click(object sender, EventArgs e)
        {
            Fields fiel = (Fields)dataGridViewFiel.CurrentRow.DataBoundItem;
            fieldID = int.Parse(textBoxfieldID.Text);
            fieldName = textBox4fieldName.Text;
            growthStatus = textBox3growthstat.Text;
            soilType = textBox1soiltype.Text;
            cropID = int.Parse(textBox2cropID.Text);

            string query = "INSERT INTO Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            dataGridViewFiel.Refresh();
        }
    public void refreshData()
    {
        dataGridViewFiel.DataSource = null;
        fiel = da.returnField();
        dataGridViewFiel.DataSource = Cont;
        dataGridViewFiel.Update();
    }

        //Exits the application
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

        private void containersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Containers Cn = new Containers();
            this.Hide();
            Cn.Show();
        }
    }
}
