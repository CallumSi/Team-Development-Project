using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceUser

    {
        //some test data to insert into the valid method 
        String AnDeliveryAdressLineOne = "77 Wall Street";
        String AnDeliveryAdressLineTwo = "New York";
        String AnPostcode = "LE4 4GL";
        String AnEmail = "cjs@gmail.com";

        //Testing Class 
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test to see if it existis
            Assert.IsNotNull(AnMarketplaceUser);
        }


        //Testing Properties

        [TestMethod]
        public void AdminPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            Boolean TestData = true;
            //assign data to the property
            AnMarketplaceUser.Admin = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.Admin, TestData);


        }

        [TestMethod]
        public void DeliveryAdressLineOnePropertyOK()
        {
            //HouseNumber + Street name
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            string TestData = "77 Wall Street";
            //assign data to the property
            AnMarketplaceUser.DeliveryAdressLineOne = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.DeliveryAdressLineOne, TestData);
        }

        [TestMethod]
        public void DeliveryAdressLineTwoPropertyOK()
        {
            //City
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            string TestData = "New York";
            //assign data to the property
            AnMarketplaceUser.DeliveryAdressLineTwo = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.DeliveryAdressLineTwo, TestData);
        }


        [TestMethod]
        public void PostCodePropertyOK()
        {
            //postcode in correct format 

            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            string TestData = "LE1 5BD";
            //assign data to the property
            AnMarketplaceUser.PostCode = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.PostCode, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //Email in form aa@bb.cc

            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            string TestData = "steve@gmail.com";
            //assign data to the property
            AnMarketplaceUser.Email = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.Email, TestData);
        }

   

        [TestMethod]
        public void RatingPropertyOK()
        {
            //integer between 1 and 10 inclusive

            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            int TestData = 7;
            //assign data to the property
            AnMarketplaceUser.Rating = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.Rating, TestData);
        }


        [TestMethod]
        public void UserIDOK()
        {
            //integer

            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            int TestData = 1;
            //assign data to the property
            AnMarketplaceUser.UserID = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.UserID, TestData);
        }


        //Testing the validmethod 

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }

        //Blank Tests
        [TestMethod]
        public void AnDeliveryAdressLineOneBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AnDeliveryAdressLineTwoBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineTwo = "";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AnPostCodeBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPostcode = "";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void AnEmailBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
  
            String AnEmail = "";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }





        // Min boundary resting 

        [TestMethod]
        public void AnDeliveryAdressLineOneMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "a";;
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void AnDeliveryAdressLineTwoMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineTwo = "a";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void AnPostCodeMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPostcode = "a";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void AnEmailMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnEmail = "a@b";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }


       

        // Max Boundary testing 

        [TestMethod]
        public void AnDeliveryAdressLineOneMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "";
            AnDeliveryAdressLineOne += AnDeliveryAdressLineOne.PadRight(45, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AnDeliveryAdressLineTwoMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineTwo = "";
            AnDeliveryAdressLineTwo += AnDeliveryAdressLineTwo.PadRight(45, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AnPostCodeMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPostcode = "";
            AnPostcode += AnPostcode.PadRight(15, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AnEmailMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnEmail = "aaaaaaaaaaaaaaaaaaaaaaaaa@bbbbbbbbbbbbbbbbbbbbbbbb";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }
       

        
     
        //Test Contains Special


        [TestMethod]
        public void ContainsSpecial()
        {

            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            bool Return = false;
            string TestData = "Hello% ";
            Return = AnMarketplaceUser.TestForSpecialCharacters(TestData);
            Assert.AreEqual(Return, true);
        }


        [TestMethod]
        public void NoSpecial()
        {

            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            bool Return = false;
            string TestData = "Hello ";
            Return = AnMarketplaceUser.TestForSpecialCharacters(TestData);
            Assert.AreEqual(Return, false);
        }



        //Test for incorrect Data Types


        [TestMethod]
        public void AnDeliveryAdressLineOneSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street %";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AnDeliveryAdressLineTwoSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineTwo = "New York %";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AnPostCodeSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPostcode = "LE4 4GL %";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AnEmailSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }




        //test email format
        [TestMethod]
        public void AnEmailFormat()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnEmail = "cjs@gmail.com";


            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }


        //test email wrong format
        [TestMethod]
        public void AnEmailWrongFormat()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnEmail = "@gmail.com";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }

    }
}

