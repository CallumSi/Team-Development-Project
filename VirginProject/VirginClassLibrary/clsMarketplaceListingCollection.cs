using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsMarketplaceListingCollection
    {
        //declare private variables for use list
        List<clsMarketplaceListing> mListingList = new List<clsMarketplaceListing>();
        //declarte private variables for a specific Listing
        clsMarketplaceListing mThisListing = new clsMarketplaceListing();

        //constructor
        public clsMarketplaceListingCollection()
        {
            //declare data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblMarketplaceListing_SelectAll");
            //populate the array with the data
            PopulateArray(DB);
        }



        //get set for Listing list
        public List<clsMarketplaceListing> ListingList
        {

            get
            {
                //return private data
                return mListingList;
            }
            set
            {
                //set the private data
                mListingList = value;
            }
        }

        // count property to return count of list
        public int Count
        {
            get
            {
                return mListingList.Count;
            }
        }


        //public property for single user
        public clsMarketplaceListing ThisListing
        {
            get
            {
                //return the private data
                return mThisListing;
            }
            set
            {
                //set private data
                mThisListing = value;
            }
        }


        public int AddListing()
        {
            //used to add a new record into the database
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@Category", mThisListing.Category);
            DB.AddParameter("@CloseDate", mThisListing.CloseDate);
            DB.AddParameter("@DeliveryType", mThisListing.DeliveryType);
            DB.AddParameter("@Description", mThisListing.Description);
            DB.AddParameter("@Img", mThisListing.Img);
            DB.AddParameter("@OwnerID", mThisListing.OwnerID);
            DB.AddParameter("@ListingName", mThisListing.ListingName);
            DB.AddParameter("@New", mThisListing.New);
            DB.AddParameter("@Price", mThisListing.Price);
            DB.AddParameter("@Quantity", mThisListing.Quantity);
            DB.AddParameter("@ListingType", mThisListing.ListingType);
            //execute the insert sproc
            return DB.Execute("sproc_tblMarketplaceListing_Insert");

        }
        public void DeleteListing()
        {
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@ListingID", mThisListing.ListingID);
            //execute the stored procedure
            DB.Execute("sproc_tblMarketplaceListing_Delete");

        }
        public void UpdateListing()
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@ListingID", mThisListing.ListingID);
            DB.AddParameter("@Category", mThisListing.Category);
            DB.AddParameter("@CloseDate", mThisListing.CloseDate);
            DB.AddParameter("@DeliveryType", mThisListing.DeliveryType);
            DB.AddParameter("@Description", mThisListing.Description);
            DB.AddParameter("@Img", mThisListing.Img);
            DB.AddParameter("@OwnerID", mThisListing.OwnerID);
            DB.AddParameter("@ListingName", mThisListing.ListingName);
            DB.AddParameter("@New", mThisListing.New);
            DB.AddParameter("@Price", mThisListing.Price);
            DB.AddParameter("@Quantity", mThisListing.Quantity);
            DB.AddParameter("@ListingType", mThisListing.ListingType);

            //execute the spoc
            DB.Execute("sproc_tblMarketplaceListing_Update");
        }
        
        public void FilterByUserFavorite(string UserID)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@UserID", UserID);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceUserFavorites_FilterByUserID");
            //populate the array with the found data
            GetFavorites(DB);
        }

        public void FilterByUserID(string UserID)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@UserID", UserID);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceListing_FilterByUserID");
            //populate the array with the found data
            PopulateArray(DB);
        }

        public void FilterByListingID(string ListingID)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@ListingID", ListingID);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceListing_FilterByListingID");
            //populate the array with the found data
            PopulateFavorites(DB);
        }

        public void FilterByListingName(string ListingName)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@ListingName", ListingName);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceListing_FilterByListingName");
            //populate the array with the found data
            PopulateArray(DB);

        }
        public void FilterByListingType(int ListingType)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@ListingType", ListingType);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceListing_FilterByListingType");
            //populate the array with the found data
            PopulateArray(DB);

        }


        public void Clear()
        {
            mListingList.Clear();

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on database in paramater
            //index vairables
            Int32 Index = 0;
            //vare to store the record count
            Int32 RecordCount;
            //get the record count
            RecordCount = DB.Count;
            //clear the list
            mListingList = new List<clsMarketplaceListing>();
            //loop through all the records
            while (Index < RecordCount)
            {
                //create a blank record
                clsMarketplaceListing AnListing = new clsMarketplaceListing();
                //read the data and add the record
                AnListing.ListingID = Convert.ToInt32(DB.DataTable.Rows[Index]["ListingID"]);
                AnListing.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AnListing.CloseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CloseDate"]);
                AnListing.DeliveryType = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryType"]);
                AnListing.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnListing.Img = Convert.ToString(DB.DataTable.Rows[Index]["Img"]);
                AnListing.OwnerID = Convert.ToInt32(DB.DataTable.Rows[Index]["OwnerID"]);
                AnListing.ListingName = Convert.ToString(DB.DataTable.Rows[Index]["ListingName"]);
                AnListing.New = Convert.ToBoolean(DB.DataTable.Rows[Index]["New"]);
                AnListing.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnListing.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnListing.ListingType = Convert.ToInt32(DB.DataTable.Rows[Index]["ListingType"]);
                //add the record 
                mListingList.Add(AnListing);
               
                //GO TO NEXT RECORD
                Index++;
            }

        }

        void PopulateFavorites(clsDataConnection DB)
        {
            //populates array list based on database in paramater
            //index vairables
            Int32 Index = 0;
            //vare to store the record count
            Int32 RecordCount;
            //get the record count
            RecordCount = DB.Count;
            
            //loop through all the records
            while (Index < RecordCount)
            {
                //create a blank record
                clsMarketplaceListing AnListing = new clsMarketplaceListing();
                //read the data and add the record
                AnListing.ListingID = Convert.ToInt32(DB.DataTable.Rows[Index]["ListingID"]);
                AnListing.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AnListing.CloseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CloseDate"]);
                AnListing.DeliveryType = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryType"]);
                AnListing.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnListing.Img = Convert.ToString(DB.DataTable.Rows[Index]["Img"]);
                AnListing.OwnerID = Convert.ToInt32(DB.DataTable.Rows[Index]["OwnerID"]);
                AnListing.ListingName = Convert.ToString(DB.DataTable.Rows[Index]["ListingName"]);
                AnListing.New = Convert.ToBoolean(DB.DataTable.Rows[Index]["New"]);
                AnListing.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnListing.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnListing.ListingType = Convert.ToInt32(DB.DataTable.Rows[Index]["ListingType"]);
                //add the record 
                mListingList.Add(AnListing);
                //GO TO NEXT RECORD
                Index++;
            }

        }

        void GetFavorites(clsDataConnection DB)
        {
            //populates favorite  list based on database in paramater
            //index vairables
            Int32 Index = 0;
            //vare to store the record count
            Int32 RecordCount;
            //Store id of listing
            string ListingID;
            //get the record count
            RecordCount = DB.Count;
            //loop through all the records
            //clear the list
            mListingList = new List<clsMarketplaceListing>();
            while (Index < RecordCount)
            {
            
                //read the data and add the record
                ListingID = Convert.ToString(DB.DataTable.Rows[Index]["ListingID"]);
                //add the record                
                FilterByListingID(ListingID);
                //GO TO NEXT RECORD
                Index++;
            }


        }
    }
}
