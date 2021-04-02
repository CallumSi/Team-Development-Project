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

        [TestMethod]
        public void ThisPatientPropertyOK()
        {
            //create an instance of the patient collection class 
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //create some test data to assign to the property
            clsVHCPatient TestPatient = new clsVHCPatient();
            //set the properties of the test object
            TestPatient.Patient_ID = 1;
            TestPatient.Patient_Title = "Miss";
            TestPatient.Patient_Firstname = "Lia";
            TestPatient.Patient_Lastname = "Potter";
            TestPatient.Patient_Address = "42 Western Road, Leicestershire";
            TestPatient.Patient_DOB = DateTime.Now.Date;
            TestPatient.Patient_Email = "LiaPotter@gmail.com";
            TestPatient.Patient_Username = "LiaPotter1";
            TestPatient.Patient_Password = "LiaP010101";
            TestPatient.Patient_Telephone = "01164891276";
            TestPatient.Patient_Telephone = "01164891276";
            TestPatient.Patient_Status = true;
            //assign the data to the property
            AllPatients.ThisPatient = TestPatient;
            //test to see that the two values are the same
            Assert.AreEqual(AllPatients.ThisPatient, TestPatient);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the patient collection class 
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsVHCPatient> TestList = new List<clsVHCPatient>();
            //add an item to the list
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
            Assert.AreEqual(AllPatients.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        //Add Method
        {
            //create an instance of the patient collection class 
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //create some test data to assign to the property
            clsVHCPatient TestItem = new clsVHCPatient();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
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
            //set ThisPatient to the test data 
            AllPatients.ThisPatient = TestItem;
            //add the record 
            PrimaryKey = AllPatients.Add();
            //set the primary key of the test data 
            TestItem.Patient_ID = PrimaryKey;
            //find the record 
            AllPatients.ThisPatient.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllPatients.ThisPatient, TestItem);
        }
    }
}
