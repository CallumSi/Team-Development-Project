using System;

namespace VirginClassLibrary
{
    public class clsForumPost
    {
        //private data member for the PostID property
        private Int32 mPostID;
        //private data member for the post title property
        private string mPostTitle;
        //private data member for the Post message property
        private string mPostMessage;
        public clsForumPost()
        {
        }

        public int PostID
        {
            get
            {
                //return the private data
                return mPostID;
            }
            set
            {
                //set the value of the private data member 
                mPostID = value;
            }
        }
        public string PostTitle
        {
            get
            {
                //return the private data
                return mPostTitle;
            }
            set
            {
                //set the value of the private data member 
                mPostTitle = value;
            }
        }
        /// <summary>
        /// Comment
        /// </summary>
        /// <param name="postTitle"></param>

        public void FindPostTitle(string postTitle)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PostTitle", PostTitle);
            DB.Execute("sproc_tblForumPost_FilterbyPostTitle");
            if (DB.Count == 1)
            {
                mPostTitle = Convert.ToString(DB.DataTable.Rows[0]["PostTitle"]);

            }
            else
            {

            }
        }

        public string PostMessage
        {
            get
            {
                //return the private data
                return mPostMessage;
            }
            set
            {
                //set the value of the private data member 
                mPostMessage = value;
            }
        }

        public bool Find(int PostID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@PostID", PostID);
            //execute the stored procedure
            DB.Execute("sproc_tblForumPost_FilterByPostID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mPostID = Convert.ToInt32(DB.DataTable.Rows[0]["PostID"]);
                mPostTitle = Convert.ToString(DB.DataTable.Rows[0]["PostTitle"]);
                mPostMessage = Convert.ToString(DB.DataTable.Rows[0]["PostMessage"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false inidating a problem
                return false;
            }
        }

        public string Valid(string PostTitle, string PostMessage)
        {
            //create a string varibale to store the error
            String Error = "";
            //if the PostTitle is blank
            if (PostTitle.Length == 0)
            {
                //record the error
                Error = Error + "The post title should not be blank.";
            }
            if (PostTitle.Length > 200)
            {
                //record the error
                Error = Error + "The post title can not be more that 200 characters.";
            }

            //if the PostTitle is blank
            if (PostMessage.Length == 0)
            {
                //record the error
                Error = Error + "The PostMessage should not be blank.";
            }
            if (PostMessage.Length > 300)
            {
                //record the error
                Error = Error + "The post message can not be more that 300 characters.";
            }


            //return any error messages
            return Error;
        }
    }
}