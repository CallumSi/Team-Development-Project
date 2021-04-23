using System.Collections.Generic;
using VirginClassLibrary;
using System;

namespace VirginClassLibrary
{
    public class clsVCHHireBookingCollection
    {
        //private data member for the car hire list
        List<clsVCHHireBooking> mHireBookingList = new List<clsVCHHireBooking>();

        //private data member for ThisHire 
        clsVCHHireBooking mThisHireBooking = new clsVCHHireBooking();

        //public property for HireList
        public List<clsVCHHireBooking> HireBookingList
        {
            get
            {
                //return the private data
                return mHireBookingList;
            }
            set
            {
                //set the private data
                mHireBookingList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return private data 
                return mHireBookingList.Count;
            }
            set
            {
                //I will come back to this later
            }
        }

        //public property for ThisHire
        public clsVCHHireBooking ThisHireBooking
        {
            get
            {
                //return the private data
                return mThisHireBooking;
            }
            set
            {
                //set the private data
                mThisHireBooking = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the record count
            RecordCount = DB.Count;
            //clear the private array list
            mHireBookingList = new List<clsVCHHireBooking>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank hire record
                clsVCHHireBooking AHireBooking = new clsVCHHireBooking();
                //read in the fields from the curent record
                AHireBooking.HireBookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["HireBookingID"]);
                AHireBooking.HireID = Convert.ToInt32(DB.DataTable.Rows[Index]["HireID"]);
                AHireBooking.HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireDate"]);
                AHireBooking.HireTime = Convert.ToInt32(DB.DataTable.Rows[Index]["HireTime"]);
                AHireBooking.HireDescription = Convert.ToString(DB.DataTable.Rows[Index]["HireDescription"]);
                //add the record to the private data member
                mHireBookingList.Add(AHireBooking);
                //point at the next record
                Index++;
            }
        }

        //constructor for the class
        public clsVCHHireBookingCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblVCHHireBooking_SelectAll");
            //populate the array list with the data
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new hire booking record to the database, based on values of ThisHireBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@HireID", mThisHireBooking.HireID);
            DB.AddParameter("@HireDate", mThisHireBooking.HireDate);
            DB.AddParameter("@HireTime", mThisHireBooking.HireTime);
            DB.AddParameter("@HireDescription", mThisHireBooking.HireDescription);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVCHHireBooking_Insert");
        }

        public void Delete()
        {
            //deletes a car hire booking record as indicted by ThisHireBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@HireBookingID", mThisHireBooking.HireBookingID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHireBooking_Delete");
        }

        public void Update()
        {
            //update an existing car hire booking record in the database, based on values of ThisHireBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@HireBookingID", mThisHireBooking.HireBookingID);
            DB.AddParameter("@HireID", mThisHireBooking.HireID);
            DB.AddParameter("@HireDate", mThisHireBooking.HireDate);
            DB.AddParameter("@HireTime", mThisHireBooking.HireTime);
            DB.AddParameter("@HireDescription", mThisHireBooking.HireDescription);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHireBooking_Update");
        }

        public void ReportByHireDate(DateTime HireDate)
        {
            //filter car hire booking records according to complete or partial Hire Date
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the hire date parameter for this stored procedure
            DB.AddParameter("@HireDate", HireDate);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHireBooking_FilterByHireDate");
            //populate the array list wit the data table
            PopulateArray(DB);
        }
        
        //private data member to store the booking date
        private DateTime mHireDate;
        ///connect to the database
        clsDataConnection DB = new clsDataConnection();

        //constructor for the class
        public clsVCHHireBookingCollection(DateTime AHireBooking)
        {
            //get bookings for this date
            FilterByDate(AHireBooking);
            //store the date used
            mHireDate = AHireBooking;
        }

        //generate the list of bookings
        private List<clsVCHHireBooking> GetSchedule()
        {
            //list of hires for this function
            List<clsVCHHireBooking> mAvailableHire = new List<clsVCHHireBooking>();
            //loop through the times of day 9 - 16
            for (Int32 SomeTime = 9; SomeTime < 17; SomeTime++)
            {
                //check to see if this time has an existing booking
                Int32 Index = HasBooking(SomeTime);
                //if the returned entry is <0 then it does not
                if (Index < 0)
                {
                    //create a new blank booking
                    clsVCHHireBooking NewHireBooking = new clsVCHHireBooking();
                    //record the HireBookingID primary key as -time
                    NewHireBooking.HireBookingID = -SomeTime;
                    //set the HireID to blank
                    NewHireBooking.HireID = 25;
                    //store the date using the private data member
                    NewHireBooking.HireDate = mHireDate;
                    //record the hire time
                    NewHireBooking.HireTime = SomeTime;
                    //set the description & info to blank
                    NewHireBooking.HireDescription = "";
                    //add it to the list
                    mAvailableHire.Add(NewHireBooking);
                }
                else //if the time has a booking
                {
                    //create a new blank booking
                    clsVCHHireBooking NewHireBooking = new clsVCHHireBooking();
                    //record the hire booking ID
                    NewHireBooking.HireBookingID = Convert.ToInt32(DB.DataTable.Rows[Index]["HireBookingID"]);
                    //record the hire ID
                    NewHireBooking.HireID = Convert.ToInt32(DB.DataTable.Rows[Index]["HireID"]);
                    //record the hire date
                    NewHireBooking.HireDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireDate"]);
                    //record the hire time
                    NewHireBooking.HireTime = Convert.ToInt32(DB.DataTable.Rows[Index]["HireTime"]);
                    //record the description & info
                    NewHireBooking.HireDescription = Convert.ToString(DB.DataTable.Rows[Index]["HireDescription"]);
                    //add it to the list
                    mAvailableHire.Add(NewHireBooking);
                }
            }
            //return the list to users
            return mAvailableHire;
        }

        private Int32 HasBooking(Int32 SomeTime)
        //checks to see if a time for the recorded date has a booking
        {
            //index for the loop
            Int32 Index = 0;
            //Boolean var to indicate if an entry is found
            Boolean Found = false;
            //loop through any records for this dat from th edatabase
            while (Index < DB.Count & Found == false)
            {
                //if a record is found
                if (SomeTime == Convert.ToInt32(DB.DataTable.Rows[Index]["HireTime"]))
                {
                    //set found to true which will make the loop end
                    Found = true;
                }
                else
                {
                    //otherwise keep on searching to the end
                    Index++;
                }
            }
            if (Found) //if a record is found for this time
            {
                return Index;//return the index of the entry 0 or above
            }
            else
            {
                return -1;//return -1 indicating it wasn't found
            }
        }

        private void FilterByDate(DateTime HireDate)
        {
            //filter car hire booking records according to complete or partial Hire Date
            //connect to the database
            DB = new clsDataConnection();
            //set the hire date parameter for this stored procedure
            DB.AddParameter("@HireDate", HireDate);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHireBooking_FilterByHireDate");
            //get the hire booking schedule for the inputted date
            mHireBookingList = GetSchedule();
        }

        public void AddBooking(Int32 HireID, Int32 HireTime, string HireDescription)
        //adds new hire booking record 
        {
            //reinitialise the data connection
            DB = new clsDataConnection();
            //send the procedure the parameters
            DB.AddParameter("@HireID", HireID);
            DB.AddParameter("@HireDate", mHireDate);
            DB.AddParameter("@HireTime", HireTime);
            DB.AddParameter("@HireDescription", HireDescription);
            //add the new record
            DB.Execute("sproc_tblVCHHireBooking_InsertBooking");
        }
    }
}