using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class FeedbackTypeDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GETALL
            {
                get
                {
                    return "SELECT * FROM FeedbackType";
                }
            }

        }

        /// <summary>
        /// Get All FeedbackType
        /// </summary>
        /// <returns>List</returns>
        public List<FeedbackType> GetAll()
        {
            List<FeedbackType> lstfeedbacktype = new List<FeedbackType>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GETALL, table);
            if (table.Rows.Count > 0)
                FeedbackType.Mapping(lstfeedbacktype, table);
            return lstfeedbacktype;
        }
    }
}
