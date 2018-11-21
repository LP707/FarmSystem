using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Common;
using System.Data;

namespace FarmSystem
{
    class DBConn : DbConection
    {
        private Dictionary<string, string> m_properties;
        private OleDbConnection connection;
        private bool open;
        public OleDbConnection(Dictionary<string, string> properties)
        {
            m_properties = properties;
            open = false;
            initialize();
        }


        private void initialize()
        {
            try
            {
                StringBuilder sb = new StringBuilder("Provider=");
                sb.Append(m_properties["Provider"]);
                sb.Append(";Data Source=\"");
                sb.Append(m_properties["Database"]);
                sb.Append("\"");
                if (m_properties.ContainsKey("User"))
                {
                    if (m_properties["User"].Length > 0)
                    {
                        sb.Append(";User ID=" + m_properties["User"]);
                        sb.Append("Password=\"");
                        sb.Append(m_properties["Password"]);
                        sb.Append("\"");
                    }
                }
                connection = new OleDbConnection(sb.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool OpenConnection()
        {
            try
            {
                if (!open)
                    connection.Open();
                open = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                open = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public DbDataReader Select(string query)
        {
            DbDataReader reader = null;
            try
            {
                OleDbCommand command = new OleDbCommand(query);
                command.Connection = (OleDbConnection)connection;
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }

        public DataSet getDataSet(string sqlStatement)
        {

            DataSet dataSet;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStatement, connection);
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}
