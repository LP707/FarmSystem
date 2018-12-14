/* 
     SID: 1719547

     Description: Used as storage method for the storage list.

     Version: 1

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class Storage
    {
        public int storeID { get; set; }
        public string storeType { get; set; }
        public bool available { get; set; }



        public string StoreName { get { return storeType + ", " + findAvailablity(); }  }

        public string findAvailablity()
        {
            if (available)
            {
                return "Storage Available";
            }
            else
            {
                return "Storage Full";
            }
        }
    }
}
