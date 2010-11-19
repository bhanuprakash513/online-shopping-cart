using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;

namespace ShoppingCart.DataAccess
{
    public class OrderDAO : ParentDAO
    {
        public static class Query
        {
            public static String GET_ORDER_BY_ID
            {
                get
                {
                    return " SELECT  [Order].OrderId,[Order].PayDetailId,[Order].DeliveryId,[Order].UserIdShip, " +
                           " [Order].UserIdCheck,[Order].PayTypeId,[Order].CustId,[Order].ShippingDate,[Order].StatusPaidId, " +
                           " [Order].StatusDeliveryId,[Order].OrderDate,[Order].ReceiverFullname,[Order].ReceiverAddress, " +
                           " [Order].ReceiverPhone,[Order].CountryId,[Order].City,[Order].State,[Order].Zipcode,[Order].TotalCost, " +
                           " DeliveryType.DeliveryName,StatusPaid.StatusPaidName, StatusDelivery.StatusDeliveryName, Country.CountryName,PaymentType.PayTypeName " +
                           " FROM [Order],[DeliveryType],[StatusPaid],[StatusDelivery],[Country],[PaymentType] " +
                           " WHERE OrderId=1 AND DeliveryType.DeliveryId=[Order].DeliveryId " +
                           " AND StatusPaid.StatusPaidId=[Order].StatusPaidId " +
                           " AND StatusDelivery.StatusDeliveryId=[Order].StatusDeliveryId " +
                           " AND Country.CountryId=[Order].CountryId " +
                           " AND PaymentType.PayTypeId=[Order].PayTypeId";
                }
            }
        }

        /// <summary>
        /// Get Order by Id
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>Order</returns>
        public Order GetOrderById(int orderid)
        {
            Order order = new Order();

            return order;
        }
    }
}
