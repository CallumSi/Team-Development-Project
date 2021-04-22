using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    ///This page uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    public partial class VPCustomerFirstTime : System.Web.UI.Page
    {
        //variable to store the Customer_ID and OrginialID
        Int32 Customer_ID;
        Int32 OriginalID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the originalID to be processed 
            OriginalID = Convert.ToInt32(Session["UserID"]);

            //create an instance of the user book
            clsVPCustomerCollection VPCustomer = new clsVPCustomerCollection();
            //find the user record
            if (VPCustomer.ThisCustomer.FindOriginal(OriginalID) == false)
            {
                //change button text to create account
                btnVPNewComer.Text = "Please Create An Account. ";
                btnContinueVP.Visible = false;
                Customer_ID = -1;
            }
            else
            {
                //change button for edit user details
                btnVPNewComer.Text = "Edit Customer Account";
                VPCustomer.ThisCustomer.FindOriginal(OriginalID);
                Customer_ID = VPCustomer.ThisCustomer.Customer_ID;
            }
        }
        
        protected void btnVPNewComer_Click(object sender, EventArgs e)
        {
            //store Customer_ID and OrginialID in session object 
            Session["Customer_ID"] = Customer_ID;
            Session["OriginalID"] = OriginalID;
            //redirect to edit user details page
            Response.Redirect("AnNewVPCustomer.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnContinueVP_Click1(object sender, EventArgs e)
        {
            //store Customer_ID in session object 
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("VPCustomerPhoneList.aspx");
        }
    }
}