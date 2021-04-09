using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceListing
    {
        //Testing Class 


        //some good data to use - data entered by user has string data type

        String AnCategory = "Cookie Jar";
        DateTime AnCloseDate = DateTime.Now.AddDays(7);
        String AnDeliveryType = "First Class";
        String AnDescription = "Includes Audio when opening";
        String AnImg = @"http://placekitten.com/200/300";
        int AnListingID = 1;
        String AnListingName = "Shrek Cookie Jar";
        bool New = true;
        String AnPrice = "10.22";
        String AnQuantity = "1";
        int AnOwnerID = 1;
        int AnListingType = 2;


        [TestMethod]
        public void InstanceOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test to see if it existis
            Assert.IsNotNull(AnMarketplaceListing);
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
        public void CloseDateOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            DateTime TestData = new DateTime(2000, 12, 12);
            //assign data to the property
            AnMarketplaceListing.CloseDate = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.CloseDate, TestData);


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
        public void OwnerIDPropertyOk()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            int TestData = 10;
            //assign data to the property
            AnMarketplaceListing.OwnerID = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.OwnerID, TestData);

        }

        [TestMethod]
        public void ListingTypePropertyOk()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //test data for property
            int TestData = 10;
            //assign data to the property
            AnMarketplaceListing.ListingType = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceListing.ListingType, TestData);

        }



        //Testing the validmethod 


      
       



        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
          
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure no error msg
            Assert.AreEqual(Error, "");

        }



        //Blank Tests
        

        [TestMethod]
        public void CategoryBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnCategory = "";         
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryTypeBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method        
            String AnDeliveryType = "";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method      
            String AnDescription = "";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ImgBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method      
            String AnImg = "";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure no error msg - can be blank
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ListingNameBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method           
            String AnListingName = "";         
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method   
            String AnPrice = "";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void QuantityBlank()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnQuantity = "";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }




        //boundary tests

        [TestMethod]
        public void CategoryMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnCategory = "A";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryTypeMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryType = "A";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDescription = "A";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ImgMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnImg = "A/";

            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ListingNameMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method       
            String AnListingName = "S";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method     
            String AnPrice = "0.01";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMinBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnQuantity = "1";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }


        //max boundary
        [TestMethod]
        public void CategoryMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnCategory = "";
            AnCategory += AnCategory.PadRight(30, 'A');
    
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryTypeMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method   
            String AnDeliveryType = "";
            AnDeliveryType += AnDeliveryType.PadRight(30, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DescriptionMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDescription = "";
            AnDescription+=AnDescription.PadRight(75, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ImgMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnImg = "/";
            AnImg += AnImg.PadRight(199, 'A');
             //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ListingNameMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnListingName = "";
            AnListingName += AnListingName.PadRight(30, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPrice = "1000000000.00";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMaxBoundary()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnQuantity = "1000";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }


        //max plus one
        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnCategory = "";
            AnCategory += AnCategory.PadRight(31, 'A');
            String AnDeliveryType = "First Class";
            String AnDescription = "Includes Audio when opening";
            String AnImg = @"C:\Users\Callum\Images\img.png";
            String AnListingName = "Shrek Cookie Jar";
            String AnPrice = "10.22";
            String AnQuantity = "1";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryType()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryType = "";
            AnDeliveryType += AnDeliveryType.PadRight(31, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDescription = "";
            AnDescription += AnDescription.PadRight(76, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ImgMaxPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnImg = "/";
            AnImg += AnImg.PadRight(200, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ListingNameMaxPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method      
            String AnListingName = "";
            AnListingName += AnListingName.PadRight(31, 'A');
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPrice = "1000000000.01";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnQuantity = "1001";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        //Incorret data types test

        [TestMethod]
        public void CategorySpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnCategory = "C%";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DeliveryTypeSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDeliveryType = "C%";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnDescription = "Includes Audio when opening&";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ImgSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ListingNameSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method   
            String AnListingName = "Shrek Cookie Jar%";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceSpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnPrice = "10.22&";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void QuantitySpecial()
        {
            //create instance of Marketplace user
            clsMarketplaceListing AnMarketplaceListing = new clsMarketplaceListing();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String AnQuantity = "1&";
            //test the valid method with the test data
            Error = AnMarketplaceListing.Valid(AnCategory, AnDeliveryType, AnDescription, AnImg, AnListingName, AnPrice, AnQuantity);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");

        }


    }
}
