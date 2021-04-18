using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPPayment : System.Web.UI.Page
    {
        Int32 PhoneID;
        Int32 Customer_ID;
        clsVPCart MyCart = new clsVPCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsVPCart)Session["MyCart"];
            //get the customer id
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
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

        protected void btnPlaceOrder_Click1(object sender, EventArgs e)
        {
            Response.Redirect("VPThankYouConfirmation.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
