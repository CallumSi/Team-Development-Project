using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    class clsMarketplaceUserCollection
    {

        //declare private variables for use list
        List<clsMarketplaceUser> mUserList = new List<clsMarketplaceUser>();
        //declarte private variables for a specific User
        clsMarketplaceUser mThisUser = new clsMarketplaceUser();

        //get set for User list
        public List<clsMarketplaceUser> UserList
        {

            get
            {
                //return private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }

    }
}
