using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPStaff{

        //testing staff properties

        string Staff_FirstName = "John";
        string Staff_LastName = "Smith";
        string Staff_Street = "Fifth Avenue";
        string Staff_Address = "103 Fifth Avenue,London";
        string Staff_Postcode = "SW3 5SF";
        string Staff_Email = "JohnSmith123@hotmail.com";
        string Staff_Telephone = "98765432101";

        [TestMethod]

        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPStaff AVPStaff = new clsVPStaff();
        }

        [TestMethod]
        //testing the property of Staff First Name of the class
        public void FirstNamePropertyOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a variable to store the first name of the staff
            string SomeFirstName;
            //assign an first name to the variable
            SomeFirstName = "John";
            //try to send some data to the first name property
            AVPStaff.Staff_FirstName = SomeFirstName;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPStaff.Staff_FirstName, SomeFirstName);
        }

        [TestMethod]
        //testing the property of Staff Last Name of the class
        public void LastNamePropertyOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a variable to store the last name of the staff
            string SomeLastName;
            //assign an last name to the variable
            SomeLastName = "Smith";
            //try to send some data to the last name property
            AVPStaff.Staff_LastName = SomeLastName;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPStaff.Staff_LastName, SomeLastName);
        }

        [TestMethod]
        //testing the property of Staff street of the class
        public void StreetPropertyOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a variable to store the street name of the staff
            string SomeStreet;
            //assign an street to the variable
            SomeStreet = "Fifth Avenue";
            //try to send some data to the street property
            AVPStaff.Staff_Street = SomeStreet;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPStaff.Staff_Street, SomeStreet);
        }


        [TestMethod]
        //testing the property of Staff Address of the class
        public void AddressPropertyOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a variable to store the address of the staff
            string SomeAddress;
            //assign an address to the variable
            SomeAddress = "103 Fifth Avenue, London";
            //try to send some data to the address property
            AVPStaff.Staff_Address = SomeAddress;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPStaff.Staff_Address, SomeAddress);  
        }

        [TestMethod]
        //testing the property of Staff postcode of the class
        public void PostcodePropertyOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a variable to store the postcode of the staff
            string SomePostcode;
            //assign an postcode to the variable
            SomePostcode = "SW3 5SF";
            //try to send some data to the postcode property
            AVPStaff.Staff_Postcode = SomePostcode;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPStaff.Staff_Postcode, SomePostcode);
        }

        [TestMethod]
        //testing the property of Staff email of the class
        public void EmailPropertyOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a variable to store the email of the staff
            string SomeEmail;
            //assign an email to the variable
            SomeEmail = "JohnSmith123@hotmail.com";
            //try to send some data to the email property
            AVPStaff.Staff_Email = SomeEmail;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPStaff.Staff_Email, SomeEmail);
        }

        [TestMethod]
        //testing the property of Staff telephone of the class
        public void TelephonePropertyOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a variable to store the telephone of the staff
            string SomeTelephone;
            //assign an telephone to the variable
            SomeTelephone = "9876543210";
            //try to send some data to the telephone property
            AVPStaff.Staff_Telephone = SomeTelephone;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPStaff.Staff_Telephone, SomeTelephone);
        }

        [TestMethod]
        //testing the valid method
        public void ValidMethodOK()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation 
            string Error = "";
            //create some test data 
            string Staff_FirstName = "John";
            string Staff_LastName = "Smith";
            string Staff_Street = "Fifth Avenue";
            string Staff_Address = "103 Fifth Avenue, London";
            string Staff_Postcode = "SW3 5SF";
            string Staff_Email = "JohnSmith123@hotmail.com";
            string Staff_Telephone = "98765432101";
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see that results is O, e.g no error message is returned 
            Assert.AreEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES FIRST NAME***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method 
        public void FirstNameMinLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(1, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void FirstNameMin()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(2, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void FirstNameMinPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(3, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void FirstNameMaxLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(19, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void FirstNameMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(20, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void FirstNameMaxPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(21, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void FirstNameMid()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(13, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void FirstNameExtremeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_FirstName = Staff_FirstName.PadLeft(50, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }



        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES LAST NAME***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method 
        public void LastNameMinLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(1, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void LastNameMin()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(2, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void LastNameMinPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(3, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method 
        public void LastNameMaxLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(19, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void LastNameMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(20, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void LastNameMaxPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(21, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void LastNameMid()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(13, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void LastNameExtremeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_LastName = Staff_LastName.PadLeft(50, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }



        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES STREET***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method 
        public void StreetMinLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(4, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void StreetMin()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(5, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void StreetMinPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(6, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void StreetMaxLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(49, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void StreetMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(50, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void StreetMaxPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(51, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void StreetMid()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(25, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void StreetExtremeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Street = Staff_Street.PadLeft(100, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }



        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES ADDRESS***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method 
        public void AddressMinLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(19, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void AddressMin()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(20, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void AddressMinPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(21, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void AddressMaxLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(49, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void AddressMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(50, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void AddressMaxPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(51, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void AddressMid()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(35, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void AddressExtremeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Address = Staff_Address.PadLeft(100, 'F');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }



        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES POSTCODE***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method 
        public void PostcodeMinLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(6, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void PostcodeMin()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(7, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void PostcodeMinPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(8, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void PostcodeMaxLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(6, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void PostcodeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(7, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void PostcodeMaxPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(8, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void PostcodeMid()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(0);
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void PostcodeExremeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Postcode = Staff_Postcode.PadLeft(50, 'S');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }



        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES EMAIL***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method 
        public void EmailMinLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(19, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void EmailMin()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(20, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void EmailMinPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(21, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void EmailMaxLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(49, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void EmailMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(50, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void EmailMaxPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(51, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void EmailMid()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(25, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method 
        public void EmailExtremeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Email = Staff_Email.PadLeft(100, 'J');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }



        ////***TESTING PROPERTIES***/

        ///// <summary>
        ///// //***TESTING PROPERTIES TELEPHONE***//
        ///// </summary>
        ///// 

        [TestMethod]
        //testing the valid method 
        public void TelephoneMinLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(10, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void TelephoneMin()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(11, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void TelephoneMinPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(12, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void TelephoneMaxLessOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(10, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method 
        public void TelephoneMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(11, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void TelephoneMaxPlusOne()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(12, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void TelephoneMid()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(7, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method 
        public void TelephoneExtremeMax()
        {
            //create an instance of a class
            clsVPStaff AVPStaff = new clsVPStaff();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method 
            Staff_Telephone = Staff_Telephone.PadLeft(15, '0');
            //invoke the method 
            Error = AVPStaff.Valid(Staff_FirstName, Staff_LastName, Staff_Street, Staff_Address, Staff_Postcode, Staff_Email, Staff_Telephone);
            //test to see the resutls is OK, e.g. no error message is retuned 
            Assert.AreNotEqual(Error, "");
        }


    }
}
