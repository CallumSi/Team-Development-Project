using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHStaff
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a variable to store the customers first name 
            string SomeFirstName;
            //assign a FirstName to the variable
            SomeFirstName = "Johann";
            //try send data to the FirstName property
            VCHStaff.FirstName = SomeFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHStaff.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a variable to store the customers first name 
            string SomeLastName;
            //assign a LastName to the variable
            SomeLastName = "Goethe";
            //try send data to the LastName property
            VCHStaff.LastName = SomeLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHStaff.LastName, SomeLastName);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a variable to store the customers address
            string SomeAddress;
            //assign an Address to the variable
            SomeAddress = "17 Frankfurt Lane, Leicester";
            //try send data to the Address property
            VCHStaff.Address = SomeAddress;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHStaff.Address, SomeAddress);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //create a variable to store the customers phone number
            string SomePhoneNumber;
            //assign a PhoneNumber to the variable
            SomePhoneNumber = "07987654321";
            //try send data to the PhoneNumber property
            VCHStaff.PhoneNumber = SomePhoneNumber;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHStaff.PhoneNumber, SomePhoneNumber);
        }

    }
}

