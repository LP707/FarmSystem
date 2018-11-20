using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    class Audit
    {
        DataAccess da = new DataAccess();

        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string EmployeeOnTask { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Desc { get; set; }
        public int QuantExpected { get; set; }
        public int QuantUsed { get; set; }
        public bool isComplete { get; set; }

        public List<Audit> buildTask()
        {
            List<Audit> theAudit = null;
            Audit au = new Audit();
            theAudit.Add(au);
            return null; ;
        }
    }
}
