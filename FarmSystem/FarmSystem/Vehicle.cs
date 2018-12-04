using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{


    /* 
     SID: 1812419

     Date: 04/12/18

     Version: 1
     */

    //makes the class 'Vehicle' and sets and gets the variable names e.g 'theID' 
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
