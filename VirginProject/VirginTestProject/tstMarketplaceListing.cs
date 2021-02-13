using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceListing
    {
        //Testing Class 
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test to see if it existis
            Assert.IsNotNull(AnMarketplaceListing);
        }


        //Testing Properties
        [TestMethod]
        public void AllowBidsPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            Boolean TestData = true;
            //assign data to the property
            AnMarketplaceListing.AllowBids = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.AllowBids, TestData);


        }


        [TestMethod]
        public void AllowOffersPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            Boolean TestData = true;
            //assign data to the property
            AnMarketplaceListing.AllowOffers = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.AllowOffers, TestData);


        }


        [TestMethod]
        public void CategoryPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            string TestData = "Video Game";
            //assign data to the property
            AnMarketplaceListing.Category = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.Category, TestData);


        }
      

        [TestMethod]
        public void DeliveryTypePropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            string TestData = "First Class";
            //assign data to the property
            AnMarketplaceListing.DeliveryType = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.DeliveryType, TestData);


        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            string TestData = "good condition ";
            //assign data to the property
            AnMarketplaceListing.Description = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.Description, TestData);


        }

        [TestMethod]
        public void ImgPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            string TestData = "C:/user/img/test.png";
            //assign data to the property
            AnMarketplaceListing.Img = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.Img, TestData);

        }

        [TestMethod]
        public void ListingIDPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            int TestData = 1090;
            //assign data to the property
            AnMarketplaceListing.ListingID = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.ListingID, TestData);

        }


        [TestMethod]
        public void ListingNamePropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            string TestData = "Shrek Cookie Jar";
            //assign data to the property
            AnMarketplaceListing.ListingName = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.ListingName, TestData);

        }


        [TestMethod]
        public void NewPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            bool TestData = true;
            //assign data to the property
            AnMarketplaceListing.New = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.New, TestData);

        }


        [TestMethod]
        public void PricePropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            decimal TestData = 10.22m;
            //assign data to the property
            AnMarketplaceListing.Price = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.Price, TestData);

        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            int TestData = 4;
            //assign data to the property
            AnMarketplaceListing.Quantity = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.Quantity, TestData);

        }
        [TestMethod]
        public void CreatedByUserIDPropertyOk()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            int TestData = 10;
            //assign data to the property
            AnMarketplaceListing.UserID = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.UserID, TestData);

        }
    }
}
