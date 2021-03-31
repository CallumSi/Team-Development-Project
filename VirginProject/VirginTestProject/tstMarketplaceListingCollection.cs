using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceListingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();
            //Test it exisits
            Assert.IsNotNull(Listings);

        }

        [TestMethod]
        public void ListingsListOK()
        {
            //Create an instance of the class
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();

            //create a new list
            List<clsMarketplaceListing> TestList = new List<clsMarketplaceListing>();
            //create some properties
            clsMarketplaceListing Listing = new clsMarketplaceListing();
            Listing.Category = "Cookie Jar";
            Listing.CloseDate = DateTime.Now.AddDays(7);
            Listing.DeliveryType = "First Class";
            Listing.Description = "Includes Audio when opening";
            Listing.Img = @"http://placekitten.com/200/300";
            Listing.ListingID = 1;
            Listing.ListingName = "Shrek Cookie Jar";
            Listing.New = true;
            Listing.Price = Convert.ToDecimal(10.22);
            Listing.Quantity = 1;
            Listing.OwnerID = 1;
            Listing.ListingType = 2;
            //add item
            TestList.Add(Listing);
            Listings.ListingList = TestList;
            //test are equal 
            Assert.AreEqual(Listings.ListingList, TestList);



        }

        [TestMethod]
        public void ThisListingPropertyOK()
        {
            //Create an instance of the class
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();
            //create some properties
            clsMarketplaceListing Listing = new clsMarketplaceListing();
            
            Listing.Category = "Cookie Jar";
            Listing.CloseDate = DateTime.Now.AddDays(7);
            Listing.DeliveryType = "First Class";
            Listing.Description = "Includes Audio when opening";
            Listing.Img = @"http://placekitten.com/200/300";
            Listing.ListingID = 1;
            Listing.ListingName = "Shrek Cookie Jar";
            Listing.New = true;
            Listing.Price = Convert.ToDecimal(10.22);
            Listing.Quantity = 1;
            Listing.OwnerID = 1;
            Listing.ListingType = 2;
            //add item
           
            Listings.ThisListing = Listing;
            //test are equal 
            Assert.AreEqual(Listings.ThisListing, Listing);
        }


        public void CountPropertyOK()
        {
            //Create an instance of the class
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();

            //create a new list
            List<clsMarketplaceListing> TestList = new List<clsMarketplaceListing>();
            //create some properties
            clsMarketplaceListing Listing = new clsMarketplaceListing();
            Listing.Category = "Cookie Jar";
            Listing.CloseDate = DateTime.Now.AddDays(7);
            Listing.DeliveryType = "First Class";
            Listing.Description = "Includes Audio when opening";
            Listing.Img = @"http://placekitten.com/200/300";
            Listing.ListingID = 1;
            Listing.ListingName = "Shrek Cookie Jar";
            Listing.New = true;
            Listing.Price = Convert.ToDecimal(10.22);
            Listing.Quantity = 1;
            Listing.OwnerID = 1;
            Listing.ListingType = 2;
            //add item
            TestList.Add(Listing);
            Listings.ListingList = TestList;
            //test are equal 
            Assert.AreEqual(Listings.Count, TestList.Count);



        }


        [TestMethod]
        public void AddListingMethodOK()
        {
            //Create an instance of the class
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();
            //create some properties
            clsMarketplaceListing Listing = new clsMarketplaceListing();

            Listing.Category = "Cookie Jar";
            Listing.CloseDate = DateTime.Now.AddDays(7);
            Listing.DeliveryType = "First Class";
            Listing.Description = "Includes Audio when opening";
            Listing.Img = @"http://placekitten.com/200/300";
            Listing.ListingID = 1;
            Listing.ListingName = "Shrek Cookie Jar";
            Listing.New = true;
            Listing.Price = Convert.ToDecimal(10.22);
            Listing.Quantity = 1;
            Listing.OwnerID = 1;
            Listing.ListingType = 2;
        
            //set test data 
            Listings.ThisListing = Listing;
            //add
            Int32 PK= Listings.AddListing();
            //find the record
            Listings.ThisListing.Find(PK);
            //test are equal 
            Assert.AreEqual(Listings.ThisListing, Listing);
        }

        [TestMethod]
        public void DeleteListingMethodOK()
        {
            //Create an instance of the class
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();
            //create some properties
            clsMarketplaceListing Listing = new clsMarketplaceListing();

            Listing.Category = "Cookie Jar";
            Listing.CloseDate = DateTime.Now.AddDays(7);
            Listing.DeliveryType = "First Class";
            Listing.Description = "Includes Audio when opening";
            Listing.Img = @"http://placekitten.com/200/300";
            Listing.ListingID = 1;
            Listing.ListingName = "Shrek grqehbqbqebqebrqeqe Jar";
            Listing.New = true;
            Listing.Price = Convert.ToDecimal(10.22);
            Listing.Quantity = 1;
            Listing.OwnerID = 1;
            Listing.ListingType = 2;

            //set test data 
            Listings.ThisListing = Listing;
            //add
            Int32 PK = Listings.AddListing();
            //find the record
            Listings.ThisListing.Find(PK);

            Listings.DeleteListing();
            Boolean Found = Listings.ThisListing.Find(PK);
            //test are equal 
            Assert.AreEqual(false, Found);
        }

        [TestMethod]
        public void UpdateListingMethodOK()
        {
            //Create an instance of the class
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();
            //create some properties
            clsMarketplaceListing Listing = new clsMarketplaceListing();

            Listing.Category = "Cookie Jar";
            Listing.CloseDate = DateTime.Now.AddDays(7);
            Listing.DeliveryType = "First Class";
            Listing.Description = "Includes Audio when opening";
            Listing.Img = @"http://placekitten.com/200/300";
            Listing.ListingID = 1;
            Listing.ListingName = "Shrek Cookie Jar";
            Listing.New = true;
            Listing.Price = Convert.ToDecimal(10.22);
            Listing.Quantity = 1;
            Listing.OwnerID = 1;
            Listing.ListingType = 2;

            //set test data 
            Listings.ThisListing = Listing;
            //add
            Int32 PK = Listings.AddListing();
            //set the pk
            Listing.ListingID = PK;
            //modify the record
            Listing.Category = "Something";
            Listing.CloseDate = DateTime.Now.AddDays(7);
            Listing.DeliveryType = "Something";
            Listing.Description = "Something";
            Listing.Img = @"http://placekitten.com/200/300";
            Listing.ListingID = 1;
            Listing.ListingName = "Something";
            Listing.New = true;
            Listing.Price = Convert.ToDecimal(22.22);
            Listing.Quantity = 2;
            Listing.OwnerID = 1;
            Listing.ListingType = 2;
            //set the record
            Listings.ThisListing = Listing;
            //update
            Listings.UpdateListing();
            //find the user to see if data matches
            Listings.ThisListing.Find(PK);
            Assert.AreEqual(Listings.ThisListing, Listing);
        }


        //user id
        [TestMethod]
        public void FilterByUserIDFound()
        {

            //create an instance of the filtered data
            clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
            FilteredListings.FilterByUserID("4");
            //test to see that the two values are the same
            Assert.AreEqual(7, FilteredListings.Count);
        }
        [TestMethod]
        public void FilterByUserIDNotFound()
        {
        
            clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
            FilteredListings.FilterByUserID("242");
            Assert.AreEqual(0, FilteredListings.Count);
        }

        //listing id
        //[TestMethod]
        //public void FilterByListingIDFound()
        //{

        //    //create an instance of the filtered data
        //    clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
        //    FilteredListings.FilterByListingID("13");
        //    //test to see that the two values are the same
        //    Assert.AreEqual(1, FilteredListings.Count);
        //}
        //[TestMethod]
        //public void FilterByListingIDNotFound()
        //{

        //    clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
        //    FilteredListings.FilterByListingID("242");
        //    Assert.AreEqual(0, FilteredListings.Count);
        //}

        //listing name
        [TestMethod]
        public void FilterByListingNameFound()
        {

            //create an instance of the filtered data
            clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
            FilteredListings.FilterByListingName("test");
            //test to see that the two values are the same
            Assert.AreEqual(1, FilteredListings.Count);
        }
        [TestMethod]
        public void FilterByListingNameNotFound()
        {

            clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
            FilteredListings.FilterByListingName("fwfwgw3hgrhbewgwhweh");
            Assert.AreEqual(0, FilteredListings.Count);
        }

        //listing type
        [TestMethod]
        public void FilterByListingTypeFound()
        {

            //create an instance of the filtered data
            clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
            FilteredListings.FilterByListingType(4);
            //test to see that the two values are the same
            Assert.AreEqual(1, FilteredListings.Count);
        }
        [TestMethod]
        public void FilterByListingTypeNotFound()
        {

            clsMarketplaceListingCollection FilteredListings = new clsMarketplaceListingCollection();
            FilteredListings.FilterByListingType(242);
            Assert.AreEqual(0, FilteredListings.Count);
        }
    }
}
