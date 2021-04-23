using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

///This page uses code originated by Matthew Dean.
///it is free for use by anybody so long as you give credit to the original author.
///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

namespace VirginFrontEnd
{
    public partial class VMThanks : System.Web.UI.Page
    {
        //variable to store the MovieID and CustomerID from session obect
        Int32 VMMovieID;
        Int32 VMCustomerID;
        //create an instance of the clsVMCart
        clsVMCart MyCart = new clsVMCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear cart as user has checked out 
            MyCart = new clsVMCart();
            //get the customer Id
            VMCustomerID = Convert.ToInt32(Session["VMCustomerID"]);

            if (IsPostBack == false)
            {
                DisplayCustomerData();
            }
        }

        void DisplayCustomerData()
        {
            //create an instance of the customer collection class
            clsVMCustomerCollection SomeCustomer = new clsVMCustomerCollection();
            //find the customer to update
            SomeCustomer.ThisCustomer.Find(VMCustomerID);
            //display the data for this record
            lblUsername.Text = SomeCustomer.ThisCustomer.VMcustomerUsername;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            //redirect to the movie details page
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}