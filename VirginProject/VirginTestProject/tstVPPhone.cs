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
        string Description = "New iPhone 12 Pro";
        string Make = "Apple";
        string Model = "12 Pro Max";
        decimal Price = 1250.00M;
        bool StockStatus = true;

        [TestMethod]
        public void InstantiationOK ()
        {
            ///create an insatance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            Assert.IsNotNull(AVPPhone);  
        }


        [TestMethod]

        //testing the property capacity 
        public void CapacityPropertyOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the capacity of the phone
            string SomeCapacity;
            //assign a capacity to the variable
            SomeCapacity = "128GB";
            //try to send some data to capacity property
            AVPPhone.Capacity = SomeCapacity;
            Assert.AreEqual(AVPPhone.Capacity, SomeCapacity);
        }

        [TestMethod]

        //testing the property colour 
        public void ColourPropertyOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the colour of the phone
            string SomeColour;
            //assign a colour to the variable
            SomeColour = "Blue";
            //try to send some data to colour property
            AVPPhone.Colour = SomeColour;
            Assert.AreEqual(AVPPhone.Colour, SomeColour);
        }


        [TestMethod]

        //testing the property description
        public void DescriptionPropertyOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the description of the phone
            string SomeDescription;
            //assign a description to the variable
            SomeDescription = "New iPhone 12 Pro Max";
            //try to send some data to description property
            AVPPhone.Description = SomeDescription;
            Assert.AreEqual(AVPPhone.Description, SomeDescription);
        }

        [TestMethod]

        //testing the property make 
        public void MakePropertyOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the Make of the phone
            string SomeMake;
            //assign a make to the variable
            SomeMake = "Apple";
            //try to send some data to make property
            AVPPhone.Make = SomeMake;
            Assert.AreEqual(AVPPhone.Make, SomeMake);
        }

        [TestMethod]

        //testing the property model 
        public void ModelPropertyOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the Model of the phone
            string SomeModel;
            //assign a model to the variable
            SomeModel = "12 Pro Max";
            //try to send some data to model property
            AVPPhone.Model = SomeModel;
            Assert.AreEqual(AVPPhone.Model, SomeModel);
        }

        [TestMethod]

        //testing the property price 
        public void PricePropertyOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the price of the phone
            decimal SomePrice;
            //assign a price to the variable
            SomePrice = 1250.00M;
            //try to send some data to price property
            AVPPhone.Price = SomePrice;
            Assert.AreEqual(AVPPhone.Price, SomePrice);
        }

        [TestMethod]

        //testing the property stock status 
        public void StockStatusPropertyOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a variable to store the Model of the phone
            bool SomeStockStatus;
            //assign a make to the variable
            SomeStockStatus = true;
            //try to send some data to make property
            AVPPhone.StockStatus = SomeStockStatus;
            Assert.AreEqual(AVPPhone.StockStatus, SomeStockStatus);
        }

        [TestMethod]

        //testing the property stock status 
        public void ValidMethodOK()
        {
            ///create an instance of the class
            clsVPPhone AVPPhone = new clsVPPhone();
            //create a string variable to store the validation
            string Error = "";
            //create some test data 
            string Capacity = "128GB";
            string Colour = "Blue";
            string Description = "New iPhone 12 Pro Max";
            string Make = "Apple";
            string Model = "12 Pro Max";
            decimal Price = 1250.00M;
            bool StockStatus = true;
            //invoke the method
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }
            


        //***TESTING PROPERTIES***/

        /// <summary>
        /// //***TESTING PROPERTIES CAPACITY***//
        /// </summary>
        /// 
        [TestMethod]
        //testing the valid method
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
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        //testing the valid method
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
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
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
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
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
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
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
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //testing the valid method
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
            Error = AVPPhone.Valid(Capacity, Colour, Description, Make, Model, Price, StockStatus);
            //test to see the results is OK, e.g no error message is returned
            Assert.AreNotEqual(Error, "");
        }

    }
}
