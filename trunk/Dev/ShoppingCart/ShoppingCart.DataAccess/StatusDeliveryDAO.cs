using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class StatusDeliveryDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
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
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
                StatusDelivery.Mapping(lststatusdelivery, table);
            return lststatusdelivery;
        }
    }
}
