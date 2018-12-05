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
        MetaLayer ml = MetaLayer.instance();
        DataAccess da = DataAccess.instance();
        DbConection db = DBCheck.instance();

        int fieldID;
        string fieldName;
        string growthStatus;
        string soilType;
        int cropID;

        public Field()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fields fiel = (Fields)dataGridViewField.CurrentRow.DataBoundItem;
            fieldID = int.Parse(textBoxfieldID.Text);
            fieldName = textBox4fieldName.Text;
            growthStatus = textBox3growthstat.Text;
            soilType = textBox1soiltype.Text;
            cropID = int.Parse(textBox2cropid.Text);

            //string query = "INSERT INTO Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            //db.ExecuteNonQuery(query);
            da.connectionToDB();
            dataGridViewField.Refresh();
        }
    }
}
