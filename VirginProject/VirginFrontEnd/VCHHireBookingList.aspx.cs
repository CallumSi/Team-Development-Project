using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHHireBookingList : System.Web.UI.Page
    {
        //variable to store the primary keywith page level scope
        Int32 StaffID;
        Int32 HireBookingID;

        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff/admin to be processed
            StaffID = Convert.ToInt32(Session["StaffID"]);
            HireBookingID = Convert.ToInt32(Session["HireBookingID"]);

            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayBookings();
            }
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
        }

        void DisplayBookings()
        {
            //int to store the primary key
            Int32 HireBookingID;
            //property for HireID - FK
            Int32 HireID;
            //property for HireDate
            DateTime HireDate;

            //create an instance of the car hire booking collection class
            clsVCHHireBookingCollection HireBookingCollection = new clsVCHHireBookingCollection();
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = HireBookingCollection.Count;
            //clear the list box
            lstBookings.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve HireBookingID
                HireBookingID = HireBookingCollection.HireBookingList[Index].HireBookingID;
                //retrieve HireID
                HireID = HireBookingCollection.HireBookingList[Index].HireID;
                //retrieve HireDate
                HireDate = HireBookingCollection.HireBookingList[Index].HireDate;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Booking ID -  " + HireBookingID + "  |  Hire ID -  " + HireID + " |  Hire Date  -  " + HireDate, HireBookingID.ToString());
                //add the user to the list
                lstBookings.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
        }

        /*protected void btnApply_Click(object sender, EventArgs e)
        {
            DisplayFilterHireDate(txtBxSearch.Text);
        }

        Int32 DisplayFilterHireDate(string HireDateFilter)
        {
            //int to store the primary key
            Int32 HireBookingID;
            //property for HireID - FK
            Int32 HireID;
            //property for HireDate
            DateTime HireDate;

            //create an instance of the car hire booking collection class
            clsVCHHireBookingCollection HireBookingCollection = new clsVCHHireBookingCollection();
            HireBookingCollection.ReportByHireDate(HireDateFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = HireBookingCollection.Count;
            //clear the list box
            lstBookings.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve HireBookingID
                HireBookingID = HireBookingCollection.HireBookingList[Index].HireBookingID;
                //retrieve HireID
                HireID = HireBookingCollection.HireBookingList[Index].HireID;
                //retrieve HireDate
                HireDate = HireBookingCollection.HireBookingList[Index].HireDate;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Booking ID -  " + HireBookingID + "  |  Hire ID -  " + HireID + " |  Hire Date  -  " + HireDate, HireBookingID.ToString());
                //add the user to the list
                lstBookings.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }*/

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //store -1 into the session object to indicate this is a new record
            Session["HireBookingID"] = -1;
            //redirect the user back to the hire booking add page
            Response.Redirect("VCHAHireBooking.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //var to store the primary key value
            Int32 HireBookingID;
            //if a record has been selected from the list
            if (lstBookings.SelectedIndex != -1)
            {
                //retrieve intended edit records primary key
                HireBookingID = Convert.ToInt32(lstBookings.SelectedValue);
                //store the data in the session object
                Session["HireBookingID"] = HireBookingID;
                //redirect the user back to the hire booking edit page
                Response.Redirect("VCHAHireBooking.aspx");
            }
            else //if a user has not selected a car hire record to edit
            {
                //display an error
                lblError.Text = "Please select a booking record to edit from the list";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnBookHire_Click(object sender, EventArgs e)
        {

        }


        protected void btnStaff_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff list page
            Response.Redirect("VCHStaffList.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the customer list page
            Response.Redirect("VCHCustomerList.aspx");
        }

        protected void btnCar_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the car list page
            Response.Redirect("VCHCarList.aspx");
        }

        protected void btnHire_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the car hire list page
            Response.Redirect("VCHHireList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff home page
            Response.Redirect("VCHStaffDefault.aspx");
        }
    }
}