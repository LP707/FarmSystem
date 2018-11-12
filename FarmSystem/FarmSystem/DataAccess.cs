using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;

namespace FarmSystem
{
    class DataAccess
    {

        public List<Employee.Manager> Managers = new List<Employee.Manager>();
        public List<Employee.Labourer> Labourers = new List<Employee.Labourer>();
        public List<Vehicle.Tractor> Tractors = new List<Vehicle.Tractor>();
        public List<Vehicle.Cmbhrv> Combines = new List<Vehicle.Cmbhrv>();

        public void connectionToDB()
        {
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;" +
                @"Data source= C:\Users\398019\Source\Repos\FarmSystem2\FarmSystem\FarmSystem\bin\Debug\FarmDB.accdb";

            try
            {
                conn.Open();
                OleDbDataReader dr = Select("SELECT LabourerID, FirstName, LastName, Speciality FROM Labourers;", conn);
                while (dr.Read())
                {
                    //set attributes of the labourer subclass
                    Employee.Labourer Lb = new Employee.Labourer();
                    {
                        Lb.theID = dr.GetInt32(0);
                        Lb.FName = dr.GetString(1);
                        Lb.LName = dr.GetString(2);
                        Lb.Role = dr.GetString(3);

                        Debug.WriteLine(Lb.theID);
                    }
                    //adds to the labourer list
                    Labourers.Add(Lb);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                //set query string to be used in Select method
                OleDbDataReader dr = Select("SELECT ManagerID, FirstName, LastName, FROM Managers;", conn);

                while (dr.Read())
                {
                    //set attributes of the manager subclass
                    Employee.Manager mg = new Employee.Manager();
                    mg.theID = dr.GetInt32(0);
                    mg.FName = dr.GetString(1);
                    mg.LName = dr.GetString(2);
                    //adds to the manager list
                    Managers.Add(mg);
            }
            //close Data Reader
            dr.Close();
            //conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                //set query string to be used in Select method
                OleDbDataReader dr = Select("SELECT VehicleID, VehicleRegistration FROM Vehicles WHERE VehcileType = 'Tractor';", conn);

                while (dr.Read())
                {
                    //set attributes of the tractor subclass
                    Vehicle.Tractor tr = new Vehicle.Tractor();
                    tr.ID = dr.GetInt32(0);
                    tr.Reg = dr.GetString(1);
                    //adds to the tractor list
                    Tractors.Add(tr);
                }
                //close Data Reader
                dr.Close();
                //conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                //set query string to be used in Select method
                OleDbDataReader dr = Select("SELECT VehicleID, VehicleRegistration FROM Vehicles WHERE VehcileType = 'Combine';", conn);

                while (dr.Read())
                {
                    //set attributes of the combine subclass
                    Vehicle.Cmbhrv cm = new Vehicle.Cmbhrv();
                    cm.ID = dr.GetInt32(0);
                    cm.Reg = dr.GetString(1);
                    //adds to the combine list
                    Combines.Add(cm);
                }
                //close Data Reader
                dr.Close();
                //conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public void refresher()
        {

        }

        public OleDbDataReader Select(string query, OleDbConnection connection)
        {
            OleDbDataReader reader = null;
            try
            {
                OleDbCommand command = new OleDbCommand(query);
                command.Connection = (OleDbConnection)connection;
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                
            }
            return reader;
        }

        

        public void test(string user, string pass, bool staus)
        {
            string theUser = user;
            string thePass = pass;
            bool theStatus = staus;

            connectionToDB();

            
            
            if (Managers.Where(o => string.Equals(user, null, StringComparison.OrdinalIgnoreCase)).Any())
            {
                ManagerForm mg = new ManagerForm();
                mg.Show();
                theStatus = true;
                return;
            }
            else if (Labourers.Where(o => string.Equals(user, null, StringComparison.OrdinalIgnoreCase)).Any())
            {
                LabourerForm lb = new LabourerForm();
                lb.Show();
                theStatus = false;
                return;
            }
            else
            {
                Login lg = new Login();
                lg.Show();
            }
            

        }
    }
}