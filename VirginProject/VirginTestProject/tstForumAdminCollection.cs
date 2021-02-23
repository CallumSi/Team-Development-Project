using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumAdminCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we wnat to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAdmins);
        }
        [TestMethod]
        public void AdminListOK()
        {
            //create an instance of the class I want to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //create a list of object to assign to the property
            List<clsForumAdmin> TestList = new List<clsForumAdmin>();
            //create the item of test data
            clsForumAdmin TestItem = new clsForumAdmin();
            //set its properties
            TestItem.AdminID = 1;
            TestItem.AdminUserName = "HMakda23";
            TestItem.AdminFirstName = "Husain";
            TestItem.AdminLastName = "Makda";
            TestItem.AdminEmail = "Husian@gmail.com";
            TestItem.AdminPassword = "HusainMk23";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllAdmins.AdminList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmins.AdminList, TestList);
        }
        [TestMethod]
        public void ThisAdminPropertyOK()
        {
            //Create an instance of the class I want to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //create some test data to assign to the property
            clsForumAdmin TestAdmin = new clsForumAdmin();
            //set the properties of the test object
            TestAdmin.AdminID = 1;
            TestAdmin.AdminUserName = "SCarol43";
            TestAdmin.AdminFirstName = "Samuel";
            TestAdmin.AdminLastName = "charol";
            TestAdmin.AdminEmail = "SaC@gmail.com";
            TestAdmin.AdminPassword = "TallJack53";
            //assign the data to the property
            AllAdmins.ThisAdmin = TestAdmin;
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmins.ThisAdmin, TestAdmin);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class I want to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //create a list of object to assign to the property
            List<clsForumAdmin> TestList = new List<clsForumAdmin>();
            //create an item to the list
            clsForumAdmin TestItem = new clsForumAdmin();
            //set its properties
            TestItem.AdminID = 1;
            TestItem.AdminUserName = "MNeuer3";
            TestItem.AdminFirstName = "Mauel";
            TestItem.AdminLastName = "Neuer";
            TestItem.AdminEmail = "MN@hotmail.com";
            TestItem.AdminPassword = "Mn54";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAdmins.AdminList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllAdmins.Count, TestList.Count);
        }
    }
}
