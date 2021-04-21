using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHHireBooking
    {
        //HireDate property
        string HireDate = DateTime.Now.AddDays(1).Date.ToString();
        //HireTime property
        string HireTime = "0900";
        //HireDescription property
        string HireDescription = "Upon collection of the hired vehicle, payment will be required.";

        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //test to see that it exists
            Assert.IsNotNull(VCHHireBooking);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireBookingIDPropertyOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create some test data to assign to the hire booking ID 
            Int32 SomeHireBookingID = 1;
            //assign the data to the property
            VCHHireBooking.HireBookingID = SomeHireBookingID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHireBooking.HireBookingID, SomeHireBookingID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireIDPropertyOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create some test data to assign to the hire ID 
            Int32 SomeHireID = 1;
            //assign the data to the property
            VCHHireBooking.HireID = SomeHireID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHireBooking.HireID, SomeHireID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireDatePropertyOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create some test data to assign to the hire date
            DateTime SomeHireDate = DateTime.Now.Date.AddDays(1);
            //assign the data to the property
            VCHHireBooking.HireDate = SomeHireDate;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHireBooking.HireDate, SomeHireDate);
        }

        [TestMethod]
        public void HireDateMinLessOne()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire date
            DateTime SomeHireDate;
            //set the data
            SomeHireDate = DateTime.Now.Date;
            //change the data match MinLessOne requirements (set the date to todays date)
            SomeHireDate = SomeHireDate.AddDays(0);
            //convert SomeHireCollectionDate to a string variable 
            string HireDate = SomeHireDate.ToString();
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateMaxPlusOne()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire date
            DateTime SomeHireDate;
            //set the data
            SomeHireDate = DateTime.Now.Date;
            //change the data match MaxPlusOne requirements (set the date to today, plus 181 days )
            SomeHireDate = SomeHireDate.AddDays(181);
            //convert SomeHireCollectionDate to a string variable 
            string HireDate = SomeHireDate.ToString();
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDateExtremeMax()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //string variable to store any error message 
            String Error = "";
            //create some test data to assign to the hire date
            DateTime SomeHireDate;
            //set the data
            SomeHireDate = DateTime.Now.Date;
            //change the data match ExtremeMax requirements (set the date to today, plus 100 years )
            SomeHireDate = SomeHireDate.AddYears(100);
            //convert SomeHireCollectionDate to a string variable 
            string HireDate = SomeHireDate.ToString();
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireTimePropertyOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create a variable to store the time of a hire
            Int32 SomeHireTime = 0900;
            //assign the data to the property
            VCHHireBooking.HireTime = SomeHireTime;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHireBooking.HireTime, SomeHireTime);
        }

        [TestMethod]
        public void HireTimeMinLessOne()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HireTime = "";
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireTimeMaxPlusOne()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HireTime = "2500";
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireTimeExtremeMax()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HireTime = "100000";
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void HireDescriptionPropertyOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create some test data to assign to the hire description
            string SomeHireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //assign the data to the property
            VCHHireBooking.HireDescription = SomeHireDescription;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHireBooking.HireDescription, SomeHireDescription);
        }

        [TestMethod]
        public void HireDescriptionMinLessOne()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireDescription = "";
            //pad string of characters
            HireDescription = HireDescription.PadRight(4, 'a');
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDescriptionMaxPlusOne()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireDescription = "";
            //pad string of characters
            HireDescription = HireDescription.PadRight(151, 'a');
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HireDescriptionExtremeMax()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string HireDescription = "";
            //pad string of characters
            HireDescription = HireDescription.PadRight(500, 'a');
            //invoke the method 
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //boolean variable to store validation results
            Boolean found = false;
            //test data to test the method
            Int32 HireBookingID = 1;
            //invoke the method
            found = VCHHireBooking.Find(HireBookingID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the hire booking class
            clsVCHHireBooking VCHHireBooking = new clsVCHHireBooking();
            //a string variable to store validation results
            String Error = "";
            //test data to test the method
            string HireDate = DateTime.Now.AddDays(1).Date.ToString();
            string HireTime = "0900";
            string HireDescription = "Upon collection of the hired vehicle, payment will be required.";
            //invoke the method
            Error = VCHHireBooking.Valid(HireDate, HireTime, HireDescription);
            //test to check the result does pass and to see if any error message is returned
            Assert.AreEqual(Error, "");
        }
    }
}
