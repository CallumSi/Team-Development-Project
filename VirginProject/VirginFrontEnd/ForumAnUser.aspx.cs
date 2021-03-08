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
        //variable to store the primary key with page level scope
        Int32 UserId;
        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be processed 
            UserId = Convert.ToInt32(Session["UserId"]);
            if (IsPostBack == false)
            {
                //populate the list of users
                DisplayUser();
                //if this is not a new record
                if (UserId != -1)
                {
                    //display the current data for the record
                    DisplayUser();
                }
            }

        }
        void DisplayUser()
        {
            //create an instance of the user book
            clsForumUserCollection UserBook = new clsForumUserCollection();
            //find the record to update
            UserBook.ThisUser.Find(UserId);
            //display the data for this record
            txtUsername.Text = UserBook.ThisUser.Userusername;
            txtFirstName.Text = UserBook.ThisUser.UserFirstName;
            txtLastName.Text = UserBook.ThisUser.UserLastName;
            txtPhoneNumber.Text = UserBook.ThisUser.UserPhoneNumber;
            txtEmailAddress.Text = UserBook.ThisUser.UserEmail;
            txtPassword.Text = UserBook.ThisUser.UserPassword;
        }
        //event handler for the ok button
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (UserId == -1)
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
        void Add()
        {
            //create an instance of the User book
            clsForumUserCollection UserBook = new clsForumUserCollection();
            //validate the data on the web form
            String Error = UserBook.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmailAddress.Text, txtPassword.Text, txtUsername.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                UserBook.ThisUser.Userusername = txtUsername.Text;
                UserBook.ThisUser.UserFirstName = txtFirstName.Text;
                UserBook.ThisUser.UserLastName = txtLastName.Text;
                UserBook.ThisUser.UserPhoneNumber = txtPhoneNumber.Text;
                UserBook.ThisUser.UserEmail = txtEmailAddress.Text;
                UserBook.ThisUser.UserPassword = txtPassword.Text;
                //add the record
                UserBook.Add();
                //Redirect back to the main page
                Response.Redirect("ForumUserList.aspx");
            }
            else
            {
                //report an error
                lblUserError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }

        }
        //function for updating records
        void Update()
        {
            //create an instance of the user book
            clsForumUserCollection UserBook = new clsForumUserCollection();
            //validate the data on the web form
            String Error = UserBook.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmailAddress.Text, txtPassword.Text, txtUsername.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                UserBook.ThisUser.Find(UserId);
                //get the data entered by the user
                UserBook.ThisUser.Userusername = txtUsername.Text;
                UserBook.ThisUser.UserFirstName = txtFirstName.Text;
                UserBook.ThisUser.UserLastName = txtLastName.Text;
                UserBook.ThisUser.UserPhoneNumber = txtPhoneNumber.Text;
                UserBook.ThisUser.UserEmail = txtEmailAddress.Text;
                UserBook.ThisUser.UserPassword = txtPassword.Text;
                //update the record 
                UserBook.Update();
                //Redirect back to the user list page
                Response.Redirect("ForumUserList.aspx");
            }
            else
            {
                //report an error
                lblUserError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }
        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}