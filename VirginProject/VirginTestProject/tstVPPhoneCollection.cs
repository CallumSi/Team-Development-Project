using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPPhoneCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPhone);
        }


        [TestMethod]
        public void VPPhoneListOK()
        {
            //create an instance of the class we want to create
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //create some test data to assign to the property
            //in this case the data needs be a list of objects 
            List<clsVPPhone> TestList = new List<clsVPPhone>();
            //add an item to the list 
            //create the item of test data
            clsVPPhone TestItem = new clsVPPhone();
            //set its properties
            TestItem.PhoneID = 1;
            TestItem.Capacity = "128GB";
            TestItem.Colour = "Blue";
            TestItem.Description = "New iPhone 12 Pro Max";
            TestItem.Make = "Apple";
            TestItem.Model = "12 Pro Max";
            TestItem.Price = 1250.00m;
            TestItem.StockStatus = true;
            TestItem.Quantity = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllPhone.PhoneList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllPhone.PhoneList, TestList);

        }

        [TestMethod]
        public void ThisPhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //create some test data to assign to the property
            clsVPPhone TestPhone = new clsVPPhone();
            //set its properties
            TestPhone.PhoneID = 1;
            TestPhone.Capacity = "128GB";
            TestPhone.Colour = "Blue";
            TestPhone.Description = "New iPhone 12 Pro Max";
            TestPhone.Make = "Apple";
            TestPhone.Model = "12 Pro Max";
            TestPhone.Price = 1250.00m;
            TestPhone.StockStatus = true;
            TestPhone.Quantity = 1;
            //assign the data to the property 
            AllPhone.ThisPhone = TestPhone;
            //test to see that two values are the same
            Assert.AreEqual(AllPhone.ThisPhone, TestPhone);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsVPPhone> TestList = new List<clsVPPhone>();
            //add an item to the list
            //create the item of the test data 
            clsVPPhone TestItem = new clsVPPhone();
            //set it's properties
            TestItem.PhoneID = 1;
            TestItem.Capacity = "128GB";
            TestItem.Colour = "Blue";
            TestItem.Description = "New iPhone 12 Pro Max";
            TestItem.Make = "Apple";
            TestItem.Model = "12 Pro Max";
            TestItem.Price = 1250.00m;
            TestItem.StockStatus = true;
            TestItem.Quantity = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllPhone.PhoneList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllPhone.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //create the item of test data 
            clsVPPhone TestItem = new clsVPPhone();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.PhoneID = 1;
            TestItem.Capacity = "128GB";
            TestItem.Colour = "Blue";
            TestItem.Description = "New iPhone 12 Pro Max";
            TestItem.Make = "Apple";
            TestItem.Model = "12 Pro Max";
            TestItem.Price = 1250.00m;
            TestItem.StockStatus = true;
            TestItem.Quantity = 1;
            //set ThisPhone to the test data 
            AllPhone.ThisPhone = TestItem;
            //add the record
            //PrimaryKey = AllPhone.Add();
            //set the primary key of the test data 
            TestItem.PhoneID = PrimaryKey;
            //find the record
            AllPhone.ThisPhone.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPhone.ThisPhone, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //create the item of the test data 
            clsVPPhone TestItem = new clsVPPhone();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PhoneID = 1;
            TestItem.Capacity = "128GB";
            TestItem.Colour = "Blue";
            TestItem.Description = "New iPhone 12 Pro Max";
            TestItem.Make = "Apple";
            TestItem.Model = "12 Pro Max";
            TestItem.Price = 1250.00m;
            TestItem.StockStatus = true;
            TestItem.Quantity = 1;
            //set ThisPhone to the test data 
            AllPhone.ThisPhone = TestItem;
            //add the record
            //PrimaryKey = AllPhone.Add();
            //set the primary key of the test data 
            TestItem.PhoneID = PrimaryKey;
            //modify the test data
            TestItem.PhoneID = 1;
            TestItem.Capacity = "250GB";
            TestItem.Colour = "Rose Gold";
            TestItem.Description = "New Samsung Galaxy Mini";
            TestItem.Make = "Samsung";
            TestItem.Model = "Galaxy Mini XC50";
            TestItem.Price = 1000.00m;
            TestItem.StockStatus = true;
            TestItem.Quantity = 2;
            //set the record based on the new test data
            AllPhone.ThisPhone = TestItem;
            //update the record
            AllPhone.Update();
            //find the record
            AllPhone.ThisPhone.Find(PrimaryKey);
            //test to see ThisPhone matches he test data
            Assert.AreEqual(AllPhone.ThisPhone, TestItem);

        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //create the item of test data 
            clsVPPhone TestItem = new clsVPPhone();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.PhoneID = 1;
            TestItem.Capacity = "128GB";
            TestItem.Colour = "Blue";
            TestItem.Description = "New iPhone 12 Pro Max";
            TestItem.Make = "Apple";
            TestItem.Model = "12 Pro Max";
            TestItem.Price = 1250.00m;
            TestItem.StockStatus = true;
            TestItem.Quantity = 1;
            //set ThisPhone to the test data 
            AllPhone.ThisPhone = TestItem;
            //add the record
            //PrimaryKey = AllPhone.Add();
            //set the primary key of the test data 
            TestItem.PhoneID = PrimaryKey;
            //find the record
            AllPhone.ThisPhone.Find(PrimaryKey);
            //delete the record 
            AllPhone.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllPhone.ThisPhone, TestItem);
        }


        [TestMethod]
        public void ReportByMakeMethod()
        {
            //create an instance of the filtered data
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //create an instance of the filtered data 
            clsVPPhoneCollection FilteredMake = new clsVPPhoneCollection();
            //apply a blank string (should return all records)
            FilteredMake.FilterByMake("");
            //test to see that two values are the same 
            Assert.AreEqual(AllPhone.Count, FilteredMake.Count);
        }

        [TestMethod]
        public void ReportByMakeNoneFound()
        {
            //create an instance of the filtered data
            clsVPPhoneCollection FilteredMake = new clsVPPhoneCollection();
            //apply a make that doesnt exists
            FilteredMake.FilterByMake("Huawei");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredMake.Count);

        }

        [TestMethod]
        public void ReportByMakeTestDataFound()
        {
            //create an instance of the filtered data
            clsVPPhoneCollection FilteredMake = new clsVPPhoneCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a make that doesn't exists 
            FilteredMake.FilterByMake("Google Pixel");
            //check that the correct number of records are found 
            if (FilteredMake.Count == 2)
            {
                //check to see the first record ID is 1
                if (FilteredMake.PhoneList[0].PhoneID != 3)
                {
                    OK = false;
                }

                //check that the last record ID is 2 
                if (FilteredMake.PhoneList[1].PhoneID != 8)
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
