using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstUserCollection
    {
       

        
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we wnat to create
            clsUserCollection AllUsers = new clsUserCollection();
            //test to see that it exists
            Assert.IsNotNull(AllUsers);
        }
        [TestMethod]
        public void UserListOK()
        {
            //create an instance of the class I want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create a list of object to assign to the property
            List<clsUser> TestList = new List<clsUser>();
            //create the item of test data
            clsUser TestItem = new clsUser();
            //set its properties
            TestItem.UserID = 1;
            TestItem.UserName = "Abdi";
            TestItem.UserPassword = "Suldan";
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
            clsUserCollection AllUsers = new clsUserCollection();
            //create some test data to assign to the property
            clsUser TestUser = new clsUser();
            //set the properties of the test object
            TestUser.UserID = 1;
            TestUser.UserName = "Abdi";
            TestUser.UserPassword = "Suldan";
            //assign the data to the property
            AllUsers.ThisUser = TestUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestUser);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class I want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create a list of object to assign to the property
            List<clsUser> TestList = new List<clsUser>();
            //create an item to the list
            clsUser TestItem = new clsUser();
            //set its properties
            TestItem.UserID = 1;
            TestItem.UserName = "Abdi";
            TestItem.UserPassword = "Suldan";
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
            clsUserCollection AllUsers = new clsUserCollection();
            //create an item of test data
            clsUser TestItem = new clsUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserName = "Abdi";
            TestItem.UserPassword = "Suldan";
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
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create the item of test data
            clsUser TestItem = new clsUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserID = 1;
            TestItem.UserName = "Callum";
            TestItem.UserPassword = "pass123";
            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //modify the record
            TestItem.UserName = "John";
            TestItem.UserPassword = "Terry";
            //set the record based on the new test data
            AllUsers.ThisUser = TestItem;
            //Update the record
            AllUsers.Update();
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see ThisUser matches the test data
            Assert.AreEqual(AllUsers.ThisUser, TestItem);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //boolean variable to store the result of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            found = AnUser.Find(UserID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestUserIDFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostID = 1;
            //invoke the method
            Found = AnUser.Find(PostID);
            //check the user id
            if (AnUser.UserID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserNameFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            Found = AnUser.Find(UserID);
            //check the user id
            if (AnUser.UserName != "Abdi")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            Found = AnUser.Find(UserID);
            //check the user id
            if (AnUser.UserPassword != "Suldan")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
