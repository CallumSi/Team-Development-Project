using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMCustomer
    {
        //create some test data to test the valid method
        string VMcustomerFirstName = "Jane";
        string VMcustomerLastName = "Doe";
        string VMcustomerEmail = "mathunila2198@gmail.com";
        string VMcustomerUsername = "JaneDoe123";
        string VMcustomerPassword = "JaneDoe123456";


        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void VMcustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.VMCustomerID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.VMCustomerID, TestData);
        }

        [TestMethod]
        public void VMcustomerFirstNamePropertyOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a variable to store the first name of the customer
            string SomeVMcustomerFirstName;
            //try send some data to the customer firstname property
            SomeVMcustomerFirstName = "Jane";
            //try send some data to the VMcustomerFirstName property
            ACustomer.VMcustomerFirstName = SomeVMcustomerFirstName;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(ACustomer.VMcustomerFirstName, SomeVMcustomerFirstName);
        }

        [TestMethod]
        public void VMcustomerLastNamePropertyOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a variable to store the lastname of the customer
            string SomeVMcustomerLastName;
            //try send some data to the customer lastname property
            SomeVMcustomerLastName = "Doe";
            //try send some data to the VMcustomerLastName property
            ACustomer.VMcustomerLastName = SomeVMcustomerLastName;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(ACustomer.VMcustomerLastName, SomeVMcustomerLastName);
        }

        [TestMethod]
        public void VMcustomerEmailPropertyOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a variable to store the email of the customer
            string SomeVMcustomerEmail;
            //try send some data to the customer email property
            SomeVMcustomerEmail = "mathunila2198@gmail.com";
            //try send some data to the VMcustomerEmail property
            ACustomer.VMcustomerEmail = SomeVMcustomerEmail;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(ACustomer.VMcustomerEmail, SomeVMcustomerEmail);
        }

        [TestMethod]
        public void VMcustomerUsernamePropertyOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a variable to store the username of the customer
            string SomeVMcustomerUsername;
            //try send some data to the customer username property
            SomeVMcustomerUsername = "JaneDoe123";
            //try send some data to the VMcustomerUsername property
            ACustomer.VMcustomerUsername = SomeVMcustomerUsername;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(ACustomer.VMcustomerUsername, SomeVMcustomerUsername);
        }


        [TestMethod]
        public void VMcustomerPasswordPropertyOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a variable to store the password of the customer
            string SomeVMcustomerPassword;
            //try send some data to the customer password property
            SomeVMcustomerPassword = "JaneDoe123456";
            //try send some data to the VMcustomerPassword property
            ACustomer.VMcustomerPassword = SomeVMcustomerPassword;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(ACustomer.VMcustomerPassword, SomeVMcustomerPassword);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMcustomerFirstName = "Jane";
            string VMcustomerLastName = "Doe";
            string VMcustomerEmail = "mathunila2198@gmail.com";
            string VMcustomerUsername = "JaneDoe123";
            string VMcustomerPassword = "JaneDoe123456";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsVMCustomer ACustomer = new clsVMCustomer();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 VMCustomerID = 4;
            //invoke the method
            Found = ACustomer.Find(VMCustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void VMcustomerFirstNameMinLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMcustomerFirstName = "";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerFirstNameMin()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerFirstName = "L";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerFirstNameMinPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerFirstName = "Lu";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerFirstNameMaxLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerFirstName = "";
            //create some test data to test the valid method 
            VMcustomerFirstName = VMcustomerFirstName.PadRight(54, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerFirstNameMid()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerFirstName = "";
            //create some test data to test the valid method 
            VMcustomerFirstName = VMcustomerFirstName.PadLeft(22, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerFirstNameMaxPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerFirstName = "";
            //create some test data to test the valid method 
            VMcustomerFirstName = VMcustomerFirstName.PadLeft(56, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerFirstNameExtremeMax()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerFirstName = "";
            //create some test data to test the valid method 
            VMcustomerFirstName = VMcustomerFirstName.PadLeft(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerLastNameMinLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMcustomerLastName = "";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerLastNameMin()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerLastName = "L";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerLastNameMinPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerLastName = "Lu";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerLastNameMaxLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerLastName = "";
            //create some test data to test the valid method 
            VMcustomerLastName = VMcustomerLastName.PadLeft(54, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerLastNameMid()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerLastName = "";
            //create some test data to test the valid method 
            VMcustomerLastName = VMcustomerLastName.PadLeft(22, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerLastNamePlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerLastName = "";
            //create some test data to test the valid method 
            VMcustomerLastName = VMcustomerLastName.PadLeft(56, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerLastNameExtremeMax()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerLastName = "";
            //create some test data to test the valid method 
            VMcustomerLastName = VMcustomerLastName.PadLeft(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerEmailMinLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerEmail = "";
            //create some test data to test the valid method 
            VMcustomerEmail = VMcustomerEmail.PadLeft(10, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerEmailMin()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerEmail = "";
            //create some test data to test the valid method 
            VMcustomerEmail = VMcustomerEmail.PadLeft(11, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerEmailMinPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerEmail = "";
            //create some test data to test the valid method 
            VMcustomerEmail = VMcustomerEmail.PadLeft(12, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerEmailMaxLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerEmail = "";
            //create some test data to test the valid method 
            VMcustomerEmail = VMcustomerEmail.PadLeft(54, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerEmailMid()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerEmail = "";
            //create some test data to test the valid method 
            VMcustomerEmail = VMcustomerEmail.PadLeft(22, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerEmailPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerEmail = "";
            //create some test data to test the valid method 
            VMcustomerEmail = VMcustomerEmail.PadLeft(56, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerEmailExtremeMax()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerEmail = "";
            //create some test data to test the valid method 
            VMcustomerEmail = VMcustomerEmail.PadLeft(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerUsernameMinLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMcustomerUsername = "";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerUsernameMin()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerUsername = "L";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerUsernameMinPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerUsername = "Lu";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerUsernameMaxLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerUsername = "";
            //create some test data to test the valid method 
            VMcustomerUsername = VMcustomerUsername.PadLeft(54, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerUsernameMid()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerUsername = "";
            //create some test data to test the valid method 
            VMcustomerUsername = VMcustomerUsername.PadLeft(22, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerUsernamePlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerUsername = "";
            //create some test data to test the valid method 
            VMcustomerUsername = VMcustomerUsername.PadLeft(56, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerUsernameExtremeMax()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerUsername = "";
            //create some test data to test the valid method 
            VMcustomerUsername = VMcustomerUsername.PadLeft(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerPasswordMinLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMcustomerPassword = "JaneDo";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerPasswordMin()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerPassword = "JaneDoe";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerPasswordMinPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMcustomerPassword = "JaneDoe1";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerPasswordMaxLessOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerPassword = "";
            //create some test data to test the valid method 
            VMcustomerPassword = VMcustomerPassword.PadLeft(54, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerPasswordMid()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerPassword = "";
            //create some test data to test the valid method 
            VMcustomerPassword = VMcustomerPassword.PadLeft(22, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerPasswordPlusOne()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerPassword = "";
            //create some test data to test the valid method 
            VMcustomerPassword = VMcustomerPassword.PadLeft(56, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMcustomerPasswordExtremeMax()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMcustomerPassword = "";
            //create some test data to test the valid method 
            VMcustomerPassword = VMcustomerPassword.PadLeft(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName, VMcustomerLastName, VMcustomerEmail, VMcustomerUsername, VMcustomerPassword);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

    }
}
