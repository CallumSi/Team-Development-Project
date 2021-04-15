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
        //variable to store the primary key with page level scope
        Int32 AdminID;
        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be processed 
            AdminID = Convert.ToInt32(Session["AdminID"]);
            if (IsPostBack == false)
            {
                //populate the list of users
                DisplayAdmin();
                //if this is not a new record
                if (AdminID !=-1)
                {
                    //display the current data for the record
                    DisplayAdmin();
                }
            }
        }
        void DisplayAdmin()
        {
            //create an instance of the user book
            clsForumAdminCollection AdminBook = new clsForumAdminCollection();
            //find the record to update
            AdminBook.ThisAdmin.Find(AdminID);
            //display the data for this record
            txtUsername.Text = AdminBook.ThisAdmin.AdminUserName;
            txtFirstName.Text = AdminBook.ThisAdmin.AdminFirstName;
            txtLastName.Text = AdminBook.ThisAdmin.AdminLastName;
            txtEmailAddress.Text = AdminBook.ThisAdmin.AdminEmail;
            txtPassword.Text = AdminBook.ThisAdmin.AdminPassword;
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
                //get the data entered by the admin
                AdminBook.ThisAdmin.AdminUserName = txtUsername.Text;
                AdminBook.ThisAdmin.AdminFirstName = txtFirstName.Text;
                AdminBook.ThisAdmin.AdminLastName = txtLastName.Text;
                AdminBook.ThisAdmin.AdminEmail = txtEmailAddress.Text;
                AdminBook.ThisAdmin.AdminPassword = txtPassword.Text;
                //add the record
                AdminBook.Add();
                //Redirect back to the main page
                Response.Redirect("ForumAdminList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }



        }


        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (AdminID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }

        void Update()
        {
            //create an instance of the admin book
            clsForumAdminCollection AdminBook = new clsForumAdminCollection();
            //validate the data on the web form
            String Error = AdminBook.ThisAdmin.Valid(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text, txtPassword.Text, txtUsername.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                AdminBook.ThisAdmin.Find(AdminID);
                //get the data entered by the admin
                AdminBook.ThisAdmin.AdminUserName = txtUsername.Text;
                AdminBook.ThisAdmin.AdminFirstName = txtFirstName.Text;
                AdminBook.ThisAdmin.AdminLastName = txtLastName.Text;
                AdminBook.ThisAdmin.AdminEmail = txtEmailAddress.Text;
                AdminBook.ThisAdmin.AdminPassword = txtPassword.Text;
                //update the record 
                AdminBook.Update();
                //Redirect back to the admin list page
                Response.Redirect("ForumAdminList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }
        }

        protected void btnCancel_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminList.aspx");
        }
    }
}