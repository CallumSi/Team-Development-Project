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
        //variable to store the UserID from session obect
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of users to be procvessed
            UserID = Convert.ToInt32(Session["UserID"]);
            if (IsPostBack == false)
            {
                //if not a new record 
                if (UserID != -1)
                {
                    //display the requeted record
                    DisplayData();
                }
            }

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if(UserID == -1)
            {
                //add the new record
                AddUser();
            }
            else
            {
                UpdateUser();
            }
            Session["UserID"] = UserID;
            Response.Redirect("MarketplaceHome2.aspx");

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MarketplaceUserList.aspx");
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
                Response.Redirect("MarketplaceUserList.aspx");

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

                //then add the record
                SomeUser.AddUser();
                //then go back to the list page
                Response.Redirect("MarketplaceUserList.aspx");

            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered: " + Error;
            }
        }

      
    }
}