using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVHCPatient
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient(); 
        }
    }
}
