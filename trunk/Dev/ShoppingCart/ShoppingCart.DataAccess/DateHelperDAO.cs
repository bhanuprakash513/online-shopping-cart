using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.DataAccess
{
    public class DateHelperDAO : ParentDAO
    {
        public static class Query
        {
            public static String GetDateCurrent
            {
                get
                {
                    return "SELECT GETDATE() As Date";
                }
            }
        }

        /// <summary>
        /// Get Date Current
        /// </summary>
        public DateTime GetDateCurrent()
        {
            DataTable table=new DataTable();

            this.Fill(Query.GetDateCurrent, table);
            return DateHelper.Mapping(table.Rows[0][ColumnName.DATE_DATE].ToString());
        }

    }
}
