using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVHCStaff
    {
        /// <summary>
        /// TESTING STAFF PROPERTIES
        /// </summary>

        //good test data 
        //create some test data to pass to the method 
        //TOTAL: 9 Properties including PK (Staff_ID) 

        string Staff_Title = "Dr"; //(1) 
        string Staff_Firstname = "Monica"; // (2) 
        string Staff_Lastname = "Geller"; // (3) 
        string Staff_Email = "MGeller@gmail.com"; // (4) 
        string Staff_Username = "MonGeller"; // (5) 
        string Staff_Password = "MG3007"; // (6) 
        string Staff_Role = "Doctor"; // (7) 
        string Staff_Status = "True"; // (8)

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //test to see that it exists 
            Assert.IsNotNull(AVHCStaff);
        }

        [TestMethod]
        //used to test the Staff_ID property of the staff class
        public void Staff_IDPropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the ID of a staff 
            Int32 SomeStaff_ID = 1;
            //try to send some data to the staff ID property
            AVHCStaff.Staff_ID = SomeStaff_ID;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_ID, SomeStaff_ID);
        }

        [TestMethod]
        //used to test the Staff_Title property of the staff class
        public void Staff_TitlePropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the title of a staff 
            string SomeStaff_Title = "Dr";
            //try to send some data to the staff title property
            AVHCStaff.Staff_Title = SomeStaff_Title;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Title, SomeStaff_Title);
        }

        [TestMethod]
        //used to test the Staff_Firstname property of the staff class
        public void Staff_FirstnamePropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the firstname of a staff 
            string SomeStaff_Firstname = "Monica";
            //try to send some data to the staff firstname property
            AVHCStaff.Staff_Firstname = SomeStaff_Firstname;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Firstname, SomeStaff_Firstname);
        }

        [TestMethod]
        //used to test the Staff_Lastname property of the staff class
        public void Staff_LastnamePropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the lastname of a staff 
            string SomeStaff_Lastname = "Geller";
            //try to send some data to the staff lastname property
            AVHCStaff.Staff_Lastname = SomeStaff_Lastname;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Lastname, SomeStaff_Lastname);
        }

        [TestMethod]
        //used to test the Staff_Email property of the staff class
        public void Staff_EmailPropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the email of a staff 
            string SomeStaff_Email = "MGeller@gmail.com";
            //try to send some data to the staff email property
            AVHCStaff.Staff_Email = SomeStaff_Email;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Email, SomeStaff_Email);
        }

        [TestMethod]
        //used to test the Staff_Username property of the staff class
        public void Staff_UsernamePropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the username of a staff 
            string SomeStaff_Username = "MonGeller";
            //try to send some data to the staff username property
            AVHCStaff.Staff_Username = SomeStaff_Username;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Username, SomeStaff_Username);
        }

        [TestMethod]
        //used to test the Staff_Password property of the staff class
        public void Staff_PasswordPropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the password of a staff 
            string SomeStaff_Password = "MG3007";
            //try to send some data to the staff password property
            AVHCStaff.Staff_Password = SomeStaff_Password;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Password, SomeStaff_Password);
        }


        [TestMethod]
        //used to test the Staff_Role property of the staff class
        public void Staff_RolePropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the role of a staff 
            string SomeStaff_Role = "Doctor";
            //try to send some data to the staff role property
            AVHCStaff.Staff_Role = SomeStaff_Role;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Role, SomeStaff_Role);
        }

        [TestMethod]
        //used to test the Staff_Status property of the staff class
        public void Staff_StatusPropertyOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store the status of a staff 
            Boolean SomeStaff_Status = true;
            //try to send some data to the staff status property
            AVHCStaff.Staff_Status = SomeStaff_Status;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCStaff.Staff_Status, SomeStaff_Status);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //string variable to store any error message 
            String Error = "";
            //create some test data to test the valid method 
            string Staff_Title = "Dr"; // (1) 
            string Staff_Firstname = "Monica"; // (2) 
            string Staff_Lastname = "Geller"; // (3) 
            string Staff_Email = "MGeller@gmail.com"; // (4) 
            string Staff_Username = "MonGeller"; // (5) 
            string Staff_Password = "MG3007"; // (6) 
            string Staff_Role = "Doctor"; // (7) 
            string Staff_Status = "True"; // (8)
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        ///// <summary>
        ///// TEST PLAN: Staff_Title Property
        ///// </summary>

        [TestMethod]
        public void Staff_TitleMinLessOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_TitleMin()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Staff_TitleMinPlusOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(3, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_TitleMaxLessOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(4, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_TitleMax()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(5, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_TitleMaxPlusOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(6, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_TitleMid()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(4, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_TitleExtremeMax()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Title = "";
            //create some test data to test the valid method 
            Staff_Title = Staff_Title.PadLeft(10, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        ///// <summary>
        ///// TEST PLAN: Staff_Firstname Property
        ///// </summary>

        [TestMethod]
        public void Staff_FirstnameMinLessOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FirstnameMin()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //create some test data to test the valid method 
            Staff_Firstname = Staff_Firstname.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FirstnameMinPlusOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //create some test data to test the valid method 
            Staff_Firstname = Staff_Firstname.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FirstnameMaxLessOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //create some test data to test the valid method 
            Staff_Firstname = Staff_Firstname.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FirstnameMax()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //create some test data to test the valid method 
            Staff_Firstname = Staff_Firstname.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FirstnameMaxPlusOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //create some test data to test the valid method 
            Staff_Firstname = Staff_Firstname.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FirstnameMid()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //create some test data to test the valid method 
            Staff_Firstname = Staff_Firstname.PadLeft(26, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_FirstnameExtremeMax()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Firstname = "";
            //create some test data to test the valid method 
            Staff_Firstname = Staff_Firstname.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        ///// <summary>
        ///// TEST PLAN: Staff_Lastname Property
        ///// </summary>

        [TestMethod]
        public void Staff_LastnameMinLessOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_LastnameMin()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //create some test data to test the valid method 
            Staff_Lastname = Staff_Lastname.PadLeft(1, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_LastnameMinPlusOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //create some test data to test the valid method 
            Staff_Lastname = Staff_Lastname.PadLeft(2, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_LastnameMaxLessOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //create some test data to test the valid method 
            Staff_Lastname = Staff_Lastname.PadLeft(49, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_LastnameMax()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //create some test data to test the valid method 
            Staff_Lastname = Staff_Lastname.PadLeft(50, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_LastnameMaxPlusOne()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //create some test data to test the valid method 
            Staff_Lastname = Staff_Lastname.PadLeft(51, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_LastnameMid()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //create some test data to test the valid method 
            Staff_Lastname = Staff_Lastname.PadLeft(26, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_LastnameExtremeMax()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //create a variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Staff_Lastname = "";
            //create some test data to test the valid method 
            Staff_Lastname = Staff_Lastname.PadLeft(100, 'A');
            //invoke the method 
            Error = AVHCStaff.Valid(Staff_Title, Staff_Firstname, Staff_Lastname, Staff_Email, Staff_Username, Staff_Password, Staff_Role, Staff_Status);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


    }
}
