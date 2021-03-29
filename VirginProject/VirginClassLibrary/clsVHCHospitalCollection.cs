using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVHCHospitalCollection
    {
        //private data member for the list
        List<clsVHCHospital> mHospitalList = new List<clsVHCHospital>();
        //private data member thisHospital
        clsVHCHospital mThisHospital = new clsVHCHospital();

        //public property for the hospital list 
        public List<clsVHCHospital> HospitalList
        {
            get
            {
                //return the private data
                return mHospitalList;
            }

            set
            {
                //set the private data 
                mHospitalList = value;
            }
        }

        //private property for ThisHospital
        public clsVHCHospital ThisHospital
        {
            get
            {
                //return the private data 
                return mThisHospital;
            }

            set
            {
                //set the private data 
                mThisHospital = value;

            }
        }

        public int Count 
        {
            get
            {
                //return the count of the list
                return mHospitalList.Count;
            }
            set
            {
                
            }
        }

        //Add Method
        public int Add()
        {
            //adds a mew record to the database based on the values of mThisHospital
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Hospital_Name", mThisHospital.Hospital_Name);
            DB.AddParameter("@Hospital_Place", mThisHospital.Hospital_Place);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVHCHospital_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisHospital
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@Hospital_ID", mThisHospital.Hospital_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCHospital_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisHospital
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure 
            DB.AddParameter("@Hospital_ID", mThisHospital.Hospital_ID);
            DB.AddParameter("@Hospital_Name", mThisHospital.Hospital_Name);
            DB.AddParameter("@Hospital_Place", mThisHospital.Hospital_Place);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCHospital_Update");
        }
    }
}