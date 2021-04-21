using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPThankYouConfirmation : System.Web.UI.Page
    {
        Int32 PhoneID;
        Int32 Customer_ID;

        //create an instance of the clsvpcart
        clsVPCart MyCart = new clsVPCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear as user has checked out
            MyCart = new clsVPCart();
            //get the customer id 
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store the data in session so we can pass it to next page
            Session["Customer_ID"] = Customer_ID;
            //redirect back to phone customer list
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}