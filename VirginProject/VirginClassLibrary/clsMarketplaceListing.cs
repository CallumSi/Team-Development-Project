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
        public int UserID { get; set; }





        public string Valid(string anCategory, string anCloseDate, string anDeliveryType, string anDescription, string anImg, string anListingName, string anPrice, string anQuantity)
        {
            //declare empty string 
            string ErrorMsg = "";
            int ConvertedQuantity;
            decimal ConvertedPrice;
            DateTime ConvertedCloseDate;


            //check for blank string
            if (anCategory.Length > 0 && anCategory.Length < 31)
            {
                if (anCloseDate.Length == 18)
                {
                    if (anDeliveryType.Length > 0 && anDeliveryType.Length < 31)
                    {
                        if (anDescription.Length > 0 && anDescription.Length < 75)
                        {
                            if (anListingName.Length > 0 && anListingName.Length < 75)
                            {
                                try
                                {
                                    if (anQuantity == "")
                                    {
                                        ErrorMsg = "";
                                    }
                                    else
                                    {
                                        ConvertedQuantity = Convert.ToInt32(anQuantity);
                                        if (ConvertedQuantity > 0 && ConvertedQuantity < 1000)
                                        {
                                            ErrorMsg = "";
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

                            }
                            else
                            {
                                //return error message 
                                ErrorMsg += "Password must be between 0 and 50 characters ";
                            }
                        }
                        else
                        {
                            //return error message 
                            ErrorMsg += "Email must be between 0 and 50 characters ";
                        }

                    }
                    else
                    {
                        //return error message 
                        ErrorMsg += "Postcode must be between 0 and 15 characters ";
                    }
                }
                else
                {
                    //return error message 
                    ErrorMsg += "Delivery Line Two must be between 0 and 46 characters ";

                }
            }
            else
            {
                //return error message 
                ErrorMsg += "Delivery Line One must be between 0 and 46 characters";
            }

            //check for special characters
            if (TestForSpecialCharacters(anCategory) == true)
            {
                ErrorMsg += "Delivery adress line one must have no special characters";

            }
            if (TestForSpecialCharacters(anDeliveryType) == true)
            {
                ErrorMsg += "Delivery adress line two must have no special characters";

            }
            if (TestForSpecialCharacters(anDescription) == true)
            {
                ErrorMsg += "PostCode must have no special characters";

            }
            if (TestForSpecialCharacters(anListingName) == true)
            {
                ErrorMsg += "PostCode must have no special characters";

            }
            if (TestForSpecialCharacters(anPrice) == true)
            {
                ErrorMsg += "PostCode must have no special characters";

            }
            if (TestForSpecialCharacters(anQuantity) == true)
            {
                ErrorMsg += "PostCode must have no special characters";

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
