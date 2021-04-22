using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHHireList : System.Web.UI.Page
    {
        //variable to store the primary keywith page level scope
        Int32 StaffID;
        Int32 HireBookingID;

        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff/admin to be processed
            StaffID = Convert.ToInt32(Session["StaffID"]);

            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayHires();
            }
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
        }

        void DisplayHires()
        {
            //int to store the primary key
            Int32 HireID;
            //property for CarID - FK
            Int32 CarID;
            //property for CustomerID - FK
            Int32 CustomerID;
            //property for HireLocation
            string HireLocation;
            //property for HireCollectionDate
            DateTime HireCollectionDate;
            //property for HireReturnDate
            DateTime HireReturnDate;
            //property for HireStatus
            string HireStatus;

            //create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = HireCollection.Count;
            //clear the list box
            lstHires.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve HireID
                HireID = HireCollection.HireList[Index].HireID;
                //retrieve CarID
                CarID = HireCollection.HireList[Index].CarID;
                //retrieve CustomerID
                CustomerID = HireCollection.HireList[Index].CustomerID;
                //retrieve HireLocation
                HireLocation = HireCollection.HireList[Index].HireLocation;
                //retrieve HireCollectionDate
                HireCollectionDate = HireCollection.HireList[Index].HireCollectionDate;
                //retrieve HireReturnDate
                HireReturnDate = HireCollection.HireList[Index].HireReturnDate;
                //retrieve HireStatus
                HireStatus = HireCollection.HireList[Index].HireStatus;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Hire ID -  " + HireID + "  |  Car ID -  " + CarID + " |  Customer ID -  " + CustomerID + "  | Hire Location -  " + HireLocation + " |  Car Collection -  " + HireCollectionDate + "  | Car Return -  " + HireReturnDate + "  | Hire Status -  " + HireStatus, HireID.ToString());
                //add the user to the list
                lstHires.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only Hire Location
            DisplayFilterHireLocation(txtBxSearch.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            
            //display the car hire list
            DisplayHires();
            
        }
        
        Int32 DisplayFilterHireLocation(string HireLocationFilter)
        {
            //int to store the primary key
            Int32 HireID;
            //property for CarID - FK
            Int32 CarID;
            //property for CustomerID - FK
            Int32 CustomerID;
            //property for HireLocation
            string HireLocation;
            //property for HireCollectionDate
            DateTime HireCollectionDate;
            //property for HireReturnDate
            DateTime HireReturnDate;
            //property for HireStatus
            string HireStatus;

            //create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            HireCollection.ReportByHireLocation(HireLocationFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = HireCollection.Count;
            //clear the list box
            lstHires.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve HireID
                HireID = HireCollection.HireList[Index].HireID;
                //retrieve CarID
                CarID = HireCollection.HireList[Index].CarID;
                //retrieve CustomerID
                CustomerID = HireCollection.HireList[Index].CustomerID;
                //retrieve HireLocation
                HireLocation = HireCollection.HireList[Index].HireLocation;
                //retrieve HireCollectionDate
                HireCollectionDate = HireCollection.HireList[Index].HireCollectionDate;
                //retrieve HireReturnDate
                HireReturnDate = HireCollection.HireList[Index].HireReturnDate;
                //retrieve HireStatus
                HireStatus = HireCollection.HireList[Index].HireStatus;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Hire ID -  " + HireID + "  |  Car ID -  " + CarID + " |  Customer ID -  " + CustomerID + "  | Hire Location -  " + HireLocation + " |  Car Collection -  " + HireCollectionDate + "  | Car Return -  " + HireReturnDate + "  | Hire Status -  " + HireStatus, HireID.ToString());
                //add the user to the list
                lstHires.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        } 

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //store -1 into the session object to indicate this is a new record
            Session["HireID"] = -1;
            //redirect the user back to the car add page
            Response.Redirect("VCHAHire.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //var to store the primary key value
            Int32 HireID;
            //if a record has been selected from the list
            if (lstHires.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                HireID = Convert.ToInt32(lstHires.SelectedValue);
                //store the data in the session object
                Session["HireID"] = HireID;
                //redirect the delete page
                Response.Redirect("VCHAHire.aspx");
            }
            else //if a user has not selected a car hire record to edit
            {
                //display an error
                lblError.Text = "Please select a Hire record to edit from the list";
            } 
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //var to store the primary key value
            Int32 HireID;
            //if a record has been selected from the list
            if (lstHires.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                HireID = Convert.ToInt32(lstHires.SelectedValue);
                //store the data in the session object
                Session["HireID"] = HireID;
                //redirect the delete page
                Response.Redirect("VCHHireDelete.aspx");
            }
            else //if a user has not selected a car hire record to delete
            {
                //display an error
                lblError.Text = "Please select a Hire record to delete from the list";
            } 
        }

        protected void btnBookHire_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //var to store the primary key value
            Int32 HireID;
            //if a record has been selected from the list
            if (lstHires.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                HireID = Convert.ToInt32(lstHires.SelectedValue);
                //store the data in the session object
                Session["HireID"] = HireID;
                Session["HireBookingID"] = -1;
                //redirect the booking page
                Response.Redirect("VCHAHireBooking.aspx");
            }
            else //if a user has not selected a car hire record to book
            {
                //display an error
                lblError.Text = "Please select a Hire record to Book.";
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