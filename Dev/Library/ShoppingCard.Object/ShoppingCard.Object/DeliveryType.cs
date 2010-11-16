using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
   public class DeliveryType
    {
       private int deliveryid;
       private string deliveryname;
       private string deliverycost;

       public int DeliveryId
       {
           get
           {
               return deliveryid;
           }
           set
           {
               deliveryid = value;
           }
       }
       public String DeliveryName
       {
           get
           {
               return deliveryname;
           }
           set
           {
               deliveryname= value;
           }
       }
       public String DeliveryCost
       {
           get
           {
               return deliverycost ;
           }
           set
           {
               deliverycost = value;
           }
       }
    }
}
