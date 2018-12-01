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

        public void addLabourer(string fn, string ln, string p, string d, string phone)
        {
            string status = "Labourer";
            string query = "INSERT INTO Employees (FirstName, LastName, DOB, PhoneNumber, Status, Password1) VALUES ('" + fn + "', '" + ln + "', '" + d + "', '" + phone + "', '" + status + "', '" + p + "');";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void updateLabourer(string fn, string ln, int id, string d, string phone)
        {
            string query = "UPDATE Employees SET FirstName = '" + fn + "', LastName = '" + ln + "', DOB = '" + d + "', PhoneNumber = '" + phone + "' WHERE EmployeeID = " + id + ";";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }



    }
}
