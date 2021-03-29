using System;

namespace VirginClassLibrary
{
    public class clsVHCHospital
    {

        //private data member for the Hospital property 
        private int mHospital_ID;

        //private data member for the Hospital_Name property 
        private string mHospital_Name;

        //private data member for the Hospital_Place property 
        private string mHospital_Place;

        //Hospital_ID Property
        public int Hospital_ID 
        {
            get
            {
                    //return the private data 
                    return mHospital_ID;
            }
            set 
            {
                mHospital_ID = value; 
            }
        }

        //Hospital_Name Property
        public string Hospital_Name

        {
            get
            {
                //return the private data 
                return mHospital_Name;
            }

            set
            {
                mHospital_Name = value;
            }
        }

        //Hospital_Place Property
        public string Hospital_Place
        {
            get
            {
                //return the private data 
                return mHospital_Place;
            }

            set
            {
                mHospital_Place = value;
            }
        }

        public bool Find(int Hospital_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Hospital_ID to search for
            DB.AddParameter("@Hospital_ID", Hospital_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCHospital_FilterByVHCHospitalID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mHospital_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Hospital_ID"]);
                mHospital_Name = Convert.ToString(DB.DataTable.Rows[0]["Hospital_Name"]);
                mHospital_Place = Convert.ToString(DB.DataTable.Rows[0]["Hospital_Place"]);
            
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string Hospital_Name, string Hospital_Place)
        {
            String Error = "";

            // (1) Hospital Name Validation

            //if hospital name is blank 
            if (Hospital_Name.Length == 0)
            {
                //record the error 
                Error = Error + "HOSPITAL NAME CANNOT BE BLANK!" + " ";

            }

            if (Hospital_Name.Length < 1 | Hospital_Name.Length > 50)
            {
                //set the error message 
                Error = Error + "HOSPITAL NAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }

            // (2) Hospital Place Validation

            //if hospital place is blank 
            if (Hospital_Place.Length == 0)
            {
                //record the error 
                Error = Error + "HOSPITAL PLACE CANNOT BE BLANK!" + " ";

            }

            if (Hospital_Place.Length < 1 | Hospital_Place.Length > 50)
            {
                //set the error message 
                Error = Error + "HOSPITAL NAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }

            return Error; 
        }
    }
}