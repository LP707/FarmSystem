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
    public partial class LabourerForm : Form
    {
        MetaLayer ml = MetaLayer.instance();
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
            List<Task> EmpTasks = new List<Task>();
            EmpTasks = ml.getTimetable();
            dgvTimetable.DataSource = EmpTasks;
            dgvTimetable.Columns[0].Visible = false;
            dgvTimetable.Columns[5].Visible = false;
            dgvTimetable.Columns[6].Visible = false;
            dgvTimetable.Columns[7].Visible = false;
            dgvTimetable.Refresh();
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
