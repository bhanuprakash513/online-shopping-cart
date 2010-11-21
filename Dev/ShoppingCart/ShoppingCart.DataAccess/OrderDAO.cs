using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data.SqlClient;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.DataAccess
{
    public class OrderDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GET_ALL_ORDER
            {
                get
                {
                    return " SELECT  [Order].OrderId,[Order].PayDetailId,[Order].DeliveryId,[Order].UserIdShip, " +
                           " [Order].UserIdCheck,[Order].PayTypeId,[Order].CustId,[Order].ShippingDate,[Order].StatusPaidId, " +
                           " [Order].StatusDeliveryId,[Order].OrderDate,[Order].ReceiverFullname,[Order].ReceiverAddress, " +
                           " [Order].ReceiverPhone,[Order].CountryId,[Order].City,[Order].State,[Order].Zipcode,[Order].TotalCost, " +
                           " DeliveryType.DeliveryName,StatusPaid.StatusPaidName, StatusDelivery.StatusDeliveryName, Country.CountryName,PaymentType.PayTypeName " +
                           " FROM [Order],[DeliveryType],[StatusPaid],[StatusDelivery],[Country],[PaymentType] " +
                           " WHERE DeliveryType.DeliveryId=[Order].DeliveryId " +
                           " AND StatusPaid.StatusPaidId=[Order].StatusPaidId " +
                           " AND StatusDelivery.StatusDeliveryId=[Order].StatusDeliveryId " +
                           " AND Country.CountryId=[Order].CountryId " +
                           " AND PaymentType.PayTypeId=[Order].PayTypeId";
                }
            }

            public static String GET_ORDER_BY_ORDERID
            {
                get
                {
                    return QUERY.GET_ALL_ORDER
                            +" AND [Order].OrderId=@OrderId";
                }
            }

            public static String GET_ALL_ORDER_BY_CUSTID
            {
                get
                {
                    return QUERY.GET_ALL_ORDER + " AND [Order].CustId=@CustId";
                }
            }

            public static String UPDATE_USERIDSHIP_BY_ORDERID
            {
                get
                {
                    return "UPDATE [Order] SET [Order].UserIdShip=@UserIdShip WHERE [Order].OrderId=@OrderId";
                }
            }

            public static String UPDATE_STATUSPAIDID_BY_ORDERID
            {
                get
                {
                    return "UPDATE [Order] SET [Order].StatusPaidId=@StatusPaidId WHERE [Order].OrderId=@OrderId";
                }
            }

            public static String UPDATE_STATUSDELIVERYID_BY_ORDERID
            {
                get
                {
                    return "UPDATE [Order] SET [Order].StatusDeliveryId=@StatusDeliveryId WHERE [Order].OrderId=@OrderId";
                }
            }

            public static String UPDATE_DELIVERYID_BY_ORDERID
            {
                get
                {
                    return "UPDATE [Order] SET [Order].DeliveryId=@DeliveryId WHERE [Order].OrderId=@OrderId";
                }
            }

            public static String GET_ORDER_BY_DELIVERYID_AND_DATE
            {
                get
                {
                    return QUERY.GET_ALL_ORDER+ " AND [Order].OrderDate >= @StartDate AND [Order].OrderDate<=@EndDate AND [ORDER].DELIVERYID=@DeliveryId";
                }
            }
        }

        /// <summary>
        /// Get  Order  list
        /// </summary>
        /// <returns>List</returns>
        public List<Order> GetAllOrder()
        {
            List<Order> lstorder = new List<Order>();

            DataTable table = new DataTable();

            this.Fill(QUERY.GET_ALL_ORDER, table);
            if (table.Rows.Count > 0)
            {
                Order.Mapping(lstorder, table);
                
                for (int i = 0; i < lstorder.Count; i++)
                {
                    if (table.Rows[i][ColumnName.ORDER_PAYTYPEID] != null && table.Rows[i][ColumnName.ORDER_PAYTYPEID].ToString() != "")
                    {
                        int paytypeid =Convert.ToInt32(table.Rows[i][ColumnName.ORDER_PAYTYPEID]);
                        if (paytypeid == Constant.PAYMENTTYPE_CC)
                            lstorder[i].PaymentCCInfor = new PaymentDetailDAO().GetPaymentCreditCardByOrderId(lstorder[i].OrderId);
                        else if (paytypeid == Constant.PAYMENTTYPE_DD)
                            lstorder[i].PaymentDDInfor = new PaymentDetailDAO().GetPaymentDemandDraftByOrderId(lstorder[i].OrderId);
                        else if (paytypeid == Constant.PAYMENTTYPE_CHEQUE)
                            lstorder[i].PaymentChequeInfor = new PaymentDetailDAO().GetPaymentChequeByOrderId(lstorder[i].OrderId);
                       
                    }
                    lstorder[i].ListOrderItem = new OrderItemDAO().GetAllOrderItemByOrderID(lstorder[i].OrderId);
                }
            }
            return lstorder;        
        }


        /// <summary>
        /// Get Order by orderId
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>Order</returns>
        public Order GetOrderByOrderId(int orderid)
        {
            Order obj = new Order();

            this.paramCollection = new SqlParameter[1];
            paramCollection[0] = new SqlParameter("OrderId", orderid);
            DataTable table = new DataTable();

            this.Fill(QUERY.GET_ORDER_BY_ORDERID, paramCollection, table);
            if (table.Rows.Count > 0)
            {
                Order.Mapping(obj, table.Rows[0]);

           
                if (table.Rows[0][ColumnName.ORDER_PAYTYPEID] != null && table.Rows[0][ColumnName.ORDER_PAYTYPEID].ToString() != "")
                {
                    int paytypeid = Convert.ToInt32(table.Rows[0][ColumnName.ORDER_PAYTYPEID]);
                    if (paytypeid == Constant.PAYMENTTYPE_CC)
                        obj.PaymentCCInfor = new PaymentDetailDAO().GetPaymentCreditCardByOrderId(obj.OrderId);
                    else if (paytypeid == Constant.PAYMENTTYPE_DD)
                        obj.PaymentDDInfor = new PaymentDetailDAO().GetPaymentDemandDraftByOrderId(obj.OrderId);
                    else if (paytypeid == Constant.PAYMENTTYPE_CHEQUE)
                        obj.PaymentChequeInfor = new PaymentDetailDAO().GetPaymentChequeByOrderId(obj.OrderId);

                }
                obj.ListOrderItem = new OrderItemDAO().GetAllOrderItemByOrderID(obj.OrderId);
            
            }
            return obj;
        }


        /// <summary>
        /// Get  Order  by Custid
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>List</returns>
        public List<Order> GetAllOrderByCustId(int custid)
        {
            List<Order> lstorder = new List<Order>();

            DataTable table = new DataTable();
            paramCollection = new SqlParameter[1];
            paramCollection[0] = new SqlParameter("CustId", custid);
            this.Fill(QUERY.GET_ALL_ORDER_BY_CUSTID,paramCollection, table);
            if (table.Rows.Count > 0)
            {
                Order.Mapping(lstorder, table);

                for (int i = 0; i < lstorder.Count; i++)
                {
                    if (table.Rows[i][ColumnName.ORDER_PAYTYPEID] != null && table.Rows[i][ColumnName.ORDER_PAYTYPEID].ToString() != "")
                    {
                        int paytypeid = Convert.ToInt32(table.Rows[i][ColumnName.ORDER_PAYTYPEID]);
                        if (paytypeid == Constant.PAYMENTTYPE_CC)
                            lstorder[i].PaymentCCInfor = new PaymentDetailDAO().GetPaymentCreditCardByOrderId(lstorder[i].OrderId);
                        else if (paytypeid == Constant.PAYMENTTYPE_DD)
                            lstorder[i].PaymentDDInfor = new PaymentDetailDAO().GetPaymentDemandDraftByOrderId(lstorder[i].OrderId);
                        else if (paytypeid == Constant.PAYMENTTYPE_CHEQUE)
                            lstorder[i].PaymentChequeInfor = new PaymentDetailDAO().GetPaymentChequeByOrderId(lstorder[i].OrderId);

                    }
                    lstorder[i].ListOrderItem = new OrderItemDAO().GetAllOrderItemByOrderID(lstorder[i].OrderId);
                }
            }
            return lstorder;
        }

        public Boolean UpdateStatusDeliveryIdByOrderId(int statusdeliveryid,int orderid)
        {
            this.paramCollection = new SqlParameter[2];
            this.paramCollection[0] = new SqlParameter("StatusDeliveryId", statusdeliveryid);
            this.paramCollection[1] = new SqlParameter("OrderId", orderid);
      
            return this.ExecuteNonQuery(QUERY.UPDATE_STATUSDELIVERYID_BY_ORDERID, paramCollection);
        }

        public Boolean UpdateStatusPaidIdByOrderId(int statuspaidid,int orderid)
        {
            this.paramCollection = new SqlParameter[2];
            this.paramCollection[0] = new SqlParameter("StatusPaidId", statuspaidid);
            this.paramCollection[1] = new SqlParameter("OrderId", orderid);

            return this.ExecuteNonQuery(QUERY.UPDATE_STATUSPAIDID_BY_ORDERID, paramCollection);
        }

        public Boolean UpdateDeliveryIdByOrderId(char deliveryid,int orderid)
        {
            this.paramCollection = new SqlParameter[2];
            this.paramCollection[0] = new SqlParameter("DeliveryId", deliveryid);
            this.paramCollection[1] = new SqlParameter("OrderId", orderid);

            return this.ExecuteNonQuery(QUERY.UPDATE_DELIVERYID_BY_ORDERID, paramCollection);
        }

        public Boolean UpdateUserIdShipByOrderId(int useridship, int orderid)
        {
            this.paramCollection = new SqlParameter[2];
            this.paramCollection[0] = new SqlParameter("UserIdShip", useridship);
            this.paramCollection[1] = new SqlParameter("OrderId", orderid);

            return this.ExecuteNonQuery(QUERY.UPDATE_USERIDSHIP_BY_ORDERID, paramCollection);
        }

        public List<Order> GetOrderByDateAndDeliveryId(char deliveryid, DateTime startdate, DateTime enddate)
        {
            List<Order> lstorder = new List<Order>();

            DataTable table = new DataTable();
            paramCollection = new SqlParameter[3];
            paramCollection[0] = new SqlParameter("StartDate",DateHelper.Mapping(startdate));
            paramCollection[1] = new SqlParameter("EndDate",DateHelper.Mapping(enddate));
            paramCollection[2] = new SqlParameter("DeliveryId", deliveryid);

            this.Fill(QUERY.GET_ORDER_BY_DELIVERYID_AND_DATE,paramCollection, table);
            if (table.Rows.Count > 0)
            {
                Order.Mapping(lstorder, table);

                for (int i = 0; i < lstorder.Count; i++)
                {
                    if (table.Rows[i][ColumnName.ORDER_PAYTYPEID] != null && table.Rows[i][ColumnName.ORDER_PAYTYPEID].ToString() != "")
                    {
                        int paytypeid = Convert.ToInt32(table.Rows[i][ColumnName.ORDER_PAYTYPEID]);
                        if (paytypeid == Constant.PAYMENTTYPE_CC)
                            lstorder[i].PaymentCCInfor = new PaymentDetailDAO().GetPaymentCreditCardByOrderId(lstorder[i].OrderId);
                        else if (paytypeid == Constant.PAYMENTTYPE_DD)
                            lstorder[i].PaymentDDInfor = new PaymentDetailDAO().GetPaymentDemandDraftByOrderId(lstorder[i].OrderId);
                        else if (paytypeid == Constant.PAYMENTTYPE_CHEQUE)
                            lstorder[i].PaymentChequeInfor = new PaymentDetailDAO().GetPaymentChequeByOrderId(lstorder[i].OrderId);

                    }
                    lstorder[i].ListOrderItem = new OrderItemDAO().GetAllOrderItemByOrderID(lstorder[i].OrderId);
                }
            }
            return lstorder;        
        }


    }
}
