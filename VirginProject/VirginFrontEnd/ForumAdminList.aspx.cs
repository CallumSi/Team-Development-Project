using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAdminList : System.Web.UI.Page
    {
        //declare admin id
        Int32 AdminID;
        //declare orginial id
        Int32 OriginalID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the admin id to be processed
            AdminID = Convert.ToInt32(Session["AdminID "]);
            //get the orginial id to be processed
            OriginalID = Convert.ToInt32(Session["OriginalID"]);

            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayAdmin();
            }
            
        }
        void DisplayAdmin()
        {
            //create an instance of the admin Collection
            clsForumAdminCollection Admins = new clsForumAdminCollection();
            //set the data source to the list of admins in the collection
            lstForumAdmin.DataSource = Admins.AdminList;
            //set the name of the primary key
            lstForumAdmin.DataValueField = "AdminID";
            //set the data field to display
            lstForumAdmin.DataTextField = "AdminFirstName";
            //bind the data to the list
            lstForumAdmin.DataBind();
            //clear the list box
            lstForumAdmin.Items.Clear();
        }

        protected void lstForumAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["AdminID"] = -1;
            //redirect to the data entry page
            Response.Redirect("ForumAnAdmin.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 AdminID;
            //if a record has been selected from the list
            if (lstForumAdmin.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                AdminID = Convert.ToInt32(lstForumAdmin.SelectedValue);
                //store the data in the session object
                Session["AdminID"] = AdminID;
                //redirect to the delete page
                Response.Redirect("ForumAdminDelete.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete.";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be editied
            Int32 AdminID;
            //if a record has been selected from the list
            if (lstForumAdmin.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                AdminID = Convert.ToInt32(lstForumAdmin.SelectedValue);
                //store the data in the session object
                Session["AdminID"] = AdminID;
                //redirect to the edit page
                Response.Redirect("ForumAnAdmin.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblError.Text = "Please make you select a record from the list";

            }
        }


        protected void btnApply_Click1(object sender, EventArgs e)
        {
            //display only usernames
            DisplayFilterAdminFirstName(txtFilterFirstName.Text);
        }

  
        Int32 DisplayFilterAdminFirstName(string AdminfirstName)
        {
            //int to store the primary key
            Int32 AdminID;
            //string firstname
            string AdminFirstName;
            //string last name
            string AdminLastName;
            //create an instance of the user collection class
            clsForumAdminCollection AdminBook = new clsForumAdminCollection();
            AdminBook.ReportByAdminFirstName(AdminfirstName);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = AdminBook.Count;
            //clear the list box
            lstForumAdmin.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the User id
                AdminID = AdminBook.AdminList[Index].AdminID;
                //get the first name
                AdminFirstName = AdminBook.AdminList[Index].AdminFirstName;
                //get the last name
                AdminLastName = AdminBook.AdminList[Index].AdminLastName;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem( AdminFirstName + "" + AdminLastName, AdminID.ToString());
                //add the user to the list
                lstForumAdmin.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }

        protected void btnAdminHome_Click(object sender, EventArgs e)
        {
            //redirect to home page
            Response.Redirect("ForumAdminHomePage.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //redirect to log in
            Response.Redirect("ForumAdminLogIn.aspx");
        }
    }
}