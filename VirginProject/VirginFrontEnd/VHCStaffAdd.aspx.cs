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
    
    public partial class VHCStaffAdd : System.Web.UI.Page
    {
        //Declare Staff Primary Key
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

        //function for adding new records
        void Add()
        {
            //create an instance of the staff class
            clsVHCStaffCollection AllStaff = new clsVHCStaffCollection();
            //validate the data on the web form
            String Error = AllStaff.ThisStaff.Valid(txtStaff_Title.Text, txtStaff_Firstname.Text, txtStaff_Lastname.Text, txtStaff_Email.Text, txtStaff_Username.Text, txtStaff_Password.Text, txtStaff_Role.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                AllStaff.ThisStaff.Staff_Title = txtStaff_Title.Text;
                AllStaff.ThisStaff.Staff_Firstname = txtStaff_Firstname.Text;
                AllStaff.ThisStaff.Staff_Lastname = txtStaff_Lastname.Text;
                AllStaff.ThisStaff.Staff_Email = txtStaff_Email.Text;
                AllStaff.ThisStaff.Staff_Username = txtStaff_Username.Text;
                AllStaff.ThisStaff.Staff_Password = txtStaff_Password.Text;
                AllStaff.ThisStaff.Staff_Role = txtStaff_Role.Text;
                AllStaff.ThisStaff.Staff_Status = Convert.ToBoolean(cbStaff_Status.Checked);
                //add the record
                AllStaff.Add();
                //redirect to the main page
                Response.Redirect("VHCStaffList.aspx");
            }

            else
            {
                //report an error
                lblError.Text = "⚠️" + "  " + Error;
            }
        }

        //function for updating new records
        void Update()
        {
            //create an instance of the staff class
            clsVHCStaffCollection AllStaff = new clsVHCStaffCollection();
            //validate the data on the web form
            String Error = AllStaff.ThisStaff.Valid(txtStaff_Title.Text, txtStaff_Firstname.Text, txtStaff_Lastname.Text, txtStaff_Email.Text, txtStaff_Username.Text, txtStaff_Password.Text, txtStaff_Role.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update 
                AllStaff.ThisStaff.Find(Staff_ID);
                //get the data entered by the user 
                AllStaff.ThisStaff.Staff_Title = txtStaff_Title.Text;
                AllStaff.ThisStaff.Staff_Firstname = txtStaff_Firstname.Text;
                AllStaff.ThisStaff.Staff_Lastname = txtStaff_Lastname.Text;
                AllStaff.ThisStaff.Staff_Email = txtStaff_Email.Text;
                AllStaff.ThisStaff.Staff_Username = txtStaff_Username.Text;
                AllStaff.ThisStaff.Staff_Password = txtStaff_Password.Text;
                AllStaff.ThisStaff.Staff_Role = txtStaff_Role.Text;
                AllStaff.ThisStaff.Staff_Status = Convert.ToBoolean(cbStaff_Status.Checked);
                //update the record 
                AllStaff.Update();
                Response.Redirect("VHCStaffList.aspx");
            }

            else
            {
                //report an error
                lblError.Text = "⚠️:" + "  " + Error;
            }
        }

        private void DisplayStaff()
        {
            //create an instance of the staff class
            clsVHCStaffCollection AllStaff = new clsVHCStaffCollection();
            //find the record to update
            AllStaff.ThisStaff.Find(Staff_ID);
            //display the data for this record
            txtStaff_Title.Text = AllStaff.ThisStaff.Staff_Title;
            txtStaff_Firstname.Text = AllStaff.ThisStaff.Staff_Firstname;
            txtStaff_Lastname.Text = AllStaff.ThisStaff.Staff_Lastname;
            txtStaff_Email.Text = AllStaff.ThisStaff.Staff_Email;
            txtStaff_Username.Text = AllStaff.ThisStaff.Staff_Username;
            txtStaff_Password.Text = AllStaff.ThisStaff.Staff_Password;
            txtStaff_Role.Text = AllStaff.ThisStaff.Staff_Role;
            cbStaff_Status.Checked = AllStaff.ThisStaff.Staff_Status;
        }

        //Close Button
        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");
        }

        //Submit Button
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Staff_ID == -1)
            {
                //Add the new record
                Add();
            }

            else
            {
                ////Update the record
                Update();
            }
        }

        
    }

     
}