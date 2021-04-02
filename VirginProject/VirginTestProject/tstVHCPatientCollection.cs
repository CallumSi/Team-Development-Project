using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVHCPatientCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the patient collection class 
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllPatients);
        }
    }
}
