using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using ShoppingCart.DataAccess;

namespace ShoppingCart.Business
{
    public class UnreCustomerService
    {
        FeedbackDAO feeddao;
        public UnreCustomerService()
        {
            feeddao = new FeedbackDAO();
        }


        public List<Feedback> ShowAllFAQ()
        {
            return feeddao.GetAllFAQ();
        }
    }
}
