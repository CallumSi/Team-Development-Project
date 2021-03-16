using System;
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
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
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
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dante";
            TestItem.LastName = "Alighieri";
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
    }
}
