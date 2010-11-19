using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
    public class Role
    {
        private int roleid;
        private string rolename;

        public int RoleId
        {
            get
            {
                return roleid;
            }
            set
            {
                roleid = value;
            }

        }
        public String RoleName
        {
            get
            {
                return rolename;
            }
            set
            {
                rolename = value;
            }
        }

        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="obj">Role</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(Role obj, DataRow row)
        {
            
            try
            {
                
                if(row[ColumnName.ROLE_ROLEID]!=null)
                    obj.RoleId = Convert.ToInt32(row[ColumnName.ROLE_ROLEID].ToString());
                if(row[ColumnName.ROLE_ROLENAME]!=null)
                    obj.RoleName = row[ColumnName.ROLE_ROLENAME].ToString();
            
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        
        }

        /// <summary>
        /// Mapping List
        /// </summary>
        /// <param name="lst">List</param>
        /// <param name="table">DataTable</param>
        public static void Mapping(List<Role> lst, DataTable table)
        {
            Role obj;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                obj = new Role();
                Mapping(obj,table.Rows[i]);
                lst.Add(obj);
            }
        }
    }
}
