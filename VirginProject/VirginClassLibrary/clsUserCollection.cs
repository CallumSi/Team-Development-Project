using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    class clsUserCollection
    {

        List<clsUser> mUserList = new List<clsUser>();
        clsUser mThisUser = new clsUser();




        //public clsUserCollection()
        //{
        //    clsDataConnection DB = new clsDataConnection();
        //    DB.Execute("sproc_tblUser_SelectAll");
        //    PopulateArray(DB);
        //}
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



    }

}
