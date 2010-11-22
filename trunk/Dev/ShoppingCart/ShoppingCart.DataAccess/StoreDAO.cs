using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess
{
    class StoreDAO
    {

        public static String SP_ORDER_CREATEORDER
        {
            get
            {
                return "SP_Order_CreateOrder";
            }
        }

        public static String SP_ORDER_UPDATEORDER_BY_ORDERID
        {
            get
            {
                return "SP_Order_UpdateOrderByOrderId";
            }
        }

        public static String SP_ORDER_DELETEORDER_BY_ORDERID
        {
            get
            {
                return "SP_Order_DeleteOrderByOrderId";
            }
        }

        public static String SP_PAYMENTDETAIL_INSERTPAYMENTDETAIL
        {
            get
            {
                return "SP_PaymentDetail_InsertPaymentDetail";
            }
        }

        public static String SP_PAYMENTDETAIL_UPDATEPAYMENTDETAIL_BY_PAYDETAILID
        {
            get
            {
                return "SP_PaymentDetail_UpdatePaymentDetailByPayDetailId";
            }
        }


        public static String SP_ORDERITEM_INSERTORDERITEM
        {
            get
            {
                return "SP_OrderItem_InsertOrderItem";
            }
        }

        public static String SP_ORDERITEM_UPDATEORDERITEM_BY_ORDERITEMID
        {
            get
            {
                return "SP_OrderItem_UpdateOrderItemByOrderItemId";
            }
        }

        public static String SP_ORDER_UPDATESTATUSDELIVERY_BY_ORDERID
        {
            get
            {
                return "SP_Order_UpdateStatusDeliveryByOrderId";
            }
        }

        public static String SP_ORDERITEM_GENERATEORDERITEMID
        {
            get
            {
                return "SP_OrderItem_GenerateOrderItemId";
            }
        }

    }
}
