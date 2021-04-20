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
            SomeOrderID = 2;
            //try to send some data to the id property 
            AVPDelivery.OrderID = SomeOrderID;
            //check to see the data in the variable and property are the same
            Assert.AreEqual(AVPDelivery.OrderID, SomeOrderID);
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
            //assign an houseno to the variable
            SomeHouseNo = 31;
            //try to send some data to the house no property 
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
            //create a variable to store the data of the validation
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

        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES TITLE***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the valid method
        public void TitleMinLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(1, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

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


        [TestMethod]
        //testing the valid method
        public void TitleMaxPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(11, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


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


        [TestMethod]
        //testing the valid method
        public void TitleExtremeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Title = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Title = Title.PadLeft(20, 'M');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES FIRST NAME***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the valid method
        public void FirstNameMinLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(1, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMin()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(2, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMinPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(3, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMaxLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(19, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(20, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMaxPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(21, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameMid()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(13, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void FirstNameExtremeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string FirstName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            FirstName = FirstName.PadLeft(50, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES LAST NAME***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the valid method
        public void LastNameMinLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(1, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMin()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(2, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMinPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(3, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMaxLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(19, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(20, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMaxPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(21, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameMid()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(13, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void LastNameExtremeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string LastName = ""; //this should trigger an error message
            //create some test data to pass the valid method
            LastName = LastName.PadLeft(50, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES HOUSE NO***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the valid method
        public void HouseNoMinLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = ""; 
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void HouseNoMin()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = "1";
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void HouseNoMinPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = "2";
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void HouseNoMaxLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = "999";
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void HouseNoMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = "1000";
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void HouseNoMaxPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = "1001";
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void HouseNoMid()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = "500";
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void HouseNoMinExtremeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string House_No = "2000";
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }



        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES DELIVERY ADDRESS***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the valid method
        public void DeliveryAddressMinLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(4, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryAddressMin()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(5, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryAddressMinPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(6, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryAddressMaxLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(49, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryAddressMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(50, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryAddressMaxPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(51, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryAddressMid()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(35, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryAddressExtremeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Address = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Address = Delivery_Address.PadLeft(100, 'C');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES DELIVERY POSTCODE***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeMinLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(6, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeMin()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(7, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeMinPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(8, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeMaxLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(6, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(7, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeMaxPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(8, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeMid()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(0);
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryPostcodeExtremeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            string Delivery_Postcode = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Delivery_Postcode = Delivery_Postcode.PadLeft(50, 'S');
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
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
            clsVPDelivery AVPDelivery = new clsVPDelivery();
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
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryDateMin()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
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
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMinPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
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
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMaxLessOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
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
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryDateMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
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
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
        public void DeliveryDateMaxPlusOne()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
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
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateMid()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
            //create a string variable to store the validation
            String Error = "";
            //create some test data to test the valid method
            DateTime SomeDeliveryDate;
            //set the date to todays date
            SomeDeliveryDate = DateTime.Now.Date;
            //convert the date variable to string
            string Delivery_Date = SomeDeliveryDate.ToString();
            //invoke the method
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void DeliveryDateExtremeMax()
        {
            //create an instance of a class
            clsVPDelivery AVPDelivery = new clsVPDelivery();
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
            Error = AVPDelivery.Valid(Title, FirstName, LastName, House_No, Delivery_Address, Delivery_Postcode, Delivery_Date);
            //Test to see that result is OK, e.g. no error message is returned
            Assert.AreNotEqual(Error, "");
        }
    }
}
