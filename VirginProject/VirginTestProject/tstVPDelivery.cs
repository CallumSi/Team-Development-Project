using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPDelivery
    {
        //testing delivery properties

        string Title = "Miss";
        string FirstName = "Sienna";
        string LastName = "Campbell";
        string House_No = "31";
        string Delivery_Address = "31 Camp Road, Buckinghamshire";
        string Delivery_Postcode = "SL9 7PG";
        string Delivery_Date = DateTime.Now.ToString();
        

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //test to see that is exists
            Assert.IsNotNull(AVPDelivery);
        }

        //testing the property delivery id (PK)
        [TestMethod]
        public void DeliveryIDPropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the delivery id of the delivery
            Int32 SomeDeliveryID;
            //assign an ID to the variable
            SomeDeliveryID = 1;
            //try to send some data to the id property 
            AVPDelivery.Delivery_ID = SomeDeliveryID;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.Delivery_ID, SomeDeliveryID);
        }


        //testing the property order id (FK)
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the order id of the delivery
            Int32 SomeOrderID;
            //assign an ID to the variable
            SomeOrderID = 1100;
            //try to send some data to the id property 
            AVPDelivery.Order_ID = SomeOrderID;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.Order_ID, SomeOrderID);
        }

        //testing the property title
        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the title of the delivery
            string SomeTitle;
            //assign an title to the variable
            SomeTitle = "Miss";
            //try to send some data to the title property 
            AVPDelivery.Title = SomeTitle;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.Title, SomeTitle);
        }

        //testing the property first name
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the first name of the delivery
            string SomeFirstName;
            //assign an first name to the variable
            SomeFirstName = "Sienna";
            //try to send some data to the first name property 
            AVPDelivery.FirstName = SomeFirstName;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.FirstName, SomeFirstName);
        }

        //testing the property last name
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the last name of the delivery
            string SomeLastName;
            //assign an last name to the variable
            SomeLastName = "Campbell";
            //try to send some data to the last name property 
            AVPDelivery.LastName = SomeLastName;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.LastName, SomeLastName);
        }
        

        //testing the property houseno
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the house no of the delivery
            Int32 SomeHouseNo;
            //assign an address to the variable
            SomeHouseNo = 31;
            //try to send some data to the address property 
            AVPDelivery.House_No = SomeHouseNo;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.House_No, SomeHouseNo);
        }


        //testing the property address
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the address of the delivery
            string SomeAddress;
            //assign an address to the variable
            SomeAddress = "31 Camp Road, Buckinghamshire";
            //try to send some data to the address property 
            AVPDelivery.Delivery_Address = SomeAddress;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.Delivery_Address, SomeAddress);
        }


        //testing the property postcode
        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the postcode of the delivery
            string SomePostcode;
            //assign an postcode to the variable
            SomePostcode = "SL9 7PG";
            //try to send some data to the postcode property 
            AVPDelivery.Delivery_Postcode = SomePostcode;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.Delivery_Postcode, SomePostcode);
        }


        //testing the property date
        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the date of the delivery
            DateTime SomeDeliveryDate = DateTime.Now.Date;
            //try to send some data to the date property 
            AVPDelivery.Delivery_Date = SomeDeliveryDate;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.Delivery_Date, SomeDeliveryDate);
        }


        //testing the valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a variable to store the date of the validation
            string Error = "";
            //create some test data 
            string Title = "Miss";
            string FirstName = "Sienna";
            string LastName = "Campbell";
            string House_No = "31";
            string Delivery_Address = "31 Camp Road,Buckinghamshire";
            string Delivery_Postcode = "SL9 7PG";
            string Delivery_Date = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //test to see that the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        ////***TESTING PROPERTIES***/

        ///// <summary>
        ///// //***TESTING PROPERTIES TITLE***//
        ///// </summary>
        ///// 
        //[TestMethod]
        ////testing the valid method
        //public void TitleMinLessOne()
        //{
        //    //create an instance of a class
        //    clsVPDelivery AVPDelivery = new clsVPDelivery();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    string Title = ""; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Title = Title.PadLeft(1, 'M');
        //    //invoke the method
        //    Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreNotEqual(Error, "");
        //}


        [TestMethod]
        //testing the valid method
        public void TitleMin()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(2, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void TitleMinPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(3, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void TitleMaxLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(9, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void TitleMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(10, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        //[TestMethod]
        ////testing the valid method
        //public void TitleMaxPlusOne()
        //{
        //    //create an instance of a class
        //    clsVPDelivery AVPDelivery = new clsVPDelivery();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    string Title = ""; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Title = Title.PadLeft(11, 'M');
        //    //invoke the method
        //    Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreNotEqual(Error, "");
        //}


        [TestMethod]
        //testing the valid method
        public void TitleMid()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(6, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        //[TestMethod]
        ////testing the valid method
        //public void TitleExtremeMax()
        //{
        //    //create an instance of a class
        //    clsVPDelivery AVPDelivery = new clsVPDelivery();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    string Title = ""; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    Title = Title.PadLeft(20, 'M');
        //    //invoke the method
        //    Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreNotEqual(Error, "");
        //}


        ////***TESTING PROPERTIES***/

        ///// <summary>
        ///// //***TESTING PROPERTIES FIRST NAME***//
        ///// </summary>
        ///// 
        //[TestMethod]
        ////testing the valid method
        //public void FirstNameMinLessOne()
        //{
        //    //create an instance of a class
        //    clsVPDelivery AVPDelivery = new clsVPDelivery();
        //    //create a string variable to store the validation
        //    String Error = "";
        //    //create some test data to test the valid method
        //    string FirstName = ""; //this should trigger an error message
        //    //create some test data to pass the valid method
        //    FirstName = FirstName.PadLeft(2, 'S');
        //    //invoke the method
        //    Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
        //    //Test to see that result is OK, e.g. no error message is returned
        //    Assert.AreNotEqual(Error, "");
        //}

    }
}
