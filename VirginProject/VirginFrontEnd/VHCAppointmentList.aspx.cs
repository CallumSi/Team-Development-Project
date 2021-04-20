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
  
    public partial class VHCAppointmentList : System.Web.UI.Page
    {
        //create an instance of the appointment collection with page level scope
        clsVHCAppointmentCollection AppointmentList;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page has been displayed
            if (IsPostBack == false)
            {
                //initialise the list of appointments for a specified date
                AppointmentList = new clsVHCAppointmentCollection(Convert.ToDateTime(txtAppointmentDate.Text));
                //display the appointments in the list
                DisplayAppointments();
            }

            //if this is a re-load of the page
            else
            {
                //read in the already initialised list
                AppointmentList = (clsVHCAppointmentCollection)Session["AppointmentList"];
            }
        }
        void DisplayAppointments()
        {
            //function displays the list of appointments in the list box

            //var to store the appointments id if an existing appointment it is the primary key
            //if it is an available appointments it is the time preferred with
            Int32 Appointment_ID;
            //var to store the appointments time
            Int32 Appointment_Time;
            //var to store the appointments description
            string Appointment_Description;
            //index for the loop
            Int32 Index = 0;
            //clear the list of any existing entries
            lstAppointment.Items.Clear();
            //loop for processing the appointments
            while (Index < AppointmentList.Count)
            {
                //get the appointments id
                Appointment_ID = AppointmentList.AppointmentList[Index].Appointment_ID;
                //get the appointments time
                Appointment_Time = AppointmentList.AppointmentList[Index].Appointment_Time;
                //get the appointments description
                Appointment_Description = AppointmentList.AppointmentList[Index].Appointment_Description;
                //create the appointments entry
                ListItem NewItem = new ListItem("Avaliable Booking Time " + " - " + Appointment_Time.ToString() + ":00 " + Appointment_Description, Appointment_ID.ToString());
                //add the appointments to the list
                lstAppointment.Items.Add(NewItem);
                //inc the index
                Index++;
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //store the appointments list in the session object
            Session["AppointmentList"] = AppointmentList;
        }

        protected void btnAppointmentSearch_Click(object sender, EventArgs e)
        {
            //reinitialise the list of appointments with the new date
            AppointmentList = new clsVHCAppointmentCollection(Convert.ToDateTime(txtAppointmentDate.Text));
            //dislay the list of appointments
            DisplayAppointments();
        }

        protected void btnAppointmentBook_Click(object sender, EventArgs e)
        {
            //var to store the booking time
            string BookingTime;
            //var to store the booking date
            string BookingDate;
            //clear any previous errors
            lblError.Text = "";

            //check to see that an entry has been selected
            if (lstAppointment.SelectedIndex != -1)
            {
                //read in the primary key
                BookingTime = lstAppointment.SelectedValue;
                //get the booking date
                BookingDate = txtAppointmentDate.Text;

                //if this is an available appointments eg - at the start
                if (BookingTime.Contains("-") == true)
                {
                    //redirect to the make booking page
                    Response.Redirect("VHCAppointmentBooking.aspx?BookingDate=" + BookingDate + "&BookingTime=" + BookingTime);
                }


                //otherwise cannot change the appointments (at least in this version of the system)
                else
                {
                    lblError.Text = "⚠️ ERROR: CANNOT CHANGE THIS BOOKING!";
                }
            }

            //show an error if not
            else
            {
                lblError.Text = "⚠️ ERROR: PLEASE SELECT AN AVAILABLE BOOKING FIRST!";
            }
        }

        //Close Button
        protected void btnListClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCMainMenu.aspx");
        }
    }
}