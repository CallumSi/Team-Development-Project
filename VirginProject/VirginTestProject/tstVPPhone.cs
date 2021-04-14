using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVPPhone
    {

        //testing phone properties 
        string Capacity = "128GB";
        string Colour = "Blue";
        string Description = "New iPhone 12 Pro Max";
        string Make = "Apple";
        string Model = "12 Pro Max";
        string Price = "1250.00";
        string StockStatus = "True";
        string Quantity = "1";
        
        
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //test to see that it exists
            Assert.IsNotNull(AVPPhone);
        }


        [TestMethod]

        //testing the capacity property
        public void CapacityPropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the capacity of the phone
            string SomeCapacity;
            //assign a capacity to the variable 
            SomeCapacity = "128GB";
            //try to send some data to capacity property
            AVPPhone.Capacity = SomeCapacity;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.Capacity, SomeCapacity);
        }


        [TestMethod]

        //testing the colour property
        public void ColourPropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the colour of the phone
            string SomeColour;
            //assign a colour to the variable 
            SomeColour = "Blue";
            //try to send some data to colour property
            AVPPhone.Colour = SomeColour;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.Colour, SomeColour);
        }


        [TestMethod]

        //testing the description property
        public void DescriptionPropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the description of the phone
            string SomeDescription;
            //assign a description to the variable 
            SomeDescription = "New iPhone 12 Pro Max";
            //try to send some data to description property
            AVPPhone.Description = SomeDescription;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.Description, SomeDescription);
        }


        [TestMethod]

        //testing the make property
        public void MakePropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the make of the phone
            string SomeMake;
            //assign a make to the variable 
            SomeMake = "Apple";
            //try to send some data to make property
            AVPPhone.Make = SomeMake;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.Make, SomeMake);
        }


        [TestMethod]

        //testing the model property
        public void ModelPropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the model of the phone
            string SomeModel;
            //assign a model to the variable 
            SomeModel = "12 Pro Max";
            //try to send some data to model property
            AVPPhone.Model = SomeModel;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.Model, SomeModel);
        }


        [TestMethod]

        //testing the price property
        public void PricePropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the price of the phone
            decimal SomePrice;
            //assign a price to the variable 
            SomePrice = 1250.00M;
            //try to send some data to price property
            AVPPhone.Price = SomePrice;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.Price, SomePrice);
        }

        [TestMethod]

        //testing the stock status property
        public void StockStatusPropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the status of the phone
            Boolean SomeStockStatus;
            //assign a status to the variable 
            SomeStockStatus = true;
            //try to send some data to status property
            AVPPhone.StockStatus = SomeStockStatus;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.StockStatus, SomeStockStatus);
        }


        [TestMethod]

        //testing the stock status property
        public void PhoneIDPropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the id of the phone
            Int32 SomePhoneID;
            //assign a id to the variable 
            SomePhoneID = 1;
            //try to send some data to id property
            AVPPhone.PhoneID = SomePhoneID;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.PhoneID, SomePhoneID);
        }

        [TestMethod]

        //testing the stock status property
        public void QuantityPropertyOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the id of the phone
            Int32 SomeQuantity;
            //assign a id to the variable 
            SomeQuantity = 1;
            //try to send some data to id property
            AVPPhone.Quantity = SomeQuantity;
            //check to see that the data in the variable property are the same
            Assert.AreEqual(AVPPhone.Quantity, SomeQuantity);
        }


        [TestMethod]

        //testing the valid method
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            string Error = "";
            //create some test data 
            string Capacity = "128GB";
            string Colour = "Blue";
            string Description = "New iPhone 12 Pro Max";
            string Make = "Apple";
            string Model = "12 Pro Max";
            string Price = "1250.00";
            string StockStatus = "True";
            string Quantity = "1";
            //invoke the method 
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned 
            Assert.AreEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES CAPACITY***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the capacity method
        public void CapacityMinLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(3, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the capacity method
        public void CapacityMin()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(4, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the capacity method
        public void CapacityMinPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(5, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the capacity method
        public void CapacityMaxLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(4, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the capacity method
        public void CapacityMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(5, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the capacity method
        public void CapacityMaxPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(6, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
        public void CapacityMid()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(4, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the capacity method
        public void CapacityExtremeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Capacity = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Capacity = Capacity.PadLeft(20, '1');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES COLOUR***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the colour method
        public void ColourMinLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(1, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the colour method
        public void ColourMin()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(2, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the colour method
        public void ColourMinPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(3, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the colour method
        public void ColourMaxLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(9, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the colour method
        public void ColourMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(10, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the colour method
        public void ColourMaxPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(11, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the colour method
        public void ColourMid()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(6, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the colour method
        public void ColourExtremeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Colour = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Colour = Colour.PadLeft(50, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES DESCRIPTION***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the description method
        public void DescriptionMinLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(4, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the description method
        public void DescriptionMin()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(5, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the description method
        public void DescriptionMinPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(6, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the description method
        public void DescriptionMaxLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(49, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the description method
        public void DescriptionMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(50, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the description method
        public void DescriptionMaxPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(51, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the description method
        public void DescriptionMid()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(30, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the description method
        public void DescriptionExtremeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Description = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Description = Description.PadLeft(100, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }



        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES MAKE***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the make method
        public void MakeMinLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(3, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the make method
        public void MakeMin()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(4, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the make method
        public void MakeMinPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(5, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the make method
        public void MakeMaxLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(14, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the make method
        public void MakeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(15, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the make method
        public void MakeMaxPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(16, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the make method
        public void MakeMid()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(10, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the make method
        public void MakeExtremeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Make = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Make = Make.PadLeft(50, 'A');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES MODEL***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the model method
        public void ModelMinLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(1, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the model method
        public void ModelMin()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(2, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the model method
        public void ModelMinPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(3, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the model method
        public void ModelMaxLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(29, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the model method
        public void ModelMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(30, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the model method
        public void ModelMaxPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(31, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the model method
        public void ModelMid()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(16, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the make method
        public void ModelExtremeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Model = ""; //this should trigger an error message
            //create some test data to pass the valid method
            Model = Model.PadLeft(1000, 'I');
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES PRICE***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the price method
        public void PriceMinLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "99.9"; 
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the price method
        public void PriceMin()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "100.00"; 
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the price method
        public void PriceMinPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "100.01";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the model method
        public void PriceMaxLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "1999.99";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus,Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the price method
        public void PriceMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "2000.00"; 
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus,Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the price method
        public void PriceMaxPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "2000.01"; 
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus,Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the price method
        public void PriceMid()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "1050.00"; 
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus,Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the price method
        public void PriceExtremeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string AnPrice = "3000.00";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, AnPrice, StockStatus,Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES QUANTITY***//
        /// </summary>
        /// 

        [TestMethod]
        //testing the quanity method
        public void QuantityMinLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Quantity = "";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the quantity method
        public void QuantityMin()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Quantity = "1";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the quantity method
        public void QuantityMinPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Quantity = "2";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the quantity method
        public void QuantityMaxLessOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Quantity = "4";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the quantity method
        public void QuantityMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Quantity = "5";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        //testing the quantity method
        public void QuantityMaxPlusOne()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Price = "6";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //testing the quantity method
        public void QuantityMid()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Quantity = "3";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the price method
        public void QuantityExtremeMax()
        {
            //create an instance of a class 
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation 
            String Error = "";
            //create some test data to test the valid method 
            string Quantity = "20";
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus, Quantity);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }




    }
}
