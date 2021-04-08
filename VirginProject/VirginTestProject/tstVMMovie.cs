using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMMovie
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //test to see that it exists
            Assert.IsNotNull(AMovie);
        }

        [TestMethod]
        public void VMmovieIDPropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AMovie.VMMovieID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AMovie.VMMovieID, TestData);
        }

        [TestMethod]
        public void VMmovieTitlePropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a variable to store the first name of the customer
            string SomeVMmovieTitle;
            //try send some data to the customer firstname property
            SomeVMmovieTitle = "Harry Potter";
            //try send some data to the VMcustomerFirstName property
            AMovie.VMmovieTitle = SomeVMmovieTitle;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AMovie.VMmovieTitle, SomeVMmovieTitle);
        }

        [TestMethod]
        public void VMmovieGenrePropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a variable to store the first name of the customer
            string SomeVMmovieGenre;
            //try send some data to the customer firstname property
            SomeVMmovieGenre = "Wizards";
            //try send some data to the VMcustomerFirstName property
            AMovie.VMmovieGenre = SomeVMmovieGenre;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AMovie.VMmovieGenre, SomeVMmovieGenre);
        }

        [TestMethod]
        public void VMmovieDurationPropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a variable to store the first name of the customer
            string SomeVMmovieDuration;
            //try send some data to the customer firstname property
            SomeVMmovieDuration = "158";
            //try send some data to the VMcustomerFirstName property
            AMovie.VMmovieDuration = SomeVMmovieDuration;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AMovie.VMmovieDuration, SomeVMmovieDuration);
        }


        [TestMethod]
        public void VMmovieRatingPropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a variable to store the first name of the customer
            string SomeVMmovieRating;
            //try send some data to the customer firstname property
            SomeVMmovieRating = "9";
            //try send some data to the VMcustomerFirstName property
            AMovie.VMmovieRating = SomeVMmovieRating;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AMovie.VMmovieRating, SomeVMmovieRating);
        }
        [TestMethod]
        public void VMmovieReleaseDatePropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //try send some data to the customer firstname property
            DateTime SomeVMmovieReleaseDate = DateTime.Now.Date;
            //try send some data to the VMcustomerFirstName property
            AMovie.VMmovieReleaseDate = SomeVMmovieReleaseDate;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AMovie.VMmovieReleaseDate, SomeVMmovieReleaseDate);
        }
    }
}
