using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class StatusPaidDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
            {
                get
                {
                    return "SELECT * FROM StatusPaid";
                }
            }

        }

        /// <summary>
        /// Get all status paid
        /// </summary>
        /// <returns>List</returns>
        public List<StatusPaid> GetAll()
        {
            List<StatusPaid> lststatuspaid = new List<StatusPaid>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
                StatusPaid.Mapping(lststatuspaid, table);
            return lststatuspaid;
        }
    }
}
