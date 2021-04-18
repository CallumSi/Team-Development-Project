using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMMovie
    {
        //create some test data to test the valid method
        string VMmovieTitle = "T-34";
        string VMmovieGenre = "War";
        string VMmovieDuration = "139";
        string VMmovieRating = "10";
        string VMmovieReleaseDate = DateTime.Now.Date.ToString();
        string VMImage = @"http://placeimg.com/640/360/any";
        string VMmoviePrice = "20";

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
            SomeVMmovieGenre = "Fantasy";
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
            Int32 TestData = 158;
            //try send some data to the VMcustomerFirstName property
            AMovie.VMmovieDuration = TestData;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AMovie.VMmovieDuration, TestData);
        }


        [TestMethod]
        public void VMmovieRatingPropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a variable to store the first name of the customer
            Int32 TestData = 8;
            //try send some data to the VMcustomerFirstName property
            AMovie.VMmovieRating = TestData;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AMovie.VMmovieRating, TestData);
        }

        [TestMethod]
        public void VMmovieReleaseDatePropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create some test data to assign to the property
            DateTime VMmovieReleaseDate = DateTime.Now.Date;
            //try to send some data to the VMmovieReleaseDate property
            AMovie.VMmovieReleaseDate = VMmovieReleaseDate;
            //test to see that the two values are the same 
            Assert.AreEqual(AMovie.VMmovieReleaseDate, VMmovieReleaseDate);
        }

        [TestMethod]
        public void VMmovieImagePropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //test data for property
            string TestData = "H:/COMPUTING/Year 3/IMAT 3903 - Team Development Project/MovieImageTest/DummyImage.png";
            //assign data to the property
            AMovie.VMImage = TestData;
            //test if values are equal 
            Assert.AreEqual(AMovie.VMImage, TestData);
        }

        [TestMethod]
        public void VMmoviePricePropertyOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //test data for property
            decimal TestData = 20;
            //assign data to the property
            AMovie.VMmoviePrice = TestData;
            //test if values are equal 
            Assert.AreEqual(AMovie.VMmoviePrice, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //boolean variable to store the result of the valdation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 VMMovieID = 1;
            //invoke the method
            Found = AMovie.Find(VMMovieID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void VMmovieMovieTitleMinLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMmovieTitle = "";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieMovieTitleMin()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMmovieTitle = "T";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieMovieTitleMinPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMmovieTitle = "T-";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieTitleMaxLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieTitle = "";
            //create some test data to test the valid method 
            VMmovieTitle = VMmovieTitle.PadRight(54, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieTitleMid()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieTitle = "";
            //create some test data to test the valid method 
            VMmovieTitle = VMmovieTitle.PadLeft(22, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieTitleMaxPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieTitle = "";
            //create some test data to test the valid method 
            VMmovieTitle = VMmovieTitle.PadLeft(56, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieTitleExtremeMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieTitle = "";
            //create some test data to test the valid method 
            VMmovieTitle = VMmovieTitle.PadLeft(100, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieGenreTitleMinLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMmovieGenre = "Wa";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieGenreMin()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMmovieGenre = "War";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieGenreMinPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMmovieGenre = "War";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieGenreMaxLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieGenre = "";
            //create some test data to test the valid method 
            VMmovieGenre = VMmovieGenre.PadRight(54, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieGenreMid()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieGenre = "";
            //create some test data to test the valid method 
            VMmovieGenre = VMmovieGenre.PadLeft(22, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieGenrePlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieGenre = "";
            //create some test data to test the valid method 
            VMmovieGenre = VMmovieGenre.PadLeft(56, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieGenreExtremeMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmovieGenre = "";
            //create some test data to test the valid method 
            VMmovieGenre = VMmovieGenre.PadLeft(100, 'A');
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieDurationMinLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieDuration = "";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieDurationMin()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieDuration = "0";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieDurationMinPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieDuration = "1";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieDurationMaxLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieDuration = "299";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieDurationMid()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieDuration = "150";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieDurationMaxPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieDuration = "301";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieDurationExtremeMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieDuration = "600";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieRatingMinLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieRating = "";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieRatingMin()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieRating = "0";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieRatingMinPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieRating = "1";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieRatingMaxLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieRating = "9";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieRatingMid()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieRating = "5";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieRatingMaxPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieRating = "11";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieRatingExtremeMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMmovieRating = "100";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieReleaseDateMinLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeVMmovieReleaseDate_DOB;
            //set the data to today's date 
            SomeVMmovieReleaseDate_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomeVMmovieReleaseDate_DOB = SomeVMmovieReleaseDate_DOB.AddYears(-122);
            //convert the date variable to a string variable 
            string VMmovieReleaseDate = SomeVMmovieReleaseDate_DOB.ToString();
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieReleaseDateMin()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeVMmovieReleaseDate_DOB;
            //set the data to today's date 
            SomeVMmovieReleaseDate_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomeVMmovieReleaseDate_DOB = SomeVMmovieReleaseDate_DOB.AddYears(-121);
            //convert the date variable to a string variable 
            string VMmovieReleaseDate = SomeVMmovieReleaseDate_DOB.ToString();
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieReleaseDateMinPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeVMmovieReleaseDate_DOB;
            //set the data to today's date 
            SomeVMmovieReleaseDate_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomeVMmovieReleaseDate_DOB = SomeVMmovieReleaseDate_DOB.AddYears(-120);
            //convert the date variable to a string variable 
            string VMmovieReleaseDate = SomeVMmovieReleaseDate_DOB.ToString();
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieReleaseDateMaxLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeVMmovieReleaseDate_DOB;
            //set the data to today's date 
            SomeVMmovieReleaseDate_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomeVMmovieReleaseDate_DOB = SomeVMmovieReleaseDate_DOB.AddYears(0);
            //convert the date variable to a string variable 
            string VMmovieReleaseDate = SomeVMmovieReleaseDate_DOB.ToString();
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieReleaseDateMid()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeVMmovieReleaseDate_DOB;
            //set the data to today's date 
            SomeVMmovieReleaseDate_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomeVMmovieReleaseDate_DOB = SomeVMmovieReleaseDate_DOB.AddYears(-60);
            //convert the date variable to a string variable 
            string VMmovieReleaseDate = SomeVMmovieReleaseDate_DOB.ToString();
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieReleaseDateMaxPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeVMmovieReleaseDate_DOB;
            //set the data to today's date 
            SomeVMmovieReleaseDate_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomeVMmovieReleaseDate_DOB = SomeVMmovieReleaseDate_DOB.AddYears(1);
            //convert the date variable to a string variable 
            string VMmovieReleaseDate = SomeVMmovieReleaseDate_DOB.ToString();
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmovieReleaseDateExtremeMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeVMmovieReleaseDate_DOB;
            //set the data to today's date 
            SomeVMmovieReleaseDate_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomeVMmovieReleaseDate_DOB = SomeVMmovieReleaseDate_DOB.AddYears(100);
            //convert the date variable to a string variable 
            string VMmovieReleaseDate = SomeVMmovieReleaseDate_DOB.ToString();
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMImageMinLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method      
            String VMImage = "";
            //test the valid method with the test data
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to ensure no error msg - can be blank
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMImageMin()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            String VMImage = "AAAAA";
            //test the valid method with the test data
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMImageMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            string VMImage = "";
            VMImage = VMImage.PadRight(200, 'A');
            //test the valid method with the test data
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to ensure  error msg
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMImageMaxPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //string to store if result isvalid 
            String Error = "";
            //some test data to insert into the valid method 
            string VMImage = "";
            VMImage = VMImage.PadRight(201, 'A');
            //test the valid method with the test data
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to ensure  error msg
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmoviePriceMinLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMmoviePrice = "4.99m";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmoviePriceMin()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMmoviePrice = "5.01";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void VMmoviePriceMinPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMmoviePrice = "5.01";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmoviePriceMaxLessOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmoviePrice = "99.99";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmoviePriceMid()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmoviePrice = "55";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmoviePriceMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmoviePrice = "100";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMmoviePriceMaxPlusOne()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmoviePrice = "101";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMmoviePriceExtremeMax()
        {
            //create an instance of the movie class
            clsVMMovie AMovie = new clsVMMovie();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMmoviePrice = "500";
            //invoke the method
            Error = AMovie.Valid(VMmovieTitle, VMmovieGenre, VMmovieDuration, VMmovieRating, VMmovieReleaseDate, VMImage, VMmoviePrice);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }
    }
}
