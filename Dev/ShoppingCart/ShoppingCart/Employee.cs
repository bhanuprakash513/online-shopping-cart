using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
   public class Employee : User
   {
       private Role emprole;
       public Employee()
       {
           emprole=new Role();
           emprole.RoleId=Constant.ROLEID_EMPLOYEE;
           emprole.RoleName = Constant.ROLENAME_EMPLOYEE;

       }
       public override Role UserRole
       {
           get
           {
               return emprole;
           }

       }

   }
}
