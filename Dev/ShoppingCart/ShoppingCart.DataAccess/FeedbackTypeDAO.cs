using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class FeedbackTypeDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
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
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
                FeedbackType.Mapping(lstfeedbacktype, table);
            return lstfeedbacktype;
        }
    }
}
