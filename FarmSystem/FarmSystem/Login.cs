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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string storedUser = lblUser.Text;
            string storedPass = lblPassword.Text;
            this.Hide();

            DataAccess da = DataAccess.instance();

            da.test(storedUser, storedPass);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
