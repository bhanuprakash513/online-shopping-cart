using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data.SqlClient;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.DataAccess
{
    public class FeedbackDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GET_ALL
            {
                get
                {
                    return "SELECT Feedback.FeedId,Feedback.Question,Feedback.Answer,Feedback.UserId,Feedback.FeedTypeId,Feedback.DateWrite, " +
            " [User].Username,[User].Password,[User].Fullname,[User].Gender,[User].Address,[User].Email,[User].RoleId,[User].PhoneNumber,[User].StatusId, " +
            " FeedbackType.FeedTypeName,[Role].RoleName,StatusUser.StatusUserName " +
            " FROM Feedback,[User],FeedbackType,[Role],StatusUser " +
            " WHERE [User].UserId=Feedback.UserId AND FeedbackType.FeedTypeId=Feedback.FeedTypeId AND [Role].RoleId=[User].RoleId AND StatusUser.StatusUserId=[User].StatusId ";
                }
            }

            public static String GET_ALL_FEEDBACKTYPEID
            {
                get
                {
                    return GET_ALL + "  AND FeedbackType.FeedTypeId=@FeedTypeId";
                }
            }

            public static String GET_ALL_FEEDBACK_BY_USERID
            {
                get
                {
                    return GET_ALL + " AND FeedbackType.FeedTypeId=" + Constant.FEEDBACK_TYPE_ID + " AND Feedback.UserId=@UserId ";
                }
            }

            public static String GET_FEEDBACK_BY_FEEDID
            {
                get
                {
                    return "SELECT Feedback.FeedId,Feedback.Question,Feedback.Answer,Feedback.UserId,Feedback.FeedTypeId,Feedback.DateWrite, " +
            " [User].Username,[User].Password,[User].Fullname,[User].Gender,[User].Address,[User].Email,[User].RoleId,[User].PhoneNumber,[User].StatusId, " +
            " FeedbackType.FeedTypeName,[Role].RoleName,StatusUser.StatusUserName " +
            " FROM Feedback,[User],FeedbackType,[Role],StatusUser " +
            " WHERE [User].UserId=Feedback.UserId AND FeedbackType.FeedTypeId=Feedback.FeedTypeId AND [Role].RoleId=[User].RoleId AND StatusUser.StatusUserId=[User].StatusId AND Feedback.FeedId=@FeedId";

                }
            }

            public static String INSERT_FEEDBACK
            {
                get
                {
                    return "INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId,DateWrite) "+
                           " VALUES (@Question,@Answer,@UserId,@FeedTypeId,GETDATE())";
                }
            }

            public static String UPDATE_FEEDBACK
            {
                get
                {
                    return "UPDATE Feedback SET Question=@Question,Answer=@Answer " +
                        " WHERE FeedId=@FeedId";
                }
            }

            public static String DELETE_FEEDBACK
            {
                get
                {
                    return "DELETE Feedback WHERE FeedId=@FeedId";
                }
            }
        }

        /// <summary>
        /// Get All feedback by feed type id
        /// </summary>
        /// <param name="feedtypeid">int</param>
        /// <returns>List</returns>
        public List<Feedback> GetAllByFeedTypeId(int feedtypeid)
        {
            List<Feedback> lstfeedback = new List<Feedback>();
            
            this. paramCollection = new SqlParameter[1];
            DataTable table = new DataTable();
            this.paramCollection[0] =new SqlParameter("FeedTypeId",feedtypeid);
            this.Fill(QUERY.GET_ALL_FEEDBACKTYPEID, this.paramCollection, table);
            if(table.Rows.Count>0)
                Feedback.Mapping(lstfeedback, table);
            return lstfeedback;
        }

        /// <summary>
        /// Get All FAQ
        /// </summary>
        /// <returns>List</returns>
        public List<Feedback> GetAllFAQ()
        {
            return this.GetAllByFeedTypeId(Constant.FAQ_TYPE_ID);
        }

        /// <summary>
        /// Get All Feedback
        /// </summary>
        /// <returns>List</returns>
        public List<Feedback> GetAllFeedback()
        {
            return this.GetAllByFeedTypeId(Constant.FEEDBACK_TYPE_ID);
        }
        

        /// <summary>
        /// Add a non-feedback type
        /// </summary>
        /// <param name="feed">Feedback</param>
        /// <returns>Boolean</returns>
        public Boolean AddFeedbackFAQ(Feedback feed)
        {
            this.paramCollection = new SqlParameter[4];
            this.paramCollection[0] = new SqlParameter("Question", feed.Question.Trim());
            this.paramCollection[1] = new SqlParameter("Answer", feed.Answer.Trim());
            this.paramCollection[2] = new SqlParameter("UserId", feed.UserCheck.UserId);
            this.paramCollection[3] = new SqlParameter("FeedTypeId", feed.FeedType.FeedTypeId);
            return this.ExecuteNonQuery(QUERY.INSERT_FEEDBACK, paramCollection);
        }

        /// <summary>
        /// Add a feedback
        /// </summary>
        /// <param name="feed">Feedback</param>
        /// <returns>Boolean</returns>
        public Boolean AddFeedback(Feedback feed)
        {
            feed.FeedType.FeedTypeId=Constant.FEEDBACK_TYPE_ID;
            return this.AddFeedbackFAQ(feed);
        }

        /// <summary>
        /// Add a FAQ
        /// </summary>
        /// <param name="feed">Feedback</param>
        /// <returns>Boolean</returns>
        public Boolean AddFAQ(Feedback feed)
        {
            feed.FeedType.FeedTypeId = Constant.FAQ_TYPE_ID;
            return this.AddFeedbackFAQ(feed);
            
        }

        /// <summary>
        /// Get detail a non type feedback
        /// </summary>
        /// <param name="feedid">int</param>
        /// <returns>Feedback</returns>
        public Feedback GetFeedbackFAQByFeedId(int feedid)
        {
            Feedback feed= new Feedback();
            this.paramCollection = new SqlParameter[1];
            DataTable table = new DataTable();
            this.paramCollection[0] = new SqlParameter("FeedId", feedid);
            this.Fill(QUERY.GET_FEEDBACK_BY_FEEDID, this.paramCollection, table);
            if (table.Rows.Count > 0)
            {
                Feedback.Mapping(feed, table.Rows[0]);
            }
            return feed;
        }


        /// <summary>
        /// Get Feedback by userid
        /// </summary>
        /// <param name="userid">int</param>
        /// <returns>List</returns>
        public List<Feedback> GetFeedbackByUserId(int userid)
        {
            List<Feedback> lstfeed = new List<Feedback>();
            this.paramCollection = new SqlParameter[1];
            DataTable table = new DataTable();
            this.paramCollection[0] = new SqlParameter("UserId", userid);
            this.Fill(QUERY.GET_ALL_FEEDBACK_BY_USERID, this.paramCollection, table);
            if (table.Rows.Count > 0)
            {
                Feedback.Mapping(lstfeed, table);
            }
            return lstfeed;
        }


        /// <summary>
        /// Update feedback by Id
        /// </summary>
        /// <param name="feed">Feedback</param>
        /// <returns>Boolean</returns>
        public Boolean UpdateFeedbackFAQByFeedId(Feedback feed)
        {
            this.paramCollection = new SqlParameter[3];
            this.paramCollection[0] = new SqlParameter("Question", feed.Question.Trim());
            this.paramCollection[1] = new SqlParameter("Answer", feed.Answer.Trim());
            this.paramCollection[2] = new SqlParameter("FeedId", feed.FeedId);
            return this.ExecuteNonQuery(QUERY.UPDATE_FEEDBACK, paramCollection);
        }


        /// <summary>
        /// Delete feedback by id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Boolean</returns>
        public Boolean DeleteFeedbackFAQByFeedId(int feedid)
        {
            this.paramCollection = new SqlParameter[1];
            this.paramCollection[0] = new SqlParameter("FeedId", feedid);
            return this.ExecuteNonQuery(QUERY.DELETE_FEEDBACK, paramCollection);
        }


    }
}
