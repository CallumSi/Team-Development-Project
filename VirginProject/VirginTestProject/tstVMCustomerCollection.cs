using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMCustomerCollection
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the customer collection class
            clsVMCustomerCollection allCustomers = new clsVMCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(allCustomers);
        }

        [TestMethod]
        public void VMCustomerListOK()
        {
            //create an instance of the customer collection class 
            clsVMCustomerCollection allCustomers = new clsVMCustomerCollection();
            //create a list of object to assign to the property
            List<clsVMCustomer> TestList = new List<clsVMCustomer>();
            //create the item of test data
            clsVMCustomer TestItem = new clsVMCustomer();
            //set its properties
            TestItem.VMCustomerID = 1;
            TestItem.VMcustomerFirstName = "Paul";
            TestItem.VMcustomerLastName = "Pogba";
            TestItem.VMcustomerEmail = "PPogba6@hotmail.co.uk";
            TestItem.VMcustomerUsername = "MUFCForever";
            TestItem.VMcustomerPassword = "PaulPogba6";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the clsVMCustomerCollection class
            clsVMCustomerCollection allCustomers = new clsVMCustomerCollection();
            //create some test data to assign to the property
            clsVMCustomer TestCustomer = new clsVMCustomer();
            //set the properties of the test object
            TestCustomer.VMCustomerID = 2;
            TestCustomer.VMcustomerFirstName = "Sufiyaan";
            TestCustomer.VMcustomerLastName = "Hussain";
            TestCustomer.VMcustomerEmail = "SufiyaanHussain@yahoo.com";
            TestCustomer.VMcustomerUsername = "SufiyaanHussain97";
            TestCustomer.VMcustomerPassword = "ManUtd97";
            //assign the data to the property
            allCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(allCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the clsVMCustomerCollection class
            clsVMCustomerCollection allCustomers = new clsVMCustomerCollection();
            //in this case the data needs to be a list of objects
            List<clsVMCustomer> TestList = new List<clsVMCustomer>();
            //add an item to the list
            //create the item of test data
            clsVMCustomer TestItem = new clsVMCustomer();
            //set the properties of the test object
            TestItem.VMcustomerFirstName = "Sufiyaan";
            TestItem.VMcustomerLastName = "Hussain";
            TestItem.VMcustomerEmail = "SufiyaanHussain@yahoo.com";
            TestItem.VMcustomerUsername = "SufiyaanHussain97";
            TestItem.VMcustomerPassword = "ManUtd97";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the clsVMCustomerCollection class
            clsVMCustomerCollection allCustomers = new clsVMCustomerCollection();
            //create the item of test data
            clsVMCustomer TestItem = new clsVMCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMcustomerFirstName = "Hussain";
            TestItem.VMcustomerLastName = "Sufiyaan";
            TestItem.VMcustomerEmail = "SufiyaanHussain@yahoo.com";
            TestItem.VMcustomerUsername = "SufiyaanHussain97";
            TestItem.VMcustomerPassword = "ManUtd97";
            //set ThisCustomer to the test data
            allCustomers.ThisCustomer = TestItem;
            //add the record
            //PrimaryKey = allCustomers.Add();
            //Set the primary key of the test data
            TestItem.VMCustomerID = PrimaryKey;
            //find the record
            allCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the clsVMCustomerCollection class
            clsVMCustomerCollection allCustomers = new clsVMCustomerCollection();
            //create the item of test data
            clsVMCustomer TestItem = new clsVMCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMcustomerFirstName = "Hussain";
            TestItem.VMcustomerLastName = "Sufiyaan";
            TestItem.VMcustomerEmail = "SufiyaanHussain@yahoo.com";
            TestItem.VMcustomerUsername = "SufiyaanHussain97";
            TestItem.VMcustomerPassword = "ManUtd97";
            //set ThisCustomer to the test data
            allCustomers.ThisCustomer = TestItem;
            //add the record
            //PrimaryKey = allCustomers.Add();
            //Set the primary key of the test data
            TestItem.VMCustomerID = PrimaryKey;
            //mdoify the record
            TestItem.VMcustomerFirstName = "Cristiano";
            TestItem.VMcustomerLastName = "Romaldo";
            TestItem.VMcustomerEmail = "RonnieGoat@hotmail.co.uk";
            TestItem.VMcustomerUsername = "CR7United";
            TestItem.VMcustomerPassword = "Ronaldo123";
            //set the record based on the new test data
            allCustomers.ThisCustomer = TestItem;
            //Update the record
            allCustomers.Update();
            //find the record
            allCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the clsVMCustomerCollection class
            clsVMCustomerCollection allCustomers = new clsVMCustomerCollection();
            //create the item of test data
            clsVMCustomer TestItem = new clsVMCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.VMCustomerID = 8;
            TestItem.VMcustomerFirstName = "Sufiyaan";
            TestItem.VMcustomerLastName = "Hussain";
            TestItem.VMcustomerEmail = "SufiyaanHussain@yahoo.com";
            TestItem.VMcustomerUsername = "SufiyaanHussain97";
            TestItem.VMcustomerPassword = "ManUtd97";
            //set ThisCustomer to the test data
            allCustomers.ThisCustomer = TestItem;
            //add the record
            //PrimaryKey = allCustomers.Add();
            //set the primary key of the test data
            TestItem.VMCustomerID = PrimaryKey;
            //find the record
            allCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            allCustomers.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(allCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            //create an instance of the clsVMCustomerCollection class
            clsVMCustomerCollection AllCustomers = new clsVMCustomerCollection();
            // create an instance of the filtered data
            clsVMCustomerCollection FilteredVMCUsernames = new clsVMCustomerCollection();
            //apply a blank string (should return all records)
            FilteredVMCUsernames.FilterByUsername("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredVMCUsernames.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            // create an instance of the filtered data
            clsVMCustomerCollection FilteredVMCUsernames = new clsVMCustomerCollection();
            //apply a username that doesnt exist
            FilteredVMCUsernames.FilterByUsername("Hello");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredVMCUsernames.Count);
        }

        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            // create an instance of the filtered data
            clsVMCustomerCollection FilteredVMCUsernames = new clsVMCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a username that does exist
            FilteredVMCUsernames.FilterByUsername("LaPoiche");
            //check that the correct number of records are found
            if (FilteredVMCUsernames.Count == 2)
            {
                //check that the first record is ID 80
                if (FilteredVMCUsernames.CustomerList[0].VMCustomerID != 80)
                {
                    OK = false;
                }
                //check that the first record is ID 82
                if (FilteredVMCUsernames.CustomerList[1].VMCustomerID != 82)
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
