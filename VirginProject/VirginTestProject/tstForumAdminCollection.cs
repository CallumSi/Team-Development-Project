﻿using System;
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
        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class I want to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //create an item of test data
            clsForumAdmin TestItem = new clsForumAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AdminUserName = "TestAdmin";
            TestItem.AdminFirstName = "Test";
            TestItem.AdminLastName = "Admin";
            TestItem.AdminEmail = "Admin@hotmail.com";
            TestItem.AdminPassword = "Admin";
            //set ThisUser to the test data
            AllAdmins.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmins.Add();
            //set the primary key of the test data
            TestItem.AdminID = PrimaryKey;
            //find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //test to see that the two value are the same
            Assert.AreEqual(AllAdmins.ThisAdmin, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //create the item of test data
            clsForumAdmin TestItem = new clsForumAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AdminID = 2;
            TestItem.AdminUserName = "Tedward02";
            TestItem.AdminFirstName = "Taf";
            TestItem.AdminLastName = "Edward";
            TestItem.AdminEmail = "Taf@hotmail.com";
            TestItem.AdminPassword = "TafMan";
            //set ThisUser to the test data
            AllAdmins.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmins.Add();
            //set the primary key of the test data
            TestItem.AdminID = PrimaryKey;
            //find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //delete the record
            AllAdmins.Delete();
            //now find the record
            Boolean Found = AllAdmins.ThisAdmin.Find(PrimaryKey);
            //test to see that the two value are the same
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //create the item of test data
            clsForumAdmin TestItem = new clsForumAdmin();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AdminID = 2;
            TestItem.AdminUserName = "Tedward02";
            TestItem.AdminFirstName = "Taf";
            TestItem.AdminLastName = "Edward";
            TestItem.AdminEmail = "Taf@hotmail.com";
            TestItem.AdminPassword = "TafMan";
            //set ThisUser to the test data
            AllAdmins.ThisAdmin = TestItem;
            //add the record
            PrimaryKey = AllAdmins.Add();
            //set the primary key of the test data
            TestItem.AdminID = PrimaryKey;
            //modify the record
            TestItem.AdminUserName = "JB";
            TestItem.AdminFirstName = "Jim";
            TestItem.AdminLastName = "Bob";
            TestItem.AdminEmail = "Jim@hotmail.com";
            TestItem.AdminPassword = "JimBob";
            //set the record based on the new test data
            AllAdmins.ThisAdmin = TestItem;
            //Update the record
            AllAdmins.Update();
            //find the record
            AllAdmins.ThisAdmin.Find(PrimaryKey);
            //test to see ThisAdmin matches the test data
            Assert.AreEqual(AllAdmins.ThisAdmin, TestItem);

        }
        [TestMethod]
        public void ReportByAdminFirstNameMethodOK()
        {
            //create an instance of the class we want to create
            clsForumAdminCollection AllAdmins = new clsForumAdminCollection();
            //create an instance of the filtered data
            clsForumAdminCollection FilteredAdmins = new clsForumAdminCollection();
            //apply a blank string(should return all records)
            FilteredAdmins.ReportByAdminFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAdmins.Count, FilteredAdmins.Count);
        }
        [TestMethod]
        public void ReportByAdminFirstNameFound()
        {
            //create an instance of the filtered data
            clsForumAdminCollection FilteredAdmins = new clsForumAdminCollection();
            //apply a username that does not exist
            FilteredAdmins.ReportByAdminFirstName("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredAdmins.Count);
        }
        [TestMethod]
        public void ReportByAdminFirstNameTestDataFound()
        {
            //create an instance of filtered data
            clsForumAdminCollection FilteredAdmins = new clsForumAdminCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a username that doesn't exist
            FilteredAdmins.ReportByAdminFirstName("max");
            //check that the correct number of records 
            if (FilteredAdmins.Count == 2)
            {
                //check that the correct number of records are found
                if (FilteredAdmins.AdminList[0].AdminID != 554)
                {
                    OK = false;
                }
                //check that the first record is ID 6
                if (FilteredAdmins.AdminList[1].AdminID != 556)
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
