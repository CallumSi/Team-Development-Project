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
            Response.Redirect("VCHStaffDefault.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //direct me to the initial customer end page
            Response.Redirect("VCHCustomerDefault.aspx");
        }
    }
}