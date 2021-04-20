using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHACarViewer : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CustomerID;
        Int32 UserID;
        //variable to store the primary key with page level scope
        Int32 CarID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer/user to be processed
            CustomerID = Convert.ToInt32(Session["CustomerID"]);

            //get the number of the car to be processed
            CarID = Convert.ToInt32(Session["CarID"]);
            if (IsPostBack == false)
            {
                //populate the list of car
                DisplayCar();
                //if this is not a new record
                if (CarID != -1)
                {
                    //display the current data for the record
                    DisplayCar();
                }
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the CustomerID & UserID when a page unload event happens
            Session["CustomerID"] = CustomerID;
            Session["UserID"] = UserID;
            Session["CarID"] = CarID;
        }

        void DisplayCar()
        {
            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //find the CarID for the record to be updated
            CarCollection.ThisCar.Find(CarID);
            //display the data for this record
            txtCarMake.Text = CarCollection.ThisCar.CarMake;
            txtCarModel.Text = CarCollection.ThisCar.CarModel;
            txtCarEngine.Text = CarCollection.ThisCar.CarEngine.ToString();
            txtCarBody.Text = CarCollection.ThisCar.CarBody;
            txtCarColour.Text = CarCollection.ThisCar.CarColour;
            txtCarFuel.Text = CarCollection.ThisCar.CarFuel;
            txtCarPrice.Text = CarCollection.ThisCar.CarPrice.ToString();
            txtCarRegistration.Text = CarCollection.ThisCar.CarRegistration;
        }

        protected void btnHire_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["CustomerID"] = CustomerID;
            Session["CarID"] = CarID;
            Session["HireID"] = -1;
            //redirect the user back to the car add page
            Response.Redirect("VCHAHireCE.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            //redirect the customer to the customer home page
            Response.Redirect("VCHCustomerHomeCE.aspx");
        }
    }
}