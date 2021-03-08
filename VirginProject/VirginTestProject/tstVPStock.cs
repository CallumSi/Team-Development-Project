using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPStock
    {
        //testing stock properties

        string Quantity = "4";

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPStock AVPStock = new clsVPStock();
            //test to see that it exists
            Assert.IsNotNull(AVPStock);
        }

        //testing the property stock id (PK)
        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class
            clsVPStock AVPStock = new clsVPStock();
            //create a variable to store the stock id of the stock
            Int32 SomeStockID;
            //assign an ID  to the variable
            SomeStockID = 192;
            //try to send some data to the id property
            AVPStock.Stock_ID = SomeStockID;
            //test to see that it exists
            Assert.AreEqual(AVPStock.Stock_ID, SomeStockID);
        }

        [TestMethod]
        public void PhoneIDPropertyOK()
        {
            //create an instance of the class
            clsVPStock AVPStock = new clsVPStock();
            //create a variable to store the phone id of the stock
            Int32 SomePhoneID;
            //assign an ID  to the variable
            SomePhoneID = 1;
            //try to send some data to the id property
            AVPStock.Phone_ID = SomePhoneID;
            //test to see that it exists
            Assert.AreEqual(AVPStock.Phone_ID, SomePhoneID);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class
            clsVPStock AVPStock = new clsVPStock();
            //create a variable to store the quantity of the stock
            Int32 SomeQuantity;
            //assign a quanity to the variable
            SomeQuantity = 4;
            //try to send some data to the quantity property
            AVPStock.Quantity = SomeQuantity;
            //test to see that it exists
            Assert.AreEqual(AVPStock.Quantity, SomeQuantity);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVPStock AVPStock = new clsVPStock();
            //create a string variable to store the validation
            string Error = "";
            //create some test data 
            string Quantity = "4";
            //invoke the method 
            Error = AVPStock.Valid(Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");

        }


        ////***TESTING PROPERTIES***/

        ///// <summary>
        ///// //***TESTING PROPERTIES QUANTITY***//
        ///// </summary>
        ///// 

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityMinLessOne()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityMin()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityMinPlusOne()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityMaxLessOne()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityMax()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityMaxPlusOne()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityMid()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////testing the quantity method
        //public void QuantityExtremeMax()
        //{
        //    //create an instance of a class
        //    clsVPStock AVPStock = new clsVPStock();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    Int32 Quantity = 0; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Quantity = Quantity = (0);
        //    //invoke the method
        //    Error = AVPStock.Valid(Quantity);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreNotEqual(Error, "");
        //}
    }
}
