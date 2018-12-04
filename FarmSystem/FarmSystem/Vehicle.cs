using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    //makes the class 'Vehicle' and sets and gets the variable names e.g 'theID' -ALMAZ
    public class Vehicle
    {
        private string displayName;
        public int vehID { get; set; }
        public string name { get; set; }
        public string attach { get; set; }
        public string reg { get; set; }


        //sets instances of the class 'Vehicle' i.e 'Tractor' 
        public string DName { get { return name + " " + reg; } set { displayName = value; } }

        public class Tractor : Vehicle
        {

            
        }

        public class Cmbhrv : Vehicle
        {

        }


       




    }
}
