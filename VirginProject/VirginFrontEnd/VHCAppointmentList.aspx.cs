using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;


namespace VirginFrontEnd
{
    public partial class VHCAppointmentList : System.Web.UI.Page
    {
        //create an instance of the appointment collection with page level scope
        clsVHCAppointmentCollection AppointmentList;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page has been displayed
            if (IsPostBack == false)
            {
                //initialise the list of appointments for specified date
                AppointmentList = new clsVHCAppointmentCollection(Convert.ToDateTime(txtAppointmentDate.Text));
                //display the appts in the list
                DisplayAppointments();
            }
            else //if this is a re-load of the page
            {
                //read in the already initialised list
                AppointmentList = (clsVHCAppointmentCollection)Session["AppointmentList"];
            }
        }
        void DisplayAppointments()
        {
            //function displays the list of appointments in the list box

            //var to store the appt no if an existing appointment it is the primary key
            //if it is an available appt it is the time prefied with -
            Int32 Appointment_ID;
            //var to store the appt time
            Int32 Appointment_Time;
            //var to store the appt reason
            string Appointment_Description;
            //index for the loop
            Int32 Index = 0;
            //clear the list of any existing entries
            lstAppointment.Items.Clear();
            //loop for processing the appts
            while (Index < AppointmentList.Count)
            {
                //get the appt no
                Appointment_ID = AppointmentList.AppointmentList[Index].Appointment_ID;
                //get the appt time
                Appointment_Time = AppointmentList.AppointmentList[Index].Appointment_Time;
                //get the appt reason
                Appointment_Description = AppointmentList.AppointmentList[Index].Appointment_Description;
                //create the appt entry
                ListItem NewItem = new ListItem("Primary key " + Appointment_ID.ToString() + "Time " + Appointment_Time.ToString() + " " + Appointment_Description, Appointment_ID.ToString());
                //add the appt to the list
                lstAppointment.Items.Add(NewItem);
                //inc the index
                Index++;
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //store the appt list in the session object
            Session["AppointmentList"] = AppointmentList;
        }

        protected void btnAppointmentSearch_Click(object sender, EventArgs e)
        {
            //reinitialise the list of appt with the new date
            AppointmentList = new clsVHCAppointmentCollection(Convert.ToDateTime(txtAppointmentDate.Text));
            //dislay the list of appts
            DisplayAppointments();
        }

        protected void btnAppointmentBook_Click(object sender, EventArgs e)
        {
            //var to store the booking time
            string BookingTime;
            //var to store the booking date
            string BookingDate;
            //clear amu previous errors
            lblError.Text = "";
            //check to see that an entry has been selected
            if (lstAppointment.SelectedIndex != -1)
            {
                //read in the primary key
                BookingTime = lstAppointment.SelectedValue;
                //get the booking date
                BookingDate = txtAppointmentDate.Text;
                //if this is an available appt eg - at the start
                if (BookingTime.Contains("-") == true)
                {
                    //redirect to the make booking page
                    Response.Redirect("MakeBooking.aspx?BookingDate=" + BookingDate + "&BookingTime=" + BookingTime);
                }
                else//otherwise cannot change the appt (at least in this version of the system)
                {
                    lblError.Text = "Cannot change this booking";
                }
            }
            else //show an error if not
            {
                lblError.Text = "You must select an available booking first";
            }
        }
    }
}