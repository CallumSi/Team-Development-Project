using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceUserDelete : System.Web.UI.Page
    {

        //var for UserId of record to be deleted
        Int32 UserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieve the id from session object
            UserID = Convert.ToInt32(Session["UserID"]);
            lblLoad.Text = "Are you sure you want to delete usewr with the ID:" + UserID;

        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //call the funciton to delete the recrod
            DeleteUser();
            //then go back to main page
            Response.Redirect("MarketplaceUserList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //go back to main page
            Response.Redirect("MarketplaceUserList.aspx");
        }


        void DeleteUser()
        {
            //function for deleting records
            //create  instance of  user colleciton
            clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //find the record to delete
            SomeUser.ThisUser.Find(UserID);
            //delete the record
            SomeUser.DeleteUser();
           
        }
    }
}