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

        public string FName { get { return fName; } }
        public string LName { get { return lName; } }
        public string Role { get { return role; } }

        public class Manager : Employee
        {

        }

        public class Labourer : Employee
        {

        }
    }

}
