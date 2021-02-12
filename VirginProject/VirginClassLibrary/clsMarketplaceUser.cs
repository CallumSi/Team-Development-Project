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
        public int UserID { get; set; }
        //public Boolean Find(int UserID)
        //{


        //}

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
                        if (anEmail.Length>2 && anEmail.Length<51)
                        {
                            if (anPassword.Length>2 && anPassword.Length < 51)
                            {
                                try
                                {
                                    if (anRating=="")
                                    {
                                        ErrorMsg = "";
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

            //check for special characters
            if (TestForSpecialCharacters(anDeliveryAdressLineOne) == true)
            {
                ErrorMsg += "Delivery adress line one must have no special characters";

            }
            if (TestForSpecialCharacters(anDeliveryAdressLineTwo) == true)
            {
                ErrorMsg += "Delivery adress line two must have no special characters";

            }
            if (TestForSpecialCharacters(anPostCode) == true)
            {
                ErrorMsg += "PostCode must have no special characters";

            }
            if (anRating!="" && TestForSpecialCharacters(anRating) == true)
            {
                ErrorMsg += "Rating must have no special characters";

            }
            if (TestForSpecialCharacters(anPassword) == false)
            {
                ErrorMsg += "passsword must have 1 special character";

            }
            //test email format
            if (anEmail != "")
            {
                
                try
                {
                    var EmailTest = new System.Net.Mail.MailAddress(anEmail);
                }
                catch
                {
                    ErrorMsg += "Email must be in the correct format";
                }
            }
            return ErrorMsg;
        }




        public bool TestForSpecialCharacters(string TestData)
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
