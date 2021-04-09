using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMCheckout : System.Web.UI.Page
    {
        clsVMCart MyCart = new clsVMCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsVMCart)Session["MyCart"];
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
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
    }
}