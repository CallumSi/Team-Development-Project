using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsUser
    {
        private Int32 mUserID;
        private string mUserName;
        private string mUserPassword;

        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }
        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string UserPassword
        {
            get
            {
                return mUserPassword;
            }
            set
            {
                mUserPassword = value;
            }
        }
        

        public Boolean Find(int UserID)
        {
            //instantiate the data connection
            clsDataConnection DB = new clsDataConnection();
            //ad the parameter we use to search
            DB.AddParameter("UserID", UserID);
            //execute the sproc
            DB.Execute("sproc_tblVMUser_FilterByUserID");
            //if record found 
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data variables
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mUserPassword = Convert.ToString(DB.DataTable.Rows[0]["UserPassword"]);    
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                //mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);

                return true;
            }
            else
            {
                //return false if no record ofund
                return false;
            }

        }

        public string Valid(string text1, string text2)
        {
            return "";
        }
    }
}
