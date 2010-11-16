using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
