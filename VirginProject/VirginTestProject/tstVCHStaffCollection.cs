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
        }

        [TestMethod]
        public void AllStaffOK()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection Staff = new clsVCHStaffCollection();
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
            Staff.AllStaff = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(Staff.AllStaff, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the staff collection class
            clsVCHStaffCollection Staff = new clsVCHStaffCollection();
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
            Staff.AllStaff = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(Staff.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoStaffPresent()
        {
            //create an instance of the customer collection class
            clsVCHStaffCollection Staff = new clsVCHStaffCollection();
            //test to see the values ARE the same
            Assert.AreEqual(Staff.Count, 2);
        }
    }
}
