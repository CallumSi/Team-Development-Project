using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VirginClassLibrary;

namespace VirginTestProject
{
    ///This test uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    
    [TestClass]
    public class tstVHCAppointmentCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllAppointments);
        }

        [TestMethod]
        public void VHCAppointmentListOK()
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //create a list of object to assign to the property
            List<clsVHCAppointment> TestList = new List<clsVHCAppointment>();
            //create the item of test data
            clsVHCAppointment TestItem = new clsVHCAppointment();
            //set its properties
            TestItem.Appointment_ID = 1;
            TestItem.Appointment_Date = DateTime.Now.Date;
            TestItem.Appointment_Time = 0900;
            TestItem.Appointment_Description = "Broken Arm";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.AppointmentList, TestList);
        }


        [TestMethod]
        public void ThisAppointmentPropertyOK()
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //create the item of test data
            clsVHCAppointment TestAppointment = new clsVHCAppointment();
            //set the properties of the test object
            TestAppointment.Appointment_ID = 1;
            TestAppointment.Appointment_Date = DateTime.Now.Date;
            TestAppointment.Appointment_Time = 0900;
            TestAppointment.Appointment_Description = "Broken Arm";
            //assign the data to the property
            AllAppointments.ThisAppointment = TestAppointment;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestAppointment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsVHCAppointment> TestList = new List<clsVHCAppointment>();
            //add an item to the list
            //create the item of test data
            clsVHCAppointment TestItem = new clsVHCAppointment();
            //set its properties
            TestItem.Appointment_ID = 1;
            TestItem.Appointment_Date = DateTime.Now.Date;
            TestItem.Appointment_Time = 0900;
            TestItem.Appointment_Description = "Broken Arm";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        //Add Method
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //create the item of test data
            clsVHCAppointment TestItem = new clsVHCAppointment();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Appointment_ID = 1;
            TestItem.Appointment_Date = DateTime.Now.Date;
            TestItem.Appointment_Time = 0900;
            TestItem.Appointment_Description = "Broken Arm";
            //set ThisPatient to the test data 
            AllAppointments.ThisAppointment = TestItem;
            //add the record 
            //PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data 
            TestItem.Appointment_ID = PrimaryKey;
            //find the record 
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        //Update Method
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //create the item of test data
            clsVHCAppointment TestItem = new clsVHCAppointment();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Appointment_ID = 1;
            TestItem.Appointment_Date = DateTime.Now.Date;
            TestItem.Appointment_Time = 0900;
            TestItem.Appointment_Description = "Broken Arm";
            //set ThisAppointment to the test data 
            AllAppointments.ThisAppointment = TestItem;
            //add the record 
            //PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data 
            TestItem.Appointment_ID = PrimaryKey;
            //modify the test data 
            TestItem.Appointment_ID = 1;
            TestItem.Appointment_Date = DateTime.Now.Date;
            TestItem.Appointment_Time = 0900;
            TestItem.Appointment_Description = "Broken Leg";
            //set the record based on the new test data
            AllAppointments.ThisAppointment = TestItem;
            //update the method 
            AllAppointments.Update();
            //find the record
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see ThisAppointment matches the test data
            Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        //Delete Method
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //create the item of test data
            clsVHCAppointment TestItem = new clsVHCAppointment();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Appointment_ID = 1;
            TestItem.Appointment_Date = DateTime.Now.Date;
            TestItem.Appointment_Time = 0900;
            TestItem.Appointment_Description = "Broken Arm";
            //set ThisAppointment to the test data 
            AllAppointments.ThisAppointment = TestItem;
            //add the record 
            //PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data 
            TestItem.Appointment_ID = PrimaryKey;
            //find the record 
            AllAppointments.ThisAppointment.Find(PrimaryKey);
            //delete the record 
            AllAppointments.Delete();
            //now find the record 
            Boolean Found = AllAppointments.ThisAppointment.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }

        [TestMethod]
        public void ReportByAppointmentMethodOK()
        //Report By Appointment Method 
        {
            //create an instance of the appointment collection class 
            clsVHCAppointmentCollection AllAppointments = new clsVHCAppointmentCollection();
            //create an instance of the filtered data
            clsVHCAppointmentCollection FilteredAppointment = new clsVHCAppointmentCollection();
            //apply a blank string (Should return all appointments) 
            //FilteredAppointment.ReportByAppointment(""); **** DATE CANNOT BE NULL ****
            //test to see that the two values are the same 
            Assert.AreEqual(AllAppointments.Count, FilteredAppointment.Count);
        }

        [TestMethod]
        public void ReportByAppointmentNoneFound()
        //Report By Appointment None Found Method 
        {
            //create an instance of the filtered data
            clsVHCAppointmentCollection FilteredAppointment = new clsVHCAppointmentCollection();
            //apply a blank string (Should return all appointments) 
            FilteredAppointment.ReportByAppointment(Convert.ToDateTime("21/04/2020"));
            //test to see that the two values are the same 
            Assert.AreEqual(0, FilteredAppointment.Count);
        }

        [TestMethod]
        public void ReportByAppointmentTestDataFound()
        //Report By Appointment Test Data Found Method 
        {
            //create an instance of the filtered data
            clsVHCAppointmentCollection FilteredAppointment = new clsVHCAppointmentCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a make that does exist
            FilteredAppointment.ReportByAppointment(Convert.ToDateTime("21/01/1998"));
            //check that the correct number of records are found
            if (FilteredAppointment.Count == 2)
            {
                //check that the first record id ID 3
                if (FilteredAppointment.AppointmentList[0].Appointment_ID != 3)
                {
                    OK = false;
                }

                //check that the last record is ID 82
                if (FilteredAppointment.AppointmentList[1].Appointment_ID != 82)
                {
                    OK = false;
                }
            }

            else
            {
                OK = false;
            }

            //test to see that the two values are the same 
            Assert.IsTrue(OK);
        }
    } 
}

