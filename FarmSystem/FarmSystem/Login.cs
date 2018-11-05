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

        private void button1_Click(object sender, EventArgs e)
        {
            string storedUser = lblUser.Text;
            string storedPass = lblPassword.Text;
            bool isManager = false;

            DataAccess da = new DataAccess();

            da.test(storedUser, storedPass, isManager);

           // ManagerForm mg = new ManagerForm();
           // this.Hide();
           // mg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
