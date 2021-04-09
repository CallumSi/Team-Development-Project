using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of AnUser
            clsUser AnUser = new clsUser();
            string TestData = "Callum";
            //assign the data to the property
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);

        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of AnUser
            clsUser AnUser = new clsUser();
            string TestData = "Pass1#";
            //assign the data to the property
            AnUser.UserPassword = TestData;
            Assert.AreEqual(AnUser.UserPassword, TestData);

        }

    }
}
