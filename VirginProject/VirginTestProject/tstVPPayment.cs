﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPPayment
    {
        //testing payment properties

        string CardNo = "0000000000000000";
        string ExpiryDate = DateTime.Now.ToString();
        string SecurityNo = "999";

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //test to see that it exists
            Assert.IsNotNull(AVPPayment);
        }


        //testing the property card no
        [TestMethod]
        public void CardNoPropertyOK()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the card no of the payment
            Int32 SomeCardNo;
            //assign an card no to the variable
            SomeCardNo = 0000000000000000;
            //try to send some data to the card no property 
            AVPPayment.CardNo = SomeCardNo;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPPayment.CardNo, SomeCardNo);
        }

        //testing the property expiry date
        [TestMethod]
        public void ExpiryDatePropertyOK()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the expiry date of the payment
            DateTime SomeExpiryDate = DateTime.Now.Date;
            //try to send some data to the date property
            AVPPayment.ExpiryDate = SomeExpiryDate;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPPayment.ExpiryDate, SomeExpiryDate);
        }

        //testing the property security no
        [TestMethod]
        public void SecurityNoPropertyOK()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the security no of the payment
            Int32 SomeSecurityNo;
            //assign an security no to the variable
            SomeSecurityNo = 999;
            //try to send some data to the security no property 
            AVPPayment.SecurityNo = SomeSecurityNo;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPPayment.SecurityNo, SomeSecurityNo);
        }

        //testing the valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the data of the validation
            string Error = "";
            //create some test data
            string CardNo = "0000000000000000";
            string ExpiryDate = DateTime.Now.ToString();
            string SecurityNo = "999";
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see that the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");

        }

        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES EXPIRY DATE***//
        /// </summary>
        /// 

        //testing the valid methods

        [TestMethod]
        public void ExpiryDateMinLessOne()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeExpiryDate = SomeExpiryDate.AddYears(-101);
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMin()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeExpiryDate = SomeExpiryDate.AddYears(-100);
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMinPlusOne()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeExpiryDate = SomeExpiryDate.AddYears(-99);
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMaxLessOne()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeExpiryDate = SomeExpiryDate.AddYears(99);
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMax()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeExpiryDate = SomeExpiryDate.AddYears(100);
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMaxPlusOne()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeExpiryDate = SomeExpiryDate.AddYears(101);
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMid()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateExtremeMax()
        {
            //create an instance of the class
            clsVPPayment AVPPayment = new clsVPPayment();
            //create a variable to store the validation
            string Error = "";
            //create some test data to test the valid methid
            DateTime SomeExpiryDate;
            //set the date to todays date
            SomeExpiryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeExpiryDate = SomeExpiryDate.AddYears(200);
            //convert the date variable to string
            string ExpiryDate = SomeExpiryDate.ToString();
            //invoke the method
            Error = AVPPayment.Valid(CardNo, ExpiryDate, SecurityNo);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }
    }
}
