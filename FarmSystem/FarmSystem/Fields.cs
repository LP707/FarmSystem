using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    class Fields
    {
        string displayName;
        public int fieldID { get; set; }
        public string fieldName { get; set; }
        public string growthStatus { get; set; }
        public string soilType { get; set; }
        public string cropName { get; set; }


        public string DName { get { return fieldName + " " + cropName; } set { displayName = value; } }
    }
}
