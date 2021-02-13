using System;

namespace VirginClassLibrary
{
    public class clsMarketplaceUser
    {


        //private data 
        private bool mAdmin;
        private string mDeliveryAdressLineOne;
        private string mDeliveryAdressLineTwo;
        private string mPostCode;
        private string mEmail;
        private string mPassword;
        private int mRating;
        private int mUserID;

        //public data
        public bool Admin
        {
            get
            {
                //return private data
                return mAdmin;
            }
            set
            {
                //set value to private data
                mAdmin = value;
            }
        }
        public string DeliveryAdressLineOne
        {
            get
            {
                //return private data
                return mDeliveryAdressLineOne;
            }
            set
            {
                //set value to private data
                mDeliveryAdressLineOne = value;
            }
        }
        public string DeliveryAdressLineTwo
        {
            get
            {
                //return private data
                return mDeliveryAdressLineTwo;
            }
            set
            {
                //set value to private data
                mDeliveryAdressLineTwo = value;
            }
        }
        public string PostCode
        {
            get
            {
                //return private data
                return mPostCode;
            }
            set
            {
                //set value to private data
                mPostCode = value;
            }
        }
        public string Email
        {
            get
            {
                //return private data
                return mEmail;
            }
            set
            {
                //set value to private data
                mEmail = value;
            }
        }
        public string Password
        {
            get
            {
                //return private data
                return mPassword;
            }
            set
            {
                //set value to private data
                mPassword = value;
            }
        }
        public int Rating
        {
            get
            {
                //return private data
                return mRating;
            }
            set
            {
                //set value to private data
                mRating = value;
            }
        }
        public int UserID
        {
            get
            {
                //return private data
                return mUserID;
            }
            set
            {
                //set value to private data
                mUserID = value;
            }
        }
        public Boolean Find(int UserID)
        {
            //instantiate the data connection
            clsDataConnection DB = new clsDataConnection();
            //ad the parameter we use to search
            DB.AddParameter("UserID", UserID);
            //execute the sproc
            DB.Execute("sproc_tblUser_FilterByUserID");
            //if record found 
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data variables
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                mDeliveryAdressLineOne = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAdressLineOne"]);
                mDeliveryAdressLineTwo = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAdressLineTwo"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mRating = Convert.ToInt32(DB.DataTable.Rows[0]["Rating"]);
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;
            }
            else
            {
                //return false if no record ofund
                return false;
            }

        }

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
                                ErrorMsg += "";     
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

            //try Convert Rating
            try
            {
                if (anRating == "")
                {
                    ErrorMsg += "";
                }
                else
                {
                    ConvertedRating = Convert.ToInt32(anRating);
                    if (ConvertedRating > -1 && ConvertedRating < 11)
                    {
                        ErrorMsg += "";
                    }
                    else
                    {
                        //return error message 
                        ErrorMsg += "Rating must be out of ten ";
                    }
                }


            }
            catch
            {
                //return error message 
                ErrorMsg += "Rating must be int ";

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
