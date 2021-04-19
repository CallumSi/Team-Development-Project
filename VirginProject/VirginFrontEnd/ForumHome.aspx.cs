using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumHome : System.Web.UI.Page
    {
        //variable to the user and orginial id
        Int32 OriginalID;
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be processed 
            OriginalID = Convert.ToInt32(Session["UserID"]);

            //create an instance of the user book
            clsForumUserCollection Userbook = new clsForumUserCollection();
            //find the user record
            if (Userbook.ThisUser.FindOriginal(OriginalID) == false)
            {
                //change button text to create account
                btnNewComer.Text = "Create An Account";
                btnForum.Visible = false;
                UserID = -1;
            }
            else
            {
                //change button for edit user details
                btnNewComer.Text = "Edit User Account";
                Userbook.ThisUser.FindOriginal(OriginalID);
                UserID = Userbook.ThisUser.UserID;

            }
        }

        protected void btnForum_Click(object sender, EventArgs e)
        {
            //store user id in session object 
            Session["UserID"] = UserID;
            Response.Redirect("ForumPostList.aspx");
        }

        protected void btnNewComer_Click(object sender, EventArgs e)
        {
            //store user id and orginial id in session object 
            Session["UserID"] = UserID;
            Session["OriginalID"] = OriginalID;
            //redirect to edit user details page
            Response.Redirect("ForumAnUser.aspx");
        }
    }
}