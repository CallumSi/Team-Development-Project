using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPPaymentCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsVPPaymentCollection AllPayment = new clsVPPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayment);
        }

        [TestMethod]
        public void VPPaymentListOK()
        {
            //create an instance of the class we want to create
            clsVPPaymentCollection AllPayment = new clsVPPaymentCollection();
            //create some test data to assign to the property
            //in this case the data needs be a list of objects 
            List<clsVPPayment> TestList = new List<clsVPPayment>();
            //add an item to the list 
            //create the item of test data
            clsVPPayment TestItem = new clsVPPayment();
            //set its properties
            TestItem.Payment_ID = 1;
            TestItem.CardNo = 0000000000000000;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.SecurityNo = 999;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllPayment.PaymentList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllPayment.PaymentList, TestList);

        }

        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsVPPaymentCollection AllPayment = new clsVPPaymentCollection();
            //create some test data to assign to the property 
            clsVPPayment TestPayment = new clsVPPayment();
            //set the properties of the test object
            TestPayment.Payment_ID = 1;
            TestPayment.CardNo = 0000000000000000;
            TestPayment.ExpiryDate = DateTime.Now.Date;
            TestPayment.SecurityNo = 999;
            //assign the data to the property 
            AllPayment.ThisPayment = TestPayment;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayment.ThisPayment, TestPayment);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsVPPaymentCollection AllPayment = new clsVPPaymentCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsVPPayment> TestList = new List<clsVPPayment>();
            //add an item to the list
            //create the item of the test data 
            clsVPPayment TestItem = new clsVPPayment();
            //set it's properties
            TestItem.Payment_ID = 1;
            TestItem.CardNo = 0000000000000000;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.SecurityNo = 999;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllPayment.PaymentList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllPayment.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsVPPaymentCollection AllPayment = new clsVPPaymentCollection();
            //create the item of test data 
            clsVPPayment TestItem = new clsVPPayment();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Payment_ID = 1;
            TestItem.CardNo = 0000000000000000;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.SecurityNo = 999;
            //set ThisPayment to the test data 
            AllPayment.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayment.Add();
            //set the primary key of the test data 
            TestItem.Payment_ID = PrimaryKey;
            //find the record
            AllPayment.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPayment.ThisPayment, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsVPPaymentCollection AllPayment = new clsVPPaymentCollection();
            //create the item of the test data 
            clsVPPayment TestItem = new clsVPPayment();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CardNo = 0000000000000000;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.SecurityNo = 999;
            //set ThisPayment to the test data 
            AllPayment.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayment.Add();
            //set the primary key of the test data 
            TestItem.Payment_ID = PrimaryKey;
            //modify the test data
            TestItem.Payment_ID = 1;
            TestItem.CardNo = 0000000000000000;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.SecurityNo = 888;
            //set the record based on the new test data
            AllPayment.ThisPayment = TestItem;
            //update the record
            AllPayment.Update();
            //find the record
            AllPayment.ThisPayment.Find(PrimaryKey);
            //test to see ThisPhone matches he test data
            Assert.AreEqual(AllPayment.ThisPayment, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsVPPaymentCollection AllPayment = new clsVPPaymentCollection();
            //create the item of test data 
            clsVPPayment TestItem = new clsVPPayment();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Payment_ID = 1;
            TestItem.CardNo = 0000000000000000;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.SecurityNo = 999;
            //set ThisPayment to the test data 
            AllPayment.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayment.Add();
            //set the primary key of the test data 
            TestItem.Payment_ID = PrimaryKey;
            //find the record
            AllPayment.ThisPayment.Find(PrimaryKey);
            //delete the record 
            AllPayment.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllPayment.ThisPayment, TestItem);
        }

    }
}
