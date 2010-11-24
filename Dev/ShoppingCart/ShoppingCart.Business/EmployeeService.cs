using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using ShoppingCart.DataAccess;

namespace ShoppingCart.Business
{
    public class EmployeeService
    {
        OrderDAO orderdao;
        public EmployeeService()
        {
            orderdao = new OrderDAO();
        }

        public List<Order> SearchByDateAnDeliveryOfOrder(char deliveryid, DateTime startdate, DateTime enddate)
        {
            return orderdao.GetOrderByDateAndDeliveryId(deliveryid, startdate, enddate);
        }

        public Boolean UpdatePayStatusOfOrder(int statuspaidid, int orderid)
        {
            return orderdao.UpdateStatusPaidIdByOrderId(statuspaidid, orderid);
        }

        public Boolean UpdateDeliveryStatusOfOrder(int statusdeliveryid, int orderid, DateTime shippingdate)
        {
            return orderdao.UpdateStatusDeliveryIdByOrderId(statusdeliveryid, orderid, shippingdate);
        }

        public Boolean UpdateUserShipOfOrder(int useridship, int orderid)
        {
            return orderdao.UpdateUserIdShipByOrderId(useridship, orderid);        
        }

        public Order ViewOrderDetail(int orderid)
        {
            return orderdao.GetOrderByOrderId(orderid);
        }
    }
}
