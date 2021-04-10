using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]

    public class tstVHCAppointment
    {

        /// <summary>
        /// TESTING APPOINTMENT PROPERTIES
        /// </summary>

        //good test data 
        //create some test data to pass to the method 
        //TOTAL: 4 Properties including PK (Appointment_ID) 

        string Appointment_Date = DateTime.Now.Date.ToString(); // (1) 
        string Appointment_Time = "09:00"; // (2) 
        string Appointment_Description = "Broken arm"; // (3) 


        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //test to see that it exists 
            Assert.IsNotNull(AVHCAppointment);
        }

        [TestMethod]
        //used to test the Appointment_ID property of the appointment class
        public void Appointment_IDPropertyOK()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //create a variable to store the ID of a appointment 
            Int32 SomeAppointment_ID = 1;
            //try to send some data to the appointment ID property
            AVHCAppointment.Appointment_ID = SomeAppointment_ID;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCAppointment.Appointment_ID, SomeAppointment_ID);
        }

        [TestMethod]
        //used to test the Appointment_Date property of the appointment class
        public void Appointment_DatePropertyOK()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //create a variable to store the date of a appointment 
            DateTime Appointment_Date = DateTime.Now.Date; // (1) 
            //try to send some data to the appointment date property
            AVHCAppointment.Appointment_Date = Appointment_Date;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCAppointment.Appointment_Date, Appointment_Date);
        }

        [TestMethod]
        //used to test the Appointment_Time property of the appointment class
        public void Appointment_TimePropertyOK()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //create a variable to store the time of a appointment 
            string SomeAppointment_Time = "09:00";
            //try to send some data to the appointment time property
            AVHCAppointment.Appointment_Time = SomeAppointment_Time;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCAppointment.Appointment_Time, SomeAppointment_Time);
        }

        [TestMethod]
        //used to test the Appointment_Description property of the appointment class
        public void Appointment_DescriptionPropertyOK()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //create a variable to store the description of a appointment 
            string SomeAppointment_Description = "Broken arm";
            //try to send some data to the appointment description property
            AVHCAppointment.Appointment_Description = SomeAppointment_Description;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCAppointment.Appointment_Description, SomeAppointment_Description);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to test the valid method 
            string Appointment_Date = DateTime.Now.Date.ToString(); // (1) 
            string Appointment_Time = "09:00"; // (2) 
            string Appointment_Description = "Broken arm"; // (3) 
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Appointment_Date Property
        ///// </summary>

        [TestMethod]
        public void Appointment_DateExtremeMin()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is less 100 years 
            SomeAppointment_Date = SomeAppointment_Date.AddYears(-100);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Appointment_DateMinLessOne()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is less 1 day 
            SomeAppointment_Date = SomeAppointment_Date.AddDays(-1);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void Appointment_DateMin()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Appointment_DateMinPlusOne()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is plus 1 day 
            SomeAppointment_Date = SomeAppointment_Date.AddDays(1);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Appointment_DateMaxLessOne()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is plus 29 days 
            SomeAppointment_Date = SomeAppointment_Date.AddDays(29);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }



        [TestMethod]
        public void Appointment_DateMax()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is plus 30 days 
            SomeAppointment_Date = SomeAppointment_Date.AddDays(30);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Appointment_DateMaxPlusOne()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is plus 31 days 
            SomeAppointment_Date = SomeAppointment_Date.AddDays(31);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Appointment_DateMid()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is plus 14 days 
            SomeAppointment_Date = SomeAppointment_Date.AddDays(14);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Appointment_DateExtremeMax()

        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomeAppointment_Date;
            //set the data to today's date 
            SomeAppointment_Date = DateTime.Now.Date;
            //change the data to whatever the date is plus 100 years 
            SomeAppointment_Date = SomeAppointment_Date.AddYears(100);
            //convert the date variable to a string variable 
            string Appointment_Date = SomeAppointment_Date.ToString();
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Appointment_DateInvalidData()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //set the appointment date to a non data value 
            string Appointment_Date = "This is not a date!";
            //invoke the method
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Appointment_Time Property
        ///// </summary>

        [TestMethod]
        public void Appointment_TimeExtremeMin()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(3, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_TimeMinLessOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(4, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_TimeMin()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(5, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_TimeMinPlusOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(6, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_TimeMaxLessOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(4, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_TimeMax()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(5, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Appointment_TimeMaxPlusOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(6, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_TimeMid()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(0, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_TimeExtremeMax()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Time = "";
            //create some test data to test the valid method 
            Appointment_Time = Appointment_Time.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Appointment_Description Property
        ///// </summary>

        [TestMethod]
        public void Appointment_DescriptionMinLessOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_DescriptionMin()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //create some test data to test the valid method 
            Appointment_Description = Appointment_Description.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_DescriptionMinPlusOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //create some test data to test the valid method 
            Appointment_Description = Appointment_Description.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_DescriptionMaxLessOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //create some test data to test the valid method 
            Appointment_Description = Appointment_Description.PadLeft(149, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_DescriptionMax()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //create some test data to test the valid method 
            Appointment_Description = Appointment_Description.PadLeft(150, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_DescriptionMaxPlusOne()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //create some test data to test the valid method 
            Appointment_Description = Appointment_Description.PadLeft(151, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_DescriptionMid()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //create some test data to test the valid method 
            Appointment_Description = Appointment_Description.PadLeft(76, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Appointment_DescriptionExtremeMax()
        {
            //create an instance of the appointment class 
            clsVHCAppointment AVHCAppointment = new clsVHCAppointment();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Appointment_Description = "";
            //create some test data to test the valid method 
            Appointment_Description = Appointment_Description.PadLeft(1000, 'A');
            //invoke the method 
            Error = AVHCAppointment.Valid(Appointment_Date, Appointment_Time, Appointment_Description);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

    }
}
