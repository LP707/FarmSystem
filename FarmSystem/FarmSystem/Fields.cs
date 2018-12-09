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
        public int cropID { get; set; }


        public string DName { get { return fieldName + " " + findCrop(); } set { displayName = value; } }


        public string findCrop()
        {
            string cropName = "";
            DataAccess da = DataAccess.instance();
            List<Crops> cr = da.returnCropList();

            foreach (var e in cr.Where(e => cropID == e.cropID))
            {
                cropName = e.cropName;
                return cropName;
            }

            return cropName;
        }
    }
}
