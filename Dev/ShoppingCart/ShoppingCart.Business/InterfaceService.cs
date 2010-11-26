using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.DataAccess;
using ShoppingCart.Common;
using ShoppingCart.Object;

namespace ShoppingCart.Business
{
    public class InterfaceService
    {
        UserDAO userdao;    
        ProductDAO productdao;
        DeliveryTypeDAO deliverytypedao;
        CardTypeDAO cardtypedao;
        CategoryDAO categorydao;
        CountryDAO countrydao;
        FeedbackTypeDAO feedbacktypedao;
        PaymentTypeDAO paymenttypedao;
        StatusPaidDAO statuspaiddao;
        StatusUserDAO statususerdao;
        StatusDeliveryDAO statusdeliverydao;

        /// <summary>
        /// Init
        /// </summary>
        public InterfaceService()
        {
            userdao = new UserDAO();
            productdao = new ProductDAO();
            deliverytypedao = new DeliveryTypeDAO();
            cardtypedao = new CardTypeDAO();
            categorydao = new CategoryDAO();
            countrydao = new CountryDAO();
            feedbacktypedao = new FeedbackTypeDAO();
            paymenttypedao = new PaymentTypeDAO();
            statuspaiddao = new StatusPaidDAO();
            statususerdao = new StatusUserDAO();
            statusdeliverydao = new StatusDeliveryDAO();
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username">String</param>
        /// <param name="password">String</param>
        /// <returns>User</returns>
        public User Login(String username,String password)
        {
            if (userdao.Login(username, password) == LoginResult.Succeed)
                return GetUserDetailByUsername(username);
            else
                return new User();
        }

        /// <summary>
        /// Check login
        /// </summary>
        /// <param name="username">String</param>
        /// <param name="pass">String</param>
        /// <returns>LoginResult</returns>
        public LoginResult CheckLogin(String username, String pass)
        {
            return userdao.Login(username, pass);
        } 

        /// <summary>
        /// Payment a product
        /// </summary>
        /// <param name="productid">String</param>
        /// <param name="quantity">int</param>
        /// <returns>String</returns>
        public String PaymentAProduct(String productid, int quantity)
        {
            return productdao.GetTotalCost(productid, quantity).ToString();
        }
        
        /// <summary>
        /// Cal total product
        /// </summary>
        /// <param name="lstproduct">List</param>
        /// <returns>String</returns>
        public String PaymentTotalProduct(List<Product> lstproduct)
        {
            int money = 0;
            for (int i = 0; i < lstproduct.Count; i++)
                money = money + Convert.ToInt32(PaymentAProduct(lstproduct[i].ProducId, lstproduct[i].Quantity));
            return money.ToString();
        }
        
        /// <summary>
        /// Payment
        /// </summary>
        /// <param name="lstproduct">List</param>
        /// <param name="deliveryid">Char</param>
        /// <returns>String</returns>
        public String Payment(List<Product> lstproduct, Char deliveryid)
        {
            int totalcost = Convert.ToInt32(deliverytypedao.GetDeliveryTypeByDeliveryId(deliveryid).DeliveryCost);
            return (Convert.ToInt32(PaymentTotalProduct(lstproduct)) + totalcost)+"";

        }
   
        /// <summary>
        /// Check username exits
        /// </summary>
        /// <param name="username">String</param>
        /// <returns>Result</returns>
        public Result CheckUsernameExist(String username)
        {
            return userdao.CheckUsernameExist(username);
        }

        /// <summary>
        /// Get user by userdetail by username
        /// </summary>
        /// <param name="username">String</param>
        /// <returns>User</returns>
        private User GetUserDetailByUsername(String username)
        {
            User user = new User();
            return userdao.GetUserByUsername(username);

        }

        /// <summary>
        /// Get all card type
        /// </summary>
        /// <returns>List</returns>
        public List<CardType> GetAllCardType()
        {
            return cardtypedao.GetAll();
        }

        /// <summary>
        /// Get all feedback type
        /// </summary>
        /// <returns>List</returns>
        public List<FeedbackType> GetAllFeedbackType()
        {
            return feedbacktypedao.GetAll();
        }

        /// <summary>
        /// Get all delivery type
        /// </summary>
        /// <returns>List</returns>
        public List<DeliveryType> GetAllDeliveryType()
        {
            return deliverytypedao.GetAll();
        }

        /// <summary>
        /// Get all country
        /// </summary>
        /// <returns>List</returns>
        public List<Country> GetAllCountry()
        {
            return countrydao.GetAll();
        }

        /// <summary>
        /// Get all category
        /// </summary>
        /// <returns>List</returns>
        public List<Category> GetAllCategory()
        {
            return categorydao.GetAll();
        }

        /// <summary>
        /// Get all payment type
        /// </summary>
        /// <returns>List</returns>
        public List<PaymentType> GetAllPaymentType()
        {
            return paymenttypedao.GetAll();
        }

        /// <summary>
        /// Get all status paid
        /// </summary>
        /// <returns>List</returns>
        public List<StatusPaid> GetAllStatusPaid()
        {
            return statuspaiddao.GetAll();
        }

        /// <summary>
        /// Get all status user
        /// </summary>
        /// <returns>List</returns>
        public List<StatusUser> GetAllStatusUser()
        {
            return statususerdao.GetAll();
        }

        /// <summary>
        /// Get all status delivery
        /// </summary>
        /// <returns>List</returns>
        public List<StatusDelivery> GetAllStatusDeliveryForEmployee()
        {
            List<StatusDelivery> lststatus = statusdeliverydao.GetAll();
            List<StatusDelivery> lsttemp = new List<StatusDelivery>();
            for (int i = 0; i < lststatus.Count; i++)
            {
                if(lststatus[i].StatusDeliveryId!=Constant.STATUSDELIVERYID_NEW&&lststatus[i].StatusDeliveryId!=Constant.STATUSDELIVERYID_RETURN)
                    lsttemp.Add(lststatus[i]);
            }   
            return lsttemp;
        }
    }
}
