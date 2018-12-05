﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Storage stor = (Storage)dataGridViewCont.CurrentRow.DataBoundItem;
            cID = int.Parse(textBox4.Text);
            cType = textBox5.Text;
            cAval = textBox6.Text;

            string query = "INSERT INTO Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            dataGridViewCont.Refresh();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Storage stor = (Storage)dataGridViewCont.CurrentRow.DataBoundItem;
            cID = int.Parse(textBox4.Text);
            cType = textBox5.Text;
            cAval = textBox6.Text;
           
            string query = "UPDATE Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
            dataGridViewCont.Refresh();
        }

        private void Containers_Load(object sender, EventArgs e)
        {

        }

        //Exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }






}
