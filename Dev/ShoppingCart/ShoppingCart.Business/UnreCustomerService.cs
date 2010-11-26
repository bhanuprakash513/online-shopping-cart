using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using ShoppingCart.DataAccess;
using ShoppingCart.Common;

namespace ShoppingCart.Business
{
    public class UnreCustomerService
    {
        FeedbackDAO feeddao;
        ProductDAO productDAO;
        UserDAO userdao;

        /// <summary>
        /// Init
        /// </summary>
        public UnreCustomerService()
        {
            productDAO = new ProductDAO();
            feeddao = new FeedbackDAO();
            userdao = new UserDAO();
        }

        /// <summary>
        /// Get all FAQ
        /// </summary>
        /// <returns>List</returns>
        public List<Feedback> GetAllFAQ()
        {
            return feeddao.GetAllFAQ();
        }

        /// <summary>
        /// Get product by product name
        /// </summary>
        /// <param name="productname">String</param>
        /// <returns>Database.ProductCategoryDataTable</returns>
        public Database.ProductCategoryDataTable GetProductByProductName(String productname)
        {
            return productDAO.GetProductByProductName(productname);
        }

        /// <summary>
        /// Get product by category
        /// </summary>
        /// <param name="category">String</param>
        /// <returns>Database.ProductCategoryDataTable</returns>
        public Database.ProductCategoryDataTable GetProductByCategory(String category)
        {
            return productDAO.GetProductByCategory(category);
        }

        /// <summary>
        /// View FAQ Detail
        /// </summary>
        /// <param name="feedid">int</param>
        /// <returns>Feedback</returns>
        public Feedback ViewFAQDetail(int feedid)
        {
            Feedback feed=feeddao.GetFeedbackFAQByFeedId(feedid);
            if (feed.FeedType.FeedTypeId == Constant.FAQ_TYPE_ID)
                return feed;
            return new Feedback();
        }

        /// <summary>
        /// Register customer
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <return>Boolean</returns>
        public Boolean Register(Customer customer)
        {
            return userdao.AddUser(customer);
        }
    }

}
