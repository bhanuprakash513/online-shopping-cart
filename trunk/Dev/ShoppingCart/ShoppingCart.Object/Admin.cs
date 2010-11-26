using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{
   public class Admin : User
   {
       public Role adminrole;
       public Admin()
       {
           adminrole=new Role();
           adminrole.RoleId=Constant.ROLEID_ADMIN;
           adminrole.RoleName=Constant.ROLENAME_ADMIN;
       }

       public override Role UserRole
       {
           get
           {
               return adminrole;
           }
       }   
   }
}
