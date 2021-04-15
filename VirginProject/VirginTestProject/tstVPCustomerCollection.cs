using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPCustomerCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void VPCustomerListOK()
        {
            //create an instance of the class we want to create
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs be a list of objects 
            List<clsVPCustomer> TestList = new List<clsVPCustomer>();
            //add an item to the list 
            //create the item of test data
            clsVPCustomer TestItem = new clsVPCustomer();
            //set its properties
            TestItem.Customer_ID = 1;
            TestItem.Customer_FirstName = "Jane";
            TestItem.Customer_LastName = "Doe";
            TestItem.Customer_Street = "Western Road";
            TestItem.Customer_Address = "42D Western Road, Leicester";
            TestItem.Customer_Postcode = "LE3 0BJ";
            TestItem.Customer_Email = "JaneDoe123@hotmail.com";
            TestItem.Customer_Telephone = "12345678901";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCustomer.CustomerList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);

        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //create some test data to assign to the property 
            clsVPCustomer TestCustomer = new clsVPCustomer();
            //set the properties of the test object
            TestCustomer.Customer_ID = 1;
            TestCustomer.Customer_FirstName = "Jane";
            TestCustomer.Customer_LastName = "Doe";
            TestCustomer.Customer_Street = "Western Road";
            TestCustomer.Customer_Address = "42 Western Road, Leicester";
            TestCustomer.Customer_Postcode = "LE3 0BJ";
            TestCustomer.Customer_Email = "JaneDoe123@hotmail.com";
            TestCustomer.Customer_Telephone = "12345678901";
            //assign the data to the property 
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsVPCustomer> TestList = new List<clsVPCustomer>();
            //add an item to the list
            //create the item of the test data 
            clsVPCustomer TestItem = new clsVPCustomer();
            //set it's properties
            TestItem.Customer_ID = 1;
            TestItem.Customer_FirstName = "Jane";
            TestItem.Customer_LastName = "Doe";
            TestItem.Customer_Street = "Western Road";
            TestItem.Customer_Address = "42 Western Road, Leicester";
            TestItem.Customer_Postcode = "LE3 0BJ";
            TestItem.Customer_Email = "JaneDoe123@hotmail.com";
            TestItem.Customer_Telephone = "12345678901";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCustomer.CustomerList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllCustomer.Count, TestList.Count);

        }


        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //create the item of test data 
            clsVPCustomer TestItem = new clsVPCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Customer_ID = 1;
            TestItem.Customer_FirstName = "Jane";
            TestItem.Customer_LastName = "Doe";
            TestItem.Customer_Street = "Western Road";
            TestItem.Customer_Address = "42 Western Road,Leicester";
            TestItem.Customer_Postcode = "LE3 0BJ";
            TestItem.Customer_Email = "JaneDoe123@hotmail.com";
            TestItem.Customer_Telephone = "12345678901";
            //set ThisCustomer to the test data 
            AllCustomer.ThisCustomer = TestItem;
            /* 
            commented out to prevent constant-reduplication of customer record into data table
            "//add the record
            PrimaryKey = AllCustomer.Add();" 
            */
            //set the primary key of the test data 
            TestItem.Customer_ID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //create the item of the test data 
            clsVPCustomer TestItem = new clsVPCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Customer_ID = 1;
            TestItem.Customer_FirstName = "Jane";
            TestItem.Customer_LastName = "Doe";
            TestItem.Customer_Street = "Western Road";
            TestItem.Customer_Address = "42 Western Road, Leicester";
            TestItem.Customer_Postcode = "LE3 0BJ";
            TestItem.Customer_Email = "JaneDoe123@hotmail.com";
            TestItem.Customer_Telephone = "12345678901";
            //set ThisCustomer to the test data 
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data 
            TestItem.Customer_ID = PrimaryKey;
            //modify the test data
            TestItem.Customer_ID = 1;
            TestItem.Customer_FirstName = "King";
            TestItem.Customer_LastName = "Kong";
            TestItem.Customer_Street = "Forest Drive";
            TestItem.Customer_Address = "15 Forest Drive, Virginia Water";
            TestItem.Customer_Postcode = " VW1 5AZ";
            TestItem.Customer_Email = "KingKong@gmail.com";
            TestItem.Customer_Telephone = "23456789012";
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see ThisStaff matches he test data
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);

        }


        [TestMethod]
        public void DeleteMethod()
        {
            //create an instance of the class we want to create
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //create the item of test data 
            clsVPCustomer TestItem = new clsVPCustomer();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Customer_ID = 1;
            TestItem.Customer_FirstName = "Jane";
            TestItem.Customer_LastName = "Doe";
            TestItem.Customer_Street = "Western Road";
            TestItem.Customer_Address = "42 Western Road, Leicester";
            TestItem.Customer_Postcode = "LE3 0BJ";
            TestItem.Customer_Email = "JaneDoe123@hotmail.com";
            TestItem.Customer_Telephone = "12345678901";
            //set ThisCustomer to the test data 
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data 
            TestItem.Customer_ID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomer.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByFirstNameMethod()
        {
            //create an instance of the filtered data
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //create an instance of the filtered data 
            clsVPCustomerCollection FilteredFirstName = new clsVPCustomerCollection();
            //apply a blank string (should return all records)
            FilteredFirstName.FilterByCustomerFirstName("");
            //test to see that two values are the same 
            Assert.AreEqual(AllCustomer.Count, FilteredFirstName.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsVPCustomerCollection FilteredFirstName = new clsVPCustomerCollection();
            //apply a first name that doesnt exists
            FilteredFirstName.FilterByCustomerFirstName("Edward");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredFirstName.Count);

        }


        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsVPCustomerCollection FilteredFirstName = new clsVPCustomerCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a first name that doesn't exists 
            FilteredFirstName.FilterByCustomerFirstName("Meera");
            //check that the correct number of records are found 
            if (FilteredFirstName.Count == 2)
            {
                //check to see the first record ID is 1
                if (FilteredFirstName.CustomerList[0].Customer_ID != 4)
                {
                    OK = false;
                }

                //check that the last record ID is 3 
                if (FilteredFirstName.CustomerList[1].Customer_ID != 5)
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
