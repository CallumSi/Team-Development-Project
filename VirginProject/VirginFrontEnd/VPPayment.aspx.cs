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
    public partial class VPPayment : System.Web.UI.Page
    {
        Int32 PhoneID;
        Int32 Customer_ID;
        Int32 OriginalID;
        clsVPCart MyCart = new clsVPCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            OriginalID = Convert.ToInt32(Session["UserID"]);
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsVPCart)Session["MyCart"];
            //get the customer id
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
            MyCart.UserNo = Customer_ID;
        }


        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //test to see that card details are entered
            if (txtCardNo.Text != "")
            {
                //save the card no 
                MyCart.CardNo = txtCardNo.Text;
                MyCart.Checkout();
                Response.Redirect("VPThankYouConfirmation.aspx");
            }
            else
            {
                lblError.Text = "Payment details are not correct, please try again";
            }

        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session["Customer_ID"] = Customer_ID;
            //redirect back to customer phone list
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            //store the data in the session so we can pass it to the next page
            Session["Customer_ID"] = Customer_ID;
            //redirect to the cart page
            Response.Redirect("AnVPEditCustomer.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store the data in the session so we can pass it to the next page
            Session["Customer_ID"] = Customer_ID;
            //redirect to the cart page
            Response.Redirect("VPViewCart");
        }

        protected void btnCustomerHome_Click(object sender, EventArgs e)
        {
            //store the data in the session so we can pass it to the next page
            Session["Customer_ID"] = Customer_ID;
            //redirect back to customer phone list
            Response.Redirect("VPCustomerPhoneList.aspx");
        }
    }
}
