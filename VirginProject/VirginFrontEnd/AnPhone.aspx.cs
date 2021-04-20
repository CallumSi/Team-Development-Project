using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AnPhone : System.Web.UI.Page
    {
        //declare the primary key 
        Int32 PhoneID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of phone to be processed
            PhoneID = Convert.ToInt32(Session["PhoneID"]);
            if (IsPostBack == false)
            {
                //populate the list of phone
                DisplayPhone();
                //if this is not a new record
                if (PhoneID != -1)
                {
                    //display the current data for the record
                    DisplayPhone();
                }

            }
        }

        void DisplayPhone()
        {
            //create an instance of the phone class
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //find the record to update 
            AllPhone.ThisPhone.Find(PhoneID);
            //display the data for this record
            txtCapacity.Text = AllPhone.ThisPhone.Capacity;
            txtColour.Text = AllPhone.ThisPhone.Colour;
            txtDescription.Text = AllPhone.ThisPhone.Description;
            txtMake.Text = AllPhone.ThisPhone.Make;
            txtModel.Text = AllPhone.ThisPhone.Model;
            txtPrice.Text = AllPhone.ThisPhone.Price.ToString();
            chkStockStatus.Checked = AllPhone.ThisPhone.StockStatus;
            ddlQuantity.Text = AllPhone.ThisPhone.Quantity.ToString();
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the staff list
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //validate the data on the web form
            string Error = AllPhone.ThisPhone.Valid(txtCapacity.Text, txtColour.Text, txtDescription.Text, txtMake.Text, txtModel.Text, txtPrice.Text, ddlQuantity.SelectedValue.ToString());
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user 
                AllPhone.ThisPhone.Capacity = txtCapacity.Text;
                AllPhone.ThisPhone.Colour = txtColour.Text;
                AllPhone.ThisPhone.Description = txtDescription.Text;
                AllPhone.ThisPhone.Make = txtMake.Text;
                AllPhone.ThisPhone.Model = txtModel.Text;
                AllPhone.ThisPhone.Price = Convert.ToDecimal(txtPrice.Text);
                AllPhone.ThisPhone.StockStatus = Convert.ToBoolean(chkStockStatus.Checked);
                AllPhone.ThisPhone.Quantity = Convert.ToInt32(ddlQuantity.SelectedValue.ToString());
                //add the record
                AllPhone.Add();
                //redirect back to the main page
                Response.Redirect("VPPhoneList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered, please try again" + Error;
            }

        }



        protected void btnOK_Click(object sender, EventArgs e)

        {
            if (PhoneID == -1)
            {
                //add the record
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
            //create an instance of the phone 
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //validate the data on the web form 
            String Error = AllPhone.ThisPhone.Valid(txtCapacity.Text, txtColour.Text, txtDescription.Text, txtMake.Text, txtModel.Text, txtPrice.Text, ddlQuantity.SelectedValue.ToString());
            //if the data is ok then add it to the object 
            if (Error == "")
            {
                //find the record to update 
                AllPhone.ThisPhone.Find(PhoneID);
                //get the data entered by the user 
                AllPhone.ThisPhone.Capacity = txtCapacity.Text;
                AllPhone.ThisPhone.Colour = txtColour.Text;
                AllPhone.ThisPhone.Description = txtDescription.Text;
                AllPhone.ThisPhone.Make = txtMake.Text;
                AllPhone.ThisPhone.Model = txtModel.Text;
                AllPhone.ThisPhone.Price = Convert.ToDecimal(txtPrice.Text);
                AllPhone.ThisPhone.StockStatus = Convert.ToBoolean(chkStockStatus.Checked);
                AllPhone.ThisPhone.Quantity = Convert.ToInt32(ddlQuantity.SelectedValue.ToString());
                //update the record
                AllPhone.Update();
                //all done so redirect back to the main page
                Response.Redirect("VPPhoneList.aspx");
            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with data entered" + Error;
            }
            
        }
        
        protected void chkStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VPStaffList.aspx");
        }
        
        protected void btnViewCustomer_Click(object sender, EventArgs e)
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

        protected void btnViewStaffList_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VPStaff.aspx");
        }

        protected void btnViewCustomerList_Click(object sender, EventArgs e)
        {

        }
    }
}