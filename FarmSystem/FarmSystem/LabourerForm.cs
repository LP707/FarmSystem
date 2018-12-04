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

/* 
 SID: 1812419

 Date: 04/12/18

 Version: 1
 */

//intialises component
{
    public partial class LabourerForm : Form
    {
        public LabourerForm()
        {
            InitializeComponent();
        }

        //When the login button is pressed this form is show 
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        //Exits the application
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

        //Exits the program
        private void LabourerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LabourerForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
