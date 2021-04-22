using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    ///This page uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    public partial class AnVPStaff : System.Web.UI.Page
    {
        Int32 Staff_ID;
        protected void Page_Load(object sender, EventArgs e)
        {

            //get the number of staff to be processed
            Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of staff
                DisplayStaff();
                //if this is not a new record
                if (Staff_ID != -1) 
                {
                    //display the current data for the record
                    DisplayStaff();
                }
                    
            }
        }

        void DisplayStaff()
        {
            //create an instance of the staff class
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //find the record to update
            AllStaff.ThisStaff.Find(Staff_ID);
            //display the data for this record
            txtStaffFirstName.Text = AllStaff.ThisStaff.Staff_FirstName;
            txtStaffLastName.Text = AllStaff.ThisStaff.Staff_LastName;
            txtStaffStreet.Text = AllStaff.ThisStaff.Staff_Street;
            txtStaffAddress.Text = AllStaff.ThisStaff.Staff_Address;
            txtStaffPostcode.Text = AllStaff.ThisStaff.Staff_Postcode;
            txtStaffEmail.Text = AllStaff.ThisStaff.Staff_Email;
            txtStaffTelephone.Text = AllStaff.ThisStaff.Staff_Telephone;
        }


        //function for adding new records
        void Add()
        {
            //create an instance of the staff list
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //validate the data on the web form
            string Error = AllStaff.ThisStaff.Valid(txtStaffFirstName.Text, txtStaffLastName.Text, txtStaffStreet.Text, txtStaffAddress.Text, txtStaffPostcode.Text, txtStaffEmail.Text, txtStaffTelephone.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user 
                AllStaff.ThisStaff.Staff_FirstName = txtStaffFirstName.Text;
                AllStaff.ThisStaff.Staff_LastName = txtStaffLastName.Text;
                AllStaff.ThisStaff.Staff_Street = txtStaffStreet.Text;
                AllStaff.ThisStaff.Staff_Address = txtStaffAddress.Text;
                AllStaff.ThisStaff.Staff_Postcode = txtStaffPostcode.Text;
                AllStaff.ThisStaff.Staff_Email = txtStaffEmail.Text;
                AllStaff.ThisStaff.Staff_Telephone = txtStaffTelephone.Text;
                //add the record
                AllStaff.Add();
                //redirect back to the main page
                Response.Redirect("VPStaffList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered, please try again" + Error;
            }

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (Staff_ID == -1)
            {
                //add a new record
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
            //create an instance of the staff 
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //validate the data on the web form 
            String Error = AllStaff.ThisStaff.Valid(txtStaffFirstName.Text, txtStaffLastName.Text, txtStaffStreet.Text, txtStaffAddress.Text, txtStaffPostcode.Text, txtStaffEmail.Text, txtStaffTelephone.Text);
            //if the data is ok then add it to the object 
            if (Error == "")
            {
                //find the record to update 
                AllStaff.ThisStaff.Find(Staff_ID);
                //get the data entered by the user 
                AllStaff.ThisStaff.Staff_FirstName = txtStaffFirstName.Text;
                AllStaff.ThisStaff.Staff_LastName = txtStaffLastName.Text;
                AllStaff.ThisStaff.Staff_Street = txtStaffStreet.Text;
                AllStaff.ThisStaff.Staff_Address = txtStaffAddress.Text;
                AllStaff.ThisStaff.Staff_Postcode = txtStaffPostcode.Text;
                AllStaff.ThisStaff.Staff_Email = txtStaffEmail.Text;
                AllStaff.ThisStaff.Staff_Telephone = txtStaffTelephone.Text;
                //update the record
                AllStaff.Update();
                //all done so redirect back to the main page
                Response.Redirect("VPStaffList.aspx");
            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with data entered" + Error;
            }

            

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnViewStaffList_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnViewCustomerList_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnViewPhoneList_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VirginLogin.aspx");
        }
    }
}