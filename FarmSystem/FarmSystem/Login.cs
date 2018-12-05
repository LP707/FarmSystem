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
        MetaLayer ml = MetaLayer.instance();
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
            ml.loginTest(storedUser, storedPass);
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string storedUser = txtUser.Text;
                string storedPass = txtPass.Text;

                DataAccess da = DataAccess.instance();

                this.Hide();
                ml.loginTest(storedUser, storedPass);
            }

        }
    }
}
