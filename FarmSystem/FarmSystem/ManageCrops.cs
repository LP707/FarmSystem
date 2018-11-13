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
    public partial class ManageCrops : Form
    {
        DataAccess da = new DataAccess();
        public ManageCrops()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManageCrops_Load(object sender, EventArgs e)
        {
            List<Crops> cr = new List<Crops>();
            cr = da.returnCropList();
            dataView.DataSource = cr;
            dataView.Refresh();
        }

        private void ManageCrops_Click(object sender, EventArgs e)
        {
            Crops lb = (Crops)dataView.CurrentRow.DataBoundItem;
            txtName.Text = lb.cropName;
            txtPrice.Text = lb.cropPrice.ToString();
            txtQuant.Text = lb.Quant.ToString();
        }
    }
}
