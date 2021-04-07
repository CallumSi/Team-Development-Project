using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class MarketplaceWelcome : System.Web.UI.Page
    {
        int UserID = 1;
        protected void Page_Load(object sender, EventArgs e)
        
        {
            //check if user exisits
            //create an instance of the user collection class
            VirginClassLibrary.clsMarketplaceUserCollection SomeUser = new VirginClassLibrary.clsMarketplaceUserCollection();
            //find the record to update
            if (SomeUser.ThisUser.Find(UserID) == false)
            {
               
                btnFirstTime.Text = "Create Account";
                btnContinue.Visible = false;
                UserID = -1;
            }
            else
            {
                btnFirstTime.Text = "Edit Account Details";

            }

     
        }

        protected void btnFirstTime_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = -1;
            //redirect to edit user details page
            Response.Redirect("AnMarketplaceUser.aspx");
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Session["UserID"] = UserID;
            Response.Redirect("MarketplaceHome2.aspx");
        }
    }
}