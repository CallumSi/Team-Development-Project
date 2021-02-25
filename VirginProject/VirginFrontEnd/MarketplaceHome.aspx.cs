using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceHome : System.Web.UI.Page
    {
        int UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //get the User Id
            UserID = Convert.ToInt32(Session["UserID"]);
            //display the User data
            DisplayUserData();
            //display the Listings
            DisplayListings();
        }

        void DisplayUserData()
        {
            //create an instance of the user collection class
            clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //find the record to update
            SomeUser.ThisUser.Find(UserID);
            //display the data for this record
            lblEmail.Text = SomeUser.ThisUser.Email;
           

        }

        void DisplayListings()
        {
            //create an instance of the user collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            Random rnd = new Random();
            bool found1 = false;
            while (found1 == false)
            {
                try
                {
                    int ListingID1 = rnd.Next(1, 100);
                    if(SomeListing.ThisListing.Find(ListingID1)==true)
                    {
                        //display the data for this record
                        listingname1.Text = SomeListing.ThisListing.ListingName;
                        listingprice1.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage1.ImageUrl = SomeListing.ThisListing.Img;
                        found1 = true;
                    }
                    else
                    {
                        found1 = false;
                    }

                    
                   
                }
                catch
                {
                    found1 = false;
                }

            }
            bool found2 = false;
            while (found2 == false)
            {
                try
                {
                    int ListingID2 = rnd.Next(1, 100);
                    if (SomeListing.ThisListing.Find(ListingID2) == true)
                    {
                        //display the data for this record
                        listingname2.Text = SomeListing.ThisListing.ListingName;
                        listingprice2.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage2.ImageUrl = SomeListing.ThisListing.Img;
                        found2 = true;
                    }
                    else
                    {
                        found2 = false;
                    }



                }
                catch
                {
                    found2 = false;
                }

            }
            bool found3 = false;
            while (found3 == false)
            {
                try
                {
                    int ListingID3 = rnd.Next(1, 100);
                    if (SomeListing.ThisListing.Find(ListingID3) == true)
                    {
                        //display the data for this record
                        listingname3.Text = SomeListing.ThisListing.ListingName;
                        listingprice3.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage3.ImageUrl = SomeListing.ThisListing.Img;
                        found3 = true;
                    }
                    else
                    {
                        found3 = false;
                    }



                }
                catch
                {
                    found3 = false;
                }

            }
            bool found4 = false;
            while (found4 == false)
            {
                try
                {
                    int ListingID4 = rnd.Next(1, 100);
                    if (SomeListing.ThisListing.Find(ListingID4) == true)
                    {
                        //display the data for this record
                        listingname4.Text = SomeListing.ThisListing.ListingName;
                        listingprice4.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage4.ImageUrl = SomeListing.ThisListing.Img;
                        found4 = true;
                    }
                    else
                    {
                        found4 = false;
                    }



                }
                catch
                {
                    found4 = false;
                }

            }
            bool found5 = false;
            while (found5 == false)
            {
                try
                {
                    int ListingID5 = rnd.Next(1, 100);
                    if (SomeListing.ThisListing.Find(ListingID5) == true)
                    {
                        //display the data for this record
                        listingname5.Text = SomeListing.ThisListing.ListingName;
                        listingprice5.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage5.ImageUrl = SomeListing.ThisListing.Img;
                        found5 = true;
                    }
                    else
                    {
                        found5 = false;
                    }



                }
                catch
                {
                    found5 = false;
                }

            }
            bool found6 = false;
            while (found6 == false)
            {
                try
                {
                    int ListingID6 = rnd.Next(1, 100);
                    if (SomeListing.ThisListing.Find(ListingID6) == true)
                    {
                        //display the data for this record
                        listingname6.Text = SomeListing.ThisListing.ListingName;
                        listingprice6.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage6.ImageUrl = SomeListing.ThisListing.Img;
                        found6 = true;
                    }
                    else
                    {
                        found6 = false;
                    }



                }
                catch
                {
                    found6 = false;
                }

            }
            bool found7 = false;
            while (found7 == false)
            {
                try
                {
                    int ListingID7 = rnd.Next(1, 100);
                    if (SomeListing.ThisListing.Find(ListingID7) == true)
                    {
                        //display the data for this record
                        listingname7.Text = SomeListing.ThisListing.ListingName;
                        listingprice7.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage7.ImageUrl = SomeListing.ThisListing.Img;
                        found7 = true;
                    }
                    else
                    {
                        found7 = false;
                    }



                }
                catch
                {
                    found7 = false;
                }

            }
            bool found8 = false;
            while (found8 == false)
            {
                try
                {
                    int ListingID8 = rnd.Next(1, 100);
                    if (SomeListing.ThisListing.Find(ListingID8) == true)
                    {
                        //display the data for this record
                        listingname8.Text = SomeListing.ThisListing.ListingName;
                        listingprice8.Text = SomeListing.ThisListing.Price.ToString();
                        listingimage8.ImageUrl = SomeListing.ThisListing.Img;
                        found8 = true;
                    }
                    else
                    {
                        found8 = false;
                    }



                }
                catch
                {
                    found8 = false;
                }

            }


        }

        Int32 FilterListing(string ListingNameFilter)
        {
            //declare variables
            Int32 ListingID;
            string ListingName;
            string ListingImg;
            string ListingPrice;
            //create instance of collection class
            clsMarketplaceListingCollection ListOfListings = new clsMarketplaceListingCollection();
            ListOfListings.FilterByListingName(ListingNameFilter);
            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            //get count of filtered list
            RecordCount = ListOfListings.Count;
   
           
            //loop through the list adding them to the list boxes
            while (Index < RecordCount && Index<9)
            {
                ListingID = ListOfListings.ListingList[Index].ListingID;
                ListingName = ListOfListings.ListingList[Index].ListingName;
                ListingPrice = ListOfListings.ListingList[Index].Price.ToString();
                ListingImg = ListOfListings.ListingList[Index].Img;
                if (Index == 0)
                {
                    listingimage1.ImageUrl = ListingImg;
                    listingname1.Text = ListingName;
                    listingprice1.Text = ListingPrice;
                }
                if (Index == 1)
                {
                    listingimage2.ImageUrl = ListingImg;
                    listingname2.Text = ListingName;
                    listingprice2.Text = ListingPrice;
                }
                if (Index == 2)
                {
                    listingimage3.ImageUrl = ListingImg;
                    listingname3.Text = ListingName;
                    listingprice3.Text = ListingPrice;
                }
                if (Index == 3)
                {
                    listingimage4.ImageUrl = ListingImg;
                    listingname4.Text = ListingName;
                    listingprice4.Text = ListingPrice;
                }
                if (Index == 4)
                {
                    listingimage5.ImageUrl = ListingImg;
                    listingname5.Text = ListingName;
                    listingprice5.Text = ListingPrice;
                }
                if (Index == 5)
                {
                    listingimage6.ImageUrl = ListingImg;
                    listingname6.Text = ListingName;
                    listingprice6.Text = ListingPrice;
                }
                if (Index == 6)
                {
                    listingimage7.ImageUrl = ListingImg;
                    listingname7.Text = ListingName;
                    listingprice7.Text = ListingPrice;
                }
                if (Index == 7)
                {
                    listingimage8.ImageUrl = ListingImg;
                    listingname8.Text = ListingName;
                    listingprice8.Text = ListingPrice;
                }
                Index++;
            }
            return RecordCount;

        }

        protected void btnApplySearch_Click(object sender, EventArgs e)
        {
            FilterListing(txtSearch.Text);
        }
    }
}