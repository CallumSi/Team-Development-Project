using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AnVirginUser : System.Web.UI.Page
    {
        //variable to store the UserID from session obect
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of users to be procvessed
            UserID = Convert.ToInt32(Session["UserID"]);
            if (IsPostBack == false)
            {
                //if not a new record 
                if (UserID != -1)
                {
                    //display the requeted record
                    DisplayData();
                }
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (UserID == -1)
            {
                //add the new record
                AddUser();
            }
            else
            {
                UpdateUser();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginUserList.aspx");
        }

        void DisplayData()
        {
            //create an instance of the user collection class
            clsUserCollection SomeUser = new clsUserCollection();
            //find the record to update
            SomeUser.ThisUser.Find(UserID);
            //display the data for this record
           
            txtUserName.Text = SomeUser.ThisUser.UserName;
            txtPassword.Text = SomeUser.ThisUser.UserPassword;
        }

        public void UpdateUser()
        {
            //create a instance of the user collection class
            clsUserCollection SomeUser = new clsUserCollection();
            //ensure the data is valid by using the valid method
            string Error = "";
            Error = SomeUser.ThisUser.Valid(txtUserName.Text, txtPassword.Text);
            //if no error msg then add it to object
            if (Error == "")
            {
                //find the record to update

                SomeUser.ThisUser.Find(UserID);

                //get the data from the form

                SomeUser.ThisUser.UserName = txtUserName.Text;
                SomeUser.ThisUser.UserPassword = txtPassword.Text;


                //then update the record
                SomeUser.Update();
                //then go back to the list page
                Response.Redirect("VirginUserList.aspx");

            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered: " + Error;
            }
        }


        //function for adding records
        public void AddUser()
        {
            //create a instance of the user collection class
            clsUserCollection SomeUser = new clsUserCollection();
            //ensure the data is valid by using the valid method
            string Error = "";
            Error = SomeUser.ThisUser.Valid(txtUserName.Text, txtPassword.Text);
            //if no error msg then add it to object
            if (Error == "")
            {
                SomeUser.ThisUser.UserName = txtUserName.Text;
                SomeUser.ThisUser.UserPassword = txtPassword.Text;


                //then add the record
                SomeUser.Add();
                //then go back to the list page
                Response.Redirect("VirginUserList.aspx");

            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered: " + Error;
            }
        }
    }
}