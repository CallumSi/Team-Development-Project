﻿using System;
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

    public partial class VHCAppointmentBooking : System.Web.UI.Page
    {
        //variable Patient_ID from session obect
        Int32 Patient_ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            Patient_ID = Convert.ToInt32(Session["Patient_ID"]);

            //vars to store the date and time
            string BookingDate;
            string BookingTime;
            //get the date and time from the query string
            BookingDate = Request.QueryString["BookingDate"];
            BookingTime = Request.QueryString["BookingTime"];
            //display the date
            txtDate.Text = BookingDate;
            //display the time but removing the character
            txtTime.Text = BookingTime.Remove(0, 1);
        }
        
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //get the time
            int Appointment_Time = Convert.ToInt32(txtTime.Text);
            //get the date
            DateTime Appointment_Date = Convert.ToDateTime(txtDate.Text);
            //get the description
            string Appointment_Description = Convert.ToString(txtDescription.Text);
            //create an instance of the appointment collection
            clsVHCAppointmentCollection Appointment = new clsVHCAppointmentCollection(Appointment_Date);
            //add the new appointment
            Appointment.AddBooking(Appointment_Time, Appointment_Description);
            //redirect to the main page
            //store data in session object so we can pass it to next page
            Session["Patient_ID"] = Patient_ID;
            Response.Redirect("VHCAppointmentList.aspx");
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["Patient_ID"] = Patient_ID;
            //redirect to the main page
            Response.Redirect("VHCAppointmentList.aspx");

        }
    }
}