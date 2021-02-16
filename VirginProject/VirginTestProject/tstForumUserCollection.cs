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
   
    }
}
