using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHHire
    {
        //HireCollectionDate property
        string HireCollectionDate = DateTime.Now.AddDays(1).Date.ToString();
        //HireReturnDate property
        string HireReturnDate = DateTime.Now.Date.AddDays(8).ToString();
        //HireLocation property
        string HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
        ////HirePostCode property
        //string HirePostCode = "LE2 5RE";
        //Hire Status property
        string HireStatus = "Pending Confirmation";

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
            DateTime SomeHireCollectionDate = DateTime.Now.Date.AddDays(1);
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
            //change the data match MinLessOne requirements (set the date to todays date)
            SomeHireCollectionDate = SomeHireCollectionDate.AddDays(0);
            //convert SomeHireCollectionDate to a string variable 
            string HireCollectionDate = SomeHireCollectionDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
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
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
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
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
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
            DateTime SomeHireReturnDate = DateTime.Now.Date.AddDays(8);
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
            //change the data match MinLessOne requirements (set the date to today, plus 7 days )
            SomeHireReturnDate = SomeHireReturnDate.AddDays(7);
            //convert SomeHireReturnDate to a string variable 
            string HireReturnDate = SomeHireReturnDate.ToString();
            //invoke the method 
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
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
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
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
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireLocationPropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire location
            string SomeHireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            //assign the data to the property
            VCHHire.HireLocation = SomeHireLocation;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireLocation, SomeHireLocation);
        }

        [TestMethod]
        public void HireLocationMinLessOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireLocation = "";
            //pad string of characters
            HireLocation = HireLocation.PadRight(4, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireLocationMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireLocation = "";
            //pad string of characters
            HireLocation = HireLocation.PadRight(71, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireLocationExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireLocation = "";
            //pad string of characters
            HireLocation = HireLocation.PadRight(200, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*[TestMethod]
        public void HirePostCodePropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire post code
            string SomeHirePostCode = "LE2 5RE";
            //assign the data to the property
            VCHHire.HirePostCode = SomeHirePostCode;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire. SomeHirePostCode);
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
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, DriverAge, DriverLicenseNumber, HireStatus);
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
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
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
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireStatusPropertyOK()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the Hire Status
            string SomeHireStatus = "Pending Confirmation";
            //assign the data to the property
            VCHHire.HireStatus = SomeHireStatus;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireStatus, SomeHireStatus);
        }

        [TestMethod]
        public void HireStatusMinLessOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireStatus = "";
            //pad string of characters
            HireStatus = HireStatus.PadRight(7, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireStatusMaxPlusOne()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireStatus = "";
            //pad string of characters
            HireStatus = HireStatus.PadRight(21, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireStatusExtremeMax()
        {
            //create an instance of the car hire class
            clsVCHHire VCHHire = new clsVCHHire();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireStatus = "";
            //pad string of characters
            HireStatus = HireStatus.PadRight(100, 'a');
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //boolean variable to store validation results
            Boolean found = false;
            //test data to test the method
            Int32 HireID = 23;
            //invoke the method
            found = VCHHire.Find(HireID);
            //test to see that the result is correct
            Assert.IsTrue(found);
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
            string HireCollectionDate = DateTime.Now.Date.AddDays(1).ToString();
            string HireReturnDate = DateTime.Now.Date.AddDays(8).ToString();
            string HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            string HireStatus = "Pending Confirmation";
            //invoke the method
            Error = VCHHire.Valid(HireCollectionDate, HireReturnDate, HireLocation, HireStatus);
            //test to check the result does pass and to see if any error message is returned
            Assert.AreEqual(Error, "");
        }
    }
}
