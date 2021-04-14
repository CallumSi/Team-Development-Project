using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCustomerOrStaffSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            //direct me to the staff end pages
            Response.Redirect("VCHDefault.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //direct me to the customer end pages
            // I haven't created this side yet - Response.Redirect("VCHDefault2.aspx");
        }
    }
}