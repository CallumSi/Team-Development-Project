using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCustomerHomeCE : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CustomerID;
        Int32 UserID;

        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer/user to be processed
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            UserID = Convert.ToInt32(Session["UserID"]);

            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCars();
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the CustomerID & UserID when a page unload event happens
            Session["CustomerID"] = CustomerID;
            Session["UserID"] = UserID;
        }

        void DisplayCars()
        {
            //int to store the primary key
            Int32 CarID;
            //Car make property
            string CarMake;
            //Car model property
            string CarModel;
            //Car body property
            string CarBody;

            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = CarCollection.Count;
            //clear the list box
            lstCars.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve CarID
                CarID = CarCollection.CarList[Index].CarID;
                //retrieve CarMake
                CarMake = CarCollection.CarList[Index].CarMake;
                //retrieve CarModel
                CarModel = CarCollection.CarList[Index].CarModel;
                //retrieve CarBody
                CarBody = CarCollection.CarList[Index].CarBody;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Make - " + CarMake + " | Model - " + CarModel + " | Body Type - " + CarBody, CarID.ToString());
                //add the user to the list
                lstCars.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }

        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only staff usernames
            DisplayFilterCarBody(txtBxSearch.Text);
        }

        Int32 DisplayFilterCarBody(string CarBodyFilter)
        {
            //int to store the primary key
            Int32 CarID;
            //Car make property
            string CarMake;
            //Car model property
            string CarModel;
            //Car body property
            string CarBody;

            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            CarCollection.ReportByCarBody(CarBodyFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = CarCollection.Count;
            //clear the list box
            lstCars.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve CarID
                CarID = CarCollection.CarList[Index].CarID;
                //retrieve CarMake
                CarMake = CarCollection.CarList[Index].CarMake;
                //retrieve CarModel
                CarModel = CarCollection.CarList[Index].CarModel;
                //retrieve CarBody
                CarBody = CarCollection.CarList[Index].CarBody;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Make - " + CarMake + " | Model - " + CarModel + " | Body Type - " + CarBody, CarID.ToString());
                //add the user to the list
                lstCars.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 CarID;
            //if a record has been selected from the list
            if (lstCars.SelectedIndex != -1)
            {
                //retrieve intended view records primary key
                CarID = Convert.ToInt32(lstCars.SelectedValue);
                //store the data in the session object
                Session["CarID"] = CarID;
                //redirect the delete page
                Response.Redirect("VCHACarViewerCE.aspx");
            }
            else //if a user has not selected a Car record to view
            {
                //display an error
                lblError.Text = "Please select a Car to view from the list";
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display the car list
            DisplayCars();
        }
    }
}