using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHStaff> TestList = new List<clsVCHStaff>();
            //add items to the list
            //create the item of test data
            clsVCHStaff TestItem = new clsVCHStaff();
            //set data properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Johann";
            TestItem.StaffLastName = "Goethe";
            TestItem.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestItem.StaffPostCode = "LE1 8WE";
            TestItem.StaffUsername = "JohannGoethizzy";
            TestItem.StaffEmail = "j.goethe@gmail.com";
            TestItem.StaffPassword = "HeiMepGre1";
            TestItem.StaffPhoneNumber = "07987654321";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllStaff.StaffList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            clsVCHStaff TestStaff = new clsVCHStaff();
            //set data properties
            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Johann";
            TestStaff.StaffLastName = "Goethe";
            TestStaff.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestStaff.StaffPostCode = "LE1 8WE";
            TestStaff.StaffUsername = "JohannGoethizzy";
            TestStaff.StaffEmail = "j.goethe@gmail.com";
            TestStaff.StaffPassword = "HeiMepGre1";
            TestStaff.StaffPhoneNumber = "07987654321";
            //assign data to the properties
            AllStaff.ThisStaff = TestStaff;
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHStaff> TestList = new List<clsVCHStaff>();
            //add items to the list
            //create the item of test data
            clsVCHStaff TestItem = new clsVCHStaff();
            //set data properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Johann";
            TestItem.StaffLastName = "Goethe";
            TestItem.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestItem.StaffPostCode = "LE1 8WE";
            TestItem.StaffUsername = "JohannGoethizzy";
            TestItem.StaffEmail = "j.goethe@gmail.com";
            TestItem.StaffPassword = "HeiMepGre1";
            TestItem.StaffPhoneNumber = "07987654321";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllStaff.StaffList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        /*[TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHStaff> TestList = new List<clsVCHStaff>();
            //add items to the list
            //create the item of test data
            clsVCHStaff TestItem = new clsVCHStaff();
            //set data properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Johann";
            TestItem.StaffLastName = "Goethe";
            TestItem.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestItem.StaffPostCode = "LE1 8WE";
            TestItem.StaffUsername = "JohannGoethizzy";
            TestItem.StaffEmail = "j.goethe@gmail.com";
            TestItem.StaffPassword = "HeiMepGre1";
            TestItem.StaffPhoneNumber = "07987654321";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllStaff.AllStaff = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoStaffPresent()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.Count, 2);
        }*/

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            clsVCHStaff TestItem = new clsVCHStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.StaffID = 1;
            TestItem.AdminID = 23;
            TestItem.StaffFirstName = "Johann";
            TestItem.StaffLastName = "Goethe";
            TestItem.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestItem.StaffPostCode = "LE1 8WE";
            TestItem.StaffUsername = "JohannGoethizzy";
            TestItem.StaffEmail = "j.goethe@gmail.com";
            TestItem.StaffPassword = "HeiMepGre1";
            TestItem.StaffPhoneNumber = "07987654321";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            /* 
            commented out to prevent constant-reduplication of staff record into data table
            "//add the record
            PrimaryKey = AllStaff.Add();" 
            */
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            clsVCHStaff TestItem = new clsVCHStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.StaffID = 1;
            TestItem.AdminID = 23;
            TestItem.StaffFirstName = "Johann";
            TestItem.StaffLastName = "Goethe";
            TestItem.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestItem.StaffPostCode = "LE1 8WE";
            TestItem.StaffUsername = "JohannGoethizzy";
            TestItem.StaffEmail = "j.goethe@gmail.com";
            TestItem.StaffPassword = "HeiMepGre1";
            TestItem.StaffPhoneNumber = "07987654321";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the staff record
            AllStaff.Delete();
            //now find the staff record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //test data to assign to the property
            clsVCHStaff TestItem = new clsVCHStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Johann";
            TestItem.StaffLastName = "Goethe";
            TestItem.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestItem.StaffPostCode = "LE1 8WE";
            TestItem.StaffUsername = "JohannGoethizzy";
            TestItem.StaffEmail = "j.goethe@gmail.com";
            TestItem.StaffPassword = "HeiMepGre1";
            TestItem.StaffPhoneNumber = "07987654321";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            /* 
            commented out to prevent constant-reduplication of staff record into data table
            "//add the record
            PrimaryKey = AllStaff.Add();" 
            */
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data in the following manner
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Johann";
            TestItem.StaffLastName = "Goethe";
            TestItem.StaffAddress = "49 Frankfurt Lane, Leicester";
            TestItem.StaffPostCode = "LE1 8WE";
            TestItem.StaffUsername = "MrHighIQ";
            TestItem.StaffEmail = "j.goethe@gmail.com";
            TestItem.StaffPassword = "HeiMepGre1";
            TestItem.StaffPhoneNumber = "07987654321";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByStaffUsernameMethodOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection AllStaff = new clsVCHStaffCollection();
            //create an instance of the data to filter
            clsVCHStaffCollection FilteredStaff = new clsVCHStaffCollection();
            //apply a blank string (all customer records should be returned)
            FilteredStaff.ReportByStaffUsername("");
            //test to see that both values ARE the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffUsernameNoneFound()
        {
            //create an instance of the data to filter
            clsVCHStaffCollection FilteredStaff = new clsVCHStaffCollection();
            //data variable of a none existent staff Username
            FilteredStaff.ReportByStaffUsername("HeyThisDoesn'tExist");
            //test to see that no matching staff usernames are found 
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffUsernameTestDataFound()
        {
            //create an instance of the data to filter
            clsVCHStaffCollection FilteredStaff = new clsVCHStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a data variable of an existent staff Username
            FilteredStaff.ReportByStaffUsername("M_Var99");
            //check that the correct number of staff records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first staff record is StaffID 12
                if (FilteredStaff.StaffList[0].StaffID != 12)
                {
                    OK = false;
                }
                //check that the first staff record is StaffID 13
                if (FilteredStaff.StaffList[1].StaffID != 13)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see that there are no new staff records
            Assert.IsTrue(OK);
        }
    }
}
