using System.Collections.Generic;
using VirginClassLibrary;
using System;

namespace VirginClassLibrary
{
    public class clsVCHCarCollection
    {
        //private data member for the car list
        List<clsVCHCar> mCarList = new List<clsVCHCar>();

        //private data member for ThisCar 
        clsVCHCar mThisCar = new clsVCHCar();

        //public property for CarList
        public List<clsVCHCar> CarList
        {
            get
            {
                //return private data 
                return mCarList;
            }
            set
            {
                //set the private data 
                mCarList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return private data 
                return mCarList.Count;
            }
            set
            {
                //I will come back to this later
            }
        }

        public clsVCHCar ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mCarList = new List<clsVCHCar>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsVCHCar ACar = new clsVCHCar();
                //read in the fields from the curent record
                ACar.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                ACar.CarMake = Convert.ToString(DB.DataTable.Rows[Index]["CarMake"]);
                ACar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                ACar.CarEngine = Convert.ToDecimal(DB.DataTable.Rows[Index]["CarEngine"]);
                ACar.CarBody = Convert.ToString(DB.DataTable.Rows[Index]["CarBody"]);
                ACar.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                ACar.CarFuel = Convert.ToString(DB.DataTable.Rows[Index]["CarFuel"]);
                ACar.CarPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["CarPrice"]);
                ACar.CarRegistration = Convert.ToString(DB.DataTable.Rows[Index]["CarRegistration"]);
                //add the record to the private data member
                mCarList.Add(ACar);
                //point at the next record
                Index++;
            }
        }

        //constructor for the class
        public clsVCHCarCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblVCHCar_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

            /*//create the item of test data
            clsVCHCar TestItem = new clsVCHCar();
            //set data properties
            TestItem.CarID = 1;
            TestItem.CarMake = "Volkswagen";
            TestItem.CarModel = "Golf R";
            TestItem.CarEngine = Convert.ToDecimal(2.0);
            TestItem.CarBody = "Hatchback";
            TestItem.CarColour = "Lapiz Blue";
            TestItem.CarFuel = "Petrol";
            TestItem.CarPrice = Convert.ToDecimal(250.00);
            TestItem.CarRegistration = "VW19 GLF";
            //add the items to the test list
            mCarList.Add(TestItem);
            //re-intialise the object for new data
            //create the item of test data
            TestItem = new clsVCHCar();
            //set data properties
            TestItem.CarID = 1;
            TestItem.CarMake = "BMW";
            TestItem.CarModel = "M5 Comp F90";
            TestItem.CarEngine = Convert.ToDecimal(4.4);
            TestItem.CarBody = "Saloon";
            TestItem.CarColour = "Donington-Grey Metallic";
            TestItem.CarFuel = "Petrol";
            TestItem.CarPrice = Convert.ToDecimal(670.00);
            TestItem.CarRegistration = "DY19 PLF";
            //add the items to the test list
            mCarList.Add(TestItem);*/
        }

        public int Add()
        {
            //add a new staff record to the database, based on values of thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarEngine", mThisCar.CarEngine);
            DB.AddParameter("@CarBody", mThisCar.CarBody);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarFuel", mThisCar.CarFuel);
            DB.AddParameter("@CarPrice", mThisCar.CarPrice);
            DB.AddParameter("@CarRegistration", mThisCar.CarRegistration);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVCHCar_Insert");
        }

        public void Delete()
        {
            //deletes a car record as indicted by thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCar_Delete");
        }

        public void Update()
        {
            //update an existing car record in the database, based on values of thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@CarID", mThisCar.CarID);
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarEngine", mThisCar.CarEngine);
            DB.AddParameter("@CarBody", mThisCar.CarBody);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarFuel", mThisCar.CarFuel);
            DB.AddParameter("@CarPrice", mThisCar.CarPrice);
            DB.AddParameter("@CarRegistration", mThisCar.CarRegistration);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCar_Update");
        }

        public void ReportByCarBody(string CarBody)
        {
            //filter car records according to complete or partial car body
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the car body parameter for this stored procedure
            DB.AddParameter("@CarBody", CarBody);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCar_FilterByCarBody");
            //populate the array list wit the data table
            PopulateArray(DB);
        }
    }
}