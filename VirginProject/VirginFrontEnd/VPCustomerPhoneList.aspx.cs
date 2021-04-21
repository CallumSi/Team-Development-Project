using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPCustomerPhoneList : System.Web.UI.Page
    {
        Int32 PhoneID;
        Int32 Customer_ID;
        clsVPCart MyCart = new clsVPCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            MyCart = (clsVPCart)Session["MyCart"];
            if (MyCart == null)
            {
                MyCart = new clsVPCart();
            }

            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
            //then you can display how many phones are in the cart
            lblCartCount.Text = MyCart.Products.Count.ToString();
            if (IsPostBack == false)
            {
                //update the listbox
                DisplayPhones();
            }
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //you must also save the cart everytime the unload event takes place
            Session["MyCart"] = MyCart;
        }

        void DisplayPhones()
        {
            //create an instance of the phone collection class
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            lstPhones.DataSource = AllPhone.PhoneList;
            //set the primary key
            lstPhones.DataValueField = "PhoneID";

            //bind the data 
            lstPhones.DataTextField = "Make";
            lstPhones.DataBind();
        }

        protected void btnViewPhone_Click(object sender, EventArgs e)
        {
            //var to store the primary value of the record to be edited
            Int32 PhoneID;
            //if a record has been selected from the list 
            if (lstPhones.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                PhoneID = Convert.ToInt32(lstPhones.SelectedValue);
                //store the data in the session object 
                Session["PhoneID"] = PhoneID;
                //redirect to the edit page
                Response.Redirect("VPPhoneViewer.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error
                lblError.Text = "Please selected a phone from the list to view";
            }
                

            }

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            //display all phones
            DisplayPhoneMake(txtFilterPhoneMake.Text);
        }

        Int32 DisplayPhoneMake (string FilterMake)
        {
            Int32 PhoneID;
            string Make;
            //create an instance of the phone collection class
            clsVPPhoneCollection PhoneMake = new clsVPPhoneCollection();
            //invoke the make filter
            PhoneMake.FilterByMake(FilterMake);
            //var to store the count record
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count record
            RecordCount = PhoneMake.Count;
            //clear the list box
            lstPhones.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key 
                PhoneID = PhoneMake.PhoneList[Index].PhoneID;
                //get the model
                Make = PhoneMake.PhoneList[Index].Make;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Make + " ", PhoneID.ToString());
                //add the phone to the list
                lstPhones.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            return RecordCount;
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayPhones();
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store the sesssion object so we can pass it to the next page 
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("VPViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            ////store the sesssion object so we can pass it to the next page
            Session["Customer_ID"] = Customer_ID;
            Response.Redirect("AnVPEditCustomer.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }
    }

}
