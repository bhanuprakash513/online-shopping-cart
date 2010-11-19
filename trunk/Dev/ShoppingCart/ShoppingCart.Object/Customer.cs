using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
    public class Customer : User
    {
        private Role custrole;
        public Customer()
        {
            custrole = new Role();
            custrole.RoleId = Constant.ROLEID_CUSTOMER;
            custrole.RoleName = Constant.ROLENAME_CUSTOMER;
        }
        public override Role UserRole
        {
            get
            {
                return custrole;
            }
        }

    }
}