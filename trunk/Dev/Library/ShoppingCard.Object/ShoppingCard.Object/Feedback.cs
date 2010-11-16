using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
    public class Feedback
    {
        private int feedid;
        private string question;
        private string answer;
        private User usercheck;
        private FeedbackType feedtype;
        private DateTime datewrite;

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
        }
}
