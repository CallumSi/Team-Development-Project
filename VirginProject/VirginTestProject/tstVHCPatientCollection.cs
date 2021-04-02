using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void VHCPatientListOK()
        {
            //create an instance of the patient collection class 
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //create a list of object to assign to the property
            List<clsVHCPatient> TestList = new List<clsVHCPatient>();
            //create the item of test data
            clsVHCPatient TestItem = new clsVHCPatient();
            //set its properties
            TestItem.Patient_ID = 1;
            TestItem.Patient_Title = "Miss";
            TestItem.Patient_Firstname = "Lia";
            TestItem.Patient_Lastname = "Potter";
            TestItem.Patient_Address = "42 Western Road, Leicestershire";
            TestItem.Patient_DOB = DateTime.Now.Date;
            TestItem.Patient_Email = "LiaPotter@gmail.com";
            TestItem.Patient_Username = "LiaPotter1";
            TestItem.Patient_Password = "LiaP010101";
            TestItem.Patient_Telephone = "01164891276";
            TestItem.Patient_Telephone = "01164891276";
            TestItem.Patient_Status = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPatients.PatientList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPatients.PatientList, TestList);
        }
    }
}
