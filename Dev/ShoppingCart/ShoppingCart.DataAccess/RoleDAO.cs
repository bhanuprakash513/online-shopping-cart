using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class RoleDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GETALL
            {
                get
                {
                    return "SELECT * FROM Role";
                }
            }

        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns>List</returns>
        public List<Role> GetAll()
        {
            List<Role> lstrole = new List<Role>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GETALL, table);
            if (table.Rows.Count > 0)
                Role.Mapping(lstrole, table);
            return lstrole;
        }
    }
}
