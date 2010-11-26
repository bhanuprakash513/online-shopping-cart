using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;
using System.Data.SqlClient;

namespace ShoppingCart.DataAccess
{
    public class DateHelperDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GET_DATE_CURRENT
            {
                get
                {
                    return "SELECT GETDATE() As Date";
                }
            }

            public static String ADD_DATE_WITH_DAY
            {
                get
                {
                    return "SELECT DATEADD(dd,@Day,@DateTime) As Date";
                }
            }
        }

        /// <summary>
        /// Get date current
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetDateCurrent()
        {
            DataTable table=new DataTable();

            this.Fill(QUERY.GET_DATE_CURRENT, table);
            try
            {
                return DateHelper.Mapping(table.Rows[0][ColumnName.DATE_DATE].ToString());
            }
            catch (Exception e)
            {
                Console.Write(e.Message); 
            }
            return new DateTime();
        }

        /// <summary>
        /// Add date with a day
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <param name="day">int</param>
        /// <returns>DateTime</returns>
        public DateTime AddDateWithDay(DateTime date,int day)
        {
            DataTable table = new DataTable();
            paramCollection = new SqlParameter[2];
            paramCollection[0] = new SqlParameter("Day",SqlDbType.Int);
            paramCollection[0].Value = day.ToString();
            paramCollection[1] = new SqlParameter("DateTime",DateHelper.Mapping(date));
            this.Fill(QUERY.ADD_DATE_WITH_DAY,paramCollection,table);
            if (table.Rows.Count > 0)
            {
                return DateHelper.Mapping(table.Rows[0][ColumnName.DATE_DATE].ToString());
            }
            else
                return new DateTime();
        }

    }
}
