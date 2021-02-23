using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumAdmin
    {
        ////create some test data to pass the method
        //string AdminFirstname = "Robin";
        //string AdinUserName = "RVP20";
        //string AdminLastName = "Vanpersie";
        //string UserEmailAddress = "RVP@gmail.com";
        //string UserPassword = "United4RVP";

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
        //[TestMethod]
        //public void FindMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsForumAdmin AAdmin = new clsForumAdmin();
        //    //boolean variable to store the result of the validation
        //    Boolean found = false;
        //    //create some test data to use with the method
        //    Int32 AdminID = 1;
        //    //invoke the method
        //    found = AAdmin.Find(AdminID);
        //    //test to see that the result is correct
        //    Assert.IsTrue(found);
        //}
        //[TestMethod]
        //public void TestAdminIDFound()
        //{
        //    //create an instance of the class we want to create
        //    clsForumAdmin AAdmin = new clsForumAdmin();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 AdminID = 1;
        //    //invoke the method
        //    Found = AAdmin.Find(AdminID);
        //    //check the Admin id
        //    if (AAdmin.AdminID != 1)
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}
    }
}
