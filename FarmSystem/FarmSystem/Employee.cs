using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmSystem
{
    public class Employee
    {
        private string fName;
        private string lName;
        private string role;
        private int ID;
        private bool isManager;

        public bool testManager { get; set; }
        public int theID { get { return ID; } set { ID = value; } }
        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get { return lName; } set { lName = value; } }
        public string Role { get { return role; } set { role = value; } }

        public class Manager : Employee
        {

        }

        public class Labourer : Employee
        {

        }
    }

}
