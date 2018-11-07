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
