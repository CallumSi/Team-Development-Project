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

        public string Valid(string anDeliveryAdressLineOne)
        {
            if (anDeliveryAdressLineOne != "" )
            {
                if (anDeliveryAdressLineOne.Length < 46)
                {
                    //return no error message 
                    return "";
                }
                else
                {
                    //return error message 
                    return "Delivery Line One cannot exceed 45 characters";
                }
                
            }
            else
            {
                //return error message 
                return "Delivery Line One cannot be left blank! ";
            }
        
        }

    }
}
