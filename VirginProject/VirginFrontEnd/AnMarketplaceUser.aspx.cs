using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AnMarketplaceUser : System.Web.UI.Page
    {
        //variable to store the UserID  and Original from session obect
        Int32 UserID;
        Int32 OriginalID;

        //when page is loaded
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the user ID and original ID
            UserID = Convert.ToInt32(Session["UserID"]);
            OriginalID = Convert.ToInt32(Session["OriginalID"]);
            lblOriginalID.Text = "New User";


            if (IsPostBack == false)
            {
                //if not a new record 
                if (UserID != -1)
                {
                    //display the requeted record
                    DisplayData();
                    //indicate the users ID
                    lblOriginalID.Text = OriginalID.ToString();
                }
            }

        }

       

            protected void btnOk_Click(object sender, EventArgs e)
        {
            //if new record
            if(UserID == -1)
            {
                //add the new record
                AddUser();
            }
            else
            {
                //update the record
                UpdateUser();
            }
            //add user id to session object 
            Session["UserID"] = UserID;
            //redirect to the main page
            Response.Redirect("MarketplaceHome2.aspx");

        }

        //go back to the welcome page
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session["UserID"] = OriginalID;
            Response.Redirect("MarketplaceWelcome.aspx");
           
        }

        void DisplayData()
        {
            //create an instance of the user collection class
            clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //find the record to update
            SomeUser.ThisUser.Find(UserID);
            //display the data for this record
            txtEmail.Text = SomeUser.ThisUser.Email;
            txtDeliveryAdressLineOne.Text = SomeUser.ThisUser.DeliveryAdressLineOne;
            txtDeliveryAdressLineTwo.Text = SomeUser.ThisUser.DeliveryAdressLineTwo;
            txtPostCode.Text = SomeUser.ThisUser.PostCode;

        }


        //METHOD TO UPDATE USER
        public void UpdateUser()
        {
            //create a instance of the user collection class
            clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //ensure the data is valid by using the valid method
            string Error = "";
            Error = SomeUser.ThisUser.Valid(txtDeliveryAdressLineOne.Text, txtDeliveryAdressLineTwo.Text, txtPostCode.Text, txtEmail.Text);
            //if no error msg then add it to object
            if (Error == "")
            {
                //find the record to update
                SomeUser.ThisUser.Find(UserID);
                //get the data from the form     
                SomeUser.ThisUser.Email = txtEmail.Text;
                SomeUser.ThisUser.DeliveryAdressLineOne = txtDeliveryAdressLineOne.Text;
                SomeUser.ThisUser.DeliveryAdressLineTwo = txtDeliveryAdressLineTwo.Text;
                SomeUser.ThisUser.PostCode = txtPostCode.Text;    
                //then update the record
                SomeUser.UpdateUser();
                //then go back to the list page
                Session["UserID"] = UserID;
                Response.Redirect("MarketplaceHome2.aspx");
            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered: " + Error;
            }
        }


        //function for adding records
        public void AddUser()
        {
            //create a instance of the user collection class
            clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //ensure the data is valid by using the valid method
            string Error = "";
            Error = SomeUser.ThisUser.Valid(txtDeliveryAdressLineOne.Text, txtDeliveryAdressLineTwo.Text, txtPostCode.Text, txtEmail.Text);
            //if no error msg then add it to object
            if (Error == "")
            {
                //get the data from the form        
                SomeUser.ThisUser.Email = txtEmail.Text;
                SomeUser.ThisUser.DeliveryAdressLineOne = txtDeliveryAdressLineOne.Text;
                SomeUser.ThisUser.DeliveryAdressLineTwo = txtDeliveryAdressLineTwo.Text;
                SomeUser.ThisUser.PostCode = txtPostCode.Text;
                SomeUser.ThisUser.OriginalID = OriginalID;
                //then add the record
                SomeUser.AddUser();
                //then go back to the list page
                SomeUser.ThisUser.FindByOriginal(OriginalID);
                Session["UserID"] = SomeUser.ThisUser.UserID;
                Response.Redirect("MarketplaceHome2.aspx");
            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered: " + Error;
            }
        }

      
    }
}