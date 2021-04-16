using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AnVMStaff : System.Web.UI.Page
    {
        Int32 VMStaffID;
        protected void Page_Load(object sender, EventArgs e)
        {

            //get the number of Customers to be processed
            VMStaffID = Convert.ToInt32(Session["VMStaffID"]);
            if (IsPostBack == false)
            {
                //populate the list of Customers
                DisplayVMStaff();
                //if this is not a new record
                if (VMStaffID !=-1)
                {
                    //display the current data for the record
                    DisplayVMStaff();
                }
            }
        }
        void DisplayVMStaff()
        {
            //create an instance of the customer class
            clsVMStaffCollection AllStaff = new clsVMStaffCollection();
            //find the record to update
            AllStaff.ThisStaff.Find(VMStaffID);
            //display the data for this record
            txtVMStaffFirstname.Text = AllStaff.ThisStaff.VMstaffFirstName;
            txtVMStaffLastname.Text = AllStaff.ThisStaff.VMstaffLastName;
            txtVMStaffEmail.Text = AllStaff.ThisStaff.VMstaffEmail;
            txtVMStaffPassword.Text = AllStaff.ThisStaff.VMstaffPassword;
            txtVMStaffPosition.Text = AllStaff.ThisStaff.VMstaffPosition;
        }

        protected void btnOkay_Click(object sender, EventArgs e)
        {
            if (VMStaffID == -1)
            {
                //add the new record
                Add();

            }
            else
            {
                //update the record
                Update();
            }

            //function for adding new records
            void Add()
            {
                //create an instance of the staff class
                clsVMStaffCollection AllStaff = new clsVMStaffCollection();
                //validate the data on the web form
                String Error = AllStaff.ThisStaff.Valid(txtVMStaffFirstname.Text, txtVMStaffLastname.Text, txtVMStaffEmail.Text, txtVMStaffPassword.Text, txtVMStaffPosition.Text);
                //if the data is OK then add it to the object
                if (Error == "")
                {
                    AllStaff.ThisStaff.VMstaffFirstName = txtVMStaffFirstname.Text;
                    AllStaff.ThisStaff.VMstaffLastName = txtVMStaffLastname.Text;
                    AllStaff.ThisStaff.VMstaffEmail = txtVMStaffEmail.Text;
                    AllStaff.ThisStaff.VMstaffPassword = txtVMStaffPassword.Text;
                    AllStaff.ThisStaff.VMstaffPosition = txtVMStaffPosition.Text;

                    //add the record
                    AllStaff.Add();
                    //redirect to the main page
                    Response.Redirect("VMStaffList.aspx");
                }
                else
                {
                    //report an error
                    lblError.Text = "There were problems with the data entered: " + Error;
                }
            }

            //function for Updating records
            void Update()
            {
                //create an instance of the staff class
                clsVMStaffCollection AllStaff = new clsVMStaffCollection();
                //validate the data on the web form
                String Error = AllStaff.ThisStaff.Valid(txtVMStaffFirstname.Text, txtVMStaffLastname.Text, txtVMStaffEmail.Text, txtVMStaffPassword.Text, txtVMStaffPosition.Text);
                //if the data is OK then add it to the object
                if (Error == "")
                {
                    //find the record to update
                    AllStaff.ThisStaff.Find(VMStaffID);
                    //get the data entered by the user
                    AllStaff.ThisStaff.VMstaffFirstName = txtVMStaffFirstname.Text;
                    AllStaff.ThisStaff.VMstaffLastName = txtVMStaffLastname.Text;
                    AllStaff.ThisStaff.VMstaffEmail = txtVMStaffEmail.Text;
                    AllStaff.ThisStaff.VMstaffPassword = txtVMStaffPassword.Text;
                    AllStaff.ThisStaff.VMstaffPosition = txtVMStaffPosition.Text;

                    //add the record
                    AllStaff.Update();
                    //redirect to the main page
                    Response.Redirect("VMStaffList.aspx");
                }
                else
                {
                    //report an error
                    lblError.Text = "There were problems with the data entered: " + Error;
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect to the staff list
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect to the customer list
            Response.Redirect("VMCustomerList.aspx");

        }

        protected void btnStaffMovie_Click(object sender, EventArgs e)
        {
            //redirect to the staff movie list
            Response.Redirect("VMStaffMovie.aspx");

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to the login page
            Response.Redirect("VirginLogin.aspx");

        }

        protected void btnVMStaffList_Click(object sender, EventArgs e)
        {
            //redirect to the staff list
            Response.Redirect("VMStaffList.aspx");
        }
    }
}