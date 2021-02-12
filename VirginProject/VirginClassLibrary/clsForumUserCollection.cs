using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsForumUserCollection
    {
        //private data member for the list
        List<clsForumUser> mUserList = new List<clsForumUser>();
        public List<clsForumUser> UserList
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
                //return the count of the list
                return mUserList.Count;
            }
            set
            {

            }
        }
        public clsForumUser ThisUser { get; set; }

        public clsForumUserCollection()
        {
            //create the item of test data
            clsForumUser TestItem = new clsForumUser();
            //set its properties
            TestItem.UserEmail = "Karim@gmail.com";
            TestItem.UserFirstName = "Abdikarim";
            TestItem.UserID = 1;
            TestItem.UserLastName = "Sulieman";
            TestItem.UserPassword = "Abdikarim_233";
            TestItem.UserPhoneNumber = "02323374628";
            //add the item to the test item
            mUserList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsForumUser();
            //set its properties
            TestItem.UserEmail = "Jon@gmail.com";
            TestItem.UserFirstName = "Jon";
            TestItem.UserID = 1;
            TestItem.UserLastName = "Snow";
            TestItem.UserPassword = "Snow3";
            TestItem.UserPhoneNumber = "08269264628";
            //add the item to the test list
            mUserList.Add(TestItem);

        }
    }
 

}