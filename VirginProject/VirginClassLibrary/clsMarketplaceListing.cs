using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsMarketplaceListing
    {
        public bool AllowBids { get; set; }
        public bool AllowOffers { get; set; }
        public string Category { get; set; }
        public DateTime CloseDate { get; set; }
        public string DeliveryType { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int ListingID { get; set; }
        public string ListingName { get; set; }
        public bool New { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CreatedByUserID { get; set; }

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
            if (TestForSpecialCharacters(anPrice) == false)
            {
                ErrorMsg += "Price must be in the format 10.00";

            }
            if (TestForSpecialCharacters(anQuantity) == true)
            {
                ErrorMsg += "Quantity must have no special characters";

            }
            if (anImg !="" && TestForSpecialCharacters(anImg) == false)
            {
                ErrorMsg += "img path must include : and / ";

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


            //check money in range
            try
            {
                ConvertedPrice = Convert.ToDecimal(anPrice);
                int decimalplaces = BitConverter.GetBytes(decimal.GetBits(ConvertedPrice)[3])[2];
                if(decimalplaces == 2)
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
