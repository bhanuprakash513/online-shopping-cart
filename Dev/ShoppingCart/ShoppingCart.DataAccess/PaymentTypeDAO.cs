using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class PaymentTypeDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GETALL
            {
                get
                {
                    return "SELECT * FROM PaymentType";
                }
            }

        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns>List</returns>
        public List<PaymentType> GetAll()
        {
            List<PaymentType> lstpaytype= new List<PaymentType>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GETALL, table);
            if (table.Rows.Count > 0)
                PaymentType.Mapping(lstpaytype, table);
            return lstpaytype;
        }
    }
}
