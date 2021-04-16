using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPPhoneList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //the first time the page is displayed 
            if (IsPostBack == false)
            {
                //update the list box
                DisplayVPPhone();
            }
        }


        void DisplayVPPhone()
        {
            //create an instance of the staff collection 
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            //set the data source to the staff in staff collection 
            lstPhone.DataSource = AllPhone.PhoneList;
            //set the same of the primary key
            lstPhone.DataValueField = "PhoneID";
            //set the data field to display
            lstPhone.DataTextField = "Make";
            //bind the data to the list
            lstPhone.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["PhoneID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnPhone.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 PhoneID;
            //if the record has been selected from the list 
            if (lstPhone.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                PhoneID = Convert.ToInt32(lstPhone.SelectedValue);
                //store the data in the session object 
                Session["PhoneID"] = PhoneID;
                //redirect to the delete page 
                Response.Redirect("VPPhoneDelete.aspx");
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
            Int32 PhoneID;
            //if the record has been selected from the list 
            if (lstPhone.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                PhoneID = Convert.ToInt32(lstPhone.SelectedValue);
                //store the data in the session object 
                Session["PhoneID"] = PhoneID;
                //redirect to the delete page 
                Response.Redirect("AnPhone.aspx");
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
            //display the filtered search by make
            DisplayMake(txtSearchPhone.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all the phones
            DisplayMake("");
        }

        Int32 DisplayMake(string VPPhoneFilter)
        {
            Int32 PhoneID;
            string Make; //this one is declared in the collections and tests
            //create an instance of the staff collection
            clsVPPhoneCollection PhoneMake = new clsVPPhoneCollection();
            //invoke the phone make filter
            PhoneMake.FilterByMake(VPPhoneFilter);
            //var to store the count of record
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count record
            RecordCount = PhoneMake.Count;
            //clear the list box
            lstPhone.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key 
                PhoneID = PhoneMake.PhoneList[Index].PhoneID;
                //get the first name
                Make = PhoneMake.PhoneList[Index].Make;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Make + "", PhoneID.ToString());
                //add the phone to the list
                lstPhone.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            return RecordCount;
        }





    }
}