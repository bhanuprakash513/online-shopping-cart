using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{
    public class PaymentCC : Payment
    {
        private CardType cardbank;
        private string ccnumber;
        private string cvv;
        private string securitynumber;

        public PaymentCC()
        {
            cardbank = new CardType();
        }

        public CardType CardBank
        {
            get
            {
                return cardbank;
            }
            set
            {
                cardbank = value;
            }
        }

        public String CCNumber
        {
            get
            {
                return ccnumber;
            }
            set
            {
                ccnumber = value;
            }
        }
        public String CVV
        {
            get
            {
                return cvv;
            }
            set
            {
                cvv = value;
            }
        }
        public String SecurityNumber
        {
            get
            {
                return securitynumber;
            }
            set
            {
                securitynumber = value;
            }
        }


        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="row">DataRow</param>
        /// <returns>PaymentCC</returns>
        public static PaymentCC Mapping(DataRow row)
        {
            PaymentCC obj=new PaymentCC();
            try
            {
                PaymentType.Mapping(obj.PayType, row);
                StatusPaid.Mapping(obj.Status, row);
                CardType.Mapping(obj.CardBank, row);
                if (row[ColumnName.PAYMENTDETAIL_CCNUMBER] != null)
                    obj.CCNumber=row[ColumnName.PAYMENTDETAIL_CCNUMBER].ToString(); 
                if (row[ColumnName.PAYMENTDETAIL_CVV] != null)
                    obj.CCNumber=row[ColumnName.PAYMENTDETAIL_CVV].ToString();

                if (row[ColumnName.PAYMENTDETAIL_SECURITYNUMBER] != null)
                    obj.CCNumber = row[ColumnName.PAYMENTDETAIL_SECURITYNUMBER].ToString();

               
                if (row[ColumnName.PAYMENTDETAIL_PAYDETAILID] != null)
                    obj.PayId = Convert.ToInt32(row[ColumnName.PAYMENTDETAIL_PAYDETAILID]);
                if (row[ColumnName.PAYMENTDETAIL_PAY] != null)
                    obj.PayMoney = row[ColumnName.PAYMENTDETAIL_PAY].ToString();
 
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return obj;
        }

        /// <summary>
        /// Mapping list
        /// </summary>
        /// <param name="table">DataTable</param>
        /// <returns>List</returns>
        public static List<PaymentCC> Mapping(DataTable table)
        {
            List<PaymentCC> lst = new List<PaymentCC>();
            for (int i = 0; i < table.Rows.Count; i++)
               lst.Add(Mapping(table.Rows[i]));
           return lst;
            
        }

    }
}