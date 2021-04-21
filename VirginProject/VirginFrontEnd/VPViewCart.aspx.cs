using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPViewCart : System.Web.UI.Page
    {
        //varible to store the customer id
        Int32 Customer_ID;
        Int32 PhoneID;

        //create an instance of the clsVPCart 
        clsVPCart MyCart = new clsVPCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the customers id 
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
            PhoneID = Convert.ToInt32(Session["PhoneID"]);
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsVPCart)Session["MyCart"];
            //display the cart contents
            DisplayCart();
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        void DisplayCart()
        {
            //create some variables
            Int32 Index = 0;
            Int32 Count = MyCart.Products.Count;
            string Phonename;
            //display the phone 
            //Response.Write("PhoneID");
            //Response.Write("Quantity");
            //if cart is empty tell the user
            if (Count == 0)
            {
                lblError.Text = ("Shopping Cart Empty");
            }
            //for each item in the cart
            while (Index < Count)
            {
                clsVPPhone AnPhone = new clsVPPhone();
                //find the listing 
                AnPhone.Find((MyCart.Products[Index].ProductID));
                //add the item to the list box
                Phonename = AnPhone.Make;
                string lstitem = Phonename;
                lstShoppingCart.Items.Add(lstitem);
                Index++;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("VPViewCart.aspx");
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            if (lstShoppingCart.Items.Count !=0)
            {
                //store data in session object so we can pass it to next page
                Session["Customer_ID"] = Customer_ID;
                Response.Redirect("VPDeliveryList.aspx");
            }
            else
            {
                lblError.Text = "Please add items to cart first";
            }
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            //send the customer back to the main phone list page
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPCustomerPhoneList.aspx");
        }
    }
}