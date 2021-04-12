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
    }
}
