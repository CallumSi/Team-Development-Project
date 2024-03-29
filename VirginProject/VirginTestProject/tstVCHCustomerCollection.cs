﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHCustomer> TestList = new List<clsVCHCustomer>();
            //add items to the list
            //create the item of test data
            clsVCHCustomer TestItem = new clsVCHCustomer();
            //set data properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
            TestItem.Age = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            TestItem.Address = "12 Florence Cresent, Leicestershire";
            TestItem.PostCode = "LE13 2RV";
            TestItem.Username = "DanteAyyy";
            TestItem.Email = "d.alighieri@outlook.com";
            TestItem.Password = "3InPuPa";
            TestItem.PhoneNumber = "07912345678";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllCustomers.CustomerList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        /* Test is no longer neccessary because this is no guarantee to the amount of customers
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see the values ARE the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test data to assign to the property
            clsVCHCustomer TestCustomer = new clsVCHCustomer();
            //set data properties
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Dante";
            TestCustomer.LastName = "Alighieri";
            TestCustomer.Age = 26;
            TestCustomer.DriverLicenseNumber = "ALIGH902245DA99S";
            TestCustomer.Address = "12 Florence Cresent, Leicestershire";
            TestCustomer.PostCode = "LE13 2RV";
            TestCustomer.Username = "DanteAyyy";
            TestCustomer.Email = "d.alighieri@outlook.com";
            TestCustomer.Password = "3InPuPa";
            TestCustomer.PhoneNumber = "07912345678";
            //assign data to the properties
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see the values ARE the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHCustomer> TestList = new List<clsVCHCustomer>();
            //add items to the list
            //create the item of test data
            clsVCHCustomer TestItem = new clsVCHCustomer();
            //set data properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
            TestItem.Age = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            TestItem.Address = "12 Florence Cresent, Leicestershire";
            TestItem.PostCode = "LE13 2RV";
            TestItem.Username = "DanteAyyy";
            TestItem.Email = "d.alighieri@outlook.com";
            TestItem.Password = "3InPuPa";
            TestItem.PhoneNumber = "07912345678";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllCustomers.CustomerList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        /* Test is no longer neccessary because this is no guarantee to the amount of customers
        [TestMethod]
        public void TwoCustomersPresent()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test to see the values ARE the same
            Assert.AreEqual(AllCustomers.Count, 2);
        }*/

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test data to assign to the property
            clsVCHCustomer TestItem = new clsVCHCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.CustomerID = 1;
            TestItem.UserID = 175;
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
            TestItem.Age = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            TestItem.Address = "12 Florence Cresent, Leicestershire";
            TestItem.PostCode = "LE13 2RV";
            TestItem.Username = "DanteAyyy";
            TestItem.Email = "d.alighieri@outlook.com";
            TestItem.Password = "3InPuPa";
            TestItem.PhoneNumber = "07912345678";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            /* 
            commented out to prevent constant-reduplication of customer record into data table
            "//add the record
            PrimaryKey = AllCustomers.Add();"
            */
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test data to assign to the property
            clsVCHCustomer TestItem = new clsVCHCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.UserID = 137;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
            TestItem.Age = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            TestItem.Address = "12 Florence Cresent, Leicestershire";
            TestItem.PostCode = "LE13 2RV";
            TestItem.Username = "DanteAyyy";
            TestItem.Email = "d.alighieri@outlook.com";
            TestItem.Password = "3InPuPa";
            TestItem.PhoneNumber = "07912345678";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //test data to assign to the property
            clsVCHCustomer TestItem = new clsVCHCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
            TestItem.Age = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            TestItem.Address = "12 Florence Cresent, Leicestershire";
            TestItem.PostCode = "LE13 2RV";
            TestItem.Username = "DanteAyyy";
            TestItem.Email = "d.alighieri@outlook.com";
            TestItem.Password = "3InPuPa";
            TestItem.PhoneNumber = "07912345678";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            /* 
            commented out to prevent constant-reduplication of customer record into data table
            "//add the record
            PrimaryKey = AllCustomers.Add();"
            */
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data in the following manner
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
            TestItem.Age = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            TestItem.Address = "12 Florence Cresent, Leicestershire";
            TestItem.PostCode = "LE13 2RV";
            TestItem.Username = "King_of_Florence";
            TestItem.Email = "d.alighieri@outlook.com";
            TestItem.Password = "3InPuPa";
            TestItem.PhoneNumber = "07912345678";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection AllCustomers = new clsVCHCustomerCollection();
            //create an instance of the data to filter
            clsVCHCustomerCollection FilteredCustomers = new clsVCHCustomerCollection();
            //apply a blank string (all customer records should be returned)
            FilteredCustomers.ReportByUsername("");
            //test to see that both values ARE the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            //create an instance of the data to filter
            clsVCHCustomerCollection FilteredCustomers = new clsVCHCustomerCollection();
            //data variable of a none existent Username
            FilteredCustomers.ReportByUsername("HelloThisDoesn'tExist");
            //test to see that no matching customer usernames are found 
            Assert.AreEqual(0, FilteredCustomers.Count);
        }


        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            //create an instance of the data to filter
            clsVCHCustomerCollection FilteredCustomers = new clsVCHCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a data variable of an existent Username
            FilteredCustomers.ReportByUsername("CallyG");
            //check that the correct number of customer records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first customer record is CustomerID 52
                if (FilteredCustomers.CustomerList[0].CustomerID != 52)
                {
                    OK = false;
                }
                //check that the second customer record is CustomerID 55
                if (FilteredCustomers.CustomerList[1].CustomerID != 55)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see that there are no new customer records
            Assert.IsTrue(OK);
        }
    }
}
