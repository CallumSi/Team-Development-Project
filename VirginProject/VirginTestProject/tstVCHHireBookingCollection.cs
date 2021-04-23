using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHHireBookingCollection
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllHireBookings);
        }

        [TestMethod]
        public void HireBookingListOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHHireBooking> TestList = new List<clsVCHHireBooking>();
            //add items to the list
            //create the item of test data
            clsVCHHireBooking TestItem = new clsVCHHireBooking();
            //set data properties
            TestItem.HireBookingID = 1;
            TestItem.HireID = 25;
            TestItem.HireDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireTime = 0900;
            TestItem.HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllHireBookings.HireBookingList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllHireBookings.HireBookingList, TestList);
        }

        [TestMethod]
        public void ThisHireBookingPropertyOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //create the item of test data
            clsVCHHireBooking TestHireBooking = new clsVCHHireBooking();
            //set data properties
            TestHireBooking.HireBookingID = 1;
            TestHireBooking.HireID = 25;
            TestHireBooking.HireDate = DateTime.Now.Date.AddDays(1);
            TestHireBooking.HireTime = 0900;
            TestHireBooking.HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //assign data to the properties
            AllHireBookings.ThisHireBooking = TestHireBooking;
            //test to see the values ARE the same
            Assert.AreEqual(AllHireBookings.ThisHireBooking, TestHireBooking);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHHireBooking> TestList = new List<clsVCHHireBooking>();
            //add items to the list
            //create the item of test data
            clsVCHHireBooking TestItem = new clsVCHHireBooking();
            //set data properties
            TestItem.HireBookingID = 1;
            TestItem.HireID = 25;
            TestItem.HireDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireTime = 0900;
            TestItem.HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllHireBookings.HireBookingList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllHireBookings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //test data to assign to the property
            clsVCHHireBooking TestItem = new clsVCHHireBooking();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.HireBookingID = 1;
            TestItem.HireID = 25;
            TestItem.HireDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireTime = 0900;
            TestItem.HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //set ThisHireBooking to the test data
            AllHireBookings.ThisHireBooking = TestItem;
            /* 
            commented out to prevent constant-reduplication of car hire booking record into data table
            "//add the record
            PrimaryKey = AllHireBookings.Add();" 
            */
            //set the primary key of the test data
            TestItem.HireBookingID = PrimaryKey;
            //find the record
            AllHireBookings.ThisHireBooking.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllHireBookings.ThisHireBooking, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //test data to assign to the property
            clsVCHHireBooking TestItem = new clsVCHHireBooking();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.HireBookingID = 1;
            TestItem.HireID = 25;
            TestItem.HireDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireTime = 0900;
            TestItem.HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //set ThisHireBooking to the test data
            AllHireBookings.ThisHireBooking = TestItem;
            /* 
            commented out to prevent constant-reduplication of car hire booking record into data table
            "//add the record
            PrimaryKey = AllHireBookings.Add();" 
            */
            //set the primary key of the test data
            TestItem.HireBookingID = PrimaryKey;
            //find the record
            AllHireBookings.ThisHireBooking.Find(PrimaryKey);
            //delete the record
            AllHireBookings.Delete();
            //now find the record
            Boolean Found = AllHireBookings.ThisHireBooking.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllHireBookings.ThisHireBooking, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //test data to assign to the property
            clsVCHHireBooking TestItem = new clsVCHHireBooking();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.HireBookingID = 1;
            TestItem.HireID = 25;
            TestItem.HireDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireTime = 0900;
            TestItem.HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //set ThisHireBooking to the test data
            AllHireBookings.ThisHireBooking = TestItem;
            /* 
            commented out to prevent constant-reduplication of car hire booking record into data table
            "//add the record
            PrimaryKey = AllHireBookings.Add();" 
            */
            //set the primary key of the test data
            TestItem.HireBookingID = PrimaryKey;
            //modify the test data in the following manner
            //set data properties
            TestItem.HireBookingID = 1;
            TestItem.HireID = 29;
            TestItem.HireDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireTime = 0900;
            TestItem.HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //set the record based on the new test data
            AllHireBookings.ThisHireBooking = TestItem;
            //update the record
            AllHireBookings.Update();
            //find the record
            AllHireBookings.ThisHireBooking.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllHireBookings.ThisHireBooking, TestItem);
        }

        [TestMethod]
        public void ReportByHireDateMethodOK()
        {
            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection AllHireBookings = new clsVCHHireBookingCollection();
            //create an instance of the data to filter
            clsVCHHireBookingCollection FilteredHireDate = new clsVCHHireBookingCollection();
            //apply a blank string (all car hire booking records should be returned)
            //FilteredHireDate.ReportByHireDate = Convert.ToDateTime("");
            //test to see that both values ARE the same
            Assert.AreEqual(AllHireBookings.Count, FilteredHireDate.Count);
        }

        [TestMethod]
        public void ReportByHireDateNoneFound()
        {
            //create an instance of the data to filter
            clsVCHHireBookingCollection FilteredHireBooking = new clsVCHHireBookingCollection();
            //apply a none existent hire booking date
            FilteredHireBooking.ReportByHireDate(Convert.ToDateTime("31/01/1999"));
            //test to see that both values ARE the same
            Assert.AreEqual(0, FilteredHireBooking.Count);
        }

        [TestMethod]
        public void ReportByHireDateDataFound()
        {
            //create an instance of the data to filter
            clsVCHHireBookingCollection FilteredHireBooking = new clsVCHHireBookingCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply an existent body type
            FilteredHireBooking.ReportByHireDate(Convert.ToDateTime("19/05/2021"));
            //check that the correct number of records are found
            if (FilteredHireBooking.Count == 2)
            {
                //check that the first record ID is 1
                if (FilteredHireBooking.HireBookingList[0].HireBookingID != 4)
                {
                    OK = false;
                }
                //check that the second record ID is 5
                if (FilteredHireBooking.HireBookingList[1].HireBookingID != 6)
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
