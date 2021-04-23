using System;

namespace VirginClassLibrary
{
    public class clsVCHHireBooking
    {
        //private property for HireBookingID
        private int mHireBookingID;
        //foreign key
        //private property for HireID
        private int mHireID;
        //private property for HireDate
        private DateTime mHireDate;
        //private property for HireTime
        private int mHireTime;
        //private property for HireDescription
        private string mHireDescription;

        // HireBookingID property
        public int HireBookingID
        {
            get
            {
                //return the private data
                return mHireBookingID;
            }
            set
            {
                //set the private data
                mHireBookingID = value;
            }
        }

        // HireID property
        public int HireID
        {
            get
            {
                //return the private data
                return mHireID;
            }
            set
            {
                //set the private data
                mHireID = value;
            }
        }

        // HireDate property
        public DateTime HireDate
        {
            get
            {
                //return the private data 
                return mHireDate;
            }

            set
            {
                //set the private data
                mHireDate = value;
            }
        }

        // HireTime property
        public int HireTime
        {
            get
            {
                //return the private data
                return mHireTime;
            }
            set
            {
                //set the private data
                mHireTime = value;
            }
        }

        // HireDescription property
        public string HireDescription
        {
            get
            {
                //return the private data
                return mHireDescription;
            }
            set
            {
                //set the private data
                mHireDescription = value;
            }
        }

        //find method for HireBookingID
        public bool Find(int HireBookingID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for HireBookingID to search for
            DB.AddParameter("@HireBookingID", HireBookingID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHireBooking_FilterByHireBookingID");
            //if one record is found (there should only be 1 or 0 records found)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mHireBookingID = Convert.ToInt32(DB.DataTable.Rows[0]["HireBookingID"]);
                mHireID = Convert.ToInt32(DB.DataTable.Rows[0]["HireID"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]);
                mHireTime = Convert.ToInt32(DB.DataTable.Rows[0]["HireTime"]);
                mHireDescription = Convert.ToString(DB.DataTable.Rows[0]["HireDescription"]);
                //return that the method worked
                return true;
            }
            //if no record is found
            else
            {
                //return false - showing an error
                return false;
            }
        }
        //sproc_tblVCHHireBooking_FilterByHireDate

        public string Valid(string HireDate, string HireTime, string HireDescription)
        {
            //string variable to store the error message
            string Error = "";

            //variable for date values
            DateTime DateTemp;

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            if (HireDate.Length > 0)
            {
                try
                {
                    //assign HireDate date to the DateTemp variable
                    DateTemp = Convert.ToDateTime(HireDate);
                    //check to see the Hire Date is not in the past
                    if (DateTemp < DateTime.Now.Date.AddDays(1))
                    {
                        //record the error 
                        return "A hire date must be dated between tomorrows date or six months from today. Please enter a valid date.";
                    }

                    //check to see if a Hire Date is further than 6 months (180 days) away
                    if (DateTemp > DateTime.Now.Date.AddDays(180))
                    {
                        //record the error
                        return "A hire date may not be 6 months more than the current date. Please enter a valid date.";
                    }
                }

                catch
                {
                    //record the error 
                    return "The inputted date was not valid. Please enter a valid date.";
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            try
            {
                Int32 TempHireTime = Convert.ToInt32(HireTime);

                if (TempHireTime == 0)
                {
                    return "A hire time may not be blank. Please enter an appropriate time";
                }

                if (TempHireTime < 0001 | TempHireTime > 2401)
                {
                    return "A hire time must be between the hours 0900 - 2400. Please enter an appropriate time";
                }
            }
            catch
            {
                return "The hire time is invalid.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the Hire Description length is blank
            if (HireDescription.Length == 0)
            {
                //return the following error message
                return "A hire booking description may not be blank. Please enter an appropriate description.";
            }
            //if the Hire Description length is more than 150 characters
            if (HireDescription.Length > 150)
            {
                //return the following error message
                return "The hire booking is invalid. Please enter a description with fewer than 150 characters.";
            }
            //if the Hire Description length is less than 5 characters 
            if (HireDescription.Length < 5)
            {
                //return the following error message
                return "The hire booking is invalid. Please enter a description with more than 5 characters.";
            }

            return Error;
        }
    }
}