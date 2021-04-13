using System.Collections.Generic;
using System;
namespace VirginClassLibrary
{
    public class clsForumCommentCollection
    {

        //private data memeber for the list
        List<clsForumComment> mCommentList = new List<clsForumComment>();
        //private data menmber thisPost
        clsForumComment mThisComment = new clsForumComment();
        //public property for the comment list
        public List<clsForumComment> CommentList
        {
            get
            {
                //return the private data
                return mCommentList;
            }
            set
            {
                //set the priavte date
                mCommentList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCommentList.Count;
            }

        }

        public clsForumComment ThisComment
        {
            get
            {
                return mThisComment;
            }
            set
            {
                mThisComment = value;
            }
        }

        public void Delete()
        {
            //delete the record pointed to by thisPost
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CommentID", mThisComment.CommentID);
            //execute the stored procedure 
            DB.Execute("sproc_tblForumComment_Delete");
        }

        //constructor for the class
        public clsForumCommentCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblForumComment_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {

            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count record
            RecordCount = DB.Count;
            //clear the private array list
            mCommentList = new List<clsForumComment>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank post
                clsForumComment AnComment = new clsForumComment();
                //read in the fields from the current record
                AnComment.CommentID = Convert.ToInt32(DB.DataTable.Rows[Index]["CommentID"]);
                AnComment.CommentMessage = Convert.ToString(DB.DataTable.Rows[Index]["CommentMessage"]);
                mCommentList.Add(AnComment);
                //point at the next record
                Index++;
            }
        }
        public void AddComment(int PostID, string comment)
        {
            //reinitalise the data connection
            clsDataConnection DB = new clsDataConnection();
            //send the procedure to the parameters
            DB.AddParameter("@PostID", PostID);
            DB.AddParameter("@CommentMessage", comment);
            //add the new record
            DB.Execute("sproc_tblForumComment_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisPost
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procdure 
            DB.AddParameter("@CommentID", mThisComment.CommentID);
            DB.AddParameter("@CommentMessage", mThisComment.CommentMessage);
            //execute the stored procedure
            DB.Execute("sproc_tblForumComment_Update");
        }
    }
}