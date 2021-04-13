using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPOrderCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsVPOrderCollection AllOrder = new clsVPOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }


        [TestMethod]
        public void VPOrderListOK()
        {
            //create an instance of the class we want to create
            clsVPOrderCollection AllOrder = new clsVPOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs be a list of objects 
            List<clsVPOrder> TestList = new List<clsVPOrder>();
            //add an item to the list 
            //create the item of test data
            clsVPOrder TestItem = new clsVPOrder();
            //set its properties
            TestItem.Order_ID = 1;
            TestItem.Customer_ID = 1;
            TestItem.Delivery_Date = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrder.OrderList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);

        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsVPOrderCollection AllOrder = new clsVPOrderCollection();
            //create some test data to assign to the property 
            clsVPOrder TestOrder = new clsVPOrder();
            //set the properties of the test object
            TestOrder.Order_ID = 1;
            TestOrder.Customer_ID = 1;
            TestOrder.Delivery_Date = DateTime.Now.Date;
            //assign the data to the property 
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsVPOrderCollection AllOrder = new clsVPOrderCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsVPOrder> TestList = new List<clsVPOrder>();
            //add an item to the list
            //create the item of the test data 
            clsVPOrder TestItem = new clsVPOrder();
            //set it's properties
            TestItem.Order_ID = 1;
            TestItem.Customer_ID = 1;
            TestItem.Delivery_Date = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrder.OrderList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllOrder.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsVPOrderCollection AllOrder = new clsVPOrderCollection();
            //create the item of test data 
            clsVPOrder TestItem = new clsVPOrder();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.Customer_ID = 1;
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set ThisOrder to the test data 
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data 
            TestItem.Order_ID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsVPOrderCollection AllOrder = new clsVPOrderCollection();
            //create the item of test data 
            clsVPOrder TestItem = new clsVPOrder();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.Customer_ID = 1;
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set ThisOrder to the test data 
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data 
            TestItem.Order_ID = PrimaryKey;
            //modify the test data
            TestItem.Order_ID = 2;
            TestItem.Customer_ID = 2;
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set the record based on the new test data 
            AllOrder.ThisOrder = TestItem;
            //update the record
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsVPOrderCollection AllOrder = new clsVPOrderCollection();
            //create the item of test data 
            clsVPOrder TestItem = new clsVPOrder();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Order_ID = 1;
            TestItem.Customer_ID = 1;
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set ThisOrder to the test data 
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data 
            TestItem.Order_ID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
    }
}
