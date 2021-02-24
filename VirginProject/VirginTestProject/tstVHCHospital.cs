using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVHCHospital
    {

        /// <summary>
        /// TESTING HOSPITAL PROPERTIES
        /// </summary>

        //good test data 
        //create some test data to pass to the method 
        //TOTAL: 3 Properties including PK (Hospital_ID) 

        string Hospital_Name = "West Middlesex Hospital"; // (1) 
        string Hospital_Place = "West London"; // (2) 

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //test to see that it exists 
            Assert.IsNotNull(AVHCHospital);
        }

        [TestMethod]
        //used to test the Hospital_ID property of the hospital class
        public void Hospital_IDPropertyOK()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //create a variable to store the ID of a hospital 
            Int32 SomeHospital_ID = 1;
            //try to send some data to the hospital ID property
            AVHCHospital.Hospital_ID = SomeHospital_ID;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCHospital.Hospital_ID, SomeHospital_ID);
        }

        [TestMethod]
        //used to test the Hospital_Name property of the hospital class
        public void Hospital_NamePropertyOK()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //create a variable to store the name of a hospital 
            string SomeHospital_Name = "West Middlesex Hospital";
            //try to send some data to the hospital name property
            AVHCHospital.Hospital_Name = SomeHospital_Name;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCHospital.Hospital_Name, SomeHospital_Name);
        }

        [TestMethod]
        //used to test the Hospital_Place property of the hospital class
        public void Hospital_PlacePropertyOK()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //create a variable to store the place of a hospital 
            string SomeHospital_Place = "West London";
            //try to send some data to the hospital place property
            AVHCHospital.Hospital_Place = SomeHospital_Place;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCHospital.Hospital_Place, SomeHospital_Place);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to test the valid method 
            string Hospital_Name = "West Middlesex Hospital"; // (1) 
            string Hospital_Place = "West London"; // (2) 
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Hospital_Name Property
        ///// </summary>

        [TestMethod]
        public void Hospital_NameMinLessOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_NameMin()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //create some test data to test the valid method 
            Hospital_Name = Hospital_Name.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_NameMinPlusOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //create some test data to test the valid method 
            Hospital_Name = Hospital_Name.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_NameMaxLessOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //create some test data to test the valid method 
            Hospital_Name = Hospital_Name.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_NameMax()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //create some test data to test the valid method 
            Hospital_Name = Hospital_Name.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_NameMaxPlusOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //create some test data to test the valid method 
            Hospital_Name = Hospital_Name.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_NameMid()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //create some test data to test the valid method 
            Hospital_Name = Hospital_Name.PadLeft(26, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_NameExtremeMax()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Name = "";
            //create some test data to test the valid method 
            Hospital_Name = Hospital_Name.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Hospital_Place Property
        ///// </summary>

        [TestMethod]
        public void Hospital_PlaceMinLessOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_PlaceMin()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //create some test data to test the valid method 
            Hospital_Place = Hospital_Place.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_PlaceMinPlusOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //create some test data to test the valid method 
            Hospital_Place = Hospital_Place.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_PlaceMaxLessOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //create some test data to test the valid method 
            Hospital_Place = Hospital_Place.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_PlaceMax()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //create some test data to test the valid method 
            Hospital_Place = Hospital_Place.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_PlaceMaxPlusOne()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //create some test data to test the valid method 
            Hospital_Place = Hospital_Place.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_PlaceMid()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //create some test data to test the valid method 
            Hospital_Place = Hospital_Place.PadLeft(26, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Hospital_PlaceExtremeMax()
        {
            //create an instance of the hospital class 
            clsVHCHospital AVHCHospital = new clsVHCHospital();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Hospital_Place = "";
            //create some test data to test the valid method 
            Hospital_Place = Hospital_Place.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCHospital.Valid(Hospital_Name, Hospital_Place);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

    }
}
