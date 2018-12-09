
/* 
     SID: 1719547

     Description: Used as storage method for the tasks list.

     Version: 1

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
 
        public class Task
        {
            private int tID;
            private int tType;
            //private string employeeT;
            //private string desc;
            private string TName, vOJ, atch;
            private int vID;
            //private int cropQuant;
            private DateTime startTime, endTime;

            public static List<string> taskTypes = new List<string>();

            public int taskID { get { return tID; } set { tID = value; } }
            public DateTime theStart { get { return startTime; } set { startTime = value; } }
            public DateTime theEnd { get { return endTime; } set { endTime = value; } }
            public int fieldID { get; set; }
            public string taskType { get; set; }
            public int vehID { get { return vID; } set { vID = value; } }
            public int fertID { get; set; }
            public int treatID { get; set; }
            public int quantity { get; set; }
            public string reason { get; set; }
            public string status { get; set; }

        


        public void popList()
        {
            taskTypes.Add("Harvesting");
            taskTypes.Add("Sowing");
            taskTypes.Add("Treating");
            taskTypes.Add("Ploughing");
            taskTypes.Add("Storing");
            taskTypes.Add("Fertilising");
        }

        public List<string> returnList()
        {
            popList();
            return taskTypes;
        }

        public void returnEmployee()
            {
                List<Employee.Labourer> newLab = new List<Employee.Labourer>();
                Employee.Labourer lb = new Employee.Labourer();
                DataAccess da = DataAccess.instance();

            }

            public class Sewing : Task
            {

            }

            public class Harvesting : Task
            {

            }

             public class Treating : Task
             {

             }


    }

    }



