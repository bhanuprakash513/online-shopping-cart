using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{
    public class StatusUser
    {
        private int statusid;
        private string statusname;

        public StatusUser()
        {
            statusid = -1;
            statusname = "";
        }

        public int StatusId
        {
            get
            {
                return statusid;
            }

            set
            {
                statusid = value;
            }
        }
        public String StatusName
        {

            get 
            {
                return statusname;

            }
            set 
            {
                statusname = value;
            }
        }


        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="obj">StatusUser</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(StatusUser obj,DataRow row)
        { 
            try
            {

                if (row[ColumnName.STATUSUSER_STATUSUSERID] != null && row[ColumnName.STATUSUSER_STATUSUSERID].ToString()!="")
                    obj.StatusId = Convert.ToInt32(row[ColumnName.STATUSUSER_STATUSUSERID].ToString());
                if (row[ColumnName.STATUSUSER_STATUSUSERNAME] != null && row[ColumnName.STATUSUSER_STATUSUSERNAME].ToString()!="")
                    obj.StatusName = row[ColumnName.STATUSUSER_STATUSUSERNAME].ToString();
            
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
        }


        /// <summary>
        /// Mapping list
        /// </summary>
        /// <param name="lst">List</param>
        /// <param name="table">DataTable</param>
        public static void Mapping(List<StatusUser> lst,DataTable table)
        {
            StatusUser obj;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                obj = new StatusUser();
                Mapping(obj,table.Rows[i]);
                lst.Add(obj);
            }
        }
    }
}
