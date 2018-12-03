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
    
    //intialises component-ALMAZ
{
    public partial class LabourerForm : Form
    {
        public LabourerForm()
        {
            InitializeComponent();
        }

        //When the login button is pressed this form is show - ALMAZ
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        //Exits the application -ALMAZ
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Exits the program- ALMAZ
        private void LabourerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LabourerForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
