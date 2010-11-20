using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using ShoppingCart.Common;
using System.Data;

namespace ShoppingCart.Object
{
    public class PaymentCheque : Payment
    {
        private string title;
        private DateTime releasedate;
        private string releaseplace;
        private string bankname;
        private string account;
        

        public PaymentCheque()
        {
            releasedate = new DateTime();
        }

        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return releasedate;
            }
            set
            {
                releasedate = value;
            }
        }

        public String ReleasePlace
        {
            get
            {
                return releaseplace;
            }
            set
            {
                releaseplace = value;
            }
        }
        public String BankName
        {
            get
            {
                return bankname;
            }
            set
            {
                bankname = value;
            }
        }
        public String Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }
   

        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="row">DataRow</param>
        /// <returns>PaymentCheque</returns>
        public static PaymentCheque Mapping(DataRow row)
        {
            PaymentCheque obj = new PaymentCheque();
            try
            {
                PaymentType.Mapping(obj.PayType, row);
                StatusPaid.Mapping(obj.Status, row);
            
                if (row[ColumnName.PAYMENTDETAIL_TITLE] != null)
                    obj.Title = row[ColumnName.PAYMENTDETAIL_TITLE].ToString();
                if (row[ColumnName.PAYMENTDETAIL_RELEASEDATE] != null)
                    obj.ReleaseDate = DateHelper.Mapping(row[ColumnName.PAYMENTDETAIL_RELEASEDATE].ToString());
                if (row[ColumnName.PAYMENTDETAIL_RELEASEPLACE] != null)
                    obj.ReleasePlace =row[ColumnName.PAYMENTDETAIL_RELEASEPLACE].ToString();
                if (row[ColumnName.PAYMENTDETAIL_BANKNAME] != null)
                    obj.ReleasePlace =row[ColumnName.PAYMENTDETAIL_BANKNAME].ToString();
                if (row[ColumnName.PAYMENTDETAIL_ACCOUNT] != null)
                    obj.Account = row[ColumnName.PAYMENTDETAIL_ACCOUNT].ToString();
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
        public static List<PaymentCheque> Mapping(DataTable table)
        {
            List<PaymentCheque> lst = new List<PaymentCheque>();
            for (int i = 0; i < table.Rows.Count; i++)
                lst.Add(Mapping(table.Rows[i]));
            return lst;

        }


    }
}
