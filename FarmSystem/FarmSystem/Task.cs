using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
 
        public class Task
        {
            private int taskID;
            private string tType;
            private string employeeT;
            private string desc;
            private int cropQuant;
            private DateTime startTime, endTime;

            public static List<string> taskTypes = new List<string>();

            public int taskiD { get { return taskID; } set { taskID = value; } }
            public int employeeID { get { return taskID; } set { taskID = value; } }
            public string taskType { get { return tType; } set { tType = value; } }
            public string emplyT { get { return employeeT; } set { employeeT = value; } }
            public int crops { get { return cropQuant; } set { cropQuant = value; } }
            public string Desc { get { return desc; } set { desc = value; } }
            public DateTime theStart { get { return startTime; } set { startTime = value; } }
            public DateTime theEnd { get { return endTime; } set { endTime = value; } }

            public void popList()
            {
                taskTypes.Add("Harvesting");
                taskTypes.Add("Sewing");
                taskTypes.Add("Treating");
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
            DataAccess da = new DataAccess();
            
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



