using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VPCustomerWelcome : System.Web.UI.Page
    {
        Int32 Customer_ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer_ID = Convert.ToInt32(Session["UserID"]);
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            //take the customer user to the homepage
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnFirstTime_Click(object sender, EventArgs e)
        {
            Response.Redirect("");
        }
    }
}