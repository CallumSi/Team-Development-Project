using System;

namespace VirginClassLibrary
{
    public class clsVHCStaff
    {
        //Staff_ID roperty
        public int Staff_ID { get; set; }

        //Staff_Title Property
        public string Staff_Title { get; set; }

        //Staff_Firstname Property
        public string Staff_Firstname { get; set; }

        //Staff_Lastname Property
        public string Staff_Lastname { get; set; }

        //Staff_Email Property
        public string Staff_Email { get; set; }

        //Staff_Username Property
        public string Staff_Username { get; set; }

        //Staff_Password Property
        public string Staff_Password { get; set; }

        //Staff_Role Property
        public string Staff_Role { get; set; }

        //Staff_Status Property
        public bool Staff_Status { get; set; }

        public string Valid(string staff_Title, string staff_Firstname, string staff_Lastname, string staff_Email, string staff_Username, string staff_Password, string staff_Role, string staff_Status)
        {
            String Error = ""; 

            return Error; 
        }
    }
}