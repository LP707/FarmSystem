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
    public partial class Fertiliser : Form
    {
        public Fertiliser()
        {
            InitializeComponent();
        }


        string fertName;
        int quantity;
        List<Storage> Cont;

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
    }
}
