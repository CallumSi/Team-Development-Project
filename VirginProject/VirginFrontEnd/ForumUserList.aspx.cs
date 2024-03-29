﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumUserList : System.Web.UI.Page
    {
        //declare admin id
        Int32 AdminID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the admin to be processed 
            AdminID = Convert.ToInt32(Session["AdminID"]);
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayUser();
                //display first name
                DisplayFirstName();
            }

        }
        void DisplayUser()
        {
            //create an instance of the user Collection
            clsForumUserCollection Users = new clsForumUserCollection();
            //set the data source to the list of user in the collection
            lstUserListBox.DataSource = Users.UserList;
            //set the name of the primary key
            lstUserListBox.DataValueField = "UserID";
            //set the data field to display
            lstUserListBox.DataTextField = "UserFirstName";
            //bind the data to the list
            lstUserListBox.DataBind();
            //clear the list box
            lstUserListBox.Items.Clear();
        }
        void DisplayFirstName()
        {
            //create an instance of the user Collection
            clsForumAdminCollection Admin = new clsForumAdminCollection();
            //find First name
            Admin.ThisAdmin.Find(AdminID);
            //display the first name
            lblFirstName.Text = Admin.ThisAdmin.AdminFirstName;
        }
  

        Int32 DisplayFilterUserFirstName(string UserFirstNameFilter)
        {
            //int to store the primary key
            Int32 UserId;
            //string firstname
            string UserFirstName;
            //string last name
            string UserLastName;
            //create an instance of the user collection class
            clsForumUserCollection UserBook = new clsForumUserCollection();
            UserBook.ReportByUserFirstName(UserFirstNameFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = UserBook.Count;
            //clear the list box
            lstUserListBox.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the User id
                UserId = UserBook.UserList[Index].UserID;
                //get the first name
                UserFirstName = UserBook.UserList[Index].UserFirstName;
                //get the last name
                UserLastName = UserBook.UserList[Index].UserLastName;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(UserFirstName + "" + UserLastName, UserId.ToString());
                //add the user to the list
                lstUserListBox.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }

  

        protected void btnApply_Click1(object sender, EventArgs e)
        {
            Int32 RecordCount;
            //store the string
            string UserFirstName = txtFilterbyuserfirstname.Text;
            //if the text box is blank
            if (UserFirstName=="")
            {
                //display the error message
                lblError.Text = "Please enter a first name";
            }
            else
            {
                //record the user
                RecordCount = DisplayFilterUserFirstName(txtFilterbyuserfirstname.Text);
                //display how many user have been found
                lblError.Text = RecordCount + "Record Found";
            }
        }
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["UserID"] = -1;
            //redirect to the data entry page
            Response.Redirect("ForumAnUser.aspx");
        }

        protected void btnEdit_Click1(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be editied
            Int32 UserID;
            //if a record has been selected from the list
            if (lstUserListBox.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                UserID = Convert.ToInt32(lstUserListBox.SelectedValue);
                //store the data in the session object
                Session["UserID"] = UserID;
                //redirect to the edit page
                Response.Redirect("ForumAnUser.aspx");
            }
            //if no recod has been selected
            else
            {
                
                //display an error
                lblError.Text = "Please make you select a record from the list";

            }

        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 UserID;
            //if a record has been selected from the list
            if (lstUserListBox.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                UserID = Convert.ToInt32(lstUserListBox.SelectedValue);
                //store the data in the session object
                Session["UserID"] = UserID;
                //redirect to the delete page
                Response.Redirect("ForumUserDelete.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblError.Text = "Please make you select a record from the list";

            }
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            //redirect to log in
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnForumPost_Click(object sender, EventArgs e)
        {
            //redirect to post list
            Response.Redirect("ForumPostList.aspx");
        }
    }
}