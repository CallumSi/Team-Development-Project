using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAdminHome : System.Web.UI.Page
    {
        //variable to the user and orginial id
        Int32 OriginalID;
        Int32 AdminID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be processed 
            OriginalID = Convert.ToInt32(Session["AdminID"]);

            //create an instance of the user book
            clsForumAdminCollection Adminbook = new clsForumAdminCollection();
            //find the user record
            if (Adminbook.ThisAdmin.FindOriginal(OriginalID) == false)
            {
                //change button text to create account
                btnNewComer.Text = "Create An Account";
                btnAdminPage.Visible = false;
                AdminID = -1;
            }
            else
            {
                //change button for edit user details
                btnNewComer.Text = "Edit User Account";
                Adminbook.ThisAdmin.FindOriginal(OriginalID);
                AdminID = Adminbook.ThisAdmin.AdminID;

            }
        }

      

        protected void btnNewComer_Click(object sender, EventArgs e)
        {
            //store user id and orginial id in session object 
            Session["AdminID"] = AdminID;
            Session["OriginalID"] = OriginalID;
            //redirect to edit user details page
            Response.Redirect("ForumAnAdmin.aspx");
        }

        protected void btnAdminPage_Click(object sender, EventArgs e)
        {
            //store user id in session object 
            Session["AdminID"] = AdminID;
            Response.Redirect("ForumAdminHomePage.aspx");
        }
    }
}