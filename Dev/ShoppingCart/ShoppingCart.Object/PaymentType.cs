using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{
    public class PaymentType
    {
        private int paytypeid;
        private string paytypename;

        public PaymentType()
        {
            paytypeid = -1;
            paytypename = "";
        }

        public int PayTypeId
        {
            get
            {
                return paytypeid;
            }
            set
            {
                paytypeid = value;
            }
        }
        public String PayTypeName
        {
            get
            {
                return paytypename;
            }
            set
            {
                paytypename = value;
            }
        }


        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="obj">PaymentType</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(PaymentType obj, DataRow row)
        {

            try
            {
                if (row[ColumnName.PAYMENTTYPE_PAYTYPEID] != null && row[ColumnName.PAYMENTTYPE_PAYTYPEID].ToString()!="")
                    obj.PayTypeId = Convert.ToInt32(row[ColumnName.PAYMENTTYPE_PAYTYPEID].ToString());
                if (row[ColumnName.PAYMENTTYPE_PAYTYPENAME] != null && row[ColumnName.PAYMENTTYPE_PAYTYPENAME].ToString()!="")
                    obj.PayTypeName = row[ColumnName.PAYMENTTYPE_PAYTYPENAME].ToString();

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }


        /// <summary>
        /// Mapping list
        /// </summary>
        /// <param name="lst">List</param>
        /// <param name="table">DataTable</param>
        public static void Mapping(List<PaymentType> lst, DataTable table)
        {
            PaymentType obj;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                obj = new PaymentType();
                Mapping(obj, table.Rows[i]);
                lst.Add(obj);
            }
        }
    }
}
