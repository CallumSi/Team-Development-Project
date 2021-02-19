using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsMarketplaceListing
    {
               

        //private Data
        private bool mAllowBids;
        private bool mAllowOffers;
        private string mCategory;
        private DateTime mCloseDate;
        private string mDeliveryType;
        private string mDescription;
        private string mImg;
        private int mListingID;
        private string mListingName;
        private bool mNew;
        private Decimal mPrice;
        private int mQuantity;
        private int mOwnerID;

        //public data
        public bool AllowBids
        {
            get
            {
                //return private data
                return mAllowBids;
            }
            set
            {
                //set value to private data
                mAllowBids = value;
            }
        }

     
        public bool AllowOffers
        {
            get
            {
                //return private data
                return mAllowOffers;
            }
            set
            {
                //set value to private data
                mAllowOffers = value;
            }
        }

        public string Category
        {
            get
            {
                //return private data
                return mCategory;
            }
            set
            {
                //set value to private data
                mCategory = value;
            }
        }


        public DateTime CloseDate
        {
            get
            {
                //return private data
                return mCloseDate;
            }
            set
            {
                //set value to private data
                mCloseDate = value;
            }
        }
        
        public string DeliveryType
        {
            get
            {
                //return private data
                return mDeliveryType;
            }
            set
            {
                //set value to private data
                mDeliveryType = value;
            }
        }
        public string Description
        {
            get
            {
                //return private data
                return mDescription;
            }
            set
            {
                //set value to private data
                mDescription = value;
            }
        }
        public string Img
        {
            get
            {
                //return private data
                return mImg;
            }
            set
            {
                //set value to private data
                mImg = value;
            }
        }
        public int ListingID
        {
            get
            {
                //return private data
                return mListingID;
            }
            set
            {
                //set value to private data
                mListingID = value;
            }
        }
        public string ListingName
        {
            get
            {
                //return private data
                return mListingName;
            }
            set
            {
                //set value to private data
                mListingName = value;
            }
        }
        public bool New
        {
            get
            {
                //return private data
                return mNew;
            }
            set
            {
                //set value to private data
                mNew = value;
            }
        }

        
         public Decimal Price
        {
            get
            {
                //return private data
                return mPrice;
            }
            set
            {
                //set value to private data
                mPrice = value;
            }
        }
        public int Quantity
    {
            get
            {
                //return private data
                return mQuantity;
            }
            set
            {
            //set value to private data
            mQuantity = value;
            }
        }
        public int OwnerID
        {
            get
            {
                //return private data
                return mOwnerID;
            }
            set
            {
                //set value to private data
                mOwnerID = value;
            }
        }

        public Boolean Find(int ListingID)
        {
            //instantiate the data connection
            clsDataConnection DB = new clsDataConnection();
            //ad the parameter we use to search
            DB.AddParameter("ListingID", ListingID);
            //execute the sproc
            DB.Execute("sproc_tblMarketplaceListing_FilterByListingID");
            //if record found 
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data variables
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mCloseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CloseDate"]);
                mDeliveryType = Convert.ToString(DB.DataTable.Rows[0]["DeliveryType"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mImg = Convert.ToString(DB.DataTable.Rows[0]["Img"]);
                mListingID = Convert.ToInt32(DB.DataTable.Rows[0]["ListingID"]);
                mListingName = Convert.ToString(DB.DataTable.Rows[0]["ListingName"]);
                mNew = Convert.ToBoolean(DB.DataTable.Rows[0]["New"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mOwnerID = Convert.ToInt32(DB.DataTable.Rows[0]["OwnerID"]);
                return true;
            }
            else
            {
                //return false if no record ofund
                return false;
            }

        }

        public string Valid(string anCategory, string anDeliveryType, string anDescription, string anImg, string anListingName, string anPrice, string anQuantity)
        {
            //declare empty string 
            string ErrorMsg = "";
            int ConvertedQuantity;
            decimal ConvertedPrice;

            //check for blank string
            if (anCategory.Length > 0 && anCategory.Length < 31)
            {
                if (anDeliveryType.Length > 0 && anDeliveryType.Length < 31)
                {
                    if (anDescription.Length > 0 && anDescription.Length < 76)
                    {
                        if (anListingName.Length > 0 && anListingName.Length < 31)
                        {
                           if(anPrice.Length > 0)
                           {
                                if(anImg.Length>-1 && anImg.Length<201)
                                {
                                    ErrorMsg += "";

                                }
                                else
                                {
                                    //return error message
                                    ErrorMsg += "Img cannot exceed 200 characters";

                                }
                           }
                           else
                           {
                                //return error message
                                ErrorMsg += "Price cannot be left blank";
                           }

                        }
                        else
                        {
                            //return error message 
                            ErrorMsg += "Listing Name must be between 0 and 76 characters";
                        }
                    }
                    else
                    {
                        //return error message 
                        ErrorMsg += "Description must be between 0 and 76 characters ";
                    }
                }
                else
                {
                  //return error message 
                  ErrorMsg += "Delivery Type must be between 0 and 31 characters ";
                }
                
            }
            else
            {
                //return error message 
                ErrorMsg += "Category must be between 0 and 31 characters";
            }


            try
            {
                if (anQuantity == "")
                {
                    ErrorMsg += "Please Enter a Quantity";
                }
                else
                {
                    ConvertedQuantity = Convert.ToInt32(anQuantity);
                    if (ConvertedQuantity > 0 && ConvertedQuantity < 1001)
                    {
                        ErrorMsg += "";
                    }
                    else
                    {
                        //return error message 
                        ErrorMsg += "quantity must be out of 1000 ";
                    }
                }


            }
            catch
            {
                //return error message 
                ErrorMsg += "Quantity  must be int ";

            }

            //check money in range
            try
            {
                ConvertedPrice = Convert.ToDecimal(anPrice);
                int decimalplaces = BitConverter.GetBytes(decimal.GetBits(ConvertedPrice)[3])[2];
                if (decimalplaces == 2)
                {
                    if (ConvertedPrice > 0m && ConvertedPrice < 1000000000.01m)
                    {
                        ErrorMsg += "";

                    }
                    else
                    {
                        ErrorMsg += "Price must be between 0 and 1million";
                    }
                }
                else
                {
                    ErrorMsg += "Price must have 2 decimal places";
                }

            }
            catch
            {
                ErrorMsg += "Price must be a decimal and not blank";
            }


            ////test email format
            //if (anEmail != "")
            //{

            //    try
            //    {
            //        var EmailTest = new System.Net.Mail.MailAddress(anEmail);
            //    }
            //    catch
            //    {
            //        ErrorMsg += "Email must be in the correct format";
            //    }
            //}


            //check for special characters
            if (TestForSpecialCharacters(anCategory) == true)
            {
                ErrorMsg += "Category must have no special characters";

            }
            if (TestForSpecialCharacters(anDeliveryType) == true)
            {
                ErrorMsg += "Delivery Typeo must have no special characters";

            }
            if (TestForSpecialCharacters(anListingName) == true)
            {
                ErrorMsg += "ListingName must have no special characters";

            }
            
            if (TestForSpecialCharacters(anQuantity) == true)
            {
                ErrorMsg += "Quantity must have no special characters";

            }
            if (anImg !="" && TestForSpecialCharacters(anImg) == false)
            {
                ErrorMsg += "img path must include : and / ";

            }
            if (TestForSpecialCharacters(anDescription) == true)
            {
                ErrorMsg += "Description must have no special characters";

            }




            return ErrorMsg;

        }



        private bool TestForSpecialCharacters(string TestData)
        {
            bool ContainsSpecial = false;
            foreach (var i in TestData)
            {
                if (char.IsLetterOrDigit(i) || char.IsWhiteSpace(i) == true)
                {
                    ContainsSpecial = false;
                }
                else
                {
                    ContainsSpecial = true;
                    break;
                }

            }

            return ContainsSpecial;
        }
    }
}
