using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;
using System.Data.SqlClient;
using ShoppingCart.Common;
using ShoppingCart.Object;

namespace ShoppingCart.DataAccess
{
    class PaymentDetailDAO : ParentDAO
    {
        public static class Query
        {
            public static String GET_PAYMENTDETAIL_BY_ORDERID
            {
                get
                {
                    return 
                        " SELECT PaymentDetail.PayDetailId,PaymentDetail.PaymentName, "+
		                " PaymentDetail.CardTypeId, "+
		                " Title,ReleaseDate,ReleasePlace,BankName, "+
		                " Account,Pay,PayPlace,PayWay,ExpirationDate,DrawerName,PayerName,CCNumber,CVV,SecurityNumber, "+
		                " PaymentType.PayTypeId,PaymentType.PayTypeName "+
                        " FROM PaymentDetail,[Order],[PaymentType] "+
                        " WHERE PaymentDetail.PayDetailId=[Order].PayDetailId "+ 
		                " AND [Order].OrderId=@OrderId " +
		                " AND PaymentType.PayTypeId=[Order].PayTypeId ";
                }
            }

            
        }


        /// <summary>
        /// Get Payment Detail by Orderid
        /// </summary>
        /// <param name="OrderId">int</param>
        /// <returns>Payment</returns>
        public PaymentCC GetPaymentCreditCardByOrderId(int OrderId)
        {
            PaymentCC obj = new PaymentCC(); ;
            DataTable table=new DataTable();
            paramCollection = new SqlParameter[1];
            paramCollection[0] = new SqlParameter("OrderId",OrderId);
            Fill(Query.GET_PAYMENTDETAIL_BY_ORDERID,paramCollection,table);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][ColumnName.ORDER_PAYTYPEID]!=null&&table.Rows[0][ColumnName.ORDER_PAYTYPEID].ToString() != "")
                {
                    int paytypeid=Convert.ToInt32(table.Rows[0][ColumnName.ORDER_PAYTYPEID].ToString());
                    if (paytypeid == Constant.PAYMENTTYPE_CC)
                        obj=PaymentCC.Mapping(table.Rows[0]);
             
                }
            }
            return obj;

        }



        public PaymentCheque GetPaymentChequeByOrderId(int OrderId)
        {
            PaymentCheque obj = new PaymentCheque(); ;
            DataTable table=new DataTable();
            paramCollection = new SqlParameter[1];
            paramCollection[0] = new SqlParameter("OrderId",OrderId);
            Fill(Query.GET_PAYMENTDETAIL_BY_ORDERID,paramCollection,table);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][ColumnName.ORDER_PAYTYPEID]!=null&&table.Rows[0][ColumnName.ORDER_PAYTYPEID].ToString() != "")
                {
                    int paytypeid=Convert.ToInt32(table.Rows[0][ColumnName.ORDER_PAYTYPEID].ToString());
                    if (paytypeid == Constant.PAYMENTTYPE_CHEQUE)
                        obj =PaymentCheque.Mapping(table.Rows[0]);
                    
                }
            }
            return obj;

        }

        public PaymentDD GetPaymentDemandDraftByOrderId(int OrderId)
        {
            PaymentDD obj = new PaymentDD(); ;
            DataTable table = new DataTable();
            paramCollection = new SqlParameter[1];
            paramCollection[0] = new SqlParameter("OrderId", OrderId);
            Fill(Query.GET_PAYMENTDETAIL_BY_ORDERID, paramCollection, table);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][ColumnName.ORDER_PAYTYPEID] != null && table.Rows[0][ColumnName.ORDER_PAYTYPEID].ToString() != "")
                {
                    int paytypeid = Convert.ToInt32(table.Rows[0][ColumnName.ORDER_PAYTYPEID].ToString());
                    if (paytypeid == Constant.PAYMENTTYPE_DD)
                        obj = PaymentDD.Mapping(table.Rows[0]);
                   
                }
            }
            return obj;

        }
    }
}
