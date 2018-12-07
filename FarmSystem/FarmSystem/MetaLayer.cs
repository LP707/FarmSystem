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
