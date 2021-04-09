using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMStaffCollection
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the staff collection class
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void VMStaffListOK()
        {
            //create an instance of the staff collection class 
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            //create a list of object to assign to the property
            List<clsVMStaff> TestList = new List<clsVMStaff>();
            //create the item of test data
            clsVMStaff TestItem = new clsVMStaff();
            //set its properties
            TestItem.VMstaffID = 1;
            TestItem.VMstaffFirstName = "Mike";
            TestItem.VMstaffLastName = "Jordan";
            TestItem.VMstaffEmail = "MikeJordan@gmail.com";
            TestItem.VMstaffPassword = "Mike6Jordan";
            TestItem.VMstaffPosition = "Helper";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the staff collection class 
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            //create some test data to assign to the property
            clsVMStaff TestStaff = new clsVMStaff();
            //set the properties of the test object
            TestStaff.VMstaffID = 2;
            TestStaff.VMstaffFirstName = "Sufiyaan";
            TestStaff.VMstaffLastName = "Hussain";
            TestStaff.VMstaffEmail = "SufiyaanHussain@yahoo.com";
            TestStaff.VMstaffPassword = "SufiyaanHussain97";
            TestStaff.VMstaffPosition = "Admin";
            //assign the data to the property
            allStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the staff collection class 
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsVMStaff> TestList = new List<clsVMStaff>();
            //add an item to the list
            //create the item of test data
            clsVMStaff TestItem = new clsVMStaff();
            //set the properties of the test object
            TestItem.VMstaffFirstName = "Sufiyaan";
            TestItem.VMstaffLastName = "Hussain";
            TestItem.VMstaffEmail = "SufiyaanHussain@yahoo.com";
            TestItem.VMstaffPassword = "SufiyaanHussain97";
            TestItem.VMstaffPosition = "Admin";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the staff collection class 
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            //create the item of test data
            clsVMStaff TestItem = new clsVMStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMstaffFirstName = "Harry";
            TestItem.VMstaffLastName = "Potter";
            TestItem.VMstaffEmail = "Potter@hotmail.com";
            TestItem.VMstaffPassword = "Wizard123";
            TestItem.VMstaffPosition = "Customer Service";
            //set ThisCustomer to the test data
            allStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = allStaff.Add();
            //Set the primary key of the test data
            TestItem.VMstaffID = PrimaryKey;
            //find the record
            allStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the staff collection class 
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            //create the item of test data
            clsVMStaff TestItem = new clsVMStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMstaffFirstName = "Harry";
            TestItem.VMstaffLastName = "Potter";
            TestItem.VMstaffEmail = "Potter@hotmail.com";
            TestItem.VMstaffPassword = "Wizard123";
            TestItem.VMstaffPosition = "Customer Service";
            //set ThisCustomer to the test data
            allStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = allStaff.Add();
            //Set the primary key of the test data
            TestItem.VMstaffID = PrimaryKey;
            //mdoify the record
            TestItem.VMstaffFirstName = "Hermione";
            TestItem.VMstaffLastName = "Granger";
            TestItem.VMstaffEmail = "PotionMaster@Gmail.co.uk";
            TestItem.VMstaffPassword = "HGranger999";
            TestItem.VMstaffPosition = "Customer Service";
            //set the record based on the new test data
            allStaff.ThisStaff = TestItem;
            //Update the record
            allStaff.Update();
            //find the record
            allStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the staff collection class 
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            //create the item of test data
            clsVMStaff TestItem = new clsVMStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMstaffFirstName = "Hermione";
            TestItem.VMstaffLastName = "Granger";
            TestItem.VMstaffEmail = "PotionMaster@Gmail.co.uk";
            TestItem.VMstaffPassword = "HGranger999";
            TestItem.VMstaffPosition = "Customer Service";
            //set the record based on the new test data
            allStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = allStaff.Add();
            //set the primary key of the test data
            TestItem.VMstaffID = PrimaryKey;
            //find the record
            allStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            allStaff.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            //create an instance of the staff collection class 
            clsVMStaffCollection allStaff = new clsVMStaffCollection();
            // create an instance of the filtered data
            clsVMStaffCollection FilteredVMSFirstName = new clsVMStaffCollection();
            //apply a blank string (should return all records)
            FilteredVMSFirstName.FilterByFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(allStaff.Count, FilteredVMSFirstName.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            // create an instance of the filtered data
            clsVMStaffCollection FilteredVMSFirstName = new clsVMStaffCollection();
            //apply a firstname that doesnt exist
            FilteredVMSFirstName.FilterByFirstName("Hello");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredVMSFirstName.Count);
        }

        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            // create an instance of the filtered data
            clsVMStaffCollection FilteredVMSFirstName = new clsVMStaffCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a username that does exist
            FilteredVMSFirstName.FilterByFirstName("Sufiyaan");
            //check that the correct number of records are found
            if (FilteredVMSFirstName.Count == 2)
            {
                //check that the first record is ID 80
                if (FilteredVMSFirstName.StaffList[0].VMstaffID != 17)
                {
                    OK = false;
                }
                //check that the first record is ID 82
                if (FilteredVMSFirstName.StaffList[1].VMstaffID != 28)
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
