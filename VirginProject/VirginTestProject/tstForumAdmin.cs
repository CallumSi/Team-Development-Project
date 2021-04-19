using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumAdmin
    {
        //create some test data to pass the method
        string AdminFirstName = "Qasim";
        string AdminLastName = "Jillani";
        string AdminEmail = "QJ@gmail.com";
        string AdminPassword = "United4Life";
        string AdminUserName = "Qasim35";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AnAdmin = new clsForumAdmin();
            //test to see that it exists
            Assert.IsNotNull(AnAdmin);
        }
        [TestMethod]
        public void AdminIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AAdmin.AdminID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAdmin.AdminID, TestData);
        }

        [TestMethod]
        public void AdminFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //create a variable to store the first name of the Admin
            string SomeAdminFirstName;
            //assign a Admin first name to the variable
            SomeAdminFirstName = "Abdi";
            //try to send some data to the admin first name property
            AAdmin.AdminFirstName = SomeAdminFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AAdmin.AdminFirstName, SomeAdminFirstName);
        }
        [TestMethod]
        public void AdminLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //create a variable to store the last name of the Admin
            string SomeAdminLastName;
            //assign a Admin last name to the variable
            SomeAdminLastName = "Suldan";
            //try to send some data to the admin last name property
            AAdmin.AdminLastName = SomeAdminLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AAdmin.AdminLastName, SomeAdminLastName);
        }
        [TestMethod]
        public void AdminEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //create a variable to store the email of the Admin
            string SomeAdminEmail;
            //assign a Admin email to the variable
            SomeAdminEmail = "Abdi@gmail.com";
            //try to send some data to the admin email
            AAdmin.AdminEmail = SomeAdminEmail;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AAdmin.AdminEmail, SomeAdminEmail);
        }
        [TestMethod]
        public void AdminPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //create a variable to store the password of the Admin
            string SomeAdminPassword;
            //assign a Admin last name to the variable
            SomeAdminPassword = "Abzzz";
            //try to send some data to the admin password property
            AAdmin.AdminPassword = SomeAdminPassword;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AAdmin.AdminPassword, SomeAdminPassword);
        }
        [TestMethod]
        public void AdminUserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //create a variable to store the user name of the Admin
            string SomeAdminUserName;
            //assign a Admin first name to the variable
            SomeAdminUserName = "Asuldan01";
            //try to send some data to the admin user name property
            AAdmin.AdminUserName = SomeAdminUserName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AAdmin.AdminUserName, SomeAdminUserName);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //boolean variable to store the result of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 AdminID = 2;
            //invoke the method
            found = AAdmin.Find(AdminID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestAdminIDFound()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminID = 2;
            //invoke the method 
            Found = AAdmin.Find(AdminID);
            //check the Admin ID 
            if (AAdmin.AdminID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdminFirstNameFound()
        {
            //create an instance of the class we want to create
            clsForumAdmin AnAdmin = new clsForumAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminID = 2;
            //invoke the method
            Found = AnAdmin.Find(AdminID);
            //check the Admin id
            if (AnAdmin.AdminFirstName != "Taf")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAdminLastNameFound()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminID = 2;
            //invoke the method
            Found = AAdmin.Find(AdminID);
            //check the Admin id
            if (AAdmin.AdminLastName != "Edward")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAdminEmailFound()
        {
            //create an instance of the class we want to create
            clsForumAdmin AAdmin = new clsForumAdmin();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AdminID = 2;
            //invoke the method
            Found = AAdmin.Find(AdminID);
            //check the Admin id
            if (AAdmin.AdminEmail != "Taf@hotmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /// <summary>
        /// first name
        /// </summary>
        [TestMethod]
        public void AdminFirstNameLessOne()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string AdminFirstName = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AdminFirstNameMaxPlusOne()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string AdminFirstName = "qwertyuiopasdfgh";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AdminFirstNameExtremeMax()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string AdminFirstName = "";
            AdminFirstName = AdminFirstName.PadRight(50, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /// <summary>
        /// last name
        /// </summary>
        [TestMethod]
        public void AdminLastNameLessOne()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string AdminLastName = "";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AdminLastNameMaxPlusOne()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string AdminLastName = "qwertyuiopasdfgh";
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AdminLastNameExtremeMax()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string AdminLastName = "";
            AdminLastName = AdminLastName.PadRight(50, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /// <summary>
        /// email
        /// </summary>
        [TestMethod]
        public void AdminEmailMaxPlussOne()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "";
            AdminEmail = AdminEmail.PadRight(26, 'a');
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AdminEmailExtremeMax()
        {
            //create an instane of the class we want to create 
            clsForumAdmin AAdmin = new clsForumAdmin();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AdminEmail = "";
            AdminEmail = AdminEmail.PadRight(50, 'a'); //this should fail
            //invoke the method
            Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }
        ///// <summary>
        ///// password
        ///// </summary>
        //[TestMethod]
        //public void AdminPasswordMaxPlussOne()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumAdmin AAdmin = new clsForumAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminPassword = "qazwsxedcrfvtgbyhnujmiklop"; //this should fail
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail, AdminPassword, AdminUserName);
        //    //test to see that the test is correct
        //    Assert.AreNotEqual(Error, "");
        //}
        //[TestMethod]
        //public void AdminPasswordExtremeMax()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumAdmin AAdmin = new clsForumAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminPassword = "";
        //    AdminPassword = AdminPassword.PadRight(50, 'a'); //this should fail
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail, AdminPassword, AdminUserName);
        //    //test to see that the test is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        ///// <summary>
        ///// User name
        ///// </summary>

        //[TestMethod]
        //public void AdminUserNameMinLessOne()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumAdmin AAdmin = new clsForumAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminUserName = "abc"; //this should fail
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail, AdminPassword, AdminUserName);
        //    //test to see that the test is correct

        //}

        //[TestMethod]
        //public void AdminUserNameMaxPlussOne()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumAdmin AAdmin = new clsForumAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminUserName = "qwertyuiopasdfgh"; //this should fail
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail, AdminPassword, AdminUserName);
        //    //test to see that the test is correct

        //}
        //[TestMethod]
        //public void AdminUserNameExtremeMax()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumAdmin AAdmin = new clsForumAdmin();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string AdminUserName = "";
        //    AdminUserName = AdminUserName.PadRight(50, 'a'); //this should fail
        //    //invoke the method
        //    Error = AAdmin.Valid(AdminFirstName, AdminLastName, AdminEmail, AdminPassword, AdminUserName);
        //    //test to see that the test is correct
        //    Assert.AreNotEqual(Error, "");
        //}
    }
}
