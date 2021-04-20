using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPStaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //the first time the page is displayed 
            if (IsPostBack == false)
            {

            }
        }

        void DisplayVPStaff()
        {
            //create an instance of the staff collection 
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //set the data source to the staff in staff collection 
            lstStaff.DataSource = AllStaff.StaffList;
            //set the same of the primary key
            lstStaff.DataValueField = "Staff_ID";
            //set the data field to display
            lstStaff.DataTextField = "Staff_FirstName";
            //bind the data to the list
            lstStaff.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["Staff_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnVPStaff.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Staff_ID;
            //if the record has been selected from the list 
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Staff_ID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object 
                Session["Staff_ID"] = Staff_ID;
                //redirect to the delete page 
                Response.Redirect("VPStaffDelete.aspx");
            }
            else
            {
                //if no record has been selected 
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Staff_ID;
            //if the record has been selected from the list 
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Staff_ID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object 
                Session["Staff_ID"] = Staff_ID;
                //redirect to the delete page 
                Response.Redirect("AnVPStaff.aspx");
            }
            else
            {
                //if no record has been selected 
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }



        protected void btnApply_Click(object sender, EventArgs e)
        {
            string Filter = txtSearchFirstName.Text;
            if (Filter == "")
            {
                lblError.Text = "Please enter Staff Firstname ";
            }
            else
            {
                //display all Customer usernames
                DisplayFirstName(txtSearchFirstName.Text);
            }
        }


            Int32 DisplayFirstName(string VPStaffFilter)
            {
                Int32 Staff_ID;
                string Staff_FirstName; //this one is declared in the collections and tests
                                        //create an instance of the staff collection
                clsVPStaffCollection StaffFirstName = new clsVPStaffCollection();
                //invoke the staff first name filter
                StaffFirstName.FilterByStaffFirstName(VPStaffFilter);
                //var to store the count of record
                Int32 RecordCount;
                //var to store the index for the loop
                Int32 Index = 0;
                //get the count record
                RecordCount = StaffFirstName.Count;
                //clear the list box
                lstStaff.Items.Clear();
                //while there are records to process
                while (Index < RecordCount)
                {
                    //get the primary key 
                    Staff_ID = StaffFirstName.StaffList[Index].Staff_ID;
                    //get the first name
                    Staff_FirstName = StaffFirstName.StaffList[Index].Staff_FirstName;
                    //create a new entry for the list box
                    ListItem NewEntry = new ListItem(Staff_FirstName + "", Staff_ID.ToString());
                    //add the staff to the list
                    lstStaff.Items.Add(NewEntry);
                    //move the index to the next record
                    Index++;
                }
                return RecordCount;
            }

            protected void btnHome_Click(object sender, EventArgs e)
            {
                //redirect to staff list
                Response.Redirect("VPStaffList.aspx");
            }

            protected void btnCustomerList_Click(object sender, EventArgs e)
            {
                //redirect to customer list
                Response.Redirect("VPCustomerList.aspx");
            }

            protected void btnPhoneList_Click(object sender, EventArgs e)
            {
                //redirect to customer list
                Response.Redirect("VPPhoneList.aspx");
            }

            protected void btnLogOut_Click(object sender, EventArgs e)
            {
                //redirect to log out page
                Response.Redirect("VirginLogin.aspx");
            }
        }
    }