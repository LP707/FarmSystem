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
        DbConection db = DBCheck.instance();
        List<Employee.Manager> Managers = new List<Employee.Manager>();
        List<Employee.Labourer> Labourers = new List<Employee.Labourer>();
        List<Vehicle> Vehicles = new List<Vehicle>();
        List<Crops> Crops = new List<Crops>();
        List<Task> Tasks = new List<Task>();

        DbConection conn = DBCheck.instance();

        public void returnConString(string theConString)
        {
            //theConString = 
        }

        static private DataAccess m_instance = null;

        private DataAccess() { }

        static public DataAccess instance()
        {
            if (null == m_instance)
            {
                m_instance = new DataAccess();
            }
            return m_instance;
        }

        public void connectionToDB()
        {
            conn.OpenConnection();
            try
            {
                OleDbDataReader dr = conn.Select("SELECT LabourerID, FirstName, LastName, Task, Password1 FROM Labourers;");
                while (dr.Read())
                {
                    //set attributes of the labourer subclass
                    Employee.Labourer Lb = new Employee.Labourer();
                    {
                        Lb.ID = dr.GetInt32(0);
                        Lb.Forename = dr.GetString(1);
                        Lb.Surname = dr.GetString(2);
                        //Lb.DOB = dr.GetString(2);
                        //Lb.Phone = dr.GetString(2);
                        Lb.Role = dr.GetString(3);
                        Lb.Pass = dr.GetString(4);
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
                OleDbDataReader dr1 = conn.Select("SELECT * FROM Managers;");
               
                while (dr1.Read())
                {
                    //set attributes of the manager subclass
                    Employee.Manager mg = new Employee.Manager();
                    mg.ID = dr1.GetInt32(0);
                    mg.Forename = dr1.GetString(1);
                    mg.Surname = dr1.GetString(2);
                    //adds to the manager list
                    mg.Pass = dr1.GetString(3);
                    Managers.Add(mg);
                }
            //close Data Reader
            dr1.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Crops;");
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Tasks;");
                while (dr.Read())
                {
                    //set attributes of the labourer subclass
                    Task ta = new Task();
                    {
                        ta.taskiD = dr.GetInt32(0);
                        ta.taskType = dr.GetString(1);
                        ta.employeeID = dr.GetInt32(2);
                        ta.lbFirstN = dr.GetString(3);
                        ta.lbLastN = dr.GetString(4);
                        ta.crops = dr.GetInt32(5);
                        ta.VehOnTask = dr.GetString(6);
                        ta.attach = dr.GetString(7);
                        ta.vehID = dr.GetInt32(8);
                        ta.theStart = dr.GetDateTime(9);
                        ta.theEnd = dr.GetDateTime(10);
                    }
                    //adds to the labourer list
                    Tasks.Add(ta);
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
                OleDbDataReader dr = conn.Select("SELECT * FROM Vehicles WHERE VehicleType = 'Tractor';");

                while (dr.Read())
                {
                    //set attributes of the tractor subclass
                    Vehicle.Tractor tr = new Vehicle.Tractor();
                    tr.theID = dr.GetInt32(0);
                    tr.name = dr.GetString(1);
                    tr.type = dr.GetString(2);
                    tr.reg = dr.GetString(3);
                    //adds to the tractor list
                    Vehicles.Add(tr);
                }
                //close Data Reader
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                //set query string to be used in Select method
                OleDbDataReader dr = conn.Select("SELECT * FROM Vehicles WHERE VehicleType = 'Combine';");

                while (dr.Read())
                {
                    //set attributes of the combine subclass
                    Vehicle.Cmbhrv cm = new Vehicle.Cmbhrv();
                    cm.theID = dr.GetInt32(0);
                    cm.name = dr.GetString(1);
                    cm.type = dr.GetString(2);
                    cm.reg = dr.GetString(3);
                    //adds to the combine list
                    Vehicles.Add(cm);
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
                conn.CloseConnection();
            }
        }

        public void refresher()
        {

        }

        //public void ExecuteNonQuery(string sql)
        //{
        //    try
        //    {
        //        OleDbCommand cmd =
        //            new OleDbCommand(sql);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new DBException("DBException - OleDatabaseConnection::RunQuery()\n" + e.Message);
        //    }
        //    finally
        //    {
        //        conn.CloseConnection();
        //    }
        //}

        public void test(string user, string pass)
        {
            string theUser = user;
            string thePass = pass;

            connectionToDB();

            var list = new List<Employee.Labourer>();
            list = Labourers;
            var Mlist = new List<Employee.Manager>();
            Mlist = Managers;

            if (list.Any(x => x.Forename == user) && (list.Any(x => x.Pass == pass)))
            {
                LabourerForm lb = new LabourerForm();
                lb.Show();
            }
            else if (Mlist.Any(x => x.Forename == user) && (Mlist.Any(x => x.Pass == pass)))
            {
                ManagerForm mg = new ManagerForm();
                mg.Show();
            }
            else
            {
                ManagerForm mg = new ManagerForm();
                mg.Show();
                //Login lg = new Login();
                //lg.throwUnknownUser();
            }
        }

        public List<Employee.Labourer> returnLabourerList()
        {
            return Labourers;
        }

        public List<Vehicle> returnVehicleList()
        {
            return Vehicles;
        }

        public List<Employee.Manager> returnManageList()
        {
            return Managers;
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