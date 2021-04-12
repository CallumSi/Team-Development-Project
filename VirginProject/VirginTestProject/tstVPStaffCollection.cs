using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPStaffCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void VPStaffListOK()
        {
            //create an instance of the class we want to create
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs be a list of objects 
            List<clsVPStaff> TestList = new List<clsVPStaff>();
            //add an item to the list 
            //create the item of test data
            clsVPStaff TestItem = new clsVPStaff();
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_FirstName = "John";
            TestItem.Staff_LastName = "Smith";
            TestItem.Staff_Street = "Fifth Avenue";
            TestItem.Staff_Address = "103 Fifth Avenue,London";
            TestItem.Staff_Postcode = "SW3 5SF";
            TestItem.Staff_Email = "JohnSmith123@hotmail.com";
            TestItem.Staff_Telephone = "98765432101";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }



        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //create some test data to assign to the property 
            clsVPStaff TestStaff = new clsVPStaff();
            //set the properties of the test object
            TestStaff.Staff_ID = 1;
            TestStaff.Staff_FirstName = "John";
            TestStaff.Staff_LastName = "Smith";
            TestStaff.Staff_Street = "Fifth Avenue";
            TestStaff.Staff_Address = "103 Fifth Avenue,London";
            TestStaff.Staff_Postcode = "SW3 5SF";
            TestStaff.Staff_Email = "JohnSmith123@hotmail.com";
            TestStaff.Staff_Telephone = "98765432101";
            //assign the data to the property 
            AllStaff.ThisStaff = TestStaff;
            //test to see that thr two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsVPStaff> TestList = new List<clsVPStaff>();
            //add an item to the list
            //create the item of the test data 
            clsVPStaff TestItem = new clsVPStaff();
            //set it's properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_FirstName = "John";
            TestItem.Staff_LastName = "Smith";
            TestItem.Staff_Street = "Fifth Avenue";
            TestItem.Staff_Address = "103 Fifth Avenue,London";
            TestItem.Staff_Postcode = "SW3 5SF";
            TestItem.Staff_Email = "JohnSmith123@hotmail.com";
            TestItem.Staff_Telephone = "98765432101";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that two values are the same 
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

   

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //create the item of test data 
            clsVPStaff TestItem = new clsVPStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Staff_ID = 1;
            TestItem.Staff_FirstName = "John";
            TestItem.Staff_LastName = "Smith";
            TestItem.Staff_Street = "Fifth Avenue";
            TestItem.Staff_Address = "103 Fifth Avenue,London";
            TestItem.Staff_Postcode = "SW3 5SF";
            TestItem.Staff_Email = "JohnSmith123@hotmail.com";
            TestItem.Staff_Telephone = "98765432101";
            //set ThisStaff to the test data 
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.Staff_ID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //create the item of the test data 
            clsVPStaff TestItem = new clsVPStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_FirstName = "John";
            TestItem.Staff_LastName = "Smith";
            TestItem.Staff_Street = "Fifth Avenue";
            TestItem.Staff_Address = "103 Fifth Avenue,London";
            TestItem.Staff_Postcode = "SW3 5SF";
            TestItem.Staff_Email = "JohnSmith123@hotmail.com";
            TestItem.Staff_Telephone = "98765432101";
            //set ThisStaff to the test data 
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.Staff_ID = PrimaryKey;
            //modify the test data
            TestItem.Staff_ID = 1;
            TestItem.Staff_FirstName = "Jane";
            TestItem.Staff_LastName = "Doe";
            TestItem.Staff_Street = "Lake Hill";
            TestItem.Staff_Address = "108 Lake Hill,London";
            TestItem.Staff_Postcode = "TW4 9BQ";
            TestItem.Staff_Email = "JaneDoe123@hotmail.com";
            TestItem.Staff_Telephone = "12345678901";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches he test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //create the item of the test data 
            clsVPStaff TestItem = new clsVPStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_FirstName = "John";
            TestItem.Staff_LastName = "Smith";
            TestItem.Staff_Street = "Fifth Avenue";
            TestItem.Staff_Address = "103 Fifth Avenue,London";
            TestItem.Staff_Postcode = "SW3 5SF";
            TestItem.Staff_Email = "JohnSmith123@hotmail.com";
            TestItem.Staff_Telephone = "98765432101";
            //set ThisStaff to the test data 
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data 
            TestItem.Staff_ID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
          
        }

     

        [TestMethod]
        public void ReportByFirstNameMethod()
        {
            //create an instance of the filtered data
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //create an instance of the filtered data 
            clsVPStaffCollection FilteredFirstName = new clsVPStaffCollection();
            //apply a blank string (should return all records)
            FilteredFirstName.FilterByStaffFirstName("");
            //test to see that two values are the same 
            Assert.AreEqual(AllStaff.Count, FilteredFirstName.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsVPStaffCollection FilteredFirstName = new clsVPStaffCollection();
            //apply a first name that doesnt exists
            FilteredFirstName.FilterByStaffFirstName("Taf");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredFirstName.Count);
            
        }

        [TestMethod]
        public void ReportByFirstNameTestDataFound()
        {
            //create an instance of the filtered data
            clsVPStaffCollection FilteredFirstName = new clsVPStaffCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a first name that doesn't exists 
            FilteredFirstName.FilterByStaffFirstName("Jane");
            //check that the correct number of records are found 
            if (FilteredFirstName.Count == 2)
            {
                //check to see the first record ID is 1
                if (FilteredFirstName.StaffList[0].Staff_ID != 1)
                {
                    OK = false;
                }

                //check that the last record ID is 2 
                if (FilteredFirstName.StaffList[1].Staff_ID != 2 )
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
