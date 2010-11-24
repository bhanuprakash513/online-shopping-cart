using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using ShoppingCart.DataAccess;

namespace ShoppingCart.Business
{
    public class ReCustomerService : UnreCustomerService
    {
        FeedbackDAO feeddao;
        OrderDAO orderdao;
        ProductDAO productdao;
        DeliveryTypeDAO deliverytypedao;
        public ReCustomerService()
        {
            feeddao = new FeedbackDAO();
            orderdao = new OrderDAO();
            productdao = new ProductDAO();
            deliverytypedao = new DeliveryTypeDAO();
        }

        public Boolean AddFeedback(Feedback feed)
        {
            return feeddao.AddFeedback(feed);
        }

        public Order ViewOrderDetail(int orderid)
        {
            return orderdao.GetOrderByOrderId(orderid);
        }

        public List<Order> ShowAllOrder(int custid)
        {
            return orderdao.GetAllOrderByCustId(custid);
        }

        public Boolean CreateOrder(Order order)
        {
            return orderdao.AddOrder(order);
        }

        public Boolean UpdateOrder(Order order)
        {
            return orderdao.UpdateOrderByOrderId(order);
        }

        public Boolean DeleteOrder(int orderid)
        {
            return orderdao.DeleteOrderByOrderId(orderid);
        }

        public String PaymentAProduct(String productid, int quantity)
        {
            return productdao.GetTotalCost(productid,quantity).ToString();
        }

        public String PaymentTotalProduct(List<Product> lstproduct)
        {
            int money=0;
            for (int i = 0; i < lstproduct.Count; i++)
                money = money + Convert.ToInt32(PaymentAProduct(lstproduct[i].ProducId, lstproduct[i].Quantity));
            return money.ToString();
        }

        public String Payment(List<Product> lstproduct, Char deliveryid)
        {
            int totalcost = Convert.ToInt32(deliverytypedao.GetDeliveryTypeByDeliveryId(deliveryid).DeliveryCost);
            return PaymentTotalProduct(lstproduct) + totalcost;

        }
    }
}
