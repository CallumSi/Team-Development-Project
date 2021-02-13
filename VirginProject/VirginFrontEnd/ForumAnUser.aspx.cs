using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAnUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsUser
            clsForumUser AnUser = new clsForumUser();
            //capture the first name
            AnUser.UserFirstName = txtFirstName.Text;
            AnUser.UserLastName = txtLastName.Text;
            AnUser.UserPhoneNumber = txtPhoneNumber.Text;
            AnUser.UserEmail = txtEmailAddress.Text;
            AnUser.UserPassword = txtPassword.Text;
            //store the address in the session object
            Session["AnUser"] = AnUser;
            //redirect to the viewer page
            Response.Redirect("ForumUserViewer.aspx");
        }
    }
}