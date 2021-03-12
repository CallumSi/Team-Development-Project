using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHStaff
    {
        //staff first name property 
        string StaffFirstName = "Johann";
        //staff last name property 
        string StaffLastName = "Goethe";
        //staff address property 
        string StaffAddress = "49 Frankfurt Lane, Leicester";
        //staff postcode property 
        string StaffPostCode = "LE1 8WE";
        //staff username property
        string StaffUsername = "JohannGoethizzy";
        //staff email property
        string StaffEmail = "j.goethe@gmail.com";
        //staff password property
        string StaffPassword = "HeiMepGre1";
        //staff phone number property
        string StaffPhoneNumber = "07987654321";

        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //test to see that it exists
            Assert.IsNotNull(VCHStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staffs ID 
            Int32 SomeStaffID = 1;
            //assign the data to the property
            VCHStaff.StaffID = SomeStaffID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffID, SomeStaffID);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staffs first name
            string SomeStaffFirstName = "Johann";
            //assign the data to the property
            VCHStaff.StaffFirstName = SomeStaffFirstName;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffFirstName, SomeStaffFirstName);
        }

        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffFirstName = "";
            //pad string of characters
            StaffFirstName = StaffFirstName.PadRight(1, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffFirstName = "";
            //pad string of characters
            StaffFirstName = StaffFirstName.PadRight(31, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffFirstName = "";
            //pad string of characters
            StaffFirstName = StaffFirstName.PadRight(100, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staffs last name
            string SomeStaffLastName = "Goethe";
            //assign the data to the property
            VCHStaff.StaffLastName = SomeStaffLastName;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffLastName, SomeStaffLastName);
        }

        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffLastName = "";
            //pad string of characters
            StaffLastName = StaffLastName.PadRight(1, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffLastName = "";
            //pad string of characters
            StaffLastName = StaffLastName.PadRight(31, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffLastName = "";
            //pad string of characters
            StaffLastName = StaffLastName.PadRight(100, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staff address
            string SomeStaffAddress = "49 Frankfurt Lane, Leicester";
            //assign the data to the property
            VCHStaff.StaffAddress = SomeStaffAddress;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffAddress, SomeStaffAddress);
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffAddress = "";
            //pad string of characters
            StaffAddress = StaffAddress.PadRight(2, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffAddress = "";
            //pad string of characters
            StaffAddress = StaffAddress.PadRight(51, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffAddress = "";
            //pad string of characters
            StaffAddress = StaffAddress.PadRight(100, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodePropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the post code
            string SomeStaffPostCode = "LE1 8WE";
            //assign the data to the property
            VCHStaff.StaffPostCode = SomeStaffPostCode;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffPostCode, SomeStaffPostCode);
        }

        [TestMethod]
        public void StaffPostCodeMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPostCode = "";
            //pad string of characters
            StaffPostCode = StaffPostCode.PadRight(4, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPostCode = "";
            //pad string of characters
            StaffPostCode = StaffPostCode.PadRight(11, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPostCodeExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPostCode = "";
            //pad string of characters
            StaffPostCode = StaffPostCode.PadRight(20, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffUsernamePropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the email address
            string SomeStaffUsername = "JohannGoethizzy";
            //assign the data to the property
            VCHStaff.StaffUsername = SomeStaffUsername;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffUsername, SomeStaffUsername);
        }

        [TestMethod]
        public void StaffUsernameMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffUsername = "";
            //pad string of characters
            StaffUsername = StaffUsername.PadRight(1, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffUsernameMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffUsername = "";
            //pad string of characters
            StaffUsername = StaffUsername.PadRight(31, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffUsernameExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffUsername = "";
            //pad string of characters
            StaffUsername = StaffUsername.PadRight(100, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staff email address
            string SomeStaffEmail = "j.goethe@gmail.com";
            //assign the data to the property
            VCHStaff.StaffEmail = SomeStaffEmail;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffEmail, SomeStaffEmail);
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffEmail = "";
            //pad string of characters
            StaffEmail = StaffEmail.PadRight(6, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffEmail = "";
            //pad string of characters
            StaffEmail = StaffEmail.PadRight(51, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffEmail = "";
            //pad string of characters
            StaffEmail = StaffEmail.PadRight(100, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the password
            string SomeStaffPassword = "HeiMepGre1";
            //assign the data to the property
            VCHStaff.StaffPassword = SomeStaffPassword;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffPassword, SomeStaffPassword);
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPassword = "";
            //pad string of characters
            StaffPassword = StaffPassword.PadRight(5, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPassword = "";
            //pad string of characters
            StaffPassword = StaffPassword.PadRight(21, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPassword = "";
            //pad string of characters
            StaffPassword = StaffPassword.PadRight(100, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the phone number
            string SomeStaffPhoneNumber = "07987654321";
            //assign the data to the property
            VCHStaff.StaffPhoneNumber = SomeStaffPhoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffPhoneNumber, SomeStaffPhoneNumber);
        }

        [TestMethod]
        public void StaffPhoneNumberMinLessOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPhoneNumber = "";
            //pad string of characters
            StaffPhoneNumber = StaffPhoneNumber.PadRight(10, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberMaxPlusOne()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPhoneNumber = "";
            //pad string of characters
            StaffPhoneNumber = StaffPhoneNumber.PadRight(12, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNumberExtremeMax()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string StaffPhoneNumber = "";
            //pad string of characters
            StaffPhoneNumber = StaffPhoneNumber.PadRight(20, 'a');
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //a string variable to store validation results
            String Error = "";
            //test data to test the method
            string StaffFirstName = "Johann";
            string StaffLastName = "Goethe";
            string StaffAddress = "49 Frankfurt Lane, Leicester";
            string StaffPostCode = "LE1 8WE";
            string StaffUsername = "JohannGoethizzy";
            string StaffEmail = "j.goethe@gmail.com";
            string StaffPassword = "HeiMepGre1";
            string StaffPhoneNumber = "07987654321";
            //invoke the method
            Error = VCHStaff.Valid(StaffFirstName, StaffLastName, StaffAddress, StaffPostCode, StaffUsername, StaffEmail, StaffPassword, StaffPhoneNumber);
            //test to check the result does pass and to see if any error message is returned
            Assert.AreEqual(Error, "");
        }
    }
}
