using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHCustomer
    {
        //customer First Name property
        string FirstName = "Dante";
        //customer Last Name property
        string LastName = "Alighieri";
        //customer Address property
        string Address = "12 Florence Cresent, Leicestershire";
        //customer Postcode property
        string PostCode = "LE13 2RV";
        //customer Username property
        string Username = "DanteAyyy";
        //customer Email property
        string Email = "d.alighieri@outlook.com";
        //customer Password property
        string Password = "3InPuPa";
        //customer Phone Number property
        string PhoneNumber = "07912345678";

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //test to see that it exists
            Assert.IsNotNull(VCHCustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the customers ID 
            Int32 SomeCustomerID = 1;
            //assign the data to the property
            VCHCustomer.CustomerID = SomeCustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.CustomerID, SomeCustomerID);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the customers first name
            string SomeFirstName = "Dante";
            //assign the data to the property
            VCHCustomer.FirstName = SomeFirstName;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string FirstName = "";
            //pad string of characters
            FirstName = FirstName.PadRight(1, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string FirstName = "";
            //pad string of characters
            FirstName = FirstName.PadRight(31, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string FirstName = "";
            //pad string of characters
            FirstName = FirstName.PadRight(100, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the customers last name
            string SomeLastName = "Alighieri";
            //assign the data to the property
            VCHCustomer.LastName = SomeLastName;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.LastName, SomeLastName);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string LastName = "";
            //pad string of characters
            LastName = LastName.PadRight(1, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string LastName = "";
            //pad string of characters
            LastName = LastName.PadRight(31, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string LastName = "";
            //pad string of characters
            LastName = LastName.PadRight(100, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the address
            string SomeAddress = "12 Florence Crescent, Leicestershire";
            //assign the data to the property
            VCHCustomer.Address = SomeAddress;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.Address, SomeAddress);
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Address = "";
            //pad string of characters
            Address = Address.PadRight(2, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Address = "";
            //pad string of characters
            Address = Address.PadRight(51, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Address = "";
            //pad string of characters
            Address = Address.PadRight(100, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the post code
            string SomePostCode = "LE13 2RV";
            //assign the data to the property
            VCHCustomer.PostCode = SomePostCode;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.PostCode, SomePostCode);
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string PostCode = "";
            //pad string of characters
            PostCode = PostCode.PadRight(4, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string PostCode = "";
            //pad string of characters
            PostCode = PostCode.PadRight(11, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string PostCode = "";
            //pad string of characters
            PostCode = PostCode.PadRight(20, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the email address
            string SomeUsername = "DanteAyyy";
            //assign the data to the property
            VCHCustomer.Username = SomeUsername;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.Username, SomeUsername);
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Username = "";
            //pad string of characters
            Username = Username.PadRight(1, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Username = "";
            //pad string of characters
            Username = Username.PadRight(31, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Username = "";
            //pad string of characters
            Username = Username.PadRight(100, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the email address
            string SomeEmail = "d.alighieri@outlook.com";
            //assign the data to the property
            VCHCustomer.Email = SomeEmail;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.Email, SomeEmail);
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Email = "";
            //pad string of characters
            Email = Email.PadRight(6, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Email = "";
            //pad string of characters
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Email = "";
            //pad string of characters
            Email = Email.PadRight(100, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the password
            string SomePassword = "3InPuPa";
            //assign the data to the property
            VCHCustomer.Password = SomePassword;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.Password, SomePassword);
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Password = "";
            //pad string of characters
            Password = Password.PadRight(5, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Password = "";
            //pad string of characters
            Password = Password.PadRight(21, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string Password = "";
            //pad string of characters
            Password = Password.PadRight(100, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create some test data to assign to the phone number
            string SomePhoneNumber = "07912345678";
            //assign the data to the property
            VCHCustomer.PhoneNumber = SomePhoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(VCHCustomer.PhoneNumber, SomePhoneNumber);
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string PhoneNumber = "";
            //pad string of characters
            PhoneNumber = PhoneNumber.PadRight(10, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string PhoneNumber = "";
            //pad string of characters
            PhoneNumber = PhoneNumber.PadRight(12, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a string variable to hold the validation results (if there's an error, this'll alert users)
            String Error = "";
            //create test data to test the method
            string PhoneNumber = "";
            //pad string of characters
            PhoneNumber = PhoneNumber.PadRight(20, 'a');
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result doesn't pass and an error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //a string variable to store validation results
            String Error = "";
            //test data to test the method
            string FirstName = "Dante";
            string LastName = "Alighieri";
            string Address = "12 Florence Cresent, Leicestershire";
            string PostCode = "LE13 2RV";
            string Username = "DanteAyyy";
            string Email = "d.alighieri@outlook.com";
            string Password = "3InPuPa";
            string PhoneNumber = "07912345678";
            //invoke the method
            Error = VCHCustomer.Valid(FirstName, LastName, Address, PostCode, Username, Email, Password, PhoneNumber);
            //test to check the result does pass and to see if any error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //boolean variable to store validation results
            Boolean found = false;
            //test data to test the method
            Int32 CustomerID = 1;
            //invoke the method
            found = VCHCustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }

    }
}
