using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPCart
    {
        //testing cart properties

        string Products = "iPhone 12 Pro Max";

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPCart AVPCart = new clsVPCart();
            //test to see it exists
            Assert.IsNotNull(AVPCart);
        }

        //testing the property cart no
        [TestMethod]
        public void CartNoPropertyOK()
        {
            //create an instance of the class
            clsVPCart AVPCart = new clsVPCart();
            //create a variable to store the cart no
            Int32 SomeCartNo;
            //assign a cart no to the variable
            SomeCartNo = 1;
            //try to send some data to the cart no property
            AVPCart.CartNo = SomeCartNo;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPCart.CartNo, SomeCartNo);
        }

        //testing the property product
        [TestMethod]
        public void ProductPropertyOK()
        {
            //create an instance of the class
            clsVPCart AVPCart = new clsVPCart();
            //create a variable to store the products 
            string SomeProducts;
            //assign products to the variable
            SomeProducts = "iPhone 12 Pro Max";
            //try to send some data to the products property
            AVPCart.Products = SomeProducts;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPCart.Products, SomeProducts);
        }

        //testing the valid method 
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVPCart AVPCart = new clsVPCart();
            //create variable to store the data of the validation
            string Error = "";
            //create some test data
            string Products = "iPhone 12 Pro Max";
            //invoke the method
            Error = AVPCart.Valid(Products);
            //test to see that the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES PRODUCTS***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method
        public void ProductsMinLessOne()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(1, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void ProductsMin()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(2, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void ProductsMinPlusOne()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(3, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void ProductsMaxLessOne()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(49, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void ProductsMax()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(50, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void ProductsMaxPlusOne()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(51, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void ProductsMid()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(26, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void ProductsExtremeMax()
        {
            //create an instance of a class
            clsVPCart AVPCart = new clsVPCart();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Products = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Products = Products.PadLeft(100, 'A');
            //invoke the method
            Error = AVPCart.Valid(Products);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

    }
}
