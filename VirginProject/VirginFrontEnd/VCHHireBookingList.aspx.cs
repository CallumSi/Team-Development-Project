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
        Int32 AdminID;

        //create an instance of the hire booking collection with page level scope
        clsVCHHireBookingCollection HireBookingList;

        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be processed
            StaffID = Convert.ToInt32(Session["StaffID"]);
            AdminID = Convert.ToInt32(Session["AdminID"]);
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //initialise hire booking list for specific dates
                HireBookingList = new clsVCHHireBookingCollection(Convert.ToDateTime(txtHireDate.Text));

                //display the Hire Bookings in the list
                DisplayHireBookings();
            }
            //if the page has been reloaded 
            else
            {
                //read in the already initialised list
                HireBookingList = (clsVCHHireBookingCollection)Session["HireBookingList"];
            }
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
            Session["HireBookingList"] = HireBookingList;
            Session["HireDate"] = txtHireDate.Text;
        }

        void DisplayHireBookings()
        {
            //into to store the primary key
            Int32 HireBookingID;
            //property for HireTime
            Int32 HireTime;
            //property for HireDescription
            string HireDescription;
            //index for the loop
            Int32 Index = 0;
            //clear the list of any existing entries
            lstHireBookings.Items.Clear();
            //loop for processing the appointments
            while (Index < HireBookingList.Count)
            {
                //retrieve HireBookingID
                HireBookingID = HireBookingList.HireBookingList[Index].HireBookingID;
                //retrieve HireTime 
                HireTime = HireBookingList.HireBookingList[Index].HireTime;
                //retrieve HireDescription
                HireDescription = HireBookingList.HireBookingList[Index].HireDescription;
                //create the hire booking entry
                ListItem NewItem = new ListItem("Hire Time - " + HireTime.ToString() + ":00 " + HireDescription, HireBookingID.ToString());
                //add the hire bookings to the list
                lstHireBookings.Items.Add(NewItem);
                //inc the index
                Index++;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //initialise hire booking list for specific dates
                HireBookingList = new clsVCHHireBookingCollection(Convert.ToDateTime(txtHireDate.Text));
                //display the hire booking list
                DisplayHireBookings();
            }
            catch
            {
                lblError.Text = "Enter a valid date.";
            }
            if (txtHireDate.Text.Length == 0)
            {
                lblError.Text = "The date value may not be blank, please enter a valid date..";
            }
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            //var to store the hire booking time
            string HireBookingTime;
            //var to store the hire booking date
            string HireBookingDate;
            //restore lblError to blank [lblError]
            lblError.Text = "";

            //check to see that an entry has been selected
            if (lstHireBookings.SelectedIndex != -1)
            {
                //read in the primary key
                HireBookingTime = lstHireBookings.SelectedValue;
                //retrieve Hire Date 
                HireBookingDate = txtHireDate.Text;

                //if this is an available hire booking
                if (HireBookingTime.Contains("-") == true)
                {
                    //Save the StaffID when a page unload event happens
                    Session["StaffID"] = StaffID;
                    Session["HireBookingList"] = HireBookingList;
                    //redirect to the make booking page
                    Response.Redirect("VCHAHireBooking.aspx?HireBookingDate" + HireBookingDate + "&HireBookingTime=" + HireBookingTime);
                }


                //otherwise cannot change the hire bookings (at least in this version of the system)
                else
                {
                    lblError.Text = "This hire booking may not be modified";
                }
            }

            //show an error if not
            else
            {
                lblError.Text = "Select an available booking to proceed.";
            }
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

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff home page
            Response.Redirect("VCHHireBookingList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //direct me to the log in page
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}