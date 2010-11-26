using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using ShoppingCart.DataAccess;
using ShoppingCart.Common;

namespace ShoppingCart.Business
{
    public class ReCustomerService : UnreCustomerService
    {
        FeedbackDAO feeddao;
        OrderDAO orderdao;
        ProductDAO productdao;
        DeliveryTypeDAO deliverytypedao;
        PaymentDetailDAO paydetaildao;
        OrderItemDAO orderitemdao;
        UserDAO userdao;

        /// <summary>
        /// Init
        /// </summary>
        public ReCustomerService()
        {
            feeddao = new FeedbackDAO();
            orderdao = new OrderDAO();
            productdao = new ProductDAO();
            deliverytypedao = new DeliveryTypeDAO();
            paydetaildao = new PaymentDetailDAO();
            orderitemdao = new OrderItemDAO();
            userdao = new UserDAO();
        }

        /// <summary>
        /// Get all feedback
        /// </summary>
        /// <returns>List</returns>
        public List<Feedback> GetAllFeedback()
        {
            return feeddao.GetAllFeedback();
        }

        /// <summary>
        /// Add a feedback
        /// </summary>
        /// <param name="feed">Feedback</param>
        /// <returns>Boolean</returns>
        public Boolean CreateFeedback(Feedback feed)
        {
            if(feed.FeedType.FeedTypeId==Constant.FEEDBACK_TYPE_ID)
                return feeddao.AddFeedback(feed);
            return false;
        }

        /// <summary>
        /// View feedback detail
        /// </summary>
        /// <param name="feedid">int</param>
        /// <returns>Feedback</returns>
        public Feedback ViewFeedbackDetail(int feedid)
        {
            Feedback feedback=feeddao.GetFeedbackFAQByFeedId(feedid);
            if (feedback.FeedType.FeedTypeId == Constant.FEEDBACK_TYPE_ID)
                return feedback;
            return new Feedback();
        }
        
        /// <summary>
        /// View order detail
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>Order</returns>
        public Order ViewOrderDetail(int orderid)
        {

            Order order=orderdao.GetOrderByOrderId(orderid);
            if (order.PaymentInfor.PayType.PayTypeId == Constant.PAYMENTTYPE_CC)
                order.PaymentCCInfor = paydetaildao.GetPaymentCreditCardByOrderId(orderid);
            else if (order.PaymentInfor.PayType.PayTypeId == Constant.PAYMENTTYPE_CHEQUE)
                order.PaymentChequeInfor = paydetaildao.GetPaymentChequeByOrderId(orderid);
            else if (order.PaymentInfor.PayType.PayTypeId == Constant.PAYMENTTYPE_DD)
                order.PaymentDDInfor = paydetaildao.GetPaymentDemandDraftByOrderId(orderid);
            return order;
        }
        
        /// <summary>
        /// Show all order
        /// </summary>
        /// <param name="custid">int</param>
        /// <returns>List</returns>
        public List<Order> GetAllOrder(int custid)
        {
            return orderdao.GetAllOrderByCustId(custid);
        }

        /// <summary>
        /// Create order
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Boolean</returns>
        public Boolean CreateOrder(Order order)
        {
            return orderdao.AddOrder(order);
        }

        /// <summary>
        /// Add a orderitem
        /// </summary>
        /// <param name="lstorderitem">orderitem</param>
        /// <returns>OrderItemResult</returns>
        public OrderItemResult InsertOrderItem(OrderItem orderitem)
        {
            Order temporder = ViewOrderDetail(orderitem.OrderId);
            if(temporder.DeliveryInfo.Status.StatusDeliveryId==Constant.STATUSDELIVERYID_NEW){
                
                
                    if (orderitemdao.AddOrderItem(orderitem))
                        return OrderItemResult.Succeed;
                    else
                        return OrderItemResult.Failed;
                    
                
            }
            else
               return OrderItemResult.OrderCheck;
        }

        /// <summary>
        /// Update order by orderid
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>OrderResult</returns>
        public OrderResult UpdateOrder(Order order)
        {
            Order temporder=ViewOrderDetail(order.OrderId);

            if (temporder.DeliveryInfo.Status.StatusDeliveryId == Constant.STATUSDELIVERYID_NEW)
            {
                if (orderdao.UpdateOrderByOrderId(order))
                    return OrderResult.Succeed;
                else
                    return OrderResult.Failed;
            }
            else
                return OrderResult.OrderCheck;
        }

        /// <summary>
        /// Delete order by orderid
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>OrderResult</returns>
        public OrderResult DeleteOrder(int orderid)
        {
            Order temporder = ViewOrderDetail(orderid);
            if (temporder.DeliveryInfo.Status.StatusDeliveryId == Constant.STATUSDELIVERYID_NEW)
            {
                if (orderdao.DeleteOrderByOrderId(orderid))
                    return OrderResult.Succeed;
                else
                    return OrderResult.Failed;
            }
            else
            {
                return OrderResult.OrderCheck
;
            }
        }

        /// <summary>
        /// Replace Produt for order
        /// </summary>
        /// <param name="productreplace">String</param>
        /// <param name="quantity">int</param>
        /// <param name="orderitemid">String</param>
        /// <returns>OrderItemResult</returns>
        public OrderItemResult ReplaceProductForOrder(String productreplace, int quantity, String orderitemid)
        {
            OrderItem orderitem = orderitemdao.GetOrderItemByOrderItemId(orderitemid);
            Order order = orderdao.GetOrderByOrderId(orderitem.OrderId);
            DateTime date=new DateHelperDAO().GetDateCurrent();
            if (DateHelper.CompareDate(date, AddDateWithDay(order.OrderDate, Constant.EX_WEEK_ORDER)) == DateCompareResult.Small)
            {
                return OrderItemResult.EndTime;
            }
            else
            {
                if (orderitemdao.UpdateProductReplaceByOrderItemId(productreplace, quantity, orderitemid))
                    return OrderItemResult.Succeed;
                else
                    return OrderItemResult.Failed;
            }
        }

        /// <summary>
        /// Get orderitem by orderitemid
        /// </summary>
        /// <param name="orderitemid">String</param>
        /// <returns>OrderItem</returns>
        public OrderItem GetOrderItemByOrderItemId(String orderitemid)
        {
            return orderitemdao.GetOrderItemByOrderItemId(orderitemid);
        }

        /// <summary>
        /// Add date with day
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <param name="day">int</param>
        /// <returns>DateTime</returns>
        private DateTime AddDateWithDay(DateTime date, int day)
        {
            return new DateHelperDAO().AddDateWithDay(date, day);
        }

        /// <summary>
        /// Edit customer
        /// </summary>
        /// <param name="custobject">Customer</param>
        /// <returns>Boolean</returns>
        public Boolean EditCustomer(Customer custobject)
        {
            return userdao.EditUser(custobject);
        }

        /// <summary>
        /// View customer detail
        /// </summary>
        /// <param name="custid">int</param>
        /// <returns>Customer</returns>
        public Customer ViewCustomerDetail(int custid)
        {
            Customer customer = new Customer();
            User user=userdao.GetUserByUserId(custid);
            if (user.UserRole.RoleId == Constant.ROLEID_CUSTOMER)
                User.Mapping(customer, user);
                return customer;
        }
  
    }
}
