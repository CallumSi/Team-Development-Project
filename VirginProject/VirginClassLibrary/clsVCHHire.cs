using System.Collections.Generic;
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
        //private property for customerID
        private int mCustomerID;
        //private property for HireCollectionDate
        private DateTime mHireCollectionDate;
        //private property for HireReturnDate
        private DateTime mHireReturnDate;
        //private property for HireAddress
        private string mHireAddress;
        //private property for HirePostCode
        private string mHirePostCode;
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

        //Hire Address property
        public string HireAddress
        {
            get
            {
                //return the private data 
                return mHireAddress;
            }

            set
            {
                //set the private data
                mHireAddress = value;
            }
        }

        //Hire PostCode property
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
        }

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

        public string Valid(string HireCollectionDate, string HireReturnDate, string HireAddress, string HirePostCode, string DriverAge, string DriverLicenseNumber)
        {
            //string variable to store the error message
            string Error = "";

            //variables for date values
            DateTime DateTemp1;
            DateTime DateTemp2;

            //check hire collection date is in correct format and in range
            if (HireCollectionDate.Length > 0)
            {
                try
                {
                    //assign HireCollectionDate date to the DateTemp1 variable
                    DateTemp1 = Convert.ToDateTime(HireCollectionDate);
                    //check to see the Hire Collection is not in the past
                    if (DateTemp1 < DateTime.Now.Date)
                    {
                        //record the error 
                        return "A car hire collection cannot take place with a past date. Please enter a valid date.";
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
                    //assign HireReturnDate date to the DateTemp2 variable
                    DateTemp2 = Convert.ToDateTime(HireReturnDate);
                    //check to see the Hire Return is not in the past + is at least 7 days after the Hire Collection Date
                    if (DateTemp2 < DateTime.Now.Date.AddDays(7))
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
                }

                catch
                {
                    //record the error 
                    return "The inputted date was not valid. Please enter a valid date.";
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the hire address length is blank
            if (HireAddress.Length == 0)
            {
                //return the following error message
                return "The address may not be blank. Please enter an address.";
            }
            //if the hire address length is more than 50 characters
            if (HireAddress.Length > 50)
            {
                //return the following error message
                return "The address entered holds too many characters. Please enter a shorter address and do not include a postcode.";
            }
            //if the hire address length is less than 3 characters 
            if (HireAddress.Length < 3)
            {
                //return the following error message
                return "The address entered is too short. Please enter a longer address and do not include a postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the HirePostCode length is blank
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
            }

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