using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMCustomer
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the customer class
            clsVMCustomer ACustomer = new clsVMCustomer();
        }
    }
}
