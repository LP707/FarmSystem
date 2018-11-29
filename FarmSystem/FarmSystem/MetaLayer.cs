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

        public void addLabourer(int i, string fn, string ln, string rl, string p)
        {
            string query = "INSERT INTO Labourers (LabourerID, FirstName, LastName, Task, Password1) VALUES ('" + i + "', '" + fn + "', '" + ln + "', '" + rl + "', '" + p + "');";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void updateLabourer(string fn, string ln, string rl, int id)
        {
            string query = "UPDATE Labourers SET FirstName = '" + fn + "', LastName = '" + ln + "', Task = '" + rl + "' WHERE LabourerID = " + id + ";";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }


    }
}
