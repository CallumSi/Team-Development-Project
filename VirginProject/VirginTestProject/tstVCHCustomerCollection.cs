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
        }

        [TestMethod]
        public void AllCustomersOK()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection Customers = new clsVCHCustomerCollection();
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
            Customers.AllCustomers = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(Customers.AllCustomers, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection Customers = new clsVCHCustomerCollection();
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
            Customers.AllCustomers = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(Customers.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoCustomersPresent()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection Customers = new clsVCHCustomerCollection();
            //test to see the values ARE the same
            Assert.AreEqual(Customers.Count, 2);
        }
    }
}
