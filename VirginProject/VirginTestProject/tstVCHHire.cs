using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHHire
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the class
            clsVCHCar VCHCar = new clsVCHCar();
            //test to see that it exists
            Assert.IsNotNull(VCHCar);
        }

        [TestMethod]
        public void HireIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire ID 
            Int32 SomeHireID = 1;
            //assign the data to the property
            VCHHire.HireID = SomeHireID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireID, SomeHireID);
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire date
            DateTime SomeHireDate;
            //assign the data to the property
            SomeHireDate = Convert.ToDateTime("21/02/2021");
            //assign the data to the property
            VCHHire.HireDate = SomeHireDate;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireDate, SomeHireDate);
        }

        [TestMethod]
        public void HirePricePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire price
            decimal SomeHirePrice = 500.0M;
            //assign the data to the property
            VCHHire.HirePrice = SomeHirePrice;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HirePrice, SomeHirePrice);
        }

        [TestMethod]
        public void HireAddressPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire address pick up and drop off location
            string SomeHireAddress = "29 Hinckley Road, Leicester";
            //assign the data to the property
            VCHHire.HireAddress = SomeHireAddress;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireAddress, SomeHireAddress);
        }

        [TestMethod]
        public void HirePostCodePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire postcode pick up and drop off location
            string SomeHirePostCode = "LE3 1HR";
            //assign the data to the property
            VCHHire.HirePostCode = SomeHirePostCode;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HirePostCode, SomeHirePostCode);
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the cars ID 
            Int32 SomeCarID = 1;
            //assign the data to the property
            VCHHire.CarID = SomeCarID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.CarID, SomeCarID);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the customers ID 
            Int32 SomeCustomerID = 1;
            //assign the data to the property
            VCHHire.CustomerID = SomeCustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.CustomerID, SomeCustomerID);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the staffs ID 
            Int32 SomeStaffID = 1;
            //assign the data to the property
            VCHHire.StaffID = SomeStaffID;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.StaffID, SomeStaffID);
        }

        [TestMethod]
        public void DriverAgePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the driver age
            string SomeDriverAge = "26";
            //assign the data to the property
            VCHHire.DriverAge = SomeDriverAge;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.DriverAge, SomeDriverAge);
        }

        /*[TestMethod]
        public void DriverAgePropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the hire date
            DateTime SomeHireDate;
            //assign the data to the property 
            SomeHireDate = Convert.ToInt32("26");
            //assign the data to the property
            VCHHire.HireDate = SomeHireDate;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.HireDate, SomeHireDate);
        }*/

        [TestMethod]
        public void DriverLicenseNumberPropertyOK()
        {
            //create an instance of the class
            clsVCHHire VCHHire = new clsVCHHire();
            //create some test data to assign to the drivers license number
            string SomeDriverLicenseNumber = "ALIGH902245DA99SF21";
            //assign the data to the property
            VCHHire.DriverLicenseNumber = SomeDriverLicenseNumber;
            //test to see that the two values are the same
            Assert.AreEqual(VCHHire.DriverLicenseNumber, SomeDriverLicenseNumber);
        }
    }
}
