using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMMovie : System.Web.UI.Page
    {
        Int32 VMMovieID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayVMMovie();
            }
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

        protected void btnAddMovie_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["VMMovieID"] = -1;
            //redirect to user data entry page
            Response.Redirect("AnVMStaffAddMovie.aspx");
        }

        protected void btnUpdateMovie_Click(object sender, EventArgs e)
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
                Response.Redirect("AnVMStaffAddMovie.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 VMMovieID;
            //if a record has been selected from the list
            if (lstMovies.SelectedIndex != -1)
            {
                //get the primary key of the record to delete
                VMMovieID = Convert.ToInt32(lstMovies.SelectedValue);
                //store the data in the session object
                Session["VMMovieID"] = VMMovieID;
                //redirect to the delete page
                Response.Redirect("VMMovieDelete.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "Please select a record to delete from the list";
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
            //display all VM movies 
            DisplayVMMovie();
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect to the customer list
            Response.Redirect("VMCustomerList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to the login page 
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnStaffList_Click(object sender, EventArgs e)
        {
            //redirect to the staff list
            Response.Redirect("VMStaffList.aspx");
        }
    }
}