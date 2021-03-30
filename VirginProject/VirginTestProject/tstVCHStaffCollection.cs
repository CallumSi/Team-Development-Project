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
            //add the record
            PrimaryKey = AllStaff.Add();
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
    }
}
