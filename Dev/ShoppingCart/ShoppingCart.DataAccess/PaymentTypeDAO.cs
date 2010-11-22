using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class PaymentTypeDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
            {
                get
                {
                    return "SELECT * FROM PaymentType";
                }
            }

        }


        public List<PaymentType> GetAll()
        {
            List<PaymentType> lstpaytype= new List<PaymentType>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
                PaymentType.Mapping(lstpaytype, table);
            return lstpaytype;
        }
    }
}
