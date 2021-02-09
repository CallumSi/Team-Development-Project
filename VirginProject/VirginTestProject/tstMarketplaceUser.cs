using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceUser

    {

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
        public void PasswordPropertyOK()
        {
            //password include Capitcal + Number

            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            string TestData = "Test1";
            //assign data to the property
            AnMarketplaceUser.Password = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.Password, TestData);
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



        //Testing the validmethod 

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "";
            String AnPassword = "Password1#";
            String AnRating = "7";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
            //Test to ensure no error msg
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        //This should be okay as rating can be left blank
        public void AnRatingBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "";
            
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

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
            String AnDeliveryAdressLineOne = "a";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "a";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "a";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "a";
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void AnPasswordMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "a1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AnRatingMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "1";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            AnDeliveryAdressLineOne += AnDeliveryAdressLineOne.PadRight(45);
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "";
            AnDeliveryAdressLineTwo += AnDeliveryAdressLineTwo.PadRight(45);
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "";
            AnPostcode += AnPostcode.PadRight(15);
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
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
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "";
            AnEmail += AnEmail.PadRight(50);
            String AnPassword = "Password1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AnPasswordMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "abcdefgh1#abcdefgh1#abcdefgh1#abcdefgh1#abcdefgh1#";
            String AnRating = "7";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AnRatingMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street";
            String AnDeliveryAdressLineTwo = "New York";
            String AnPostcode = "LE4 4GL";
            String AnEmail = "cjs@gmail.com";
            String AnPassword = "Password1#";
            String AnRating = "10";

            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne, AnDeliveryAdressLineTwo, AnPostcode, AnEmail, AnPassword, AnRating);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }


    }
}

