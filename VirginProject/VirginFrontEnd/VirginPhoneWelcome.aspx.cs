using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VirginPhoneWelcome : System.Web.UI.Page
    {

        //variables to store the id 
        Int32 Customer_ID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            //take the user to the home page
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("");
        }

        protected void btnFirstTime_Click(object sender, EventArgs e)
        {

        }
    }
}