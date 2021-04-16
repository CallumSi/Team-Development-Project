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
        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayHires();
            }
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
            //store -1 into the session object to indicate this is a new record
            Session["HireID"] = -1;
            //redirect the user back to the car add page
            Response.Redirect("VCHAHire.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
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
    }
}