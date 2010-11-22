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
            public static String GetAll
            {
                get
                {
                    return "SELECT * FROM CardType";
                }
            }
            
        }


        public List<CardType> GetAll()
        {
            List<CardType> lstcardtype = new List<CardType>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GetAll,table);
            if (table.Rows.Count > 0)
                CardType.Mapping(lstcardtype, table);
            return lstcardtype;
        }
    }
}
