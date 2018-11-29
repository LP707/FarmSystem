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
        private string displayName;
        private string fName;
        private string lName;
        private string position;
        private string dob;
        private string phone;
        private string password;
        private int theID;

        public int ID { get { return theID; } set { theID = value; } }
        public string Forename { get { return fName; } set { fName = value; } }
        public string Surname { get { return lName; } set { lName = value; } }
        public string DOB { get { return dob; } set { dob = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Pass { get { return password; } set { password = value; } }
        public string Pos { get { return position; } set { position = value; } }
        public string DName { get { return fName + " " + lName; } set { displayName = value; } }
        //public string toString
        public class Manager : Employee
        {

        }

        public class Labourer : Employee
        {

        }
    }

}
