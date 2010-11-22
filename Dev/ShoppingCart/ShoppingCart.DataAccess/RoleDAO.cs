using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class RoleDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
            {
                get
                {
                    return "SELECT * FROM Role";
                }
            }

        }


        public List<Role> GetAll()
        {
            List<Role> lstrole = new List<Role>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
                Role.Mapping(lstrole, table);
            return lstrole;
        }
    }
}
