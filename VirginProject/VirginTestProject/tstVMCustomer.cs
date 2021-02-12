using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMCustomer
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
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
            SomeVMcustomerEmail = "JaneDoe@hotmail.com";
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
            //create a variable to store the email of the customer
            string SomeVMcustomerPassword;
            //try send some data to the customer email property
            SomeVMcustomerPassword = "JaneDoe123456";
            //try send some data to the VMcustomerEmail property
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
            string VMcustomerFirstName = "Marc";
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
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
            Error = ACustomer.Valid(VMcustomerFirstName);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
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
            Error = ACustomer.Valid(VMcustomerFirstName);
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
            VMcustomerFirstName = VMcustomerFirstName.PadLeft(500, 'A');
            //invoke the method
            Error = ACustomer.Valid(VMcustomerFirstName);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }
    }
}
