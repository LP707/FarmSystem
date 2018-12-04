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

        int cID;
        string cType;
        bool cAval;

        private void button1_Click(object sender, EventArgs e)
        {
            Storage stor = (Storage)dataView.CurrentRow.DataBoundItem;
            cID = txtID.Text;
            cType = txtType.Text;
            cAval = txtAval.Text;

            string query = "INSERT INTO Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            dataView.Refresh();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Storage stor = (Storage)dataView.CurrentRow.DataBoundItem;
            cID = txtID.Text;
            cType = txtType.Text;
            cAval = txtAval.Text;
           
            string query = "UPDATE Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            dataView.Refresh();
        }
    }





}
