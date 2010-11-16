using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
   public class StatusPaid
    {
       private string statuspayid;
       private string statuspayname;

       public String StatusPayId
       {
           get
           {
               return statuspayid;
           }
           set
           {
               statuspayid = value;
           }
       }
       public String StatusPsyName
       {
           get
           {
               return statuspayname;
           }
           set
           {
               statuspayname = value;
           }
       }

    }
}
