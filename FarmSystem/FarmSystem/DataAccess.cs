using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data;
using Microsoft.SqlServer.Server;
using System.ComponentModel;


namespace FarmSystem
{
    class DataAccess
    {
        DbConection db = DBCheck.instance();
        List<Employee.Manager> Managers = new List<Employee.Manager>();
        BindingList<Employee.Labourer> Labourers = new BindingList<Employee.Labourer>();
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

        public void clearLists()
        {
            Managers.Clear();
            Labourers.Clear();
            Vehicles.Clear();
            Crops.Clear();
            Tasks.Clear();
        }

        public void connectionToDB()
        {
            clearLists();
            conn.OpenConnection();
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Employees WHERE Status='Labourer';");
                while (dr.Read())
                {
                    //set attributes of the labourer subclass
                    Employee.Labourer Lb = new Employee.Labourer();
                    {
                        Lb.ID = dr.GetInt32(0);
                        Lb.Forename = dr.GetString(1);
                        Lb.Surname = dr.GetString(2);
                        Lb.DOB = dr.GetString(3);
                        Lb.Phone = dr.GetString(4);
                        Lb.Pass = dr.GetString(5);
                        Lb.Pos = dr.GetString(6);
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
                OleDbDataReader dr1 = conn.Select("SELECT * FROM Employees WHERE Status = 'Manager'");
               
                while (dr1.Read())
                {
                    //set attributes of the manager subclass
                    Employee.Manager mg = new Employee.Manager();
                    {
                        mg.ID = dr1.GetInt32(0);
                        mg.Forename = dr1.GetString(1);
                        mg.Surname = dr1.GetString(2);
                        mg.DOB = dr1.GetString(3);
                        mg.Phone = dr1.GetString(4);
                        mg.Pass = dr1.GetString(5);
                        mg.Pos = dr1.GetString(6);
                    }
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
                        ta.name = dr.GetString(2);
                        ta.VehOnTask = dr.GetString(3);
                        ta.attach = dr.GetString(4);
                        ta.theStart = dr.GetString(5);
                        ta.theEnd = dr.GetString(6);
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
            Login lg = new Login();
            connectionToDB();
           
            if (theUser == "" || thePass == "")
            {
                lg.throwUnknownUser();
            }
            else
            {
                foreach (var staff in Labourers.Where(x => x.ID.ToString() == theUser))
                {
                    if (staff.Pass == thePass)
                    {
                        LabourerForm lb = new LabourerForm();
                        lb.Show();
                    }
                    else
                    {
                        lg.throwUnknownUser();
                    }
                }
                foreach (var mStaff in Managers.Where(x => x.ID.ToString() == theUser))
                {
                    if (mStaff.Pass == thePass)
                    {
                        ManagerForm mg = new ManagerForm();
                        mg.Show();
                    }
                    else
                    {
                        lg.throwUnknownUser();
                    }
                }
            }
            
        }

        public BindingList<Employee.Labourer> returnLabourerList()
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