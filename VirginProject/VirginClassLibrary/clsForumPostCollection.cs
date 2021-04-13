using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsForumPostCollection
    {


        //private data member for the list
        List<clsForumPost> mPostList = new List<clsForumPost>();
        //private data menmber thisPost
        clsForumPost mThisPost = new clsForumPost();
        public List<clsForumPost> PostList
        {
            get
            {
                //return the private data
                return mPostList;
            }
            set
            {
                //set the private data
                mPostList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mPostList.Count;
            }
            set
            {

            }
        }

        public clsForumPost ThisPost
        {
            get
            {
                return mThisPost;
            }
            set
            {
                mThisPost = value;
            }
        }



        //constructor for the class
        public clsForumPostCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblForumPost_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the values of the mthisPost
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaeters for the stored procedure
            DB.AddParameter("@PostTitle", mThisPost.PostTitle);
            DB.AddParameter("@PostMessage", mThisPost.PostMessage);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblForumPost_Insert");
        }



        public void Delete()
        {
            //delete the record pointed to by thisPost
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PostID", mThisPost.PostID);
            //execute the stored procedure 
            DB.Execute("sproc_tblForumPost_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisPost
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procdure 
            DB.AddParameter("@PostID", mThisPost.PostID);
            DB.AddParameter("@PostTitle", mThisPost.PostTitle);
            DB.AddParameter("@PostMessage", mThisPost.PostMessage);
            //execute the stored procedure
            DB.Execute("sproc_tblForumPost_Update");
        }

        public void ReportByPostTitle(string PostTitle)
        {
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //sent the Userusername parameter to the database
            DB.AddParameter("@PostTitle", PostTitle);
            //execute the stored procedure
            DB.Execute("sproc_tblForumPost_FilterbyPostTitle");
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
            mPostList = new List<clsForumPost>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank post
                clsForumPost AnPost = new clsForumPost();
                //read in the fields from the current record
                AnPost.PostID = Convert.ToInt32(DB.DataTable.Rows[Index]["PostID"]);
                AnPost.PostTitle = Convert.ToString(DB.DataTable.Rows[Index]["PostTitle"]);
                AnPost.PostMessage = Convert.ToString(DB.DataTable.Rows[Index]["PostMessage"]);
                mPostList.Add(AnPost);
                //point at the next record
                Index++;
            }
        }
        /// <summary>
        /// comment
        /// </summary>
        /// <param name="postTitle"></param>
        /// <param name="comment"></param>
        /// 
        //public void AddComment(int PostID,  string comment)
        //{
        //    //reinitalise the data connection
        //    clsDataConnection DB = new clsDataConnection();
        //    //send the procedure to the parameters
        //    DB.AddParameter("@PostID", PostID);
        //    DB.AddParameter("@CommentMessage", comment);
        //    //add the new record
        //    DB.Execute("sproc_tblForumComment_Insert");
        //}
    }
}