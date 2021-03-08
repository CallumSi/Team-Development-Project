using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayUser();
            }

        }
        void DisplayUser()
        {
            //create an instance of the County Collection
            clsForumUserCollection Users = new clsForumUserCollection();
            //set the data source to the list of countries in the collection
            lstUserListBox.DataSource = Users.UserList;
            //set the name of the primary key
            lstUserListBox.DataValueField = "UserID";
            //set the data field to display
            lstUserListBox.DataTextField = "Userusername";
            //bind the data to the list
            lstUserListBox.DataBind();
        }

        Int32 DisplayFilterUserusername(string UserusernameFilter)
        {
            //int to store the primary key
            Int32 UserId;
            //string username 
            string Userusername;
            //string firstname
            string UserFirstName;
            //string last name
            string UserLastName;
            //create an instance of the user collection class
            clsForumUserCollection UserBook = new clsForumUserCollection();
            UserBook.ReportByUserusername(UserusernameFilter);
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
                //get the username 
                Userusername = UserBook.UserList[Index].Userusername;
                //get the first name
                UserFirstName = UserBook.UserList[Index].UserFirstName;
                //get the last name
                UserLastName = UserBook.UserList[Index].UserLastName;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Userusername + "" + UserFirstName + "" + UserLastName, UserId.ToString());
                //add the user to the list
                lstUserListBox.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayUser();
        }

        protected void btnApply_Click1(object sender, EventArgs e)
        {
            //display only usernames
            DisplayFilterUserusername(txtFilterbyusername.Text);
        }

        protected void btnDisplayAll_Click1(object sender, EventArgs e)
        {
            //display all username
            DisplayUser();
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
    }
}