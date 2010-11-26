using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class StatusDeliveryDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GETALL
            {
                get
                {
                    return "SELECT * FROM StatusDelivery";
                }
            }

        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns>List</returns>
        public List<StatusDelivery> GetAll()
        {
            List<StatusDelivery> lststatusdelivery = new List<StatusDelivery>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GETALL, table);
            if (table.Rows.Count > 0)
                StatusDelivery.Mapping(lststatusdelivery, table);
            return lststatusdelivery;
        }
    }
}
