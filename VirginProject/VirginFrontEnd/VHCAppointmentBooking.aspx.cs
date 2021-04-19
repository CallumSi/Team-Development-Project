using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VHCAppointmentBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //vars to store the date and time
            string BookingDate;
            string BookingTime;
            //get the date and time from the quety string
            BookingDate = Request.QueryString["BookingDate"];
            BookingTime = Request.QueryString["BookingTime"];
            //display the date
            txtDate.Text = BookingDate;
            //display the taime but removeing the - character
            txtTime.Text = BookingTime.Remove(0, 1);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("VHCAppointmentList.aspx");
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //get the time
            int Appointment_Time = Convert.ToInt32(txtTime.Text);
            //get the date
            DateTime Appointment_Date = Convert.ToDateTime(txtDate.Text);
            //get the reason
            string Appointment_Description = Convert.ToString(txtReason.Text);
            //create an instance of the appointment collection
            clsVHCAppointmentCollection Appointment = new clsVHCAppointmentCollection(Appointment_Date);
            //add the new appt
            Appointment.AddBooking(Appointment_Time, Appointment_Description);
            //redirect to the main page
            Response.Redirect("VHCAppointmentList.aspx");
        }
    }
}