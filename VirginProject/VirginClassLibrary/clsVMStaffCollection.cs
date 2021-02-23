using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsVMStaffCollection
    {
        //private data member for the list
        public List<clsVMStaff> mStaffList = new List<clsVMStaff>();

        public List<clsVMStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //private data member ThisStaff
        clsVMStaff mThisStaff = new clsVMStaff();

        //public property for ThisStaff
        public clsVMStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
    }
}