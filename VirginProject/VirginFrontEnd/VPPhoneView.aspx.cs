using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPPhoneView : System.Web.UI.Page
    {
        //variable to store the PhoneID and CustomerID from the session oject
        Int32 PhoneID;
        Int32 Customer_ID;
        //create an instance of the cls clsVPCart
        clsVPCart MyCart = new clsVPCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the customer id and phone id and cart from the session object 
            PhoneID = Convert.ToInt32(Session["PhoneID"]);
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
            MyCart = (clsVPCart)Session["MyCart"];

            if (IsPostBack == false)
            {
                {
                    //display the requested record and user
                    DisplayCustomerData();
                    DisplayPhoneData();

                }
            }
        }

        void DisplayPhoneData()
        {
            //create an instance of the phone collection class
            clsVPPhoneCollection SomePhone = new clsVPPhoneCollection();
            //find the phone to display
            SomePhone.ThisPhone.Find(PhoneID);
            ///display the data for this record
            lblPhoneCapacity.Text = SomePhone.ThisPhone.Capacity;
            lblPhoneColour.Text = SomePhone.ThisPhone.Colour;
            lblPhoneDescription.Text = SomePhone.ThisPhone.Description;
            lblPhoneMake.Text = SomePhone.ThisPhone.Make;
            lblPhoneModel.Text = SomePhone.ThisPhone.Model;
            lblPhonePrice.Text = SomePhone.ThisPhone.Price.ToString();
            ddlPhoneQuantity.Text = SomePhone.ThisPhone.Quantity.ToString();

        }

        void DisplayCustomerData()
        {
            //create an instance of the customer collection class
            clsVPCustomerCollection SomeCustomer = new clsVPCustomerCollection();
            //find the customer to update 
            SomeCustomer.ThisCustomer.Find(Customer_ID);
            //display the data for this record
            //lblMake;
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {
            //create an instance of the clsVPCartItem
            clsVPCartItem AnItem = new clsVPCartItem();
            //set the phone id
            AnItem.ProductID = PhoneID;
            AnItem.QTY = 1;
            //go back to shopping 
            Response.Redirect("");
        }
    }
}