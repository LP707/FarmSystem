using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;
using System.Data.Common;

namespace FarmSystem
{
    class DBCheck
    {
        private static DbConection m_instance = null;
        Dictionary<string, string> m_properties;
        private static string propfile = "properties.dat";

        private DBCheck()
        {
            m_properties = new Dictionary<string, string>();
            //m_properties = new Dictionary<string, string> { get; { return propfile; }
        }

        public static DbConection instance()
        {
            if (null == m_instance)
            {
                DBCheck dFactory = new DBCheck();
                m_instance = dFactory.getConection();
            }
            return m_instance;
        }

        private DbConection getConection()
        {
            DbConection connection = null;
            try
            {
                m_properties = getProperties();
                string provider = m_properties["Provider"];
                if (provider.Equals("Microsoft.ACE.OLEDB.16.0"))
                    connection = new DBConn(m_properties);
                else if (provider.Equals("Microsoft.ACE.OLEDB.12.0"))
                    connection = new DBConn(m_properties);
                else
                {
                    throw new DBException("Not supported provider '" + provider + "'");
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine("Error file not found" + e.Message);
                connection = null;
                throw e;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                connection = null;
                throw e;
            }
            return connection;
        }

        private Dictionary<string, string> getProperties()
        {
            string fileData = "";
            using (StreamReader sr = new StreamReader(propfile))
            {
                fileData = sr.ReadToEnd().Replace("\r", "");
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            string[] kvp;
            string[] records = fileData.Split("\n".ToCharArray());
            foreach (string record in records)
            {
                kvp = record.Split("=".ToCharArray());
                properties.Add(kvp[0], kvp[1]);
            }
            return properties;
        }
    }

    public interface DbConection
    {
        bool OpenConnection();

        bool CloseConnection();

        OleDbDataReader Select(String query);

        DataSet getDataSet(string sqlStatement);

    }
}

