using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHHire
    {
        //HireCollectionDate property
        string HireCollectionDate = DateTime.Now.Date.ToString();
        //HireReturnDate property
        string HireReturnDate = DateTime.Now.Date.AddDays(7).ToString();
        //HireAddress property
        string HireAddress = "14-16 Gulliard Lane, Leicester";
        //HirePostCode property
        string HirePostCode = "LE2 5RE";
        //Driver Age property
        string DriverAge = "26";
        //Driver License Number property
        string DriverLicenseNumber = "ALIGH902245DA99S";

        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //test to see that it exists
            Assert.IsNotNull(VCHHire);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireIDPropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire ID 
            Int32 SomeHireID = 1;
            //assign the data to the property
            VCHHire.HireID = SomeHireID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireID, SomeHireID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void CarIDPropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the cars ID 
            Int32 SomeCarID = 1;
            //assign the data to the property
            VCHHire.CarID = SomeCarID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.CarID, SomeCarID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the customers ID 
            Int32 SomeCustomerID = 1;
            //assign the data to the property
            VCHHire.CustomerID = SomeCustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.CustomerID, SomeCustomerID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void HireCollectionDatePropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire collection date
            DateTime SomeHireCollectionDate = DateTime.Now.Date;
            //assign the data to the property
            VCHHire.HireCollectionDate = SomeHireCollectionDate;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireCollectionDate, SomeHireCollectionDate);
        }

        [TestMethod]
        public void HireCollectionDateMinLessOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire collection date
            DateTime SomeHireCollectionDate;
            //set the data
            SomeHireCollectionDate = DateTime.Now.Date;
            //change the data match MinLessOne requirements (set the date to today, minus 1 day )
            SomeHireCollectionDate = SomeHireCollectionDate.AddDays(-1);
            //convert SomeHireCollectionDate to a string variable 
            string HireCollectionDate = SomeHireCollectionDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireCollectionDateMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire collection date
            DateTime SomeHireCollectionDate;
            //set the data
            SomeHireCollectionDate = DateTime.Now.Date;
            //change the data match MaxPlusOne requirements (set the date to today, plus 181 days )
            SomeHireCollectionDate = SomeHireCollectionDate.AddDays(181);
            //convert SomeHireCollectionDate to a string variable 
            string HireCollectionDate = SomeHireCollectionDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireCollectionDateExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire collection date
            DateTime SomeHireCollectionDate;
            //set the data
            SomeHireCollectionDate = DateTime.Now.Date;
            //change the data match ExtremeMax requirements (set the date to today, plus 100 years )
            SomeHireCollectionDate = SomeHireCollectionDate.AddYears(100);
            //convert SomeHireCollectionDate to a string variable 
            string HireCollectionDate = SomeHireCollectionDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireReturnDatePropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire return date
            DateTime SomeHireReturnDate = DateTime.Now.Date.AddDays(7);
            //assign the data to the property
            VCHHire.HireReturnDate = SomeHireReturnDate;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireReturnDate, SomeHireReturnDate);
        }

        [TestMethod]
        public void HireReturnDateMinLessOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire return date
            DateTime SomeHireReturnDate;
            //set the data
            SomeHireReturnDate = DateTime.Now.Date;
            //change the data match MinLessOne requirements (set the date to today, plus 6 days )
            SomeHireReturnDate = SomeHireReturnDate.AddDays(6);
            //convert SomeHireReturnDate to a string variable 
            string HireReturnDate = SomeHireReturnDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireReturnDateMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire return date
            DateTime SomeHireReturnDate;
            //set the data
            SomeHireReturnDate = DateTime.Now.Date;
            //change the data match MaxPlusOne requirements (set the date to today, plus 241 days )
            SomeHireReturnDate = SomeHireReturnDate.AddDays(241);
            //convert SomeHireReturnDate to a string variable 
            string HireReturnDate = SomeHireReturnDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireReturnDateExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire return date
            DateTime SomeHireReturnDate;
            //set the data
            SomeHireReturnDate = DateTime.Now.Date;
            //change the data match ExtremeMax requirements (set the date to today, plus 100 years )
            SomeHireReturnDate = SomeHireReturnDate.AddYears(100);
            //convert SomeHireReturnDate to a string variable 
            string HireReturnDate = SomeHireReturnDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireAddressPropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire address
            string SomeHireAddress = "14-16 Gulliard Lane, Leicester";
            //assign the data to the property
            VCHHire.HireAddress = SomeHireAddress;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireAddress, SomeHireAddress);
        }

        [TestMethod]
        public void HireAddressMinLessOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireAddress = "";
            //pad string of characters
            HireAddress = HireAddress.PadRight(2, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireAddressMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireAddress = "";
            //pad string of characters
            HireAddress = HireAddress.PadRight(51, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireAddressExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireAddress = "";
            //pad string of characters
            HireAddress = HireAddress.PadRight(100, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HirePostCodePropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire post code
            string SomeHirePostCode = "LE2 5RE";
            //assign the data to the property
            VCHHire.HirePostCode = SomeHirePostCode;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HirePostCode, SomeHirePostCode);
        }
        
        [TestMethod]
        public void HirePostCodeMinLessOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HirePostCode = "";
            //pad string of characters
            HirePostCode = HirePostCode.PadRight(4, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HirePostCodeMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HirePostCode = "";
            //pad string of characters
            HirePostCode = HirePostCode.PadRight(11, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HirePostCodeExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HirePostCode = "";
            //pad string of characters
            HirePostCode = HirePostCode.PadRight(20, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void DriverAgePropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the drivers age 
            Int32 SomeDriverAge = 26;
            //assign the data to the property
            VCHHire.DriverAge = SomeDriverAge;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.DriverAge, SomeDriverAge);
        }

        [TestMethod]
        public void DriverAgeMinLessOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverAge = "16";
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverAgeMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverAge = "76";
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverAgeExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverAge = "500";
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void DriverLicenseNumberPropertyOK()
        {
            //create an instance of the car hire class
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
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverLicenseNumber = "";
            //pad string of characters
            DriverLicenseNumber = DriverLicenseNumber.PadRight(10, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverLicenseNumberMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverLicenseNumber = "";
            //pad string of characters
            DriverLicenseNumber = DriverLicenseNumber.PadRight(21, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DriverLicenseNumberExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string DriverLicenseNumber = "";
            //pad string of characters
            DriverLicenseNumber = DriverLicenseNumber.PadRight(100, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //a string variable to store validation results
            String Error = "";
            //test data to test the method
            string HireCollectionDate = DateTime.Now.Date.ToString();
            string HireReturnDate = DateTime.Now.Date.AddDays(7).ToString();
            string HireAddress = "14-16 Gulliard Lane, Leicester";
            string HirePostCode = "LE2 5RE";
            string DriverAge = "26";
            string DriverLicenseNumber = "ALIGH902245DA99S";
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireAddress, HirePostCode, DriverAge, DriverLicenseNumber);
            //test to check the result does pass and to see if any error message is returned
            Assert.AreEqual(Error, "");
        }
    }
}
