using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHCar
    {
        //Car Make property
        string CarMake = "Volkswagen";
        //Car Model property
        string CarModel = "Golf R";

        /* //Car Engine size property
        decimal CarEngine = 2.0M; */
        
        //Car Body property
        string CarBody = "Hatchback";
        //Car Colour property
        string CarColour = "Lapiz Blue";
        //Car Fuel type property
        string CarFuel = "Petrol";

        /* //Car weekly hire Price property
        decimal CarPrice = 300.0M;  */
        
        //Car registration property
        string CarRegistration = "VW19 GLF";

        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //test to see that it exists
            Assert.IsNotNull(VCHCar);
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs ID 
            Int32 SomeCarID = 1;
            //assign the data to the property
            VCHCar.CarID = SomeCarID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarID, SomeCarID);
        }

        [TestMethod]
        public void CarMakePropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs first name
            string SomeCarMake = "Volkswagen";
            //assign the data to the property
            VCHCar.CarMake = SomeCarMake;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarMake, SomeCarMake);
        }

        [TestMethod]
        public void CarMakeMinLessOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarMake = "";
            //pad string of characters
            CarMake = CarMake.PadRight(1, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarMake = "";
            //pad string of characters
            CarMake = CarMake.PadRight(31, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarMakeExtremeMax()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarMake = "";
            //pad string of characters
            CarMake = CarMake.PadRight(100, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelPropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs first name
            string SomeCarModel = "Golf R";
            //assign the data to the property
            VCHCar.CarModel = SomeCarModel;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarModel, SomeCarModel);
        }

        [TestMethod]
        public void CarModelMinLessOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarModel = "";
            //pad string of characters
            CarModel = CarModel.PadRight(1, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarModel = "";
            //pad string of characters
            CarModel = CarModel.PadRight(31, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelExtremeMax()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarModel = "";
            //pad string of characters
            CarModel = CarModel.PadRight(100, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarEnginePropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs ID 
            decimal SomeCarEngine = 2.0M;
            //assign the data to the property
            VCHCar.CarEngine = SomeCarEngine;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarEngine, SomeCarEngine);
        }

        [TestMethod]
        public void CarBodyPropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs first name
            string SomeCarBody = "Hatchback";
            //assign the data to the property
            VCHCar.CarBody = SomeCarBody;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarBody, SomeCarBody);
        }

        [TestMethod]
        public void CarBodyMinLessOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarBody = "";
            //pad string of characters
            CarBody = CarBody.PadRight(2, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarBodyMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarBody = "";
            //pad string of characters
            CarBody = CarBody.PadRight(21, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarBodyExtremeMax()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarBody = "";
            //pad string of characters
            CarBody = CarBody.PadRight(100, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarColourPropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs first name
            string SomeCarColour = "Lapiz Blue";
            //assign the data to the property
            VCHCar.CarColour = SomeCarColour;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarColour, SomeCarColour);
        }

        [TestMethod]
        public void CarColourMinLessOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarColour = "";
            //pad string of characters
            CarColour = CarColour.PadRight(1, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarColourMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarColour = "";
            //pad string of characters
            CarColour = CarColour.PadRight(26, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarColourExtremeMax()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarColour = "";
            //pad string of characters
            CarColour = CarColour.PadRight(100, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarFuelPropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs ID 
            string SomeCarFuel = "Petrol";
            //assign the data to the property
            VCHCar.CarFuel = SomeCarFuel;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarFuel, SomeCarFuel);
        }

        [TestMethod]
        public void CarFuelMinLessOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarFuel = "";
            //pad string of characters
            CarFuel = CarFuel.PadRight(5, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarFuelMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarFuel = "";
            //pad string of characters
            CarFuel = CarFuel.PadRight(11, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarFuelExtremeMax()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarFuel = "";
            //pad string of characters
            CarFuel = CarFuel.PadRight(100, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarPricePropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs ID 
            decimal SomeCarPrice = 250.0M;
            //assign the data to the property
            VCHCar.CarPrice = SomeCarPrice;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarPrice, SomeCarPrice);
        }

        [TestMethod]
        public void CarRegistrationPropertyOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create some test data to assign to the staffs first name
            string SomeCarRegistration = "VW19 GLF";
            //assign the data to the property
            VCHCar.CarRegistration = SomeCarRegistration;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCar.CarRegistration, SomeCarRegistration);
        }

        [TestMethod]
        public void CarRegistrationMinLessOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarRegistration = "";
            //pad string of characters
            CarRegistration = CarRegistration.PadRight(1, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegistrationMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarRegistration = "";
            //pad string of characters
            CarRegistration = CarRegistration.PadRight(12, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarRegistrationExtremeMax()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string CarRegistration = "";
            //pad string of characters
            CarRegistration = CarRegistration.PadRight(100, 'a');
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //a string variable to store validation results
            String Error = "";
            //test data to test the method
            string CarMake = "Volkswagen";
            string CarModel = "Golf R";
            //
            string CarBody = "Hatchback";
            string CarColour = "Lapiz Blue";
            string CarFuel = "Petrol";
            //
            string CarRegistration = "VW19 GLF";
            //invoke the method
            Error = VCHCar.Valid(CarMake, CarModel, CarBody, CarColour, CarFuel, CarRegistration);
            //test to check the result does pass and to see if any error message is returned
            Assert.AreEqual(Error, "");
        }
    }
}
