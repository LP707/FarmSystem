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
        List<Employee.Labourer> Labourers = new List<Employee.Labourer>();
        List<Vehicle> Vehicles = new List<Vehicle>();
        List<Crops> Crops = new List<Crops>();
        List<Task> Tasks = new List<Task>();
        List<Fertilisers> Fertiliser = new List<Fertilisers>();
        List<Treatments> Treatment = new List<Treatments>();
        List<Fields> Field = new List<Fields>();
        List<Storage> Store = new List<Storage>();
        List<Scheduler> Schedule = new List<Scheduler>();
        List<TaskVehicles> taskVehicles = new List<TaskVehicles>();



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
                        Lb.DOB = dr.GetDateTime(3);
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
                        mg.DOB = dr1.GetDateTime(3);
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
                        cr.cropID = dr.GetInt32(0);
                        cr.cropName = dr.GetString(1);
                        cr.cropTreatPeriod = dr.GetString(2);
                        cr.growthTime = dr.GetString(3);
                        cr.harvestMethod = dr.GetString(4);
                        cr.cropPrice = dr.GetInt32(5);

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
                        ta.taskID = dr.GetInt32(0);
                        ta.theStart = dr.GetDateTime(1);
                        ta.theEnd = dr.GetDateTime(2);
                        ta.fieldID = dr.GetInt32(3);
                        ta.taskType = dr.GetString(4);
                        ta.fertID = dr.GetInt32(5);
                        ta.treatID = dr.GetInt32(6);

                    }
                    Tasks.Add(ta);
                    //adds to the labourer list

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
                        ta.taskID = dr.GetInt32(0);




                    }
                    Tasks.Add(ta);
                    //adds to the labourer list

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
                    tr.vehID = dr.GetInt32(0);
                    tr.name = dr.GetString(1);
                    tr.attach = dr.GetString(2);
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
                    cm.vehID = dr.GetInt32(0);
                    cm.name = dr.GetString(1);
                    cm.attach = dr.GetString(2);
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
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Fertilisers;");

                while (dr.Read())
                {
                    Fertilisers fe = new Fertilisers();
                    {
                        fe.fertID = dr.GetInt32(0);
                        fe.fertName = dr.GetString(1);
                        fe.quant = dr.GetInt32(2);
                    }
                    Fertiliser.Add(fe);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Treatments;");

                while (dr.Read())
                {
                    Treatments te = new Treatments();
                    {
                        te.treatID = dr.GetInt32(0);
                        te.treatName = dr.GetString(1);
                        te.quant = dr.GetInt32(2);
                    }
                    Treatment.Add(te);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Fields;");

                while (dr.Read())
                {
                    Fields fi = new Fields();
                    {
                        fi.fieldID = dr.GetInt32(0);
                        fi.fieldName = dr.GetString(1);
                        fi.growthStatus = dr.GetString(2);
                        fi.soilType = dr.GetString(3);
                        fi.cropID = dr.GetInt32(4);
                    }
                    Field.Add(fi);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Storage;");

                while (dr.Read())
                {
                    Storage sto = new Storage();
                    {
                        sto.storeID = dr.GetInt32(0);
                        sto.storeType = dr.GetString(1);
                        sto.available = dr.GetBoolean(2);

                    }
                    Store.Add(sto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM Scheduler;");

                while (dr.Read())
                {
                    Scheduler sch = new Scheduler();
                    {
                        sch.taskID = dr.GetInt32(0);
                        sch.empID = dr.GetInt32(1);

                    }
                    Schedule.Add(sch);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM TaskVehicles;");

                while (dr.Read())
                {
                    TaskVehicles tv = new TaskVehicles();
                    {
                        tv.vehTaskID = dr.GetInt32(0);
                        tv.taskVehID = dr.GetInt32(1);

                    }
                    taskVehicles.Add(tv);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                OleDbDataReader dr = conn.Select("SELECT * FROM TaskVehicles;");

                while (dr.Read())
                {
                    TaskVehicles tv = new TaskVehicles();
                    {
                        tv.vehTaskID = dr.GetInt32(0);
                        tv.taskVehID = dr.GetInt32(1);

                    }
                    taskVehicles.Add(tv);
                }
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

        public List<Employee.Labourer> returnLabourerList()
        {
            return Labourers;
        }
        public List<TaskVehicles> returnTaskVehicles()
        {
            return taskVehicles;
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

        public List<Scheduler> returnSchedule()
        {
            return Schedule;
        }

        public void addToLCropList(Crops TheCrop)
        {
            Crops.Add(TheCrop);
        }

        public List<Storage> returnStorage()
        {
            return Store;

        }

        public List<Fields> returnField()
        {
         return Field;
        }
    }

    public List<Fertiliser> returnFertiliser()
    {
        return Fert;
    }
        
    }