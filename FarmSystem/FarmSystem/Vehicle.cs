using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class Vehicle
    {
        private string displayName;
        public int theID { get; set; }
        public string reg { get; set; }
        public string name { get; set; }
        public string type { get; set; }


       
        public string DName { get { return name + " " + reg; } set { displayName = value; } }

        public class Tractor : Vehicle
        {

            string aTach;
            string[] aTa = new string[] { "baler", "plough", "trailer", "fertiliser" , "sewing"};
            
        }

        public class Cmbhrv : Vehicle
        {

        }


       




    }
}
