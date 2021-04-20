using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    ///This test uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    
    [TestClass]
    public class tstVHCPatient
    {
        /// <summary>
        /// TESTING PATIENT PROPERTIES
        /// </summary>

        //good test data 
        //create some test data to pass to the method 
        //TOTAL: 11 Properties including PK (Patient_ID) 

        string Patient_Title = "Miss"; // (1) 
        string Patient_Firstname = "Lia"; // (2) 
        string Patient_Lastname = "Potter"; // (3) 
        string Patient_Address = "42 Western Road, Leicestershire"; // (4) 
        string Patient_DOB = DateTime.Now.Date.ToString(); // (5) 
        string Patient_Email = "LiaPotter@gmail.com"; // (6) 
        string Patient_Username = "LiaPotter1"; // (7) 
        string Patient_Password = "LiaP010101"; // (8) 
        string Patient_Telephone = "01164891276"; // (9) 
        string Patient_Status = "True"; // (10)

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //test to see that it exists 
            Assert.IsNotNull(AVHCPatient); 
        }

        [TestMethod]
        //used to test the Patient_ID property of the patient class
        public void Patient_IDPropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the ID of a patient 
            Int32 SomePatient_ID = 1;
            //try to send some data to the patient ID property
            AVHCPatient.Patient_ID = SomePatient_ID;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_ID, SomePatient_ID);
        }

        [TestMethod]
        //used to test the Patient_Title property of the patient class 
        public void Patient_TitlePropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient title property 
            string SomePatient_Title = "Miss"; 
            //try to send some data to the patient title property
            AVHCPatient.Patient_Title = SomePatient_Title;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Title, SomePatient_Title);
        }

        [TestMethod]
        //used to test the Patient_Firstname property of the patient class 
        public void Patient_FirstnamePropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient firstname property
            string SomePatient_Firstname = "Lia";
            //try to send some data to the patient firstname property
            AVHCPatient.Patient_Firstname = SomePatient_Firstname;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Firstname, SomePatient_Firstname);
        }

        [TestMethod]
        //used to test the Patient_Lastname property of the patient class 
        public void Patient_LastnamePropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient lastname property
            string SomePatient_Lastname = "Potter";
            //try to send some data to the patient lastname property
            AVHCPatient.Patient_Lastname = SomePatient_Lastname;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Lastname, SomePatient_Lastname);
        }

        [TestMethod]
        //used to test the Patient_Address property of the patient class 
        public void Patient_AddressPropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient address property
            string SomePatient_Address = "42 Western Road, Leicestershire";
            //try to send some data to the patient address property
            AVHCPatient.Patient_Address = SomePatient_Address;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Address, SomePatient_Address);
        }
        [TestMethod]
        //used to test the Patient_DOB property of the patient class 
        public void Patient_DOBPropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the date of birth of a patient 
            DateTime Patient_DOB = DateTime.Now.Date; 
            //try to send some data to the patient_DOB property
            AVHCPatient.Patient_DOB = Patient_DOB;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_DOB, Patient_DOB);
        }

        [TestMethod]
        //used to test the Patient_Email property of the patient class 
        public void Patient_EmailPropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient email property
            string SomePatient_Email = "LiaPotter@gmail.com";
            //try to send some data to the patient email property
            AVHCPatient.Patient_Email = SomePatient_Email;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Email, SomePatient_Email);
        }

        [TestMethod]
        //used to test the Patient_Username property of the patient class 
        public void Patient_UsernamePropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient username property
            string SomePatient_Username = "LiaPotter1";
            //try to send some data to the patient username property
            AVHCPatient.Patient_Username = SomePatient_Username;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Username, SomePatient_Username);
        }

        [TestMethod]
        //used to test the Patient_Password property of the patient class 
        public void Patient_PasswordPropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient password property
            string SomePatient_Password = "LiaP010101";
            //try to send some data to the patient password property
            AVHCPatient.Patient_Password = SomePatient_Password;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Password, SomePatient_Password);
        }

        [TestMethod]
        //used to test the Patient_Telephone property of the patient class 
        public void Patient_TelephonePropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create some test data to assign to the patient telephone property
            string SomePatient_Telephone = "01164891276";
            //try to send some data to the patient telephone property
            AVHCPatient.Patient_Telephone = SomePatient_Telephone;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Telephone, SomePatient_Telephone);
        }


        [TestMethod]
        //used to test the Patient_Status property of the patient class 
        public void Patient_StatusPropertyOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the status of a patient 
            Boolean SomePatient_Status = true;
            //try to send some data to the patient status property
            AVHCPatient.Patient_Status = SomePatient_Status;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Status, SomePatient_Status);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to test the valid method 
            string Patient_Title = "Miss"; // (1) 
            string Patient_Firstname = "Lia"; // (2) 
            string Patient_Lastname = "Potter"; // (3) 
            string Patient_Address = "42 Western Road, Leicestershire"; // (4) 
            string Patient_DOB = DateTime.Now.Date.ToString(); // (5) 
            string Patient_Email = "LiaPotter@gmail.com"; // (6) 
            string Patient_Username = "LiaPotter1"; // (7) 
            string Patient_Password = "LiaP010101"; // (8) 
            string Patient_Telephone = "01164891276"; // (9) 
            string Patient_Status = "True"; // (10) 
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        ///// <summary>
        ///// TEST PLAN: Patient_Title Property
        ///// </summary>

        [TestMethod]
        public void Patient_TitleMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TitleMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TitleMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(3, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TitleMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(4, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TitleMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(5, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TitleMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(6, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TitleMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(4, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TitleExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Title = "";
            //create some test data to test the valid method 
            Patient_Title = Patient_Title.PadLeft(10, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Patient_Firstname Property
        ///// </summary>

        [TestMethod]
        public void Patient_FirstnameMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Firstname = "";
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_FirstnameMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Firstname = "";
            //create some test data to test the valid method 
            Patient_Firstname = Patient_Firstname.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_FirstnameMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Firstname = "";
            //create some test data to test the valid method 
            Patient_Firstname = Patient_Firstname.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_FirstnameMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Firstname = "";
            //create some test data to test the valid method 
            Patient_Firstname = Patient_Firstname.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_FirstnameMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Firstname = "";
            //create some test data to test the valid method 
            Patient_Firstname = Patient_Firstname.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_FirstnameMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Firstname = "";
            //create some test data to test the valid method 
            Patient_Firstname = Patient_Firstname.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_FirstnameMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Firstname = "";
            //create some test data to test the valid method 
            Patient_Firstname = Patient_Firstname.PadLeft(26, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_FirstnameExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Firstname = "";
            //create some test data to test the valid method 
            Patient_Firstname = Patient_Firstname.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Patient_Lastname Property
        ///// </summary>
        
        [TestMethod]
        public void Patient_LastnameMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Lastname = "";
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_LastnameMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Lastname = "";
            //create some test data to test the valid method 
            Patient_Lastname = Patient_Lastname.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_LastnameMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Lastname = "";
            //create some test data to test the valid method 
            Patient_Lastname = Patient_Lastname.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_LastnameMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Lastname = "";
            //create some test data to test the valid method 
            Patient_Lastname = Patient_Lastname.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_LastnameMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Lastname = "";
            //create some test data to test the valid method 
            Patient_Lastname = Patient_Lastname.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_LastnameMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Lastname = "";
            //create some test data to test the valid method 
            Patient_Lastname = Patient_Lastname.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_LastnameMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Lastname = "";
            //create some test data to test the valid method 
            Patient_Lastname = Patient_Lastname.PadLeft(26, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_LastnameExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Lastname = "";
            //create some test data to test the valid method 
            Patient_Lastname = Patient_Lastname.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Patient_Address Property
        ///// </summary>

        [TestMethod]
        public void Patient_AddressMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Address = "";
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_AddressMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Address = "";
            //create some test data to test the valid method 
            Patient_Address = Patient_Address.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_AddressMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Address = "";
            //create some test data to test the valid method 
            Patient_Address = Patient_Address.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_AddressMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Address = "";
            //create some test data to test the valid method 
            Patient_Address = Patient_Address.PadLeft(99, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_AddressMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Address = "";
            //create some test data to test the valid method 
            Patient_Address = Patient_Address.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_AddressMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Address = "";
            //create some test data to test the valid method 
            Patient_Address = Patient_Address.PadLeft(101, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_AddressMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Address = "";
            //create some test data to test the valid method 
            Patient_Address = Patient_Address.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_AddressExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Address = "";
            //create some test data to test the valid method 
            Patient_Address = Patient_Address.PadLeft(1000, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Patient_DOB Property
        ///// </summary>
        
        [TestMethod]
        public void Patient_DOBExtremeMin()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 200 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(-200);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBMinLessOne()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 101 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(-101);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBMin()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 100 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(-100);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBMinPlusOne()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is less 99 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(-99);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBMaxLessOne()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is plus 99 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(99);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBMax()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is 100 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(100);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBMaxPlusOne()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is plus 101 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(101);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBMid()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Patient_DOBExtremeMax()

        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create some test data to pass to the method 
            DateTime SomePatient_DOB;
            //set the data to today's date 
            SomePatient_DOB = DateTime.Now.Date;
            //change the data to whatever the date is plus 200 years 
            SomePatient_DOB = SomePatient_DOB.AddYears(200);
            //convert the date variable to a string variable 
            string Patient_DOB = SomePatient_DOB.ToString();
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        ///// <summary>
        ///// TEST PLAN: Patient_Email Property
        ///// </summary>

        [TestMethod]
        public void Patient_EmailMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(10, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_EmailMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(11, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_EmailMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(12, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_EmailMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_EmailMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_EmailMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_EmailMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(31, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_EmailExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Email = "";
            //create some test data to test the valid method 
            Patient_Email = Patient_Email.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Patient_Username Property
        ///// </summary>

        [TestMethod]
        public void Patient_UsernameMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Username = "";
            //create some test data to pass to the method 
            Patient_Username = Patient_Username.PadLeft(7, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_UsernameMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Username = "";
            //create some test data to test the valid method 
            Patient_Username = Patient_Username.PadLeft(8, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_UsernameMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Username = "";
            //create some test data to test the valid method 
            Patient_Username = Patient_Username.PadLeft(9, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_UsernameMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Username = "";
            //create some test data to test the valid method 
            Patient_Username = Patient_Username.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_UsernameMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Username = "";
            //create some test data to test the valid method 
            Patient_Username = Patient_Username.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_UsernameMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Username = "";
            //create some test data to test the valid method 
            Patient_Username = Patient_Username.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_UsernameMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Username = "";
            //create some test data to test the valid method 
            Patient_Username = Patient_Username.PadLeft(29, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_UsernameExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Username = "";
            //create some test data to test the valid method 
            Patient_Username = Patient_Username.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Patient_Password Property
        ///// </summary>

        [TestMethod]
        public void Patient_PasswordMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(7, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_PasswordMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(8, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_PasswordMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(9, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_PasswordMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_PasswordMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_PasswordMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_PasswordMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(29, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_PasswordExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Password = "";
            //create some test data to test the valid method 
            Patient_Password = Patient_Password.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Patient_Telephone Property
        ///// </summary>

        [TestMethod]
        public void Patient_TelephoneMinLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(6, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TelephoneMin()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(7, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TelephoneMinPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(8, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TelephoneMaxLessOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(14, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TelephoneMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(15, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TelephoneMaxPlusOne()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(16, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TelephoneMid()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(11, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Patient_TelephoneExtremeMax()
        {
            //create an instance of the patient class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to record the result of the validation test 
            String Error = "";
            //create a variable to store any error message
            string Patient_Telephone = "";
            //create some test data to test the valid method 
            Patient_Telephone = Patient_Telephone.PadLeft(100, '1');
            //invoke the method 
            Error = AVHCPatient.Valid(Patient_Title, Patient_Firstname, Patient_Lastname, Patient_Address, Patient_DOB, Patient_Email, Patient_Username, Patient_Password, Patient_Telephone);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

    }
}
