using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    class DBException : System.Exception
    {
        public DBException(string message) : base(message) { }
    }
}
