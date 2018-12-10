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

        //Query to add new employee to database
        public void addEmployee(string fn, string ln, DateTime d, string phone, string pas, string status)
        {
            //string status = "Labourer";
            string query = "INSERT INTO Employees (FirstName, LastName, DOB, PhoneNumber, Passwords, Status) VALUES ('" + fn + "', '" + ln + "', '" + d + "', '" + phone + "', '" + pas + "', '" + status + "');";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Query to update existing record in the database
        public void updateEmployee(string fn, string ln, int id, DateTime d, string phone, string pas, string status)
        {
            string query = "UPDATE Employees SET FirstName = '" + fn + "', LastName = '" + ln + "', DOB = '" + d + "', PhoneNumber = '" + phone + "', Passwords = '" + pas + "', Status = '" + status + "' WHERE EmployeeID = " + id + ";";
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Query to add new crop to database
        public void addCrop(string cName, int price, int qty)
        {
            string query = "INSERT INTO Crops (CropName, Price, Quantity) VALUES ('" + cName + "', " + price + ", " + qty + ");";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Query to update existing record in the database
        public void updateCrop(string cName, int price, int qty, int id)
        {
            string query = "UPDATE Crops SET CropName = '" + cName + "', Price = '" + price + "', Quantity = '" + qty + "' WHERE CropID = " + id + ";";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Query to add new vehicle to database
        public void addVeh(string vReg, string vType, string vAtt)
        {
            string query = "INSERT INTO Vehicles  (VehicleRegistration, VehicleType, VehicleAttachments ) VALUES ('" + vReg + "', '" + vType + "', '" + vAtt + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Query to update existing record in the database
        public void updateVeh(string vReg, string vType, string vAtt, int id)
        {
            string query = "UPDATE Vehicles SET VehicleRegistration = '" + vReg + "', VehicleType = '" + vType + "', VehicleAttachments = '" + vAtt + "' WHERE VehID = '" + id + "';";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void addEmp(int tskID, int empID)
        {
            string query = "INSERT INTO Scheduler (task_ID, employee_ID) VALUES (" + tskID + ", " + empID + ");";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Removes the employee and task assignment from the scheduler table.
        public void removeEmp(int tskID, int empID)
        {
            string query = "DELETE FROM Scheduler WHERE task_ID = " + tskID + " AND employee_ID = " + empID + ";";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void addVeh(int tskID, int vehID)
        {
            string query = "INSERT INTO TaskVehicles (task_ID, vehicle_ID) VALUES (" + tskID + ", " + vehID + ");";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        
        public void removeVeh(int tskID, int vehID)
        {
            string query = "DELETE FROM TaskVehicles WHERE task_ID = " + tskID + " AND vehicle_ID = " + vehID + ";";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void addTask(int tskID, DateTime sDate, DateTime eDate, int fieID , string tskType, int ferID, int treID, int qty, string details, string status)
        {

            string query = "INSERT INTO Tasks (TaskID, TaskStartTime, TaskEndTime, field_ID, TaskType, fertiliser_ID, treatment_ID, Quantity, Reason, Status ) VALUES " +
            "('" + tskID + "', '" + sDate + "','" + eDate + "','" + fieID + "', '" + tskType + "', '" + ferID + "', '" + treID + "', '" + qty + "', '" + details + "', '" + status + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void updTask(int tskID, DateTime sDate, DateTime eDate, int fieID, string tskType, int ferID, int treID, int qty, string details, string status)
        {

            string query = "UPDATE Tasks SET TaskStarttime = '" + sDate + "', TaskEndTime = '" + eDate + "', field_ID = " + fieID + ", TaskType = '" + tskType + "', fertiliser_ID = " + ferID + ", treatment_ID = " + treID + ", Quantity = " + qty + ", Reason = '" + details + "', Status = '" + status + "' WHERE TaskID = " + tskID + ";";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void updFertTask(int fID, int qty)
        {

            string query = "UPDATE Fertilisers SET Quantity = " + qty + " WHERE FertiliserID = " + fID + ";";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void updTreatTask(int tID, int qty)
        {

            string query = "UPDATE Treatments SET Quantity = " + qty + " WHERE TreatmentID = " + tID + ";";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }
        public void updStorageTask(int sID, int cID, int qty)
        {
            string query = "UPDATE CropsInStorage SET QuantityStored = " + qty + " WHERE Storage_ID = " + sID + " AND Crop_ID = " + cID + ";";
                            
            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }
        public void updCropTask(int cID, int qty)
        {
            string query = "UPDATE Crops SET SeedQuant = " + qty + " WHERE CropID = " + cID + ";";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void addField(int fieldID, string fieldName, string growthStatus, string soilType, int cropID)
        {
            //Query to add a new field to the database
            string query = "INSERT INTO Fields  (FieldID, FieldName, GrowthStatus, SoilType, crop_ID ) VALUES ('" + fieldID + "', '" + fieldName + "', '" + growthStatus + "', '" + soilType + "','" + cropID + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        public void updateField(int fieldID, string fieldName, string growthStatus, string soilType, int cropID)
        {
            //Query to update an existing record in the database
            string query = "UPDATE Fields  (FieldID, FieldName, GrowthStatus, SoilType, crop_ID ) VALUES ('" + fieldID + "', '" + fieldName + "', '" + growthStatus + "', '" + soilType + "','" + cropID + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }


        //Query to add new container to database 
        public void addCont(int cID, string cType, bool cAval)
        { 
            string query = "INSERT INTO Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Query to update container in database

        public void updateCont(int cID, string cType, bool cAval)
        {
            string query = "UPDATE Storage  (StorageID, StorageType, StorageAvailability ) VALUES ('" + cID + "', '" + cType + "', '" + cAval + "');";

            con.ExecuteNonQuery(query);
            da.connectionToDB();
        }

        //Query to add fertiliser to database
        public void addFert(string fertName, int quantity)
        {
            string query = "INSERT INTO Fertilisers (FertiliserName, Quantity) VALUES ('" + fertName + "', '" + quantity + "');";
            con.ExecuteNonQuery(query);
            da.connectionToDB();

        }

        //Query to update fertiliser in database 
        public void updateFert(int fertID, string fertName, int quantity)
        {
            string query = "UPDATE Fertilisers (FertiliserName, Quantity) VALUES ('" + fertName + "', '" + quantity + "') WHERE FertiliserID = " + fertID + ";";
            con.ExecuteNonQuery(query);
            da.connectionToDB();

        }

        public List<Task> getTimetable()
        {
            Login lg = new Login();
            string user = lg.returnUser();
            List<Task> EmpTask = new List<Task>();
            List<Task> tasks = da.returnTaskList();
            List<Scheduler> sch = da.returnSchedule();

            foreach (var e in sch.Where(e => user.Contains(e.empID.ToString())))
            {
                foreach (var r in tasks.Where(r => r.taskID.Equals(e.taskID)))
                {
                    EmpTask.Add(r);
                }
            }
            return EmpTask;
        }

        //public void addTask(int ID, string )

        //Login method, tests user input against the list of records to find a match and return the relevant form, or throw an exception if no result is found.
        public void loginTest(string user, string pass)
        {
            List<Employee.Manager> Managers = da.returnManageList();
            List<Employee.Labourer> Labourers = da.returnLabourerList();

            string theUser = user;
            string thePass = pass;
            Login lg = new Login();
            da.connectionToDB();

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

    }
}
