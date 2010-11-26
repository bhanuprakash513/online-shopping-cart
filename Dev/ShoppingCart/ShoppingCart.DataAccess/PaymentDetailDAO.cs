using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;
using System.Data.SqlClient;
using ShoppingCart.Common;


namespace ShoppingCart.DataAccess
{
    public class PaymentDetailDAO : ParentDAO
    {
        public static class QUERY
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
            Fill(QUERY.GET_PAYMENTDETAIL_BY_ORDERID,paramCollection,table);
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

        /// <summary>
        /// Get payment cheque by orderid
        /// </summary>
        /// <param name="OrderId">int</param>
        /// <returns>PaymentCheque</returns>
        public PaymentCheque GetPaymentChequeByOrderId(int OrderId)
        {
            PaymentCheque obj = new PaymentCheque(); ;
            DataTable table=new DataTable();
            paramCollection = new SqlParameter[1];
            paramCollection[0] = new SqlParameter("OrderId",OrderId);
            Fill(QUERY.GET_PAYMENTDETAIL_BY_ORDERID,paramCollection,table);
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

        /// <summary>
        /// Get Payment Demand Draft By OrderId
        /// </summary>
        /// <param name="OrderId">int</param>
        /// <returns>PaymentDD</returns>
        public PaymentDD GetPaymentDemandDraftByOrderId(int OrderId)
        {
            PaymentDD obj = new PaymentDD(); ;
            DataTable table = new DataTable();
            paramCollection = new SqlParameter[1];
            paramCollection[0] = new SqlParameter("OrderId", OrderId);
            Fill(QUERY.GET_PAYMENTDETAIL_BY_ORDERID, paramCollection, table);
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

        /// <summary>
        /// Add payment detail
        /// </summary>
        /// <param name="payment">PaymentCC</param>
        /// <returns>Boolean</returns>
        public Boolean AddPaymentDetail(PaymentCC payment)
        {
            this.paramCollection = new SqlParameter[17];

            this.paramCollection[0] = new SqlParameter("PaymentName", payment.PayType.PayTypeName.Trim());
            this.paramCollection[1] = new SqlParameter("CardTypeId",payment.CardBank.CardTypeId);
            this.paramCollection[2] = new SqlParameter("Title","");
            this.paramCollection[3] = new SqlParameter("ReleaseDate","");
            this.paramCollection[4] = new SqlParameter("ReleasePlace","");
            this.paramCollection[5] = new SqlParameter("BankName","");
            this.paramCollection[6] = new SqlParameter("Account","");
            this.paramCollection[7] = new SqlParameter("Pay",Convert.ToInt32(payment.PayMoney));
            this.paramCollection[8] = new SqlParameter("PayPlace","");
            this.paramCollection[9] = new SqlParameter("PayWay", "");
            this.paramCollection[10] = new SqlParameter("ExpirationDate", DateHelper.Mapping(payment.Expiration));
            this.paramCollection[11] = new SqlParameter("DrawerName","");
            this.paramCollection[12] = new SqlParameter("PayerName","");
            this.paramCollection[13] = new SqlParameter("CCNumber",payment.CCNumber.Trim());
            this.paramCollection[14] = new SqlParameter("CVV", payment.CVV.Trim());
            this.paramCollection[15] = new SqlParameter("SecurityNumber", payment.SecurityNumber.Trim());
            this.paramCollection[16] = new SqlParameter("PayDetailId", ColumnDetail.PAYMENTDATEIL_PAYDETAILID);
            this.paramCollection[16].Direction = ParameterDirection.Output;

            if (this.ExecuteStore(StoreDAO.SP_PAYMENTDETAIL_INSERTPAYMENTDETAIL, paramCollection))
            {
                payment.PayId = Convert.ToInt32(paramCollection[16].Value.ToString());
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Add payment detail
        /// </summary>
        /// <param name="payment">PaymentDD</param>
        /// <returns>Boolean</returns>
        public Boolean AddPaymentDetail(PaymentDD payment)
        {
            this.paramCollection = new SqlParameter[17];

            this.paramCollection[0] = new SqlParameter("PaymentName", payment.PayType.PayTypeName.Trim());
            this.paramCollection[1] = new SqlParameter("CardTypeId", Constant.ID_FALSE);
            this.paramCollection[2] = new SqlParameter("Title", payment.Title.Trim());
            this.paramCollection[3] = new SqlParameter("ReleaseDate","");
            this.paramCollection[4] = new SqlParameter("ReleasePlace", payment.ReleasePlace.Trim());
            this.paramCollection[5] = new SqlParameter("BankName","");
            this.paramCollection[6] = new SqlParameter("Account","");
            this.paramCollection[7] = new SqlParameter("Pay", payment.PayMoney);
            this.paramCollection[8] = new SqlParameter("PayPlace",payment.PayPlace.Trim());
            this.paramCollection[9] = new SqlParameter("PayWay",payment.PayWay.Trim());
            this.paramCollection[10] = new SqlParameter("DrawerName",payment.DrawerName.Trim());
            this.paramCollection[11] = new SqlParameter("PayerName",payment.PayerName.Trim());
            this.paramCollection[12] = new SqlParameter("CCNumber","");
            this.paramCollection[13] = new SqlParameter("CVV","");
            this.paramCollection[14] = new SqlParameter("SecurityNumber","");
            this.paramCollection[15] = new SqlParameter("ExpirationDate","");
            this.paramCollection[16] = new SqlParameter("PayDetailId", ColumnDetail.PAYMENTDATEIL_PAYDETAILID);
            this.paramCollection[16].Direction = ParameterDirection.Output;
            
            if (this.ExecuteStore(StoreDAO.SP_PAYMENTDETAIL_INSERTPAYMENTDETAIL, paramCollection))
            {
                payment.PayId = Convert.ToInt32(paramCollection[16].Value.ToString());
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Add payment detail
        /// </summary>
        /// <param name="payment">PaymentCheque</param>
        /// <returns>Boolean</returns>
        public Boolean AddPaymentDetail(PaymentCheque payment)
        {

            this.paramCollection = new SqlParameter[17];

            
            this.paramCollection[0] = new SqlParameter("PaymentName",payment.PayType.PayTypeName.Trim());
            this.paramCollection[1] = new SqlParameter("CardTypeId",Constant.ID_FALSE);
            this.paramCollection[2] = new SqlParameter("Title",payment.Title.Trim());
            this.paramCollection[3] = new SqlParameter("ReleaseDate",DateHelper.Mapping(payment.ReleaseDate));
            this.paramCollection[4] = new SqlParameter("ReleasePlace",payment.ReleasePlace.Trim());
            this.paramCollection[5] = new SqlParameter("BankName",payment.BankName.Trim());
            this.paramCollection[6] = new SqlParameter("Account",payment.Account.Trim());
            this.paramCollection[7] = new SqlParameter("Pay",payment.PayMoney);
            this.paramCollection[8] = new SqlParameter("PayPlace","");
            this.paramCollection[9] = new SqlParameter("PayWay", "");
            this.paramCollection[10] = new SqlParameter("DrawerName","");
            this.paramCollection[11] = new SqlParameter("PayerName","");
            this.paramCollection[12] = new SqlParameter("CCNumber","");
            this.paramCollection[13] = new SqlParameter("CVV","");
            this.paramCollection[14] = new SqlParameter("SecurityNumber","");
            this.paramCollection[15] = new SqlParameter("ExpirationDate","");
            this.paramCollection[16] = new SqlParameter("PayDetailId", ColumnDetail.PAYMENTDATEIL_PAYDETAILID);
            this.paramCollection[16].Direction = ParameterDirection.Output;
            if (this.ExecuteStore(StoreDAO.SP_PAYMENTDETAIL_INSERTPAYMENTDETAIL, paramCollection))
            {
                payment.PayId = Convert.ToInt32(paramCollection[16].Value.ToString());
                return true;
            }
            else
                return false;
        
        }

        /// <summary>
        /// Update payment detail by payid
        /// </summary>
        /// <param name="payment">PaymentCC</param>
        /// <returns>Boolean</returns>
        public Boolean UpdatePaymentDetailByPayId(PaymentCC payment)
        {
            this.paramCollection = new SqlParameter[17];

            this.paramCollection[0] = new SqlParameter("PaymentName", payment.PayType.PayTypeName.Trim());
            this.paramCollection[1] = new SqlParameter("CardTypeId", payment.CardBank.CardTypeId);
            this.paramCollection[2] = new SqlParameter("Title","");
            this.paramCollection[3] = new SqlParameter("ReleaseDate", "");
            this.paramCollection[4] = new SqlParameter("ReleasePlace", "");
            this.paramCollection[5] = new SqlParameter("BankName", "");
            this.paramCollection[6] = new SqlParameter("Account", "");
            this.paramCollection[7] = new SqlParameter("Pay", payment.PayMoney);
            this.paramCollection[8] = new SqlParameter("PayPlace", "");
            this.paramCollection[9] = new SqlParameter("PayWay", "");
            this.paramCollection[10] = new SqlParameter("DrawerName", "");
            this.paramCollection[11] = new SqlParameter("PayerName", "");
            this.paramCollection[12] = new SqlParameter("CCNumber", payment.CCNumber.Trim());
            this.paramCollection[13] = new SqlParameter("CVV", payment.CVV.Trim());
            this.paramCollection[14] = new SqlParameter("SecurityNumber", payment.SecurityNumber.Trim());
            this.paramCollection[15] = new SqlParameter("ExpirationDate", DateHelper.Mapping(payment.Expiration));
            this.paramCollection[16] = new SqlParameter("PayDetailid", payment.PayId);
            return this.ExecuteStore(StoreDAO.SP_PAYMENTDETAIL_UPDATEPAYMENTDETAIL_BY_PAYDETAILID, paramCollection);
        }

        /// <summary>
        /// Update payment detail by payid
        /// </summary>
        /// <param name="payment">PaymentDD</param>
        /// <returns>Boolean</returns>
        public Boolean UpdatePaymentDetailByPayId(PaymentDD payment)
        {
            this.paramCollection = new SqlParameter[17];

            this.paramCollection[0] = new SqlParameter("PaymentName", payment.PayType.PayTypeName.Trim());
            this.paramCollection[1] = new SqlParameter("CardTypeId", Constant.ID_FALSE);
            this.paramCollection[2] = new SqlParameter("Title", payment.Title.Trim());
            this.paramCollection[3] = new SqlParameter("ReleaseDate", "");
            this.paramCollection[4] = new SqlParameter("ReleasePlace", payment.ReleasePlace.Trim());
            this.paramCollection[5] = new SqlParameter("BankName", "");
            this.paramCollection[6] = new SqlParameter("Account", "");
            this.paramCollection[7] = new SqlParameter("Pay", payment.PayMoney);
            this.paramCollection[8] = new SqlParameter("PayPlace", payment.PayPlace.Trim());
            this.paramCollection[9] = new SqlParameter("PayWay", payment.PayWay);
            this.paramCollection[10] = new SqlParameter("DrawerName", payment.DrawerName.Trim());
            this.paramCollection[11] = new SqlParameter("PayerName", payment.PayerName.Trim());
            this.paramCollection[12] = new SqlParameter("CCNumber", "");
            this.paramCollection[13] = new SqlParameter("CVV", "");
            this.paramCollection[14] = new SqlParameter("SecurityNumber", "");
            this.paramCollection[15] = new SqlParameter("ExpirationDate", "");
            this.paramCollection[16] = new SqlParameter("PayDetailid", payment.PayId);

            return this.ExecuteStore(StoreDAO.SP_PAYMENTDETAIL_UPDATEPAYMENTDETAIL_BY_PAYDETAILID, paramCollection);
        }

        /// <summary>
        /// Update payment detail by payid
        /// </summary>
        /// <param name="payment">PaymentCheque</param>
        /// <returns>Boolean</returns>
        public Boolean UpdatePaymentDetailByPayId(PaymentCheque payment)
        {
            this.paramCollection = new SqlParameter[17];

            this.paramCollection[0] = new SqlParameter("PaymentName", payment.PayType.PayTypeName.Trim());
            this.paramCollection[1] = new SqlParameter("CardTypeId", Constant.ID_FALSE);
            this.paramCollection[2] = new SqlParameter("Title", payment.Title.Trim());
            this.paramCollection[3] = new SqlParameter("ReleaseDate", DateHelper.Mapping(payment.ReleaseDate));
            this.paramCollection[4] = new SqlParameter("ReleasePlace", payment.ReleasePlace.Trim());
            this.paramCollection[5] = new SqlParameter("BankName", payment.BankName.Trim());
            this.paramCollection[6] = new SqlParameter("Account", payment.Account.Trim());
            this.paramCollection[7] = new SqlParameter("Pay", payment.PayMoney);
            this.paramCollection[8] = new SqlParameter("PayPlace", "");
            this.paramCollection[9] = new SqlParameter("PayWay", "");
            this.paramCollection[10] = new SqlParameter("DrawerName", "");
            this.paramCollection[11] = new SqlParameter("PayerName", "");
            this.paramCollection[12] = new SqlParameter("CCNumber", "");
            this.paramCollection[13] = new SqlParameter("CVV", "");
            this.paramCollection[14] = new SqlParameter("SecurityNumber", "");
            this.paramCollection[15] = new SqlParameter("ExpirationDate", "");
            this.paramCollection[16] = new SqlParameter("PayDetailid", payment.PayId);

            return this.ExecuteStore(StoreDAO.SP_PAYMENTDETAIL_UPDATEPAYMENTDETAIL_BY_PAYDETAILID, paramCollection);
        }
 
        
    }
}
