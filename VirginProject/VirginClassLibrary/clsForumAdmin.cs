using System;

namespace VirginClassLibrary
{
    public class clsForumAdmin
    {
        public clsForumAdmin()
        {
        }

        public int AdminID { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string AdminUserName { get; set; }

        public bool Find(int AdminID)
        {
            return true;
        }

        public string Valid(string AdminFirstName, string AdminLastName, string AdminEmail, string AdminPassword, string AdminUserName)
        {
            return "";
        }
    }
}