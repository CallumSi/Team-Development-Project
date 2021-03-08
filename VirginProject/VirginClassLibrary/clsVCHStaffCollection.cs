using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVCHStaffCollection
    {
        //private data member for allStaff list
        public List<clsVCHStaff> mAllStaff = new List<clsVCHStaff>();

        //public constructor for the class
        public clsVCHStaffCollection()
        {
            //create an instance of the class
            clsVCHStaff VCHStaff = new clsVCHStaff();
            //set the first customers details 
            VCHStaff.StaffFirstName = "Johann";
            VCHStaff.StaffLastName = "Goethe";
            VCHStaff.StaffAddress = "49 Frankfurt Lane, Leicester";
            VCHStaff.StaffPostCode = "LE1 8WE";
            VCHStaff.StaffUsername = "JohannGoethizzy";
            VCHStaff.StaffEmail = "j.goethe@gmail.com";
            VCHStaff.StaffPassword = "HeiMepGre1";
            VCHStaff.StaffPhoneNumber = "07987654321";
            //add the first staff to the private list of customers
            mAllStaff.Add(VCHStaff);

            //set the second customers details 
            VCHStaff.StaffFirstName = "Wolfgang";
            VCHStaff.StaffLastName = "Mozart";
            VCHStaff.StaffAddress = "56 Salzburg, Leicester";
            VCHStaff.StaffPostCode = "LE9 1VI";
            VCHStaff.StaffUsername = "AmadeusM";
            VCHStaff.StaffEmail = "w.a-mozart@gmail.com";
            VCHStaff.StaffPassword = "JoChryWoThMo5691";
            VCHStaff.StaffPhoneNumber = "07943187625";
            //add the second staff to the private list of customers
            mAllStaff.Add(VCHStaff);
        }

        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllStaff.Count;
            }
            set
            {
                //returning to this one soon
            }
        }

        //public property for allStaff
        public List<clsVCHStaff> AllStaff
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllStaff;
            }
            //setter accepts data from other object
            set
            {
                //assign the incoming value to the private data member
                mAllStaff = value;
            }
        }
    }
}