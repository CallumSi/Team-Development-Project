using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VMCustomerWelcome : System.Web.UI.Page
    {
        Int32 VMCustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            //take the user to the home page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnFirstTime_Click(object sender, EventArgs e)
        {

        }
    }
}