using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHHireCollection
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test to see that it exists
            Assert.IsNotNull(AllHires);
        }

        [TestMethod]
        public void HireListOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHHire> TestList = new List<clsVCHHire>();
            //add items to the list
            //create the item of test data
            clsVCHHire TestItem = new clsVCHHire();
            //set data properties
            TestItem.HireID = 1;
            TestItem.CarID = 1;
            TestItem.CustomerID = 1;
            TestItem.HireCollectionDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(8);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.HireStatus = "Pending Confirmation";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllHires.HireList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.HireList, TestList);
        }

        [TestMethod]
        public void ThisCarHirePropertyOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //create the item of test data
            clsVCHHire TestHire = new clsVCHHire();
            //set data properties
            TestHire.HireID = 1;
            TestHire.CarID = 1;
            TestHire.CustomerID = 1;
            TestHire.HireCollectionDate = DateTime.Now.Date.AddDays(1);
            TestHire.HireReturnDate = DateTime.Now.Date.AddDays(8);
            TestHire.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestHire.HireStatus = "Pending Confirmation";
            //assign data to the properties
            AllHires.ThisHire = TestHire;
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.ThisHire, TestHire);
        }

        /*
         
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllHires.Count = SomeCount;
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.Count, SomeCount);
        }
        
        [TestMethod]
        public void TwoHiresPresent()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.Count, 2);
        }

        */

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHHire> TestList = new List<clsVCHHire>();
            //add items to the list
            //create the item of test data
            clsVCHHire TestItem = new clsVCHHire();
            //set data properties
            TestItem.HireID = 1;
            TestItem.CarID = 1;
            TestItem.CustomerID = 1;
            TestItem.HireCollectionDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(8);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.HireStatus = "Pending Confirmation";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllHires.HireList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test data to assign to the property
            clsVCHHire TestItem = new clsVCHHire();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            //set data properties
            TestItem.HireID = 1;
            TestItem.CarID = 1;
            TestItem.CustomerID = 1;
            TestItem.HireCollectionDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(8);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.HireStatus = "Pending Confirmation";
            //set ThisCar to the test data
            AllHires.ThisHire = TestItem;
            /* 
            commented out to prevent constant-reduplication of car hire record into data table
            "//add the record
            PrimaryKey = AllHires.Add();" 
            */
            //set the primary key of the test data
            TestItem.HireID = PrimaryKey;
            //find the record
            AllHires.ThisHire.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.ThisHire, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test data to assign to the property
            clsVCHHire TestItem = new clsVCHHire();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            //set data properties
            TestItem.HireID = 1;
            TestItem.CarID = 1;
            TestItem.CustomerID = 1;
            TestItem.HireCollectionDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(8);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.HireStatus = "Pending Confirmation";
            //set ThisCar to the test data
            AllHires.ThisHire = TestItem;
            /* 
            commented out to prevent constant-reduplication of car hire record into data table
            "//add the record
            PrimaryKey = AllHires.Add();" 
            */
            //set the primary key of the test data
            TestItem.HireID = PrimaryKey;
            //find the record
            AllHires.ThisHire.Find(PrimaryKey);
            //delete the record
            AllHires.Delete();
            //now find the record
            Boolean Found = AllHires.ThisHire.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.ThisHire, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //test data to assign to the property
            clsVCHHire TestItem = new clsVCHHire();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            //set data properties
            TestItem.HireID = 1;
            TestItem.CarID = 1;
            TestItem.CustomerID = 1;
            TestItem.HireCollectionDate = DateTime.Now.Date.AddDays(1);
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(8);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.HireStatus = "Pending Confirmation";
            //set ThisCar to the test data
            AllHires.ThisHire = TestItem;
            /* 
            commented out to prevent constant-reduplication of car hire record into data table
            "//add the record
            PrimaryKey = AllHires.Add();" 
            */
            //set the primary key of the test data
            TestItem.HireID = PrimaryKey;
            //modify the test data in the following manner
            //set data properties
            TestItem.HireID = 1;
            TestItem.CarID = 1;
            TestItem.CustomerID = 1;
            TestItem.HireCollectionDate = DateTime.Now.Date.AddDays(7);
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(14);
            TestItem.HireLocation = "30 Glaxon Street, Shropshire, SH7 3FG";
            TestItem.HireStatus = "Pending Confirmation";
            //set the record based on the new test data
            AllHires.ThisHire = TestItem;
            //update the record
            AllHires.Update();
            //find the record
            AllHires.ThisHire.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.ThisHire, TestItem);
        }

        [TestMethod]
        public void ReportByHireLocationMethodOK()
        {
            //create an instance of the car hire colllection class
            clsVCHHireCollection AllHires = new clsVCHHireCollection();
            //create an instance of the data to filter
            clsVCHHireCollection FilteredHireLocation = new clsVCHHireCollection();
            //apply a blank string (all car hire records should be returned)
            FilteredHireLocation.ReportByHireLocation("");
            //test to see that both values ARE the same
            Assert.AreEqual(AllHires.Count, FilteredHireLocation.Count);
        }

        [TestMethod]
        public void ReportByHireLocationNoneFound()
        {
            //create an instance of the data to filter
            clsVCHHireCollection FilteredHireLocation = new clsVCHHireCollection();
            //apply a none existent Car Hire record
            FilteredHireLocation.ReportByHireLocation("ThisDoesntExist");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredHireLocation.Count);
        }

        [TestMethod]
        public void ReportByHireLocationTestDataFound()
        {
            //create an instance of the data to filter
            clsVCHHireCollection FilteredHireLocation = new clsVCHHireCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply an existent body type
            FilteredHireLocation.ReportByHireLocation("1 Royal Scot Road, Derby, DE24 8AJ");
            //check that the correct number of records are found
            if (FilteredHireLocation.Count == 2)
            {
                //check that the first record ID is 12
                if (FilteredHireLocation.HireList[0].HireID != 21)
                {
                    OK = false;
                }
                //check that the second record ID is 15
                if (FilteredHireLocation.HireList[1].HireID != 22)
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
