using System;

namespace VirginClassLibrary
{
    public class clsMarketplaceUser
    {
        public bool Admin { get; set; }
        public string DeliveryAdressLineOne { get; set; }
        public string DeliveryAdressLineTwo { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Rating { get; set; }

        public string Valid(string anDeliveryAdressLineOne, string anDeliveryAdressLineTwo, string anPostCode, string anEmail, string anPassword, string anRating)
        {
            //declare empty string 
            string ErrorMsg = "";
            int ConvertedRating;
            //check for blank string
            if (anDeliveryAdressLineOne.Length>0 && anDeliveryAdressLineOne.Length< 46)
            {
                if (anDeliveryAdressLineTwo.Length > 0 && anDeliveryAdressLineTwo.Length < 46)
                {
                    if (anPostCode.Length>0 && anPostCode.Length<16)
                    {
                        if (anEmail.Length>0 && anEmail.Length<50)
                        {
                            if (anPassword.Length>0 && anPassword.Length < 50)
                            {
                                try
                                {
                                    if (anRating=="")
                                    {
                                        ConvertedRating = 0;
                                    }
                                    else
                                    {
                                        ConvertedRating = Convert.ToInt32(anRating);
                                        if (ConvertedRating > -1 && ConvertedRating < 11)
                                        {
                                            ErrorMsg = "";
                                        }
                                        else
                                        {
                                            //return error message 
                                            ErrorMsg += "Rating must be out of ten ";
                                        }
                                    }  
                                  
                                    
                                }
                                catch{
                                    //return error message 
                                    ErrorMsg += "Rating must be int ";

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

            return ErrorMsg;
        }
    }
}
