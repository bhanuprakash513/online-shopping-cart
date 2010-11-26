using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{
    public class PaymentDD : Payment
    {
        private string title;
        private string payway;
        private string payplace;
        private string payername;
        private string releaseplace;
        private string drawername;

        public PaymentDD()
        {
            title = "";
            payway = "";
            payplace = "";
            payername = "";
            releaseplace = "";
            drawername = "";
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

        public String PayWay
        {
            get
            {
                return payway;
            }
            set
            {
                payway = value;
            }
        }
        public String PayPlace
        {
            get
            {
                return payplace;
            }
            set
            {
                payplace = value;
            }
        }
        public String PayerName
        {
            get
            {
                return payername;
            }
            set
            {
                payername = value;
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
        public String DrawerName
        {
            get
            {
                return drawername;
            }
            set
            {
                drawername = value;
            }
        }


        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="row">DataRow</param>
        /// <returns>PaymentDD</returns>
        public static PaymentDD Mapping(DataRow row)
        {
            PaymentDD obj = new PaymentDD();
            try
            {
                PaymentType.Mapping(obj.PayType, row);
                StatusPaid.Mapping(obj.Status, row);

                if (row[ColumnName.PAYMENTDETAIL_TITLE] != null && row[ColumnName.PAYMENTDETAIL_TITLE].ToString()!="")
                    obj.Title = row[ColumnName.PAYMENTDETAIL_TITLE].ToString();
                if (row[ColumnName.PAYMENTDETAIL_PAYWAY] != null&&row[ColumnName.PAYMENTDETAIL_PAYWAY].ToString()!="")
                    obj.PayWay = row[ColumnName.PAYMENTDETAIL_PAYWAY].ToString();
                if (row[ColumnName.PAYMENTDETAIL_RELEASEPLACE] != null && row[ColumnName.PAYMENTDETAIL_RELEASEPLACE].ToString()!="")
                    obj.ReleasePlace =row[ColumnName.PAYMENTDETAIL_RELEASEPLACE].ToString();
                if (row[ColumnName.PAYMENTDETAIL_PAYPLACE] != null&&row[ColumnName.PAYMENTDETAIL_PAYPLACE].ToString()!="")
                    obj.PayPlace =row[ColumnName.PAYMENTDETAIL_PAYPLACE].ToString();
                if (row[ColumnName.PAYMENTDETAIL_PAYERNAME] != null && row[ColumnName.PAYMENTDETAIL_PAYERNAME].ToString()!="")
                    obj.PayerName = row[ColumnName.PAYMENTDETAIL_PAYERNAME].ToString();
                if (row[ColumnName.PAYMENTDETAIL_DRAWERNAME] != null && row[ColumnName.PAYMENTDETAIL_DRAWERNAME].ToString()!="")
                    obj.drawername = row[ColumnName.PAYMENTDETAIL_DRAWERNAME].ToString();
                if (row[ColumnName.PAYMENTDETAIL_PAY] != null && row[ColumnName.PAYMENTDETAIL_PAY].ToString()!="")
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
        public static List<PaymentDD> Mapping(DataTable table)
        {
            List<PaymentDD> lst = new List<PaymentDD>();
            for (int i = 0; i < table.Rows.Count; i++)
                lst.Add(Mapping(table.Rows[i]));
            return lst;

        }

    }
}
