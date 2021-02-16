using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayUser();
            }
        }

        

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            FilterUser(txtEmail.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            FilterUser("");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["UserID"] = -1;
            //redirect to user data entry page
            Response.Redirect("AnMarketplaceUser.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to edit
            Int32 UserID;
            //check if a record has been selected from the list
            if (lstMarketplaceUser.SelectedIndex != -1)
            { 
                //get primary key from selected
                UserID = Convert.ToInt32(lstMarketplaceUser.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["UserID"] = UserID;
                //redirect to edit user details page
                Response.Redirect("AnMarketplaceUser.aspx");

            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error 
                lblError.Text = "Please select a record to edit from the list ";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to delete
            Int32 UserID;
            //check if a record has been selected from the list
            if (lstMarketplaceUser.SelectedIndex != -1)
            {
                //get primary key from selected
                UserID = Convert.ToInt32(lstMarketplaceUser.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["UserID"] = UserID;
                //redirect to delete page
                Response.Redirect("MarketplaceUserDelete.aspx");

            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error 
                lblError.Text = "Please select a record to delete from the list ";
            }
        }

        void DisplayUser()
        {
            //create an instance of the use collection
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            lstMarketplaceUser.DataSource = Users.UserList;
            //set name of primary key
            lstMarketplaceUser.DataValueField = "UserID";
            //bind data
            lstMarketplaceUser.DataTextField = "Email";
            lstMarketplaceUser.DataBind();
        }


        Int32 FilterUser(string EmailFilter)
        {
            //declare variables
            Int32 UserID;
            string Email;
            //create instance of collection class
            clsMarketplaceUserCollection ListOfUsers = new clsMarketplaceUserCollection();
            ListOfUsers.FilterByEmail(EmailFilter);
            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            //get count of filtered list
            RecordCount = ListOfUsers.Count;
            //clear the list box
            lstMarketplaceUser.Items.Clear();
            //loop through the list adding them to the list box
            while (Index < RecordCount)
            {
                UserID = ListOfUsers.UserList[Index].UserID;
                Email = ListOfUsers.UserList[Index].Email;
                ListItem NewUser = new ListItem(Email + "", UserID.ToString());
                lstMarketplaceUser.Items.Add(NewUser);
                Index++;
            }
            return RecordCount;

        }
    }
}