using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMPayment
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the clsVMPayment class
            clsVMPayment APayment = new clsVMPayment();
            //test to see that it exists
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void VMpaymentIDPropertyOK()
        {
            //create an instance of the clsVMPayment class
            clsVMPayment APayment = new clsVMPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            APayment.VMPaymentID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayment.VMPaymentID, TestData);
        }

        [TestMethod]
        public void VMpaymentStatusPropertyOK()
        {
            //create an instance of the clsVMPayment class
            clsVMPayment APayment = new clsVMPayment();
            //create a variable to store the first name of the customer
            Boolean TestData = true;
            //assign data to the property
            APayment.VMPaymentStatus = TestData;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(APayment.VMPaymentStatus, TestData);
        }

        [TestMethod]
        public void VMpaymentType()
        {
            //create an instance of the clsVMPayment class
            clsVMPayment APayment = new clsVMPayment();
            //create a variable to store the lastname of the customer
            string SomeVMpaymentType;
            //try send some data to the customer lastname property
            SomeVMpaymentType = "Paypal";
            //try send some data to the VMcustomerLastName property
            APayment.VMPaymentType = SomeVMpaymentType;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(APayment.VMPaymentType, SomeVMpaymentType);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the clsVMPayment class
            clsVMPayment APayment = new clsVMPayment();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String VMPaymentType = "Paypal";
            //test the valid method with the test data
            Error = APayment.Valid(VMPaymentType);
            //Test to ensure no error message
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the clsVMPayment class
            clsVMPayment APayment = new clsVMPayment();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 VMPaymentID = 1;
            //invoke the method
            Found = APayment.Find(VMPaymentID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
    }
}
