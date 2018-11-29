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

        public void throwUnknownUser()
        {
            txtUser.Clear();
            txtPass.Clear();
            MessageBox.Show("Invalid Login");
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string storedUser = txtUser.Text;
            string storedPass = txtPass.Text;

            DataAccess da = DataAccess.instance();

            this.Hide();
            da.test(storedUser, storedPass);
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
