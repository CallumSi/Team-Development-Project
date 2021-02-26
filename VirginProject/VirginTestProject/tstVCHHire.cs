using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHHire
    {
        //hire location - address property
        string HireAddress = "29 Hinckley Road, Leicester";
        //hire location - postcode property
        string HirePostCode = "LE3 1HR";
        //driver age property
        string DriverAge = "26";
        //drivers license number property
        string DriverLicenseNumber = "ALIGH902245DA99S";

        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //test to see that it exists
            Assert.IsNotNull(VCHCar);
        }

        [TestMethod]
        public void HireIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire ID 
            Int32 SomeHireID = 1;
            //assign the data to the property
            VCHHire.HireID = SomeHireID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireID, SomeHireID);
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire date
            DateTime SomeHireDate;
            //assign the data to the property
            SomeHireDate = Convert.ToDateTime("21/02/2021");
            //assign the data to the property
            VCHHire.HireDate = SomeHireDate;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireDate, SomeHireDate);
        }

        [TestMethod]
        public void HirePricePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire price
            decimal SomeHirePrice = 500.0M;
            //assign the data to the property
            VCHHire.HirePrice = SomeHirePrice;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HirePrice, SomeHirePrice);
        }

        [TestMethod]
        public void HireAddressPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire address pick up and drop off location
            string SomeHireAddress = "29 Hinckley Road, Leicester";
            //assign the data to the property
            VCHHire.HireAddress = SomeHireAddress;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireAddress, SomeHireAddress);
        }
        [TestMethod]
        public void HireAddressMinLessOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireAddress = "";
            //pad string of characters
            HireAddress = HireAddress.PadRight(2, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireAddressMaxPlusOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireAddress = "";
            //pad string of characters
            HireAddress = HireAddress.PadRight(51, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireAddressExtremeMax()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireAddress = "";
            //pad string of characters
            HireAddress = HireAddress.PadRight(100, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HirePostCodePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire postcode pick up and drop off location
            string SomeHirePostCode = "LE3 1HR";
            //assign the data to the property
            VCHHire.HirePostCode = SomeHirePostCode;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HirePostCode, SomeHirePostCode);
        }

        [TestMethod]
        public void HirePostCodeMinLessOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HirePostCode = "";
            //pad string of characters
            HirePostCode = HirePostCode.PadRight(4, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HirePostCodeMaxPlusOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HirePostCode = "";
            //pad string of characters
            HirePostCode = HirePostCode.PadRight(11, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HirePostCodeExtremeMax()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HirePostCode = "";
            //pad string of characters
            HirePostCode = HirePostCode.PadRight(20, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the cars ID 
            Int32 SomeCarID = 1;
            //assign the data to the property
            VCHHire.CarID = SomeCarID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.CarID, SomeCarID);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the customers ID 
            Int32 SomeCustomerID = 1;
            //assign the data to the property
            VCHHire.CustomerID = SomeCustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.CustomerID, SomeCustomerID);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the staffs ID 
            Int32 SomeStaffID = 1;
            //assign the data to the property
            VCHHire.StaffID = SomeStaffID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.StaffID, SomeStaffID);
        }

        [TestMethod]
        public void DriverAgePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the driver age
            string SomeDriverAge = "26";
            //assign the data to the property
            VCHHire.DriverAge = SomeDriverAge;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.DriverAge, SomeDriverAge);
        }

        [TestMethod]
        public void DriverAgeMinLessOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverAge = "";
            //pad string of characters
            DriverAge = DriverAge.PadRight(1, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverAgeMaxPlusOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverAge = "";
            //pad string of characters
            DriverAge = DriverAge.PadRight(3, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverAgeExtremeMax()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverAge = "";
            //pad string of characters
            DriverAge = DriverAge.PadRight(10, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverLicenseNumberPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the drivers license number
            string SomeDriverLicenseNumber = "ALIGH902245DA99S";
            //assign the data to the property
            VCHHire.DriverLicenseNumber = SomeDriverLicenseNumber;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.DriverLicenseNumber, SomeDriverLicenseNumber);
        }

        [TestMethod]
        public void DriverLicenseNumberMinLessOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverLicenseNumber = "";
            //pad string of characters
            DriverLicenseNumber = DriverLicenseNumber.PadRight(15, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverLicenseNumberMaxPlusOne()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverLicenseNumber = "";
            //pad string of characters
            DriverLicenseNumber = DriverLicenseNumber.PadRight(17, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverLicenseNumberExtremeMax()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverLicenseNumber = "";
            //pad string of characters
            DriverLicenseNumber = DriverLicenseNumber.PadRight(50, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //a string variable to store validation results
            String Error = "";
            //test data to test the method
            string HireAddress = "29 Hinckley Road, Leicester";
            string HirePostCode = "LE3 1HR";
            string DriverAge = "26";
            string DriverLicenseNumber = "ALIGH902245DA99S";
            //invoke the method
            Error = VCHHire.Valid(HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result does pass and to see if any error message is returned
            Assert.AreEqual(Error, "");
        }
    }
}
