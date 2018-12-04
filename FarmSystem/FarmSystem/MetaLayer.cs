using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    class MetaLayer
    {
        DataAccess da = DataAccess.instance();
        DbConection con = DBCheck.instance();

        static private MetaLayer m_instance = null;

        private MetaLayer() { }

        static public MetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new MetaLayer();
            }
            return m_instance;
        }

        public void addEmployee(string fn, string ln, DateTime d, string phone, string pas, string status)
        {
            //string status = "Labourer";
            string query = "INSERT INTO Employees (FirstName, LastName, DOB, PhoneNumber, Passwords, Status) VALUES ('" + fn + "', '" + ln + "', '" + d + "', '" + phone + "', '" + pas + "', '" + status + "');";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void updateEmployee(string fn, string ln, int id, DateTime d, string phone, string pas, string status)
        {
            string query = "UPDATE Employees SET FirstName = '" + fn + "', LastName = '" + ln + "', DOB = '" + d + "', PhoneNumber = '" + phone + "', Passwords = '" + pas + "', Status = '" + status + "' WHERE EmployeeID = " + id + ";";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }



    }
}
