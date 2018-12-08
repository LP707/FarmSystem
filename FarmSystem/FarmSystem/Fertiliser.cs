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



    public partial class Fertiliser : Form
    {
        public Fertiliser()
        {
            InitializeComponent();
        }


        string fertName;
        int quantity;
        List<Fertiliser> Fert;

        private void button1_Click(object sender, EventArgs e)
        {
            Fertiliser fert = (Fertiliser)dgvFert.CurrentRow.DataBoundItem;


            fertName = txtfertname.Text;
            quantity = int.Parse(txtfertquant.Text);
            dgvFert.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fertiliser fert = (Fertiliser)dgvFert.CurrentRow.DataBoundItem;


            fertName = txtfertname.Text;
            quantity = int.Parse(txtfertquant.Text);
            dgvFert.Refresh();

        }



        public void refreshData()
        {
            dgvFert.DataSource = null;
            Fert = da.returnFert();
            dgvFert.DataSource = Fert;
            dgvFert.Update();
        }

        private void Fertiliser_Load(object sender, EventArgs e)
        {

        }
    }
}
