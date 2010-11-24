using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;
using System.Data.SqlClient;

namespace ShoppingCart.DataAccess
{
    public class CardTypeDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GETALL
            {
                get
                {
                    return "SELECT * FROM CardType";
                }
            }
            
        }


        /// <summary>
        /// Get All CardType
        /// </summary>
        /// <returns>List</returns>
        public List<CardType> GetAll()
        {
            List<CardType> lstcardtype = new List<CardType>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GETALL,table);
            if (table.Rows.Count > 0)
                CardType.Mapping(lstcardtype, table);
            return lstcardtype;
        }
    }
}
