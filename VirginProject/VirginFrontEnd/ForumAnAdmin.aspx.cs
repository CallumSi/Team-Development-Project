using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAnAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Add()
        {
            //create an instance of the User book
            clsForumAdminCollection AdminBook = new clsForumAdminCollection();
            //validate the data on the web form
            String Error = AdminBook.ThisAdmin.Valid(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text, txtPassword.Text, txtUsername.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                AdminBook.ThisAdmin.AdminUserName = txtUsername.Text;
                AdminBook.ThisAdmin.AdminFirstName = txtFirstName.Text;
                AdminBook.ThisAdmin.AdminLastName = txtLastName.Text;
                AdminBook.ThisAdmin.AdminEmail = txtEmailAddress.Text;
                AdminBook.ThisAdmin.AdminPassword = txtPassword.Text;
                //add the record
                AdminBook.Add();
                //Redirect back to the main page
                //Response.Redirect("ForumAdminList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }



        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("ForumAdminList.aspx");
        }
    }
}