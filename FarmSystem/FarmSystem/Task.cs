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
            private string tName;
            private string employeeT;
            private string desc;

            public int taskiD { get { return taskID; } set { taskID = value; } }
            public string tnAme { get { return tName; } set { tName = value; } }
            public string emplyT { get { return employeeT; } set { employeeT = value; } }
            public string Desc { get { return desc; } set { desc = value; } }

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



