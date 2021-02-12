using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{

        [TestClass]
        public class tstVPCustomer
        {
            [TestMethod]
            public void InstantiationOK()
            {
                //create an instance of the class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
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
                SomeAddress = "42D Western Road, Leicestershire";
                //try to sent some data to the Address property
                AVPCustomer.Address = SomeAddress;
                //check to see that the data in the variable and property are the same
                Assert.AreEqual(AVPCustomer.Address, SomeAddress);
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
                SomeEmail = "JaneDoe@hotmail.com";
                //try to sent some data to the Email property
                AVPCustomer.Email = SomeEmail;
                //check to see that the data in the variable and property are the same
                Assert.AreEqual(AVPCustomer.Email, SomeEmail);
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
                AVPCustomer.FirstName = SomeFirstName;
                //check to see that the data in the variable and property are the same
                Assert.AreEqual(AVPCustomer.FirstName, SomeFirstName);
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
                AVPCustomer.LastName = SomeLastName;
                //check to see that the data in the variable and property are the same
                Assert.AreEqual(AVPCustomer.LastName, SomeLastName);
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
                SomePostcode = "LE3 0GH";
                //try to sent some data to the Postcode property
                AVPCustomer.Postcode = SomePostcode;
                //check to see that the data in the variable and property are the same
                Assert.AreEqual(AVPCustomer.Postcode, SomePostcode);
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
                AVPCustomer.Street = SomeStreet;
                //check to see that the data in the variable and property are the same
                Assert.AreEqual(AVPCustomer.Street, SomeStreet);
            }

            [TestMethod]
            //testing the property of Telephone of the class
            public void TelephonePropertyOK()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a variable to store the telephone of the customer
                Int32 SomeTelephone;
                //assign a telephone to the variable
                SomeTelephone = 0123456789;
                //try to sent some data to the Telephone property
                AVPCustomer.Telephone = SomeTelephone;
                //check to see that the data in the variable and property are the same
                Assert.AreEqual(AVPCustomer.Telephone, SomeTelephone);
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
                string FirstName = "Jane";
                //invoke the method
                Error = AVPCustomer.Valid(FirstName);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreEqual(Error, "");
            }


            //***TESTING PROPERTIES***/

            //***TESTING PROPERTIES FIRST NAME***//
            [TestMethod]
            //testing the valid method
            public void FirstNameMinLessOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string FirstName = "J"; //this should trigger an error message -1 characters
                //invoke the method
                Error = AVPCustomer.Valid(FirstName);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

            //***TESTING PROPERTIES FIRST NAME***//
          /* [TestMethod]
            //testing the valid method for first name
            public void FirstNameMaxPlusOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string FirstName = "JJJJJJJJJJJJJJJJJJJJJ"; //this should trigger an error message 21 characters
                //invoke the method
                Error = AVPCustomer.Valid(FirstName);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            } /*

            //***TESTING PROPERTIES FIRST NAME***/
            [TestMethod]
            //testing the valid method for first name
            public void FirstNameExtremeMax()
            {
                //create an instance of a class 
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string FirstName = "";
                //create some test data to test the valid method
                FirstName = FirstName.PadLeft(50);
                //invoke the method
                Error = AVPCustomer.Valid(FirstName);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

            //***TESTING PROPERTIES LAST NAME***//
            [TestMethod]
            //testing the valid method for last name
            public void LastNameMinLessOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string LastName = "D"; //this should trigger an error message -1 characters
                //invoke the method
                Error = AVPCustomer.Valid(LastName);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

            //***TESTING PROPERTIES LAST NAME***//
           /* [TestMethod]
            //testing the valid method for last name
            public void LastNameMaxPlusOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string LastName = "";
                //create some test data to test the valid method
                LastName = LastName.PadLeft(21);
                //invoke the method
                Error = AVPCustomer.Valid(LastName);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            } */

            //***TESTING PROPERTIES LAST NAME***//
            [TestMethod]
            //testing the valid method for first name
            public void LastNameExtremeMax()
            {
                //create an instance of a class 
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string LastName = "";
                //create some test data to test the valid method
                LastName = LastName.PadLeft(50);
                //invoke the method
                Error = AVPCustomer.Valid(LastName);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

            //***TESTING PROPERTIES STREET***//
           [TestMethod]
            //testing the valid method
            public void StreetMinLessOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Street = "W"; //this should trigger an error message 1 characters
                //invoke the method
                Error = AVPCustomer.Valid(Street);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

            //***TESTING PROPERTIES STREET***//
           /* [TestMethod]
            //testing the valid method for street
            public void StreetMaxPlusOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Street = "";
                //create some test data to test the valid method
                Street = Street.PadLeft(21);
                //invoke the method
                Error = AVPCustomer.Valid(Street);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            } */

            //***TESTING PROPERTIES STREET***//
           [TestMethod]
            //testing the valid method for street
            public void StreetExtremeMax()
            {
                //create an instance of a class 
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Street = "";
                //create some test data to test the valid method
                Street = Street.PadLeft(50);
                //invoke the method
                Error = AVPCustomer.Valid(Street);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

            //***TESTING PROPERTIES EMAIL***//
           /*  [TestMethod]
             //testing the valid method
             public void EmailMinLessOne()
             {
                 //create an instance of a class
                 clsVPCustomer AVPCustomer = new clsVPCustomer();
                 //create a string variable to store the validation
                 String Error = "";
                 //create some test data to test the valid method
                 string Email = "JANEDOE@H";
                 //invoke the method
                 Error = AVPCustomer.Valid(Email);
                 //Test to see that result is OK, e.g. no error message is returned
                 Assert.AreNotEqual(Error, "");
             } */


           [TestMethod]
            //testing the valid method for street
            public void EmailMaxPlusOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Email = "";
                //create some test data to test the valid method
                Email = Email.PadLeft(26);
                //invoke the method
                Error = AVPCustomer.Valid(Email);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

           [TestMethod]
            //testing the valid method for email
            public void EmailExtremeMax()
            {
                //create an instance of a class 
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Email = "";
                //create some test data to test the valid method
                Email = Email.PadLeft(50);
                //invoke the method
                Error = AVPCustomer.Valid(Email);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }

            //***TESTING PROPERTIES postcode***//
          /*  [TestMethod]
            //testing the valid method for postcode
            public void PostcodeMinLessOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Postcode = "LE3 0G";
                //invoke the method
                Error = AVPCustomer.Valid(Postcode);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }*/

          /*  [TestMethod]
            //testing the valid method for postcode
            public void PostcodeMaxPlusOne()
            {
                //create an instance of a class
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Postcode = "";
                //create some test data to test the valid method
                Postcode = Postcode.PadLeft(8);
                //invoke the method
                Error = AVPCustomer.Valid(Postcode);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            } */


            [TestMethod]
            //testing the valid method for email
            public void PostcodeExtremeMax()
            {
                //create an instance of a class 
                clsVPCustomer AVPCustomer = new clsVPCustomer();
                //create a string variable to store the validation
                String Error = "";
                //create some test data to test the valid method
                string Postcode = "";
                //create some test data to test the valid method
                Postcode = Postcode.PadLeft(50);
                //invoke the method
                Error = AVPCustomer.Valid(Postcode);
                //Test to see that result is OK, e.g. no error message is returned
                Assert.AreNotEqual(Error, "");
            }
        }
    }

