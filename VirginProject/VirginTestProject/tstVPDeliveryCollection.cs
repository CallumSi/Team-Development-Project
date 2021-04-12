using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPDeliveryCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //test to see that it exists
            Assert.IsNotNull(AllDelivery);
        }

        [TestMethod]
        public void VPDeliveryListOK()
        {
            //create an instance of the class we want to create
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //create some test data to assign to the property
            //in this case the data needs be a list of objects 
            List<clsVPDelivery> TestList = new List<clsVPDelivery>();
            //add an item to the list 
            //create the item of test data
            clsVPDelivery TestItem = new clsVPDelivery();
            //set its properties
            TestItem.Delivery_ID = 1;
            TestItem.Order_ID = 2222;
            TestItem.Title = "Miss";
            TestItem.FirstName = "Sienna";
            TestItem.LastName = "Campbell";
            TestItem.House_No = 31;
            TestItem.Delivery_Address = "31 Camp Road, Buckinghamshire";
            TestItem.Delivery_Postcode = "SL9 7PG";
            TestItem.Delivery_Date = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllDelivery.DeliveryList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllDelivery.DeliveryList, TestList);

        }


        [TestMethod]
        public void ThisDeliveryPropertyOK()
        {
            //create an instance of the class we want to create
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //create some test data to assign to the property 
            clsVPDelivery TestDelivery = new clsVPDelivery();
            //set the properties of the test object
            TestDelivery.Delivery_ID = 1;
            TestDelivery.Order_ID = 2222;
            TestDelivery.Title = "Miss";
            TestDelivery.FirstName = "Sienna";
            TestDelivery.LastName = "Campbell";
            TestDelivery.House_No = 31;
            TestDelivery.Delivery_Address = "31 Camp Road, Buckinghamshire";
            TestDelivery.Delivery_Postcode = "SL9 7PG";
            TestDelivery.Delivery_Date = DateTime.Now.Date;
            //assign the data to the property 
            AllDelivery.ThisDelivery = TestDelivery;
            //test to see that the two values are the same
            Assert.AreEqual(AllDelivery.ThisDelivery, TestDelivery);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsVPDelivery> TestList = new List<clsVPDelivery>();
            //add an item to the list
            //create the item of the test data 
            clsVPDelivery TestItem = new clsVPDelivery();
            //set it's properties
            TestItem.Delivery_ID = 1;
            TestItem.Order_ID = 2222;
            TestItem.Title = "Miss";
            TestItem.FirstName = "Sienna";
            TestItem.LastName = "Campbell";
            TestItem.House_No = 31;
            TestItem.Delivery_Address = "31 Camp Road, Buckinghamshire";
            TestItem.Delivery_Postcode = "SL9 7PG";
            TestItem.Delivery_Date = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllDelivery.DeliveryList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllDelivery.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //create the item of test data 
            clsVPDelivery TestItem = new clsVPDelivery();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Delivery_ID = 1;
            TestItem.Order_ID = 2222;
            TestItem.Title = "Miss";
            TestItem.FirstName = "Sienna";
            TestItem.LastName = "Campbell";
            TestItem.House_No = 31;
            TestItem.Delivery_Address = "31 Camp Road, Buckinghamshire";
            TestItem.Delivery_Postcode = "SL9 7PG";
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set ThisDelivery to the test data 
            AllDelivery.ThisDelivery = TestItem;
            //add the record
            PrimaryKey = AllDelivery.Add();
            //set the primary key of the test data 
            TestItem.Delivery_ID = PrimaryKey;
            //find the record
            AllDelivery.ThisDelivery.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDelivery.ThisDelivery, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //create the item of the test data 
            clsVPDelivery TestItem = new clsVPDelivery();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Delivery_ID = 1;
            TestItem.Order_ID = 2222;
            TestItem.Title = "Miss";
            TestItem.FirstName = "Sienna";
            TestItem.LastName = "Campbell";
            TestItem.House_No = 31;
            TestItem.Delivery_Address = "31 Camp Road, Buckinghamshire";
            TestItem.Delivery_Postcode = "SL9 7PG";
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set ThisDelivery to the test data 
            AllDelivery.ThisDelivery = TestItem;
            //add the record
            PrimaryKey = AllDelivery.Add();
            //set the primary key of the test data 
            TestItem.Delivery_ID = PrimaryKey;
            //modify the test data
            TestItem.Delivery_ID = 1;
            TestItem.Order_ID = 2222;
            TestItem.Title = "Mr";
            TestItem.FirstName = "James";
            TestItem.LastName = "Bond";
            TestItem.House_No = 69;
            TestItem.Delivery_Address = "69 Gateway House, Manchester";
            TestItem.Delivery_Postcode = "MCR 9GH";
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set the record based on the new test data
            AllDelivery.ThisDelivery = TestItem;
            //update the record
            AllDelivery.Update();
            //find the record
            AllDelivery.ThisDelivery.Find(PrimaryKey);
            //test to see ThisDelivery matches he test data
            Assert.AreEqual(AllDelivery.ThisDelivery, TestItem);

        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //create the item of test data 
            clsVPDelivery TestItem = new clsVPDelivery();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Delivery_ID = 1;
            TestItem.Order_ID = 2222;
            TestItem.Title = "Miss";
            TestItem.FirstName = "Sienna";
            TestItem.LastName = "Campbell";
            TestItem.House_No = 31;
            TestItem.Delivery_Address = "31 Camp Road, Buckinghamshire";
            TestItem.Delivery_Postcode = "SL9 7PG";
            TestItem.Delivery_Date = DateTime.Now.Date;
            //set ThisDelivery to the test data 
            AllDelivery.ThisDelivery = TestItem;
            //add the record
            PrimaryKey = AllDelivery.Add();
            //set the primary key of the test data 
            TestItem.Delivery_ID = PrimaryKey;
            //find the record
            AllDelivery.ThisDelivery.Find(PrimaryKey);
            //delete the record
            AllDelivery.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllDelivery.ThisDelivery, TestItem);
        }

        [TestMethod]
        public void ReportByDeliveryDateMethod()
        {
            //create an instance of the filtered data
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //create an instance of the filtered data 
            clsVPDeliveryCollection FilteredDeliveryDate = new clsVPDeliveryCollection ();
            //apply a blank string (should return all records)
            FilteredDeliveryDate.FilterByDeliveryDate(Convert.ToDateTime("12/04/2021"));
            //test to see that two values are the same 
            Assert.AreEqual(AllDelivery.Count, FilteredDeliveryDate.Count);
        }

        [TestMethod]
        public void ReportByDeliveryDateNoneFound()
        {
            //create an instance of the filtered data
            clsVPDeliveryCollection FilteredDeliveryDate = new clsVPDeliveryCollection();
            //apply a delivery date that doesnt exists
            FilteredDeliveryDate.FilterByDeliveryDate(Convert.ToDateTime("25/12/2021"));
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredDeliveryDate.Count);

        }

        [TestMethod]
        public void ReportByDeliveryDateTestDataFound()
        {
            //create an instance of the filtered data
            clsVPDeliveryCollection FilteredDeliveryDate = new clsVPDeliveryCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a deliverydate that doesn't exists 
            FilteredDeliveryDate.FilterByDeliveryDate(Convert.ToDateTime("16/05/2021"));
            //check that the correct number of records are found 
            if (FilteredDeliveryDate.Count == 2)
            {
                //check to see the first record ID is 1
                if (FilteredDeliveryDate.DeliveryList[0].Delivery_ID != 1)
                {
                    OK = false;
                }

                //check that the last record ID is 2 
                if (FilteredDeliveryDate.DeliveryList[1].Delivery_ID != 2)
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
