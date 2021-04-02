﻿using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVHCPatientCollection
    {
        //private data member for the list
        List<clsVHCPatient> mPatientList = new List<clsVHCPatient>();
        //private data member thisHospital
        clsVHCPatient mThisPatient = new clsVHCPatient();

        public List<clsVHCPatient> PatientList
        {
            get
            {
                //return the private data
                return mPatientList;
            }

            set
            {
                //set the private data 
                mPatientList = value;
            }
        }

        public clsVHCPatient ThisPatient
        {
            get
            {
                //return the private data 
                return mThisPatient;
            }

            set
            {
                //set the private data 
                mThisPatient = value;

            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mPatientList.Count;
            }
            set
            {

            }
        }
    }
}