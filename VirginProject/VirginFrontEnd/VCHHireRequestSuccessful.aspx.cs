using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHHireRequestSuccessful : System.Web.UI.Page
    {
        //variable to store the primary key & UserID (FK) with page level scope
        Int32 CustomerID;
        Int32 UserID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the Customer that will be deleted from the session object
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the CustomerID & UserID when a page unload event happens
            Session["CustomerID"] = CustomerID;
            Session["UserID"] = UserID;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //Add the CustomerID to session object 
            Session["CustomerID"] = CustomerID;
            //redirect the customer to the customer home page
            Response.Redirect("VCHCustomerHomeCE.aspx");
        }

        protected void btnAccount_Click(object sender, EventArgs e)
        {
            //Add the CustomerID to session object 
            Session["CustomerID"] = CustomerID;
            //redirect the customers account page 
            Response.Redirect("VCHACustomerCE.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //direct me to the log in page
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnBackHome_Click(object sender, EventArgs e)
        {
            //Add the CustomerID to session object 
            Session["CustomerID"] = CustomerID;
            //redirect the customer to the customer home page
            Response.Redirect("VCHCustomerHomeCE.aspx");
        }
    }
}