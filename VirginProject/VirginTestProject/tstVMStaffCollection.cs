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
    }
}
