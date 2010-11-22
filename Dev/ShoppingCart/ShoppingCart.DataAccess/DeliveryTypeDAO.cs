using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class DeliveryTypeDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
            {
                get
                {
                    return "SELECT * FROM DeliveryType";
                }
            }

        }


        public List<DeliveryType> GetAll()
        {
            List<DeliveryType> lstdeliverytype = new List<DeliveryType>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
               DeliveryType.Mapping(lstdeliverytype, table);
            return lstdeliverytype;
        }
    }
}
