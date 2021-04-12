using System.Collections.Generic;
using VirginClassLibrary;
using System;

namespace VirginClassLibrary
{
    public class clsVCHCarCollection
    {
        //private data member for the car list
        List<clsVCHCar> mCarList = new List<clsVCHCar>();

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

        public clsVCHCar ThisCar { get; set; }

        //constructor for the class
        public clsVCHCarCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblVCHCar_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
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
    }
}