using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class CategoryDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
            {
                get
                {
                    return "SELECT * FROM Category";
                }
            }

        }


        /// <summary>
        /// Get All category
        /// </summary>
        /// <returns>List</returns>
        public List<Category> GetAll()
        {
            List<Category> lstcate = new List<Category>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
                Category.Mapping(lstcate, table);
            return lstcate;
        }
    }
}
