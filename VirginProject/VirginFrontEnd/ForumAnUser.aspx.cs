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
        //variable to store the primary key 
        Int32 UserId;
        //variable to store the primary key 
        Int32 OriginalID;
        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be processed 
            UserId = Convert.ToInt32(Session["UserId"]);
            //get the orginal to be processed 
            OriginalID = Convert.ToInt32(Session["OriginalID"]);
            if (IsPostBack == false)
            {
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
            txtFirstName.Text = UserBook.ThisUser.UserFirstName;
            txtLastName.Text = UserBook.ThisUser.UserLastName;
            txtEmailAddress.Text = UserBook.ThisUser.UserEmail;
            //txtPassword.Text = UserBook.ThisUser.UserPassword;
            txtPhoneNumber.Text = UserBook.ThisUser.UserPhoneNumber;
            //txtUsername.Text = UserBook.ThisUser.Userusername;
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
            //add PK to session object 
            Session["UserId"] = UserId;
            //redirect to the main page
            Response.Redirect("ForumPostList.aspx");

        }
        void Add()
        {
            //create an instance of the User book
            clsForumUserCollection UserBook = new clsForumUserCollection();
            //validate the data on the web form
            String Error = UserBook.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text, /*txtPassword.Text,*/ txtPhoneNumber.Text/*, txtUsername.Text*/);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                UserBook.ThisUser.UserFirstName = txtFirstName.Text;
                UserBook.ThisUser.UserLastName = txtLastName.Text;
                UserBook.ThisUser.UserEmail = txtEmailAddress.Text;
                UserBook.ThisUser.UserPhoneNumber = txtPhoneNumber.Text;
                UserBook.ThisUser.OriginalID = OriginalID;
                //add the record
                UserBook.Add();
                //find the record
                UserBook.ThisUser.FindOriginal(OriginalID);
                Session["UserId"] = UserBook.ThisUser.UserID;
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
            String Error = UserBook.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text,/* txtPassword.Text,*/ txtPhoneNumber.Text/*, txtUsername.Text*/);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                UserBook.ThisUser.Find(UserId);
                //get the data entered by the user
                UserBook.ThisUser.UserFirstName = txtFirstName.Text;
                UserBook.ThisUser.UserLastName = txtLastName.Text;
                UserBook.ThisUser.UserEmail = txtEmailAddress.Text;
                UserBook.ThisUser.UserPhoneNumber = txtPhoneNumber.Text;
                //update the record 
                UserBook.Update();
                //Redirect back to the user list page
                Session["UserID"] = UserId;
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //add PK to session object 
            Session["UserId"] = OriginalID;
            //redirect to user list
            Response.Redirect("ForumUserList.aspx");
        }
    }
}