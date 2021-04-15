using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMMovieViewer : System.Web.UI.Page
    {
        //variable to store the MovieID and CustomerID from session obect
        Int32 VMMovieID;
        Int32 VMCustomerID;
        //String VMmovieTitle;
        //String VMmovieGenre;
        //Int32 VMmovieDuration;
        //Int32 VMmovieRating;
        //DateTime VMmovieReleaseDate;

        //create an instance of the clsVMCart
        clsVMCart MyCart = new clsVMCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblMovieTitle.Text = VMmovieTitle;
            //lblMovieGenre.Text = VMmovieGenre;
            //lblMovieDuration.Text = VMmovieDuration.ToString();
            //lblMovieDuration.Text = VMmovieReleaseDate.ToString();
            //get the customersid and movieid  and cart from session object 
            VMCustomerID = Convert.ToInt32(Session["VMCustomerID"]);
            VMMovieID = Convert.ToInt32(Session["VMMovieID"]);
            MyCart = (clsVMCart)Session["MyCart"];

            if (IsPostBack == false)
            {
                {
                    //display the requeted record and user 
                    DisplayCustomerData();
                    DisplayMovieData();
                }
            }
        }

        void DisplayMovieData()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection SomeMovie = new clsVMMovieCollection();
            //find the movie to display
            SomeMovie.ThisMovie.Find(VMMovieID);
            //display the data for this record
            lblMovieTitle.Text = SomeMovie.ThisMovie.VMmovieTitle;
            lblMovieGenre.Text = SomeMovie.ThisMovie.VMmovieGenre;
            lblMovieDuration.Text = SomeMovie.ThisMovie.VMmovieDuration.ToString();
            lblMovieRating.Text = SomeMovie.ThisMovie.VMmovieRating.ToString();
            lblMovieReleaseDate.Text = SomeMovie.ThisMovie.VMmovieReleaseDate.ToString();
            MovieImage.ImageUrl = SomeMovie.ThisMovie.VMImage;
            lblMoviePrice.Text = SomeMovie.ThisMovie.VMmoviePrice.ToString();
        }
        
        void DisplayCustomerData()
        {
            //create an instance of the customer collection class
            clsVMCustomerCollection SomeCustomer = new clsVMCustomerCollection();
            //find the customer to update
            SomeCustomer.ThisCustomer.Find(VMCustomerID);
            //display the data for this record
            lblUsername.Text = SomeCustomer.ThisCustomer.VMcustomerUsername;
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomer"] = VMCustomerID;
            //redirect to edit user details page
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomer"] = VMCustomerID;
            Response.Redirect("VMViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomer"] = VMCustomerID;
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomer"] = VMCustomerID;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

            //create a new instance of clsCartItem
            clsVMCartItem AnItem = new clsVMCartItem();
            //set the movie id
            AnItem.ProductID = VMMovieID;
            try
            {
                Int32 Moviequantity = Convert.ToInt32(lblQuantity.Text);
                Int32 yourquantity = Convert.ToInt32(txtQTY.Text);

                if ( yourquantity <= Moviequantity && yourquantity > 0)
                {
                AnItem.QTY = Convert.ToInt32(txtQTY.Text);
                //add the item to the cart's movie collection
                MyCart.Products.Add(AnItem);
                //go back to shopping
                Response.Redirect("VirginCustomerMovieList.aspx");
                }
                else
                {
                    //error message
                    lblError.Text = "Please enter a valid quantity.";
                }

            }
            catch
            {
                //error message
                lblError.Text = "Please enter a number.";
            }
        }
    }
}