using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVCHCustomer
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
        }

        [TestMethod]
        public void FirstName()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers first name 
            string SomeFirstName;
            //assign a FirstName to the variable
            SomeFirstName = "Dante";
            //try send data to the FirstName property
            VCHCustomer.FirstName = SomeFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastName()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //create a variable to store the customers first name 
            string SomeLastName;
            //assign a LastName to the variable
            SomeLastName = "Alighieri";
            //try send data to the LastName property
            VCHCustomer.LastName = SomeLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(VCHCustomer.LastName, SomeLastName);
        }

        //leaving work at this stage because my tests aren't running anymore. All I'm getting is a blue exclamation mark
    }
}
