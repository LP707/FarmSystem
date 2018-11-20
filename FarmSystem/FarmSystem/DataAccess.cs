using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;
using Microsoft.SqlServer.Server;


namespace FarmSystem
{
    class DataAccess
    {
        //public List<Employee.Manager> Managers { get; set; }
        //public List<Employee.Labourer> Labourer { get; set; }
        //public List<Vehicle.Tractor> Tractors { get; set; }
        //public List<Vehicle.Cmbhrv> Combines { get; set; }
        //public List<Crops> Crops { get; set; }
        //public List<Task> Tasks { get; set; }
        public static List<Employee.Manager> Managers = new List<Employee.Manager>();
        public static List<Employee.Labourer> Labourers = new List<Employee.Labourer>();
        public static List<Vehicle.Tractor> Tractors = new List<Vehicle.Tractor>();
        public static List<Vehicle.Cmbhrv> Combines = new List<Vehicle.Cmbhrv>();
        public static List<Crops> Crops = new List<Crops>();
        public static List<Task> Tasks = new List<Task>();

        public void returnConString(string theConString)
        {
            //theConString = 
        }

        public void connectionToDB()
        {
            System.Data.OleDb.OleDbConnection conn = new
            System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;" +
                @"Data source= F:\BSc Year 2\Software Eng\FarmSystem\FarmSystem\FarmSystem\FarmSystem\bin\Debug\FarmDB.accdb";

            try
            {
                conn.Open();
                OleDbDataReader dr = Select("SELECT * FROM Labourers;", conn);
                while (dr.Read())
                {
                    //set attributes of the labourer subclass
                    Employee.Labourer Lb = new Employee.Labourer();
                    {
                        Lb.theID = dr.GetInt32(0);
                        Lb.FName = dr.GetString(1);
                        Lb.LName = dr.GetString(2);
                        //Lb.DOB = dr.GetString(2);
                        //Lb.Phone = dr.GetString(2);
                        Lb.Role = dr.GetString(3);
                    }
                    //adds to the labourer list
                    Labourers.Add(Lb);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                //set query string to be used in Select method
                conn.Open();
                OleDbDataReader dr1 = Select("SELECT * FROM Managers;", conn);
               
                while (dr1.Read())
                {
                    //set attributes of the manager subclass
                    Employee.Manager mg = new Employee.Manager();
                    mg.theID = dr1.GetInt32(0);
                    mg.FName = dr1.GetString(1);
                    mg.LName = dr1.GetString(2);
                    //adds to the manager list
                    Managers.Add(mg);
                }
            //close Data Reader
            dr1.Close();
            conn.Close();
            //conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                conn.Open();
                OleDbDataReader dr = Select("SELECT * FROM Crops;", conn);
                while (dr.Read())
                {
                    //set attributes of the labourer subclass
                    Crops cr = new Crops();
                    {
                        cr.theID = dr.GetInt32(0);
                        cr.cropName = dr.GetString(1);
                        cr.cropPrice = dr.GetInt32(2);
                        cr.Quant = dr.GetInt32(3);
                    }
                    //adds to the labourer list
                    Crops.Add(cr);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                conn.Open();
                OleDbDataReader dr = Select("SELECT * FROM Tasks;", conn);
                while (dr.Read())
                {
                    //set attributes of the labourer subclass
                    Task ta = new Task();
                    {
                        ta.taskiD = dr.GetInt32(0);
                        ta.employeeID = dr.GetInt32(1);
                        ta.taskType = dr.GetString(2);
                        ta.emplyT = dr.GetString(3);
                        ta.crops = dr.GetInt32(4);
                        ta.theStart = dr.GetDateTime(5);
                        ta.theEnd = dr.GetDateTime(6);
                    }
                    //adds to the labourer list
                    Tasks.Add(ta);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                conn.Open();
                //set query string to be used in Select method
                OleDbDataReader dr = Select("SELECT * FROM Vehicles WHERE VehicleType = 'Tractor';", conn);

                while (dr.Read())
                {
                    //set attributes of the tractor subclass
                    Vehicle.Tractor tr = new Vehicle.Tractor();
                    tr.theID = dr.GetInt32(0);
                    tr.name = dr.GetString(1);
                    tr.type = dr.GetString(2);
                    tr.reg = dr.GetString(3);
                    //adds to the tractor list
                    Tractors.Add(tr);
                }
                //close Data Reader
                dr.Close();
                conn.Close();
                //conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                conn.Open();
                //set query string to be used in Select method
                OleDbDataReader dr = Select("SELECT * FROM Vehicles WHERE VehicleType = 'Combine';", conn);

                while (dr.Read())
                {
                    //set attributes of the combine subclass
                    Vehicle.Cmbhrv cm = new Vehicle.Cmbhrv();
                    cm.theID = dr.GetInt32(0);
                    cm.name = dr.GetString(1);
                    cm.type = dr.GetString(2);
                    cm.reg = dr.GetString(3);
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
                command.Connection = connection;
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new DBException("DBException - OleDatabaseConnection::RunQuery()\n" + e.Message);
            }
            return reader;
        }

        public void ExecuteNonQuery(string sql, OleDbConnection conn)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd =
                    new OleDbCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new DBException("DBException - OleDatabaseConnection::RunQuery()\n" + e.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        public void test(string user, string pass)
        {
            string theUser = user;
            string thePass = pass;

            connectionToDB();


            Employee.Manager foundItem = Managers.FirstOrDefault(i => i.FName == user);
            if (foundItem != null)
            {
                ManagerForm mg = new ManagerForm();
                mg.Show();
            }
            else
            {
                ManagerForm mg = new ManagerForm();
                mg.Show();
            }
        }

        public List<Employee.Labourer> returnLabourerList()
        {
            return Labourers;
        }

        public List<Vehicle.Tractor> returnTVehicleList()
        {
            return Tractors;
        }

        public List<Employee.Manager> returnManageList()
        {
            return Managers;
        }

        public List<Vehicle.Cmbhrv> returnCVehicleList()
        {
            return Combines;
        }

        public List<Crops> returnCropList()
        {
            return Crops;
        }

        public List<Task> returnTaskList()
        {
            return Tasks;
        }

        public void addToLCropList(Crops TheCrop)
        {
            Crops.Add(TheCrop);
        }

    }

        
    }