using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
   public class Delivery
    {
       private StatusDelivery status;
       private DeliveryType type;

       public StatusDelivery Status
       {
           get
           {
               return status;
           }
           set
           {
               status = value;
           }
       }
       public DeliveryType Type
       {
           get
           {
               return type;
           }
           set
           {
               type = value;
           }
       }

    }
}
