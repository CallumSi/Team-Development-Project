using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
   
    public partial class VirginCustomerMovieList : System.Web.UI.Page
    {
        Int32 VMMovieID;
        Int32 VMCustomerID;
        Int32 OriginalID;
        clsVMCart MyCart = new clsVMCart();
        protected void Page_Load(object sender, EventArgs e)
        {

            MyCart = (clsVMCart)Session["MyCart"];
            if (MyCart == null)
            {
                MyCart = new clsVMCart();
            }
            VMCustomerID = Convert.ToInt32(Session["VMCustomerID"]);
            OriginalID = Convert.ToInt32(Session["OriginalID"]);
            lblMVUsername.Text = "New User";
            //then you can display how many items are in your cart
            lblCartCount.Text = MyCart.Products.Count.ToString();
            if (IsPostBack == false)
            {
                //update the list box
                DisplayVMMovie();
                //indicate the users ID
                DisplayCustomerData();
            }
        }

        void DisplayCustomerData()
        {
            //create an instance of the customer collection class
            clsVMCustomerCollection SomeCustomer = new clsVMCustomerCollection();
            //find the customer to update
            SomeCustomer.ThisCustomer.Find(VMCustomerID);
            //display the data for this record
            lblMVUsername.Text = SomeCustomer.ThisCustomer.VMcustomerUsername;
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }
        void DisplayVMMovie()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovie = new clsVMMovieCollection();
            lstMovies.DataSource = allMovie.MovieList;
            //set name of primary key
            lstMovies.DataValueField = "VMMovieID";

            //bind data
            lstMovies.DataTextField = "VMMovieTitle";
            lstMovies.DataBind();
        }

        protected void btnViewMovie_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 VMMovieID;
            //if a record has been selected from the list
            if (lstMovies.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                VMMovieID = Convert.ToInt32(lstMovies.SelectedValue);
                //store the data in the session object
                Session["VMMovieID"] = VMMovieID;
                //redirect to the edit page
                Response.Redirect("VMMovieViewer.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "Please select a movie to view from the list";
            }
        }

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            //display all movies
            DisplayVMMovieGenre(txtFilterGenre.Text);
        }

        Int32 DisplayVMMovieGenre(string VMMovieGenreFilter)
        {
            Int32 VMMovieID;
            string VMMovieTitle;
            //create an instance of the movie Collection class
            clsVMMovieCollection movieGenre = new clsVMMovieCollection();
            //invoke the movie genre filter
            movieGenre.FilterByGenre(VMMovieGenreFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = movieGenre.Count;
            //clear the list box
            lstMovies.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                VMMovieID = movieGenre.MovieList[Index].VMMovieID;
                //get the username
                VMMovieTitle = movieGenre.MovieList[Index].VMmovieTitle;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(VMMovieTitle + " ", VMMovieID.ToString());
                //add the shoes to the list
                lstMovies.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            return RecordCount;
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayVMMovie();
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("VMViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("AnVMCustomerEdit.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("VirginCustomerMovieList.aspx");
        }
    }
}