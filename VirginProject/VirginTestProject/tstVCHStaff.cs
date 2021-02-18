using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHStaff
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //test to see that it exists
            Assert.IsNotNull(VCHStaff);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staffs first name
            string SomeStaffFirstName = "Johann";
            //assign the data to the property
            VCHStaff.StaffFirstName = SomeStaffFirstName;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffFirstName, SomeStaffFirstName);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staffs last name
            string SomeStaffLastName = "Goethe";
            //assign the data to the property
            VCHStaff.StaffLastName = SomeStaffLastName;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffLastName, SomeStaffLastName);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staff address
            string SomeStaffAddress = "49 Frankfurt Lane, Leicester";
            //assign the data to the property
            VCHStaff.StaffAddress = SomeStaffAddress;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffAddress, SomeStaffAddress);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the post code
            string SomeStaffPostCode = "LE1 8WE";
            //assign the data to the property
            VCHStaff.StaffPostCode = SomeStaffPostCode;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffPostCode, SomeStaffPostCode);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the staff email address
            string SomeStaffEmail = "j.goethe@gmail.com";
            //assign the data to the property
            VCHStaff.StaffEmail = SomeStaffEmail;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffEmail, SomeStaffEmail);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the password
            string SomeStaffPassword = "HeiMepGre1";
            //assign the data to the property
            VCHStaff.StaffPassword = SomeStaffPassword;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffPassword, SomeStaffPassword);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create some test data to assign to the phone number
            string SomeStaffPhoneNumber = "07987654321";
            //assign the data to the property
            VCHStaff.StaffPhoneNumber = SomeStaffPhoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(VCHStaff.StaffPhoneNumber, SomeStaffPhoneNumber);
        }
    }
}
