using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVHCPatientCollection
    {
        //private data member for the list
        List<clsVHCPatient> mPatientList = new List<clsVHCPatient>();
        //private data member thisHospital
        clsVHCPatient mThisPatient = new clsVHCPatient();
    }
}