using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHAHire : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 HireID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the car hire to be processed
            HireID = Convert.ToInt32(Session["HireID"]);
            if (IsPostBack == false)
            {
                //populate the list of car hire
                DisplayHire();
                //if this is not a new record
                if (HireID != -1)
                {
                    //display the current data for the record
                    DisplayHire();
                }
            }
        }

        void DisplayHire()
        {
            /*//create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //find the HireID for the record to be updated
            HireCollection.ThisHire.Find(HireID);
            //display the data for this record
            txtCarMake.Text = HireCollection.ThisHire.CarMake;
            txtCarModel.Text = HireCollection.ThisHire.CarModel;
            txtCarEngine.Text = HireCollection.ThisHire.CarEngine.ToString();
            ddlCarBody.SelectedValue = HireCollection.ThisHire.CarBody;
            txtCarColour.Text = HireCollection.ThisHire.CarColour;
            ddlFuelType.SelectedValue = HireCollection.ThisHire.CarFuel;
            txtCarPrice.Text = HireCollection.ThisHire.CarPrice.ToString();
            txtCarRegistration.Text = HireCollection.ThisHire.CarRegistration;*/
        }
    }
}