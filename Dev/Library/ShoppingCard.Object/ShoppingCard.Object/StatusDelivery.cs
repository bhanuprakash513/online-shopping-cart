using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
   public class StatusDelivery
    {
       private int statusdeliveryid;
       private string statusdeliveryname;
       
       public int StatusDeliveryId
       {
           get 
           {
               return statusdeliveryid;
           }
           set
           {
               statusdeliveryid = value;
           }
       }
       public String StatusDeliveryName
       {
           get
           {
               return statusdeliveryname;
           }
           set
           {
               statusdeliveryname = value;
           }
       }
    }
}
