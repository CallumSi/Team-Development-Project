using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMPaymentCollection
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection allPayment = new clsVMPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(allPayment);
        }

        [TestMethod]
        public void VMPaymentListOK()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection allPayment = new clsVMPaymentCollection();
            //create a list of object to assign to the property
            List<clsVMPayment> TestList = new List<clsVMPayment>();
            //create the item of test data
            clsVMPayment TestItem = new clsVMPayment();
            //set its properties
            TestItem.VMPaymentID = 1;
            TestItem.VMPaymentStatus = true;
            TestItem.VMPaymentType = "Paypal";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allPayment.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allPayment.PaymentList, TestList);
        }
        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection allPayment = new clsVMPaymentCollection();
            //create some test data to assign to the property
            clsVMPayment TestPayment = new clsVMPayment();
            //set its properties
            TestPayment.VMPaymentID = 1;
            TestPayment.VMPaymentStatus = true;
            TestPayment.VMPaymentType = "Paypal";
            //assign the data to the property
            allPayment.ThisPayment = TestPayment;
            //test to see that the two values are the same
            Assert.AreEqual(allPayment.ThisPayment, TestPayment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection allPayment = new clsVMPaymentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsVMPayment> TestList = new List<clsVMPayment>();
            //add an item to the list
            //create the item of test data
            clsVMPayment TestItem = new clsVMPayment();
            //set its properties
            TestItem.VMPaymentID = 1;
            TestItem.VMPaymentStatus = true;
            TestItem.VMPaymentType = "Paypal";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allPayment.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allPayment.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection allPayment = new clsVMPaymentCollection();
            //create the item of test data
            clsVMPayment TestItem = new clsVMPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMPaymentStatus = true;
            TestItem.VMPaymentType = "Paypal";
            //set ThisCustomer to the test data
            allPayment.ThisPayment = TestItem;
            //add the record
            //PrimaryKey = allPayment.Add();
            //Set the primary key of the test data
            TestItem.VMPaymentID = PrimaryKey;
            //find the record
            allPayment.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allPayment.ThisPayment, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection allPayment = new clsVMPaymentCollection();
            //create the item of test data
            clsVMPayment TestItem = new clsVMPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMPaymentStatus = true;
            TestItem.VMPaymentType = "Paypal";
            //set ThisCustomer to the test data
            allPayment.ThisPayment = TestItem;
            //add the record
            //PrimaryKey = allPayment.Add();
            //Set the primary key of the test data
            TestItem.VMPaymentID = PrimaryKey;
            //modify the record
            TestItem.VMPaymentStatus = true;
            TestItem.VMPaymentType = "Debit Card";
            //set the record based on the new test data
            allPayment.ThisPayment = TestItem;
            //Update the record
            allPayment.Update();
            //find the record
            allPayment.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allPayment.ThisPayment, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection allPayment = new clsVMPaymentCollection();
            //create the item of test data
            clsVMPayment TestItem = new clsVMPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMPaymentID = 3;
            TestItem.VMPaymentStatus = true;
            TestItem.VMPaymentType = "Debit Payment";
            //set ThisCustomer to the test data
            allPayment.ThisPayment = TestItem;
            //add the record
            //PrimaryKey = allPayment.Add();
            //set the primary key of the test data
            TestItem.VMPaymentID = PrimaryKey;
            //find the record
            allPayment.ThisPayment.Find(PrimaryKey);
            //delete the record
            allPayment.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(allPayment.ThisPayment, TestItem);
        }
    }
}
