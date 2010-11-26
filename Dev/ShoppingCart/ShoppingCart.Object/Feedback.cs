using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{
    public class Feedback
    {
        private int feedid;
        private string question;
        private string answer;
        private User usercheck;
        private FeedbackType feedtype;
        private DateTime datewrite;

        public Feedback()
        {
            feedid = -1;
            question = "";
            answer = "";
            feedtype = new FeedbackType();
            datewrite = new DateTime();
            usercheck = new User();
        }
            

        public int FeedId
        {
            get 
            {
                return feedid;
            }
            set
            {
                feedid = value;
            }
        }
        public String Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
            }
        }
        public String Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }
        public User UserCheck
        {
            get
            {
                return usercheck;
            }
            set
            {
                usercheck = value;
            }
        }
        public FeedbackType FeedType
        {
            get 
            {
                return feedtype;
            }
            set
            {
                feedtype = value;
            }
        }
        public DateTime DateWrite
        {
            get
            {
                return datewrite;
            }
           set
            {
                datewrite = value;
            }
       }


        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="obj">obj</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(Feedback obj, DataRow row)
        {
            try
            {
                User.Mapping(obj.UserCheck,row);
                if (row[ColumnName.FEEDBACK_FEEDID] != null && row[ColumnName.FEEDBACK_FEEDID].ToString()!="")
                    obj.FeedId = Convert.ToInt32(row[ColumnName.FEEDBACK_FEEDID].ToString());
                if (row[ColumnName.FEEDBACK_QUESTION] != null && row[ColumnName.FEEDBACK_QUESTION].ToString()!="")
                    obj.Question = row[ColumnName.FEEDBACK_QUESTION].ToString();
                if (row[ColumnName.FEEDBACK_ANSWER] != null && row[ColumnName.FEEDBACK_ANSWER].ToString()!="")
                    obj.Answer = row[ColumnName.FEEDBACK_ANSWER].ToString() ;
                FeedbackType.Mapping(obj.FeedType, row);
                if (row[ColumnName.FEEDBACK_DATEWRITE] != null && row[ColumnName.FEEDBACK_DATEWRITE].ToString()!="")
                    obj.DateWrite = DateHelper.Mapping(row[ColumnName.FEEDBACK_DATEWRITE].ToString());
          
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }


        /// <summary>
        /// Mapping list
        /// </summary>
        /// <param name="obj">List</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(List<Feedback> lst, DataTable table)
        {
            Feedback obj;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                obj = new Feedback();
                Mapping(obj, table.Rows[i]);
                lst.Add(obj);
            }
        }
    }
}
