using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class Vehicle
    {
        private string wHeels;
        private string dRiver;
        private string aTach;
        private string registration;
        private int theID;

        public int ID { get { return theID; } }
        public string Reg { get { return registration; } }
        public string wheels { get { return wHeels; } }
        public string driver { get { return dRiver; } }
        public string atach { get { return aTach; } }

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
