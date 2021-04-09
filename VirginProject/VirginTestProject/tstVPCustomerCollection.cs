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

        //[TestMethod]
        //public void ThisCustomerPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsVPCustomerCollection AllStaff = new clsVPCustomerCollection();
        //    //create some test data to assign to the property 
        //    clsVPCustomer TestStaff = new clsVPCustomer();
        //    //set the properties of the test object
        //    TestStaff.Customer_ID = 1;
        //    TestStaff.Customer_FirstName = "John";
        //    TestStaff.Customer_LastName = "Smith";
        //    TestStaff.Customer_Street = "Fifth Avenue";
        //    TestStaff.Customer_Address = "103 Fifth Avenue,London";
        //    TestStaff.Customer_Postcode = "SW3 5SF";
        //    TestStaff.Customer_Email = "JohnSmith123@hotmail.com";
        //    TestStaff.Customer_Telephone = "98765432101";
        //    //assign the data to the property 
        //    AllCustomer.ThisCustomer = TestCustomer;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);

        //}


        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    //create an instance of the class we want to create
        //    clsVPCustomerCollection AllStaff = new clsVPCustomerCollection();
        //    //create some test data to assign to the property 
        //    //in this case the data needs to be a list of objects
        //    List<clsVPCustomer> TestList = new List<clsVPCustomer>();
        //    //add an item to the list
        //    //create the item of the test data 
        //    clsVPCustomer TestItem = new clsVPCustomer();
        //    //set it's properties
        //    TestItem.Customer_ID = 1;
        //    TestItem.Customer_FirstName = "John";
        //    TestItem.Customer_LastName = "Smith";
        //    TestItem.Customer_Street = "Fifth Avenue";
        //    TestItem.Customer_Address = "103 Fifth Avenue,London";
        //    TestItem.Customer_Postcode = "SW3 5SF";
        //    TestItem.Customer_Email = "JohnSmith123@hotmail.com";
        //    TestItem.Customer_Telephone = "98765432101";
        //    //add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property 
        //    AllCustomer.CustomerList = TestList;
        //    //test to see that two values are the same 
        //    Assert.AreEqual(AllCustomer.Count, TestList.Count);

        //}
    }
}
