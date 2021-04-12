﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

    [TestClass]
    public class tstVPCartCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCart);
        }

        [TestMethod]
        public void VPCartListOK()
        {
            //create an instance of the class we want to create
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //create some test data to assign to the property
            //in this case the data needs be a list of objects 
            List<clsVPCart> TestList = new List<clsVPCart>();
            //add an item to the list 
            //create the item of test data
            clsVPCart TestItem = new clsVPCart();
            //set its properties
            TestItem.CartNo = 1;
            TestItem.Products = "iPhone 12 Pro Max";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCart.CartList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllCart.CartList, TestList);

        }

        [TestMethod]
        public void ThisCartPropertyOK()
        {
            //create an instance of the class we want to create
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //create some test data to assign to the property 
            clsVPCart TestCart = new clsVPCart();
            //set the properties of the test object
            TestCart.CartNo = 1;
            TestCart.Products = "iPhone 12 Pro Max";
            //assign the data to the property 
            AllCart.ThisCart = TestCart;
            //test to see that thr two values are the same
            Assert.AreEqual(AllCart.ThisCart, TestCart);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsVPCart> TestList = new List<clsVPCart>();
            //add an item to the list
            //create the item of the test data 
            clsVPCart TestItem = new clsVPCart();
            //set it's properties
            TestItem.CartNo = 1;
            TestItem.Products = "iPhone 12 Pro Max";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCart.CartList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllCart.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //create the item of test data 
            clsVPCart TestItem = new clsVPCart();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.CartNo = 1;
            TestItem.Products = "iPhone 12 Pro Max";
            //set ThisStaff to the test data 
            AllCart.ThisCart = TestItem;
            //add the record
            PrimaryKey = AllCart.Add();
            //set the primary key of the test data 
            TestItem.CartNo = PrimaryKey;
            //find the record
            AllCart.ThisCart.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCart.ThisCart, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //create the item of the test data 
            clsVPCart TestItem = new clsVPCart();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CartNo = 1;
            TestItem.Products = "iPhone 12 Pro Max";
            //set ThisCart to the test data 
            AllCart.ThisCart = TestItem;
            //add the record
            PrimaryKey = AllCart.Add();
            //set the primary key of the test data 
            TestItem.CartNo = PrimaryKey;
            //modify the test data
            TestItem.CartNo = 1;
            TestItem.Products = "Huawei 450 Mini";
            //set the record based on the new test data
            AllCart.ThisCart = TestItem;
            //update the record
            AllCart.Update();
            //find the record
            AllCart.ThisCart.Find(PrimaryKey);
            //test to see ThisCart matches he test data
            Assert.AreEqual(AllCart.ThisCart, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //create the item of test data 
            clsVPCart TestItem = new clsVPCart();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.CartNo = 1;
            TestItem.Products = "iPhone 12 Pro Max";
            //set ThisStaff to the test data 
            AllCart.ThisCart = TestItem;
            //add the record
            PrimaryKey = AllCart.Add();
            //set the primary key of the test data 
            TestItem.CartNo = PrimaryKey;
            //find the record
            AllCart.ThisCart.Find(PrimaryKey);
            //delete the record
            AllCart.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllCart.ThisCart, TestItem);
        }


        [TestMethod]
        public void ReportByProductsMethod()
        {
            //create an instance of the filtered data
            clsVPCartCollection AllCart = new clsVPCartCollection();
            //create an instance of the filtered data 
            clsVPCartCollection FilteredProducts = new clsVPCartCollection();
            //apply a blank string (should return all records)
            FilteredProducts.FilterByProducts("");
            //test to see that two values are the same 
            Assert.AreEqual(AllCart.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByProductsNoneFound()
        {
            //create an instance of the filtered data
            clsVPCartCollection FilteredProducts = new clsVPCartCollection();
            //apply a product that doesnt exists
            FilteredProducts.FilterByProducts("Nokia 900 RM");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredProducts.Count);

        }

        [TestMethod]
        public void ReportByProductsTestDataFound()
        {
            //create an instance of the filtered data
            clsVPCartCollection FilteredProducts = new clsVPCartCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a product that doesn't exists 
            FilteredProducts.FilterByProducts("Alcatel D450");
            //check that the correct number of records are found 
            if (FilteredProducts.Count == 2)
            {
                //check to see the first record ID is 1
                if (FilteredProducts.CartList[0].CartNo != 1)
                {
                    OK = false;
                }

                //check that the last record ID is 2 
                if (FilteredProducts.CartList[1].CartNo != 2)
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
