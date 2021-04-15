﻿using System.Collections.Generic;
using VirginClassLibrary;
using System;
using System.Linq;
using System.Text;

namespace VirginClassLibrary
{
    public class clsVCHHire
    {
        //private property for HireID
        private int mHireID;
        //foreign key
        //private property for CarID
        private int mCarID;
        //foreign key
        //private property for CustomerID
        private int mCustomerID;
        //private property for HireCollectionDate
        private DateTime mHireCollectionDate;
        //private property for HireReturnDate
        private DateTime mHireReturnDate;
        //private property for HireLocation
        private string mHireLocation;
        //private property for DriverAge
        private int mDriverAge;
        //private property for DriverLicenseNumber
        private string mDriverLicenseNumber;


        //Hire ID property
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

        //Car ID property
        public int CarID
        {
            get
            {
                //return the private data
                return mCarID;
            }
            set
            {
                //set the private data
                mCarID = value;
            }
        }

        //Customer ID property
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the private data
                mCustomerID = value;
            }
        }

        //Hire Collection property
        public DateTime HireCollectionDate
        {
            get
            {
                //return the private data 
                return mHireCollectionDate;
            }

            set
            {
                //set the private data
                mHireCollectionDate = value;
            }
        }

        //Hire Return property
        public DateTime HireReturnDate
        {
            get
            {
                //return the private data 
                return mHireReturnDate;
            }

            set
            {
                //set the private data
                mHireReturnDate = value;
            }
        }

        //Hire Location property
        public string HireLocation
        {
            get
            {
                //return the private data 
                return mHireLocation;
            }

            set
            {
                //set the private data
                mHireLocation = value;
            }
        }

        /*//Hire PostCode property
        public string HirePostCode
        {
            get
            {
                //return the private data 
                return mHirePostCode;
            }

            set
            {
                //set the private data
                mHirePostCode = value;
            }
        }*/

        //DriverAge property 
        public int DriverAge
        {
            get
            {
                //return the private data 
                return mDriverAge;
            }

            set
            {
                //set the private data
                mDriverAge = value;
            }
        }

        //DriverLicenseNumber property 
        public string DriverLicenseNumber
        {
            get
            {
                //return the private data 
                return mDriverLicenseNumber;
            }

            set
            {
                //set the private data
                mDriverLicenseNumber = value;
            }
        }

        //find method for HireID
        public bool Find(int HireID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for HireID to search for
            DB.AddParameter("@HireID", HireID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHire_FilterByHireID");
            //if one record is found (there should only be 1 or 0 records found)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mHireID = Convert.ToInt32(DB.DataTable.Rows[0]["HireID"]);
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mHireCollectionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireCollectionDate"]);
                mHireReturnDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireReturnDate"]);
                mHireLocation = Convert.ToString(DB.DataTable.Rows[0]["HireLocation"]);
                mDriverAge = Convert.ToInt32(DB.DataTable.Rows[0]["DriverAge"]);
                mDriverLicenseNumber = Convert.ToString(DB.DataTable.Rows[0]["DriverLicenseNumber"]);
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

        public string Valid(string HireCollectionDate, string HireReturnDate, string HireLocation, string DriverAge, string DriverLicenseNumber)
        {
            //string variable to store the error message
            string Error = "";

            //variables for date values
            DateTime DateTemp1;
            DateTime DateTemp2;

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //check hire collection date is in correct format and in range
            if (HireCollectionDate.Length > 0)
            {
                try
                {
                    //assign HireCollectionDate date to the DateTemp1 variable
                    DateTemp1 = Convert.ToDateTime(HireCollectionDate);
                    //check to see the Hire Collection is not in the past
                    if (DateTemp1 < DateTime.Now.Date.AddDays(1))
                    {
                        //record the error 
                        return "A car hire collection must be dated between tomorrows date or six months from today. Please enter a valid date.";
                    }

                    //check to see if a Hire Collection is further than 6 months (180 days) away
                    if (DateTemp1 > DateTime.Now.Date.AddDays(180))
                    {
                        //record the error
                        return "A car hire collection date may not be 6 months more than the current date. Please enter a valid date.";
                    }
                }

                catch
                {
                    //record the error 
                    return "The inputted date was not valid. Please enter a valid date.";
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 

            

            //check hire return date is in correct format and in range
            if (HireReturnDate.Length > 0)
            {
                try
                {
                    //assign HireCollectionDate date to the DateTemp1 variable
                    DateTemp1 = Convert.ToDateTime(HireCollectionDate);
                    //assign HireReturnDate date to the DateTemp2 variable
                    DateTemp2 = Convert.ToDateTime(HireReturnDate);
                    //check to see the Hire Return is not in the past + is at least 7 days after the Hire Collection Date
                    if (DateTemp2 < DateTime.Now.Date.AddDays(8))
                    {
                        //record the error 
                        return "A car hire return cannot take place with a past date and must be dated a week from the current date. Please enter a valid date.";
                    }

                    //check to see if a Hire Collection is further than 8 months (240 days) away
                    if (DateTemp2 > DateTime.Now.Date.AddDays(240))
                    {
                        //record the error
                        return "A car hire return date may not be 8 months more than the current date. Please enter a valid date.";
                    }

                    if (DateTemp2 < DateTemp1)
                    {
                        //record the error
                        return "A car hire return date may not be sooner than a car hire collection date. Please enter a valid date.";
                    }
                }

                catch
                {
                    //record the error 
                    return "The inputted date was not valid. Please enter a valid date.";
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the hire location length is blank
            if (HireLocation.Length == 0)
            {
                //return the following error message
                return "The hire location may not be blank. Please select an appropriate hire location from the listed options.";
            }
            //if the hire location length is more than 70 characters
            if (HireLocation.Length > 70)
            {
                //return the following error message
                return "The hire location entered holds too many characters. Please select an appropriate hire location from the listed options.";
            }
            //if the hire location length is less than 5 characters 
            if (HireLocation.Length < 5)
            {
                //return the following error message
                return "The hire location entered is too short. Please select an appropriate hire location from the listed options.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            /*//if the HirePostCode length is blank
            if (HirePostCode.Length == 0)
            {
                //return the following error message
                return "The postcode may not be blank. Please enter a postcode.";
            }
            //if the HirePostCode length is more than 10 characters
            if (HirePostCode.Length > 10)
            {
                //return the following error message
                return "The postcode entered holds too many characters. Please enter a shorter postcode.";
            }
            //if the HirePostCode length is less than 5 characters 
            if (HirePostCode.Length < 5)
            {
                //return the following error message
                return "The postcode entered is too short. Please enter a longer postcode.";
            }*/

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            if (DriverAge.Length > 0)
            {
                try
                {
                    Int32 TempDriverAge = Convert.ToInt32(DriverAge);

                    if (TempDriverAge < 17)
                    {
                        return "For safety and legal reasons, drivers must be at least 17 years old to hire a car.";
                    }

                    if (TempDriverAge > 75)
                    {
                        return "For safety and legal reasons, drivers must be younger than 75 years old to hire a car.";

                    }
                }
                catch
                {
                    return "The driver age entered is not acceptable.";
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the driver license number length is blank
            if (DriverLicenseNumber.Length == 0)
            {
                //return the following error message
                return "The driver license number may not be blank. Please enter a legal driver license number.";
            }
            //if the driver license number length is more than 20 characters
            if (DriverLicenseNumber.Length > 20)
            {
                //return the following error message
                return "The driver license number is invalid. Please enter a legal driver license number.";
            }
            //if the driver license number length is less than 11 characters 
            if (DriverLicenseNumber.Length < 11)
            {
                //return the following error message
                return "The driver license number is invalid. Please enter a legal driver license number.";
            }

            return Error;
        }
    }
}