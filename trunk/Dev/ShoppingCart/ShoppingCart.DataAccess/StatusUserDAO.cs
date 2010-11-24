using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class StatusUserDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GETALL
            {
                get
                {
                    return "SELECT * FROM StatusUser";
                }
            }

        }

        /// <summary>
        /// Get all status user
        /// </summary>
        /// <returns>List</returns>
        public List<StatusUser> GetAll()
        {
            List<StatusUser> lststatususer = new List<StatusUser>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GETALL, table);
            if (table.Rows.Count > 0)
                StatusUser.Mapping(lststatususer, table);
            return lststatususer;
        }
    }
}
