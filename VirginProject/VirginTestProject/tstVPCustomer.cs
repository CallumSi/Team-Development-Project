using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{

    [TestClass]
    public class tstVPCustomer
    {

        //testing customer properties 

        string Customer_FirstName = "Jane";
        string Customer_LastName = "Doe";
        string Customer_Street = "Western Road";
        string Customer_Address = "42D Western Road,Leicester";
        string Customer_Postcode = "LE3 0BJ";
        string Customer_Email = "JaneDoe123@hotmail.com";
        string Customer_Telephone = "12345678901";

        [TestMethod]

        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //test to see that it exists
            Assert.IsNotNull(AVPCustomer);
        }

        [TestMethod]
        //testing the property of Customer Address of the class
        public void AddressPropertyOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a variable to store the address of the customer
            string SomeAddress;
            //assign an address to the variable
            SomeAddress = "42D Western Road, Leicester";
            //try to sent some data to the Address property
            AVPCustomer.Customer_Address = SomeAddress;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPCustomer.Customer_Address, SomeAddress);
        }

        [TestMethod]
        //testing the property of Email of the class
        public void EmailPropertyOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a variable to store the email of the customer
            string SomeEmail;
            //assign an email to the variable
            SomeEmail = "JaneDoe123@hotmail.com";
            //try to sent some data to the Email property
            AVPCustomer.Customer_Email = SomeEmail;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPCustomer.Customer_Email, SomeEmail);
        }

        [TestMethod]
        //testing the property of First Name of the class
        public void FirstNamePropertyOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a variable to store the first name of the customer
            string SomeFirstName;
            //assign a first name to the variable
            SomeFirstName = "Jane";
            //try to sent some data to the first name property
            AVPCustomer.Customer_FirstName = SomeFirstName;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPCustomer.Customer_FirstName, SomeFirstName);
        }

        [TestMethod]
        //testing the property of Last Name of the class
        public void LastNamePropertyOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a variable to store the last name of the customer
            string SomeLastName;
            //assign a Last name to the variable
            SomeLastName = "Doe";
            //try to sent some data to the first name property
            AVPCustomer.Customer_LastName = SomeLastName;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPCustomer.Customer_LastName, SomeLastName);
        }

        [TestMethod]
        //testing the property of Postcode of the class
        public void PostcodePropertyOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a variable to store the postcode of the customer
            string SomePostcode;
            //assign a Postcode to the variable
            SomePostcode = "LE3 0BJ";
            //try to sent some data to the Postcode property
            AVPCustomer.Customer_Postcode = SomePostcode;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPCustomer.Customer_Postcode, SomePostcode);
        }

        [TestMethod]
        //testing the property of Street of the class
        public void StreetPropertyOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a variable to store the street of the customer
            string SomeStreet;
            //assign a Street to the variable
            SomeStreet = "Western Road";
            //try to sent some data to the Street property
            AVPCustomer.Customer_Street = SomeStreet;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPCustomer.Customer_Street, SomeStreet);
        }

        [TestMethod]
         //testing the property of Telephone of the class
         public void TelephonePropertyOK()
         {
             //create an instance of a class
             clsVPCustomer AVPCustomer = new clsVPCustomer();
             //create a variable to store the telephone of the customer
             string SomeTelephone;
             //assign a telephone to the variable
             SomeTelephone = "0123456789";
             //try to sent some data to the Telephone property
             AVPCustomer.Customer_Telephone = SomeTelephone;
             //check to see that the data in the variable and property are the same
             Assert.AreEqual(AVPCustomer.Customer_Telephone, SomeTelephone);
         }


        [TestMethod]
        //testing the property of ID of the class
        public void CustomerIDPropertyOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a variable to store the id of the customer
            Int32 SomeCustomerID;
            //assign a ID to the variable
            SomeCustomerID = 1;
            //try to sent some data to the ID property
            AVPCustomer.Customer_ID = SomeCustomerID;
            //check to see that the data in the variable and property are the same
            Assert.AreEqual(AVPCustomer.Customer_ID, SomeCustomerID);
        }



        [TestMethod]
        //testing the valid method
        public void ValidMethodOK()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            string Error = "";
            //create some test data 
            string Customer_FirstName = "Jane";
            string Customer_LastName = "Doe";
            string Customer_Address = "42D Western Road, Leicester";
            string Customer_Street = "Western Road";
            string Customer_Postcode = "LE3 0BJ";
            string Customer_Email = "JaneDoe123@hotmail.com";
            string Customer_Telephone = "01234567890";
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
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
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(1, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMin()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_FirstName = ""; //
            //create some test data to pass the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(2, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMinPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_FirstName = ""; //
            //create some test data to pass the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(3, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMaxLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_FirstName = ""; //
            //create some test data to pass the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(19, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMax()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_FirstName = ""; //
            //create some test data to pass the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(20, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMaxPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_FirstName = ""; //
            //create some test data to pass the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(21, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void FirstNameMid()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_FirstName = ""; //
            //create some test data to pass the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(13, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void FirstNameExtremeMax()
        {
            //create an instance of a class 
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_FirstName = "";
            //create some test data to test the valid method
            Customer_FirstName = Customer_FirstName.PadLeft(50, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
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
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Customer_LastName = Customer_LastName.PadLeft(1, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMin()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_LastName = ""; //
            //create some test data to pass the valid method
            Customer_LastName = Customer_LastName.PadLeft(2, 'D');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMinPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_LastName = ""; //
            //create some test data to pass the valid method
            Customer_LastName = Customer_LastName.PadLeft(3, 'D');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMaxLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_LastName = ""; //
            //create some test data to pass the valid method
            Customer_LastName = Customer_LastName.PadLeft(19, 'D');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMax()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_LastName = ""; //
            //create some test data to pass the valid method
            Customer_LastName = Customer_LastName.PadLeft(20, 'D');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMaxPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_LastName = ""; //
            //create some test data to pass the valid method
            Customer_LastName = Customer_LastName.PadLeft(21, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void LastNameMid()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_LastName = ""; //
            //create some test data to pass the valid method
            Customer_LastName = Customer_LastName.PadLeft(13, 'D');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void LastNameExtremeMax()
        {
            //create an instance of a class 
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_LastName = "";
            //create some test data to test the valid method
            Customer_LastName = Customer_LastName.PadLeft(50, 'D');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
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
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Street = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(4, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void StreetMin()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Street = ""; //
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(5, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void StreetMinPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Street = ""; //
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(6, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void StreetMaxLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Street = ""; //
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(49, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void StreetMax()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Street = ""; //
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(50, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void StreetMaxPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Street = ""; //
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(51, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void StreetMid()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Street = ""; //
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(25, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void StreetExtremeMax()
        {
            //create an instance of a class 
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Street = "";
            //create some test data to test the valid method
            Customer_Street = Customer_Street.PadLeft(100, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
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
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Customer_Address = Customer_Address.PadLeft(19, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void AddressMin()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Address = ""; //
            //create some test data to pass the valid method
            Customer_Address = Customer_Address.PadLeft(20, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void AddressMinPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Address = ""; //
            //create some test data to pass the valid method
            Customer_Address = Customer_Address.PadLeft(21, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void AddressMaxLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Address = ""; //
            //create some test data to pass the valid method
            Customer_Address = Customer_Address.PadLeft(49, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void AddressMax()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Address = ""; //
            //create some test data to pass the valid method
            Customer_Address = Customer_Address.PadLeft(50, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void AddressMaxPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Address = ""; //
            //create some test data to pass the valid method
            Customer_Address = Customer_Address.PadLeft(51, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void AddressMid()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Street = ""; //
            //create some test data to pass the valid method
            Customer_Street = Customer_Street.PadLeft(35, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method 
        public void AddressExtremeMax()
        {
            //create an instance of a class 
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Street = "";
            //create some test data to test the valid method
            Customer_Street = Customer_Street.PadLeft(100, 'W');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
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
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(6, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void PostcodeMin()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Postcode = ""; //
            //create some test data to pass the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(7, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void PostcodeMinPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Postcode = ""; //
            //create some test data to pass the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(8, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void PostcodeMaxLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Postcode = ""; //
            //create some test data to pass the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(6, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void PostcodeMax()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Postcode = ""; //
            //create some test data to pass the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(7, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void PostcodeMaxPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Postcode = ""; //
            //create some test data to pass the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(8, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void PostcodeMid()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Postcode = ""; //
            //create some test data to pass the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(0);
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void PostcodeExtremeMax()
        {
            //create an instance of a class 
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Postcode = "";
            //create some test data to test the valid method
            Customer_Postcode = Customer_Postcode.PadLeft(50, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
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
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Email = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Customer_Email = Customer_Email.PadLeft(19, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void EmailMin()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Email = ""; //
            //create some test data to pass the valid method
            Customer_Email = Customer_Email.PadLeft(20, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void EmailMinPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Email = ""; //
            //create some test data to pass the valid method
            Customer_Email = Customer_Email.PadLeft(21, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void EmailMaxLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Email = ""; //
            //create some test data to pass the valid method
            Customer_Email = Customer_Email.PadLeft(49, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void EmailMax()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Email = ""; //
            //create some test data to pass the valid method
            Customer_Email = Customer_Email.PadLeft(50, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void EmailMaxPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Email = ""; //
            //create some test data to pass the valid method
            Customer_Email = Customer_Email.PadLeft(51, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone );
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void EmailMid()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Email = ""; //
            //create some test data to pass the valid method
            Customer_Email = Customer_Email.PadLeft(25, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void EmailExtremeMax()
        {
            //create an instance of a class 
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Email = "";
            //create some test data to test the valid method
            Customer_Email = Customer_Email.PadLeft(100, 'J');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email,Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES TELEPHONE***//
        /// </summary>
        /// 


        [TestMethod]
        //testing the valid method
        public void TelephoneMinLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Telephone = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(10, '0');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void TelephoneMin()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Telephone = ""; //
            //create some test data to pass the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(11, '0');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void TelephoneMinPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Telephone = ""; //
            //create some test data to pass the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(12, '0');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void TelephoneMaxLessOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Telephone = ""; //
            //create some test data to pass the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(10, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void TelephoneMax()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Telephone = ""; //
            //create some test data to pass the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(11, '0');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void TelephoneMaxPlusOne()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Telephone = ""; //
            //create some test data to pass the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(12, '0');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void TelephoneMid()
        {
            //create an instance of a class
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to pass to the method
            string Customer_Telephone = ""; //
            //create some test data to pass the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(7, '0');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void TelephoneExtremeMax()
        {
            //create an instance of a class 
            clsVPCustomer AVPCustomer = new clsVPCustomer();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Customer_Telephone = "";
            //create some test data to test the valid method
            Customer_Telephone = Customer_Telephone.PadLeft(15, 'L');
            //invoke the method
            Error = AVPCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_Street, Customer_Address, Customer_Postcode, Customer_Email, Customer_Telephone);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

    }
}



