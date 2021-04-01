using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VCHDefault : System.Web.UI.Page
    {
        //the purpose of the default page is to allow me to access relevant pages
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            //direct me to the staff list page
            Response.Redirect("VCHStaffList.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //direct me to the customer list page
            Response.Redirect("VCHCustomerList.aspx");
        }
    }
}