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
            TestItem.HireCollectionDate = DateTime.Now.Date;
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(7);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.DriverAge = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
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
            TestHire.HireCollectionDate = DateTime.Now.Date;
            TestHire.HireReturnDate = DateTime.Now.Date.AddDays(7);
            TestHire.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestHire.DriverAge = 26;
            TestHire.DriverLicenseNumber = "ALIGH902245DA99S";
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
            TestItem.HireCollectionDate = DateTime.Now.Date;
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(7);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.DriverAge = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllHires.HireList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllHires.Count, TestList.Count);
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
    }
}
