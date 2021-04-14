using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPOrder
    {

        //testing order properties 

        string Delivery_Date = DateTime.Now.ToString();


        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPOrder AVPOrder = new clsVPOrder();
            //test to see that it exists
            Assert.IsNotNull(AVPOrder);
        }

        //testing the property order id (pk)

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a variable to store the order id of the order
            Int32 SomeOrderID;
            //assign an ID to the variable
            SomeOrderID = 1100;
            //try to send some data to the id property 
            AVPOrder.Order_ID = SomeOrderID;
            //test to see that it exists
            Assert.AreEqual(AVPOrder.Order_ID, SomeOrderID);
        }

        //testing the customer id (fk)

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a variable to store the customer id of the order
            Int32 SomeCustomerID;
            //assign an ID to the variable
            SomeCustomerID = 1;
            //try to send some data to the id property 
            AVPOrder.Customer_ID = SomeCustomerID;
            //test to see that it exists
            Assert.AreEqual(AVPOrder.Customer_ID, SomeCustomerID);
        }

        //testing the delivery date 

        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            //create an instance of the class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a variable to store the delivery date of the order
            DateTime SomeDeliveryDate = DateTime.Now.Date;
            //try to send some data to the data property 
            AVPOrder.Delivery_Date = SomeDeliveryDate;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPOrder.Delivery_Date, SomeDeliveryDate);

        }

        //testing the valid methid
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a variable to store the data of validation
            string Error = "";
            //create some test data
            string Delivery_Date = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES DELIVERY DATE***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMinLessOne()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeDeliveryDate = SomeDeliveryDate.AddYears(-101);
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMin()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeDeliveryDate = SomeDeliveryDate.AddYears(-100);
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMinPlusOne()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeDeliveryDate = SomeDeliveryDate.AddYears(-99);
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMaxLessOne()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeDeliveryDate = SomeDeliveryDate.AddYears(99);
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMax()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeDeliveryDate = SomeDeliveryDate.AddYears(100);
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMaxPlusOne()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeDeliveryDate = SomeDeliveryDate.AddYears(101);
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMid()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateExtremeMax()
        {
            //create an instance of a class
            clsVPOrder AVPOrder = new clsVPOrder();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //create some test data to pass the valid method
            SomeDeliveryDate = SomeDeliveryDate.AddYears(200);
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPOrder.Valid(Delivery_Date);
            //test to see that results is OK, e.g no error message is returned 
            Assert.AreNotEqual(Error, "");
        }
    }
}
