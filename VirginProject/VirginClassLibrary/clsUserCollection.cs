using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsUserCollection
    {

        List<clsUser> mUserList = new List<clsUser>();
        clsUser mThisUser = new clsUser();




        public clsUserCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblVMUser_Select_All");
            PopulateArray(DB);
        }
        public List<clsUser> UserList
        {
            get
            {
                //return the private data
                return mUserList;

            }
            set
            {
                //set the private data
                mUserList = value;

            }
        }


        public int Count
        {
            get
            {
                return mUserList.Count;

            }
            set
            {

            }
        }


        public clsUser ThisUser
        {
            get
            {
                return mThisUser;
            }
            set
            {
                mThisUser = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the datatable in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mUserList = new List<clsUser>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blanks staff
                //read in the fields from the current record

                clsUser AnUser = new clsUser();
                //read in the fields from the current record
                AnUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AnUser.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AnUser.UserPassword = Convert.ToString(DB.DataTable.Rows[Index]["UserPassword"]);
                //add the record to the private data member
                mUserList.Add(AnUser);
                //point at the next record
                Index++;
            }

        }

    }
}
