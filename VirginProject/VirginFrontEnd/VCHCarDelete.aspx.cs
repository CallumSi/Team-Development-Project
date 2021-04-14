using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCarDelete : System.Web.UI.Page
    {
        //var to store primary key for record to be deleted
        Int32 CarID;

        //event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the car that will be deleted from the session object
            CarID = Convert.ToInt32(Session["CarID"]);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteCar();
            //redirect the user to the car list page
            Response.Redirect("VCHCarList.aspx");
        }

        //function to delete a car 
        void DeleteCar()
        {
            //create an instance of the car 
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //find the car record to be deleted 
            CarCollection.ThisCar.Find(CarID);
            //delete the record
            CarCollection.Delete();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the car list page, without having deleted a car record
            Response.Redirect("VCHCarList.aspx");
        }
    }
}