/* 
     SID: 1719547

     Description: Used as storage method for the cropstored list.

     Version: 1

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    class CropStorage
    {
        public int cID { get; set; }
        public int sID { get; set; }
        public int qtyStored { get; set; }
    }
}
