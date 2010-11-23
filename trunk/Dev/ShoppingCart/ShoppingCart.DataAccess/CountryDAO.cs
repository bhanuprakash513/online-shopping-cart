using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class CountryDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GetAll
            {
                get
                {
                    return "SELECT * FROM Country";
                }
            }

        }

        /// <summary>
        /// Get All Country
        /// </summary>
        /// <returns>List</returns>
        public List<Country> GetAll()
        {
            List<Country> lstcountry = new List<Country>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GetAll, table);
            if (table.Rows.Count > 0)
                Country.Mapping(lstcountry, table);
            return lstcountry;
        }
    }
}
