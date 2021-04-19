using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumUserCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we wnat to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //test to see that it exists
            Assert.IsNotNull(AllUsers);
        }
        [TestMethod]
        public void UserListOK()
        {
            //create an instance of the class I want to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //create a list of object to assign to the property
            List<clsForumUser> TestList = new List<clsForumUser>();
            //create the item of test data
            clsForumUser TestItem = new clsForumUser();
            //set its properties
            TestItem.UserID = 1;
            TestItem.UserFirstName = "Max";
            TestItem.UserLastName = "Arrons";
            TestItem.UserPhoneNumber = "01234567891";
            TestItem.UserEmail = "MaxArrons@gmail.com";
            TestItem.UserPassword = "ArrowsMan123";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.UserList, TestList);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //Create an instance of the class I want to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //create some test data to assign to the property
            clsForumUser TestUser = new clsForumUser();
            //set the properties of the test object
            TestUser.UserID = 1;
            TestUser.UserFirstName = "Sam";
            TestUser.UserLastName = "Choke";
            TestUser.UserPhoneNumber = "07934567291";
            TestUser.UserEmail = "SameC@gmail.com";
            TestUser.UserPassword = "CatMan43";
            //assign the data to the property
            AllUsers.ThisUser = TestUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestUser);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //Create an instance of the class I want to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //create a list of object to assign to the property
            List<clsForumUser> TestList = new List<clsForumUser>();
            //create an item to the list
            clsForumUser TestItem = new clsForumUser();
            //set its properties
            TestItem.UserID = 1;
            TestItem.UserFirstName = "Mohamed";
            TestItem.UserLastName = "Patel";
            TestItem.UserPhoneNumber = "012345862942";
            TestItem.UserEmail = "MPatel@hotmail.com";
            TestItem.UserPassword = "Patel73";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UserList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllUsers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class I want to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //create an item of test data
            clsForumUser TestItem = new clsForumUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Userusername = "Jamal94";
            TestItem.UserFirstName = "Jamal";
            TestItem.UserLastName = "Oueth";
            TestItem.UserPhoneNumber = "01234585342";
            TestItem.UserEmail = "Outeh@hotmail.com";
            TestItem.UserPassword = "ADT493";
            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the two value are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //create the item of test data
            clsForumUser TestItem = new clsForumUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserID = 1;
            TestItem.Userusername = "Jamal94";
            TestItem.UserFirstName = "Jamal";
            TestItem.UserLastName = "Oueth";
            TestItem.UserPhoneNumber = "01234585342";
            TestItem.UserEmail = "Outeh@hotmail.com";
            TestItem.UserPassword = "ADT493";
            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //delete teh record
            AllUsers.Delete();
            //now find the record
            Boolean Found = AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the two value are the same
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //create the item of test data
            clsForumUser TestItem = new clsForumUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Userusername = "Tom03";
            TestItem.UserFirstName = "Tom";
            TestItem.UserLastName = "Brady";
            TestItem.UserPhoneNumber = "12348363";
            TestItem.UserEmail = "Tom@Brady";
            TestItem.UserPassword = "Brazzz";
            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //modify the test data
            TestItem.UserFirstName = "Max";
            TestItem.UserLastName = "Haddy";
            TestItem.UserPhoneNumber = "5747598394";
            TestItem.UserEmail = "Max@gmail.com";
            TestItem.UserPassword = "Mazzy23";
            //set the record based on the new test data
            AllUsers.ThisUser = TestItem;
            //update the record
            AllUsers.Update();
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see ThisUser matches the test data
            Assert.AreEqual(AllUsers.ThisUser, TestItem);

        }
        [TestMethod]
        public void ReportByUserFirstNameMethodOK()
        {
            //create an instance of the class we want to create
            clsForumUserCollection AllUsers = new clsForumUserCollection();
            //create an instance of the filtered data
            clsForumUserCollection FilteredUsers = new clsForumUserCollection();
            //apply a blank string(should return all records)
            FilteredUsers.ReportByUserFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.Count, FilteredUsers.Count);
        }
        [TestMethod]
        public void ReportByUserFirstNameFound()
        {
            //create an instance of the filtered data
            clsForumUserCollection FilteredUsers = new clsForumUserCollection();
            //apply a username that does not exist
            FilteredUsers.ReportByUserFirstName("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredUsers.Count);
        }
        [TestMethod]
        public void ReportByUserFirstNameTestDataFound()
        {
            //create an instance of filtered data
            clsForumUserCollection FilteredUsers = new clsForumUserCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a username that doesn't exist
            FilteredUsers.ReportByUserFirstName("book");
            //check that the correct number of records 
            if (FilteredUsers.Count == 2)
            {
                //check that the correct number of records are found
                if (FilteredUsers.UserList[0].UserID != 387)
                {
                    OK = false;
                }
                //check that the first record is ID 6
                if (FilteredUsers.UserList[1].UserID != 388)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
