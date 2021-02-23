using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMStaff
    {
        //create some test data to test the valid method
        string VMstaffFirstName = "Mike";
        string VMstaffLastName = "Jordan";
        string VMstaffEmail = "MikeJordan@gmail.com";
        string VMstaffPassword = "Mike6Jordan";
        string VMstaffPosition = "Helper";

        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);

        }

        [TestMethod]
        public void VMStaffIDPropertyOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.VMstaffID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStaff.VMstaffID, TestData);
        }

        [TestMethod]
        public void VMStaffFirstNamePropertyOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a variable to store the first name of the staff
            string SomeVMstaffFirstName;
            //try send some data to the staff firstname property
            SomeVMstaffFirstName = "Mike";
            //try send some data to the VMstaffFirstName property
            AStaff.VMstaffFirstName = SomeVMstaffFirstName;
            //check to see that the data in the variable are the property are the same
            Assert.AreEqual(AStaff.VMstaffFirstName, SomeVMstaffFirstName);
        }

        [TestMethod]
        public void VMStaffLastNamePropertyOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a variable to store the lastname of the staff
            string SomeVMstaffLastName;
            //try send some data to the staff lastname property
            SomeVMstaffLastName = "Jordan";
            //try send some data to the VMcustomerLastName property
            AStaff.VMstaffLastName = SomeVMstaffLastName;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AStaff.VMstaffLastName, SomeVMstaffLastName);
        }

        [TestMethod]
        public void VMStaffEmailPropertyOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a variable to store the email of the staff
            string SomeVMstaffEmail;
            //try send some data to the staff email property
            SomeVMstaffEmail = "MikeJordan@gmail.com";
            //try send some data to the VMstaffEmail property
            AStaff.VMstaffEmail = SomeVMstaffEmail;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AStaff.VMstaffEmail, SomeVMstaffEmail);
        }

        [TestMethod]
        public void VMStaffPasswordPropertyOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a variable to store the password of the staff
            string SomeVMstaffPassword;
            //try send some data to the staff password property
            SomeVMstaffPassword = "Mike6Jordan";
            //try send some data to the VMstaffPassword property
            AStaff.VMstaffPassword = SomeVMstaffPassword;
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AStaff.VMstaffPassword, SomeVMstaffPassword);
        }

        [TestMethod]
        public void VMStaffPositionPropertyOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a variable to store the position of the customer
            string SomeVMstaffPosition;
            //try send some data to the customer position property
            SomeVMstaffPosition = "Helper";
            //try send some data to the VMstaffPosition property
            AStaff.VMstaffPosition = SomeVMstaffPosition;            
            //check to see that the data in the variable are thr property are the same
            Assert.AreEqual(AStaff.VMstaffPosition, SomeVMstaffPosition);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            string VMstaffFirstName = "Mike";
            string VMstaffLastName = "Jordan";
            string VMstaffEmail = "MikeJordan@gmail.com";
            //string VMstaffPassword = "Mike6Jordan";
            //string VMstaffPosition = "Helper";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffFirstNameMinLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMstaffFirstName = "";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffFirstNameMin()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffFirstName = "M";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffFirstNameMinPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffFirstName = "Mi";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffFirstNameMaxLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffFirstName = "";
            //create some test data to test the valid method 
            VMstaffFirstName = VMstaffFirstName.PadRight(54, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffFirstNameMid()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffFirstName = "";
            //create some test data to test the valid method 
            VMstaffFirstName = VMstaffFirstName.PadLeft(22, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffFirstNameMaxPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffFirstName = "";
            //create some test data to test the valid method 
            VMstaffFirstName = VMstaffFirstName.PadLeft(56, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffFirstNameExtremeMax()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffFirstName = "";
            //create some test data to test the valid method 
            VMstaffFirstName = VMstaffFirstName.PadLeft(100, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffLastNameMinLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMstaffLastName = "";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffLastNameMin()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffLastName = "J";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffLastNameMinPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffLastName = "Jo";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VVMstaffLastNameMaxLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffLastName = "";
            //create some test data to test the valid method 
            VMstaffLastName = VMstaffLastName.PadRight(54, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffLastNameMid()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffLastName = "";
            //create some test data to test the valid method 
            VMstaffLastName = VMstaffLastName.PadLeft(22, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffLastNameMaxPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffLastName = "";
            //create some test data to test the valid method 
            VMstaffLastName = VMstaffLastName.PadLeft(56, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffLastNameExtremeMax()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffLastName = "";
            //create some test data to test the valid method 
            VMstaffLastName = VMstaffLastName.PadLeft(100, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffEmailMinLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffEmail = "";
            //create some test data to test the valid method 
            VMstaffEmail = VMstaffEmail.PadLeft(10, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffEmailMin()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffEmail = "";
            //create some test data to test the valid method 
            VMstaffEmail = VMstaffEmail.PadLeft(11, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffEmailMinPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffEmail = "";
            //create some test data to test the valid method 
            VMstaffEmail = VMstaffEmail.PadLeft(12, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffEmailMaxLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffEmail = "";
            //create some test data to test the valid method 
            VMstaffEmail = VMstaffEmail.PadLeft(54, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffmailMid()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffEmail = "";
            //create some test data to test the valid method 
            VMstaffEmail = VMstaffEmail.PadLeft(22, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffEmailPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffEmail = "";
            //create some test data to test the valid method 
            VMstaffEmail = VMstaffEmail.PadLeft(56, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffEmailExtremeMax()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffEmail = "";
            //create some test data to test the valid method 
            VMstaffEmail = VMstaffEmail.PadLeft(100, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPasswordMinLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMstaffPassword = "Mike6J";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPasswordeMin()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffPassword = "Mike6Jo";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPasswordMinPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffPassword = "Mike6Jor";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPasswordMaxLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPassword = "";
            //create some test data to test the valid method 
            VMstaffPassword = VMstaffPassword.PadLeft(54, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPasswordMid()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPassword = "";
            //create some test data to test the valid method 
            VMstaffPassword = VMstaffPassword.PadLeft(22, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPasswordPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPassword = "";
            //create some test data to test the valid method 
            VMstaffPassword = VMstaffPassword.PadLeft(56, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPasswordExtremeMax()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPassword = "";
            //create some test data to test the valid method 
            VMstaffPassword = VMstaffPassword.PadLeft(100, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPositionMinLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the valid method 
            String VMstaffPosition = "Admi";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPositionMin()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffPosition = "Admin";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPositionMinPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to pass the method
            string VMstaffPosition = "Adminn";
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPositionMaxLessOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPosition = "";
            //create some test data to test the valid method 
            VMstaffPosition = VMstaffPosition.PadLeft(54, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPositionMid()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPosition = "";
            //create some test data to test the valid method 
            VMstaffPosition = VMstaffPosition.PadLeft(22, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPositionPlusOne()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPosition = "";
            //create some test data to test the valid method 
            VMstaffPosition = VMstaffPosition.PadLeft(56, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VMstaffPositionExtremeMax()
        {
            //create an instance of the staff class
            clsVMStaff AStaff = new clsVMStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create a variable to store the test data
            string VMstaffPosition = "";
            //create some test data to test the valid method 
            VMstaffPosition = VMstaffPosition.PadLeft(100, 'A');
            //invoke the method
            Error = AStaff.Valid(VMstaffFirstName, VMstaffLastName, VMstaffEmail, VMstaffPassword, VMstaffPosition);
            //Test to see that the result is OK i.e no error message returned
            Assert.AreNotEqual(Error, "");
        }
    }
}
