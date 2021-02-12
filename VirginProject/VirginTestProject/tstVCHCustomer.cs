using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHCustomer
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers first name 
            string SomeFirstName;
            //assign a FirstName to the variable
            SomeFirstName = "Dante";
            //try send data to the FirstName property
            VCHCustomer.FirstName = SomeFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.FirstName, SomeFirstName);
        }

        /*[TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a 1 letter string
            OK = VCHCustomer.Valid("D");
            //assert the the outcome should be false
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNamePlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(31);
            //test the valid method with a 31 letter string
            OK = VCHCustomer.Valid(SomeText);
            //assert the the outcome should be true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(100);
            //test the valid method with a 100 letter string
            OK = VCHCustomer.Valid(SomeText);
            //assert the the outcome should be true
            Assert.IsFalse(OK);
        }*/

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers first name 
            string SomeLastName;
            //assign a LastName to the variable
            SomeLastName = "Alighieri";
            //try send data to the LastName property
            VCHCustomer.LastName = SomeLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.LastName, SomeLastName);
        }

        /*[TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a 1 letter string
            OK = VCHCustomer.Valid("A");
            //assert the the outcome should be false
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNamePlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(31);
            //test the valid method with a 31 letter string
            OK = VCHCustomer.Valid(SomeText);
            //assert the the outcome should be true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(100);
            //test the valid method with a 100 letter string
            OK = VCHCustomer.Valid(SomeText);
            //assert the the outcome should be true
            Assert.IsFalse(OK);
        }*/

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers address
            string SomeAddress;
            //assign an Address to the variable
            SomeAddress = "12 Florence Cresent, Leicestershire";
            //try send data to the Address property
            VCHCustomer.Address = SomeAddress;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.Address, SomeAddress);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers phone number
            string SomePhoneNumber;
            //assign a PhoneNumber to the variable
            SomePhoneNumber = "07912345678";
            //try send data to the PhoneNumber property
            VCHCustomer.PhoneNumber = SomePhoneNumber;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.PhoneNumber, SomePhoneNumber);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers email
            string SomeEmail;
            //assign an Email to the variable
            SomeEmail = "d.alighieri@gmail.co.uk";
            //try send data to the Email property
            VCHCustomer.Email = SomeEmail;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.Email, SomeEmail);
        }

        [TestMethod]
        public void PasswordOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers password
            string SomePassword;
            //assign a Password to the variable
            SomePassword = "3booksInPuPa";
            //try send data to the Password property
            VCHCustomer.Password = SomePassword;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.Password, SomePassword);
        }

        [TestMethod]
        //used to test the presence of the Valid method
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //test to see if the valid method exists
            VCHCustomer.Valid("Dante", "Alighieri");
            
            /*//create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to store the validation
            string Error = "";
            //create some test data to test the valid method
            string FirstName = "Dante";
            //invoke the method
            Error = VCHCustomer.Valid(FirstName);
            //Test to see that the result is OK (see if any error message is returned(
            Assert.AreEqual(Error, "");*/

        }
    }
}

