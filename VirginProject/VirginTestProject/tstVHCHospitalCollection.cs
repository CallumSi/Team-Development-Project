using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;


namespace VirginTestProject
{
    [TestClass]
    public class tstVHCHospitalCollection
    {
      
            [TestMethod]
            public void InstantiationOK()
            {
                //create an instance of the hospital collection class 
                clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
                //test to see that it exists 
                Assert.IsNotNull(AllHospitals);
            }

            [TestMethod]
            public void VHCHospitalListOK()
            {
            //create an instance of the hospital collection class 
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //create a list of object to assign to the property
            List<clsVHCHospital> TestList = new List<clsVHCHospital>();
            //create the item of test data
            clsVHCHospital TestItem = new clsVHCHospital();
            //set its properties
            TestItem.Hospital_ID = 1;
            TestItem.Hospital_Name = "West Middlesex Hospital";
            TestItem.Hospital_Place = "West London";
            //add the item to the test list
            TestList.Add(TestItem);
                //assign the data to the property
                AllHospitals.HospitalList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllHospitals.HospitalList, TestList);
            }

        [TestMethod]
        public void ThisHospitalPropertyOK()
        {
            //create an instance of the hospital collection class 
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //create some test data to assign to the property
            clsVHCHospital TestHospital = new clsVHCHospital();
            //set the properties of the test object
            TestHospital.Hospital_ID = 1;
            TestHospital.Hospital_Name = "West Middlesex Hospital";
            TestHospital.Hospital_Place = "West London";
            //assign the data to the property
            AllHospitals.ThisHospital = TestHospital;
            //test to see that the two values are the same
            Assert.AreEqual(AllHospitals.ThisHospital, TestHospital);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the hospital collection class 
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsVHCHospital> TestList = new List<clsVHCHospital>();
            //add an item to the list
            //create the item of test data
            clsVHCHospital TestItem = new clsVHCHospital();
            //set its properties
            TestItem.Hospital_ID = 1;
            TestItem.Hospital_Name = "West Middlesex Hospital";
            TestItem.Hospital_Place = "West London";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllHospitals.HospitalList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllHospitals.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        //Add Method
        {
            //create an instance of the hospital collection class 
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //create some test data to assign to the property
            clsVHCHospital TestItem = new clsVHCHospital();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Hospital_ID = 1;
            TestItem.Hospital_Name = "West Middlesex Hospital";
            TestItem.Hospital_Place = "West London";
            //set ThisHospital to the test data 
            AllHospitals.ThisHospital = TestItem;
            //add the record 
            //PrimaryKey = AllHospitals.Add(); *** REMOVED DUE TO REDUNDANT DATA ***
            //set the primary key of the test data 
            TestItem.Hospital_ID = PrimaryKey;
            //find the record 
            AllHospitals.ThisHospital.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllHospitals.ThisHospital, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        //Update Method
        {
            //create an instance of the hospital collection class 
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //create some test data to assign to the property
            clsVHCHospital TestItem = new clsVHCHospital();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Hospital_ID = 1;
            TestItem.Hospital_Name = "West Middlesex Hospital";
            TestItem.Hospital_Place = "West London";
            //set ThisHospital to the test data 
            AllHospitals.ThisHospital = TestItem;
            //add the record 
            //PrimaryKey = AllHospitals.Add();  *** REMOVED DUE TO REDUNDANT DATA ***
            //set the primary key of the test data 
            TestItem.Hospital_ID = PrimaryKey;
            //modify the test data 
            TestItem.Hospital_ID = 1;
            TestItem.Hospital_Name = "East Middlesex Hospital";
            TestItem.Hospital_Place = "East London";
            //set the record based on the new test data
            AllHospitals.ThisHospital = TestItem;
            //update the method 
            AllHospitals.Update();
            //find the record
            AllHospitals.ThisHospital.Find(PrimaryKey);
            //test to see ThisHospital matches the test data
            Assert.AreEqual(AllHospitals.ThisHospital, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        //Delete Method
        {
            //create an instance of the hospital collection class 
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //create some test data to assign to the property
            clsVHCHospital TestItem = new clsVHCHospital();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Hospital_ID = 1;
            TestItem.Hospital_Name = "West Middlesex Hospital";
            TestItem.Hospital_Place = "West London";
            //set ThisHospital to the test data 
            AllHospitals.ThisHospital = TestItem;
            //add the record 
            PrimaryKey = AllHospitals.Add();
            //set the primary key of the test data 
            TestItem.Hospital_ID = PrimaryKey;
            //find the record 
            AllHospitals.ThisHospital.Find(PrimaryKey);
            //delete the record 
            AllHospitals.Delete();
            //now find the record 
            Boolean Found = AllHospitals.ThisHospital.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllHospitals.ThisHospital, TestItem);
        }

        [TestMethod]
        public void ReportByHospitalMethodOK()
        //Report By Hospital Method 
        {
            //create an instance of the hospital collection class 
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //create an instance of the filtered data
            clsVHCHospitalCollection FilteredHospital = new clsVHCHospitalCollection();
            //apply a blank string (Should return all hospitals) 
            FilteredHospital.ReportByHospital("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllHospitals.Count, FilteredHospital.Count);
        }


        [TestMethod]
        public void ReportByHospitalNoneFound()
        //Report By Hospital None Found Method 
        {
            //create an instance of the filtered data           
            clsVHCHospitalCollection FilteredHospital = new clsVHCHospitalCollection();
            //apply a blank string (Should return all hospitals) 
            FilteredHospital.ReportByHospital("xxxx");
            //test to see that the two values are the same 
            Assert.AreEqual(0, FilteredHospital.Count);
        }

        [TestMethod]
        public void ReportByHospitalTestDataFound()
        //Report By Hospital Test Data Found Method 
        {
            //create an instance of the filtered data
            clsVHCHospitalCollection FilteredHospital = new clsVHCHospitalCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a make that does exist
            FilteredHospital.ReportByHospital("East Middlesex Hospital");
            //check that the correct number of records are found
            if (FilteredHospital.Count == 2)
            {
                //check that the first record id ID 2
                if (FilteredHospital.HospitalList[0].Hospital_ID != 1)
                {
                    OK = false;
                }

                //check that the last record is ID 20
                if (FilteredHospital.HospitalList[1].Hospital_ID != 20)
                {
                    OK = false;
                }

            }

            else
            {
                OK = false;
            }


            //test to see that the two values are the same 
            Assert.IsTrue(OK);
        }
    }
}
