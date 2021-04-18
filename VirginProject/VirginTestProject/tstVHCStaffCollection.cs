using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVHCStaffCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void VHCStaffListOK()
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //create a list of object to assign to the property
            List<clsVHCStaff> TestList = new List<clsVHCStaff>();
            //create the item of test data
            clsVHCStaff TestItem = new clsVHCStaff();
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_Title = "Dr";
            TestItem.Staff_Firstname = "Monica";
            TestItem.Staff_Lastname = "Geller";
            TestItem.Staff_Email = "MGeller@gmail.com";
            TestItem.Staff_Username = "MonGeller";
            TestItem.Staff_Password = "MG30070956";
            TestItem.Staff_Role = "Doctor";
            TestItem.Staff_Status = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //create some test data to assign to the property
            clsVHCStaff TestStaff = new clsVHCStaff();
            //set the properties of the test object
            TestStaff.Staff_ID = 1;
            TestStaff.Staff_Title = "Dr";
            TestStaff.Staff_Firstname = "Monica";
            TestStaff.Staff_Lastname = "Geller";
            TestStaff.Staff_Email = "MGeller@gmail.com";
            TestStaff.Staff_Username = "MonGeller";
            TestStaff.Staff_Password = "MG30070956";
            TestStaff.Staff_Role = "Doctor";
            TestStaff.Staff_Status = true;
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsVHCStaff> TestList = new List<clsVHCStaff>();
            //add an item to the list
            //create the item of test data
            clsVHCStaff TestItem = new clsVHCStaff();
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_Title = "Dr";
            TestItem.Staff_Firstname = "Monica";
            TestItem.Staff_Lastname = "Geller";
            TestItem.Staff_Email = "MGeller@gmail.com";
            TestItem.Staff_Username = "MonGeller";
            TestItem.Staff_Password = "MG30070956";
            TestItem.Staff_Role = "Doctor";
            TestItem.Staff_Status = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        //Add Method
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //create some test data to assign to the property
            clsVHCStaff TestItem = new clsVHCStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Staff_ID = 1;
            TestItem.Staff_Title = "Dr";
            TestItem.Staff_Firstname = "Monica";
            TestItem.Staff_Lastname = "Geller";
            TestItem.Staff_Email = "MGeller@gmail.com";
            TestItem.Staff_Username = "MonGeller";
            TestItem.Staff_Password = "MG30070956";
            TestItem.Staff_Role = "Doctor";
            TestItem.Staff_Status = true;
            //set ThisStaff to the test data 
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data 
            TestItem.Staff_ID = PrimaryKey;
            //find the record 
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        //Update Method
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //create some test data to assign to the property
            clsVHCStaff TestItem = new clsVHCStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Staff_ID = 1;
            TestItem.Staff_Title = "Dr";
            TestItem.Staff_Firstname = "Monica";
            TestItem.Staff_Lastname = "Geller";
            TestItem.Staff_Email = "MGeller@gmail.com";
            TestItem.Staff_Username = "MonGeller";
            TestItem.Staff_Password = "MG30070956";
            TestItem.Staff_Role = "Doctor";
            TestItem.Staff_Status = true;
            //set ThisStaff to the test data 
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data 
            TestItem.Staff_ID = PrimaryKey;
            //modify the test data 
            TestItem.Staff_ID = 1;
            TestItem.Staff_Title = "Dr";
            TestItem.Staff_Firstname = "Monica";
            TestItem.Staff_Lastname = "Geller";
            TestItem.Staff_Email = "MGeller@gmail.com";
            TestItem.Staff_Username = "MonGeller";
            TestItem.Staff_Password = "MG30070956";
            TestItem.Staff_Role = "Doctor";
            TestItem.Staff_Status = true;
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the method 
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        //Delete Method
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //create some test data to assign to the property
            clsVHCStaff TestItem = new clsVHCStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Staff_ID = 1;
            TestItem.Staff_Title = "Dr";
            TestItem.Staff_Firstname = "Monica";
            TestItem.Staff_Lastname = "Geller";
            TestItem.Staff_Email = "MGeller@gmail.com";
            TestItem.Staff_Username = "MonGeller";
            TestItem.Staff_Password = "MG30070956";
            TestItem.Staff_Role = "Doctor";
            TestItem.Staff_Status = true;
            //set ThisStaff to the test data 
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data 
            TestItem.Staff_ID = PrimaryKey;
            //find the record 
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record 
            AllStaffs.Delete();
            //now find the record 
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByStaffMethodOK()
        //Report By Staff Method 
        {
            //create an instance of the staff collection class 
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //create an instance of the filtered data
            clsVHCStaffCollection FilteredStaff = new clsVHCStaffCollection();
            //apply a blank string (Should return all staffs) 
            FilteredStaff.ReportByStaff("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaffs.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffNoneFound()
        //Report By Staff None Found Method 
        {
            //create an instance of the filtered data           
            clsVHCStaffCollection FilteredStaff = new clsVHCStaffCollection();
            //apply a blank string (Should return all staffs) 
            FilteredStaff.ReportByStaff("xxxx");
            //test to see that the two values are the same 
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        //[TestMethod]
        //public void ReportByStaffTestDataFound()
        ////Report By Staff Test Data Found Method 
        //{
        //    //create an instance of the filtered data
        //    clsVHCStaffCollection FilteredStaff = new clsVHCStaffCollection();
        //    //var to store outcome
        //    Boolean OK = true;
        //    //apply a make that does exist
        //    FilteredStaff.ReportByStaff("Mati");
        //    //check that the correct number of records are found
        //    if (FilteredStaff.Count == 2)
        //    {
        //        //check that the first record id ID 2
        //        if (FilteredStaff.StaffList[0].Staff_ID != 20)
        //        {
        //            OK = false;
        //        }

        //        //check that the last record is ID 20
        //        if (FilteredStaff.StaffList[1].Staff_ID != 22)
        //        {
        //            OK = false;
        //        }
        //    }

        //    else
        //    {
        //        OK = false;
        //    }

        //    //test to see that the two values are the same 
        //    Assert.IsTrue(OK);
        //}
    }
}
