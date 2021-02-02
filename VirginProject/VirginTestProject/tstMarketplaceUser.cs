using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test to see if it existis
            Assert.IsNotNull(AnMarketplaceUser);
        }

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "77 Wall Street";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAdressLineOneMinMinusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure there is  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAdressLineOneMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "A";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure there is no error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAdressLineOneMinPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "AA";
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure there is no error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAdressLineOneMaxMinOne()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "";
            //add characters to the string 
            AnDeliveryAdressLineOne = AnDeliveryAdressLineOne.PadRight(44, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure there is no error msg
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DeliveryAdressLineOneMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "";
            //add characters to the string 
            AnDeliveryAdressLineOne = AnDeliveryAdressLineOne.PadRight(45, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure there is no error msg
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DeliveryAdressLineOneMaxPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "";
            //add characters to the string 
            AnDeliveryAdressLineOne = AnDeliveryAdressLineOne.PadRight(46, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure there is an error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryAdressLineOneExtremeMax()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryAdressLineOne = "";
            //add characters to the string 
            AnDeliveryAdressLineOne = AnDeliveryAdressLineOne.PadRight(450, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceUser.Valid(AnDeliveryAdressLineOne);
            //Test to ensure there is an error msg
            Assert.AreNotEqual(Error, "");

        }
    }

}
