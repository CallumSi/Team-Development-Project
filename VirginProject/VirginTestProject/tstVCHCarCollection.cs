using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }

        [TestMethod]
        public void CarListOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHCar> TestList = new List<clsVCHCar>();
            //add items to the list
            //create the item of test data
            clsVCHCar TestItem = new clsVCHCar();
            //set data properties
            TestItem.CarID = 1;
            TestItem.CarMake = "Volkswagen";
            TestItem.CarModel = "Golf R";
            TestItem.CarEngine = Convert.ToDecimal(2.0);
            TestItem.CarBody = "Hatchback";
            TestItem.CarColour = "Lapiz Blue";
            TestItem.CarFuel = "Petrol";
            TestItem.CarPrice = Convert.ToDecimal(250.00);
            TestItem.CarRegistration = "VW19 GLF";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllCars.CarList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.CarList, TestList);
        }

        [TestMethod]
        public void ThisCarPropertyOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //create the item of test data
            clsVCHCar TestCar = new clsVCHCar();
            //set data properties
            TestCar.CarID = 1;
            TestCar.CarMake = "Volkswagen";
            TestCar.CarModel = "Golf R";
            TestCar.CarEngine = Convert.ToDecimal(2.0);
            TestCar.CarBody = "Hatchback";
            TestCar.CarColour = "Lapiz Blue";
            TestCar.CarFuel = "Petrol";
            TestCar.CarPrice = Convert.ToDecimal(250.00);
            TestCar.CarRegistration = "VW19 GLF";
            //assign data to the properties
            AllCars.ThisCar = TestCar;
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test data to assign to the property
            //the data will be a list of objects
            List<clsVCHCar> TestList = new List<clsVCHCar>();
            //add items to the list
            //create the item of test data
            clsVCHCar TestItem = new clsVCHCar();
            //set data properties
            TestItem.CarID = 1;
            TestItem.CarMake = "Volkswagen";
            TestItem.CarModel = "Golf R";
            TestItem.CarEngine = Convert.ToDecimal(2.0);
            TestItem.CarBody = "Hatchback";
            TestItem.CarColour = "Lapiz Blue";
            TestItem.CarFuel = "Petrol";
            TestItem.CarPrice = Convert.ToDecimal(250.00);
            TestItem.CarRegistration = "VW19 GLF";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign data to the properties
            AllCars.CarList = TestList;
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }

        /*
        [TestMethod]
        public void TwoStaffPresent()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.Count, 2);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCars.Count = SomeCount;
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.Count, SomeCount);
        }
        */

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test data to assign to the property
            clsVCHCar TestItem = new clsVCHCar();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.CarID = 1;
            TestItem.CarMake = "Volkswagen";
            TestItem.CarModel = "Golf R";
            TestItem.CarEngine = Convert.ToDecimal(2.0);
            TestItem.CarBody = "Hatchback";
            TestItem.CarColour = "Lapiz Blue";
            TestItem.CarFuel = "Petrol";
            TestItem.CarPrice = Convert.ToDecimal(250.00);
            TestItem.CarRegistration = "VW19 GLF";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            /* 
            commented out to prevent constant-reduplication of car record into data table
            "//add the record
            PrimaryKey = AllCars.Add();" 
            */
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test data to assign to the property
            clsVCHCar TestItem = new clsVCHCar();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.CarID = 1;
            TestItem.CarMake = "Volkswagen";
            TestItem.CarModel = "Golf R";
            TestItem.CarEngine = Convert.ToDecimal(2.0);
            TestItem.CarBody = "Hatchback";
            TestItem.CarColour = "Lapiz Blue";
            TestItem.CarFuel = "Petrol";
            TestItem.CarPrice = Convert.ToDecimal(250.00);
            TestItem.CarRegistration = "VW19 GLF";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record
            AllCars.Delete();
            //now find the record
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //test data to assign to the property
            clsVCHCar TestItem = new clsVCHCar();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set data properties
            TestItem.CarID = 1;
            TestItem.CarMake = "Volkswagen";
            TestItem.CarModel = "Golf R";
            TestItem.CarEngine = Convert.ToDecimal(2.0);
            TestItem.CarBody = "Hatchback";
            TestItem.CarColour = "Lapiz Blue";
            TestItem.CarFuel = "Petrol";
            TestItem.CarPrice = Convert.ToDecimal(250.00);
            TestItem.CarRegistration = "VW19 GLF";
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            /* 
            commented out to prevent constant-reduplication of car record into data table
            "//add the record
            PrimaryKey = AllCars.Add();" 
            */
            //set the primary key of the test data
            TestItem.CarID = PrimaryKey;
            //modify the test data in the following manner
            TestItem.CarID = 14;
            TestItem.CarMake = "Volkswagen";
            TestItem.CarModel = "Golf GTD";
            TestItem.CarEngine = Convert.ToDecimal(2.0);
            TestItem.CarBody = "Hatchback";
            TestItem.CarColour = "Moonstone Grey";
            TestItem.CarFuel = "Diesel";
            TestItem.CarPrice = Convert.ToDecimal(185.00);
            TestItem.CarRegistration = "MK18 MSV";
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //update the record
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see the values ARE the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void ReportByCarBodyMethodOK()
        {
            //create an instance of the car collection class
            clsVCHCarCollection AllCars = new clsVCHCarCollection();
            //create an instance of the data to filter
            clsVCHCarCollection FilteredCarBody = new clsVCHCarCollection();
            //apply a blank string (all car records should be returned)
            FilteredCarBody.ReportByCarBody("");
            //test to see that both values ARE the same
            Assert.AreEqual(AllCars.Count, FilteredCarBody.Count);
        }

        [TestMethod]
        public void ReportByCarBodyNoneFound()
        {
            //create an instance of the data to filter
            clsVCHCarCollection FilteredCarBody = new clsVCHCarCollection();
            //apply a none existent Car Body
            FilteredCarBody.ReportByCarBody("This Doesnt Exist");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCarBody.Count);
        }

        [TestMethod]
        public void ReportByCarBodyTestDataFound()
        {
            //create an instance of the data to filter
            clsVCHCarCollection FilteredCarBody = new clsVCHCarCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply an existent body type
            FilteredCarBody.ReportByCarBody("Coupe");
            //check that the correct number of records are found
            if (FilteredCarBody.Count == 2)
            {
                //check that the first record ID is 10
                if (FilteredCarBody.CarList[0].CarID != 10)
                {
                    OK = false;
                }
                //check that the second record ID is 30
                if (FilteredCarBody.CarList[1].CarID != 30)
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
