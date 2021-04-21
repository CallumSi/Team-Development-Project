using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;


namespace VirginFrontEnd
{
    public partial class VPPhoneViewer : System.Web.UI.Page
    {
        //variable to store the phone id and customer id for session object 
        Int32 PhoneID;
        Int32 Customer_ID;
        //create an instance of the clsVPCart
        clsVPCart MyCart = new clsVPCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the customers id and phone id and cart from  the session object
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
            PhoneID = Convert.ToInt32(Session["PhoneID"]);
            MyCart = (clsVPCart)Session["MyCart"];
            
            if (IsPostBack == false)
            {
                //display the requested record and user
                DisplayCustomerData();
                DisplayPhoneData();
            }

        }

        void DisplayCustomerData()
        {
            //create an instance of the customer collection class
            clsVPCustomerCollection SomeCustomer = new clsVPCustomerCollection();
            //find the customer to update
            SomeCustomer.ThisCustomer.Find(Customer_ID);
            //display the data for this record
            lblCustomerFirstName.Text = SomeCustomer.ThisCustomer.Customer_FirstName;
            
        }


        void DisplayPhoneData()
        {
            //create an instance of the phone collection class
            clsVPPhoneCollection SomePhone = new clsVPPhoneCollection();
            //find the phone to display
            SomePhone.ThisPhone.Find(PhoneID);
            //display the data for this record
            lblPhoneCapacity.Text = SomePhone.ThisPhone.Capacity;
            lblPhoneColour.Text = SomePhone.ThisPhone.Colour;
            lblPhoneDescription.Text = SomePhone.ThisPhone.Description;
            lblPhoneMake.Text = SomePhone.ThisPhone.Make;
            lblPhoneModel.Text = SomePhone.ThisPhone.Model;
            lblPhonePrice.Text = SomePhone.ThisPhone.Price.ToString();
            chkStockStatus.Text = SomePhone.ThisPhone.StockStatus.ToString();
            ddlQuantity.Text = SomePhone.ThisPhone.Quantity.ToString();

        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to the next page
            Session["MyCart"] = MyCart;
          
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to the next page
            Session["Customer_ID"] = Customer_ID;
            //redirect to the phone details page
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to the next page
            Session["Customer_ID"] = Customer_ID;
            Session["PhoneID"] = PhoneID;
            //save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
            Response.Redirect("VPViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to the next page
            Session["Customer_ID"] = Customer_ID;
            //redirect to customer edit page
            Response.Redirect("AnVPEditCustomer.aspx");
        
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            //create a new instance of the clsCartItem
            clsVPCartItem AnItem = new clsVPCartItem();
            //set the phone id 
            AnItem.ProductID = PhoneID;
            AnItem.QTY = 1;
            //add the item to the cart phone collection 
            MyCart.Products.Add(AnItem);
            //go back to shopping page
            Response.Redirect("VPCustomerPhoneList.aspx");

        }
    }
}