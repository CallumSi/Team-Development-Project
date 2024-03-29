﻿using System;
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
    public partial class VMCheckout : System.Web.UI.Page
    {
        Int32 VMCustomerID;
        clsVMCart MyCart = new clsVMCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsVMCart)Session["MyCart"];
            //get the CustomerID
            VMCustomerID = Convert.ToInt32(Session["VMCustomerID"]);
            MyCart.UserNo = VMCustomerID;

            if (IsPostBack == false)
            {
                DisplayCustomerData();
            }

        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        void DisplayCustomerData()
        {
            //create an instance of the customer collection class
            clsVMCustomerCollection SomeCustomer = new clsVMCustomerCollection();
            //find the customer to update
            SomeCustomer.ThisCustomer.Find(VMCustomerID);
            //display the data for this record
            lblMVUsername.Text = SomeCustomer.ThisCustomer.VMcustomerUsername;
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            //test to see that card details are entered
            if (txtCardNo.Text != "")
            {
                //save the card no
                MyCart.CardNo = txtCardNo.Text;
                MyCart.Checkout();
                Response.Redirect("VMThanks.aspx");
            }
            else
            {
                lblError.Text = "Payment details not valid";
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            //redirect to home page
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            //redirect to view cart page
            Response.Redirect("VMViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("AnVMCustomerEdit.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnCheckout_Click1(object sender, EventArgs e)
        {
            Response.Redirect("VMThanks.aspx");
        }
    }
}