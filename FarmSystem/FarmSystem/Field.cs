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
        List<Field> fiel;

        private void button1_Click(object sender, EventArgs e)
        {
            Fields fiel = (Fields)dgvField.CurrentRow.DataBoundItem;
            fieldID = int.Parse(textBoxfieldID.Text);
            fieldName = textBox4fieldName.Text;
            growthStatus = textBox3growthstat.Text;
            soilType = textBox1soiltype.Text;
            cropID = int.Parse(textBox2cropID.Text);

            string query = "INSERT INTO Fields  (FieldID, FieldName, GrowthStatus, SoilType, crop_ID ) VALUES ('" + fieldID + "', '" + fieldName + "', '" + growthStatus + "', '" + soilType + "','" + cropID + "');";

           
            da.connectionToDB();
            dgvField.Refresh();
        }

        private void labourersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
