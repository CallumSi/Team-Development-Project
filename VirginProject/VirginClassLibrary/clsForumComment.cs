using System;

namespace VirginClassLibrary
{
    public class clsForumComment
    {

        //private data member for the PostID property
        private Int32 mCommentID;
        //private data member for the PostID property
        private string mCommentMessage;
        //private data member for the PostID property
        private string mPostID;

        public int CommentID
        {
            get
            {
                //return the private data
                return mCommentID;
            }
            set
            {
                //set the value of the private data member 
                mCommentID = value;
            }
        }
        public string CommentMessage
        {
            get
            {
                //return the private data
                return mCommentMessage;
            }
            set
            {
                //set the value of the private data member 
                mCommentMessage = value;
            }
        }
        public string PostID
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


        public bool Find(int CommentID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@CommentID", CommentID);
            //execute the stored procedure
            DB.Execute("sproc_tblForumComment_FilterByCommentID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mCommentID = Convert.ToInt32(DB.DataTable.Rows[0]["CommentID"]);
                mCommentMessage = Convert.ToString(DB.DataTable.Rows[0]["CommentMessage"]);
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

        public string Valid(string CommentMessage)
        {
            //create a string varibale to store the error
            String Error = "";
            //if the PostTitle is blank
            if (CommentMessage.Length == 0)
            {
                //record the error
                Error = Error + "The Comment should not be blank.";
            }
            if (CommentMessage.Length > 300)
            {
                //record the error
                Error = Error + "The comment can not be more that 300 characters.";
            }
            //return any error messages
            return Error;
        }

    }

}