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
    int fieldID;
    string fieldName;
string growthStatus;
string soilType;
int cropID;
{
    
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
            Fields fiel = (Fields)dataGridViewField.CurrentRow.DataBoundItem;
            fieldID = int.Parse(textBoxfieldID.Text);
            fieldName = textBox4fieldName.Text;
            growthStatus = textBox3growthstat.Text;
            soilType = textBox1soiltype.Text;
            cropID = textBox2cropid.Text;

            //string query = "INSERT INTO Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            //db.ExecuteNonQuery(query);
            da.connectionToDB();
            dataGridViewCont.Refresh();
        }
    }
}
