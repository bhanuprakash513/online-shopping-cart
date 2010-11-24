using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using ShoppingCart.DataAccess;
using ShoppingCart.Common;

namespace ShoppingCart.Business
{
    public class AdminService
    {
        FeedbackDAO feeddao;
        UnreCustomerService unrecustomerservice;
        UserDAO userdao;
        
        public AdminService()
        {
            feeddao = new FeedbackDAO();
            unrecustomerservice = new UnreCustomerService();
            userdao = new UserDAO();
        }

        public List<Feedback> ShowAllFeedback()
        {
            return feeddao.GetAllFeedback();
        }

        public Boolean AddFAQ(Feedback faq)
        {
            return feeddao.AddFAQ(faq);
        }

        public Feedback GetFeedbackFAQByFeedId(int feedid)
        {
            return feeddao.GetFeedbackFAQByFeedId(feedid);
        }

        public List<Feedback> GetFeedbackByUserId(int userid)
        {
            return feeddao.GetFeedbackByUserId(userid);
        }

        public Boolean UpdateFeedbackFAQByFeedId(Feedback feed)
        {
            return feeddao.UpdateFeedbackFAQByFeedId(feed);
        }

        public Boolean DeleteFeedbackFAQByFeedId(int feedid)
        {
            return feeddao.DeleteFeedbackFAQByFeedId(feedid);
        }

        public List<Feedback> ShowAllFAQ()
        {
            return unrecustomerservice.ShowAllFAQ();
        }

        public User ViewUserDetail(String username)
        {
           User user = new User();
           return userdao.GetUserByUsername(username);
           
        }
    }
}
