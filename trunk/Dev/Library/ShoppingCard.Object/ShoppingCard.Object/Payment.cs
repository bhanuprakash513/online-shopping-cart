using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
   public abstract class Payment
    {
       private int payid;
       private PaymentType paytype;
       private StatusPaid status;
       private string paymoney;
       public int PayId
       {
           get 
           {
               return payid;
           }
           set
           {
               payid = value;
           }
       }
       public PaymentType PayType
       {
           get 
           {
                return paytype;
           }
           set
           {
               paytype = value;
           }
       
       }
       public StatusPaid Status
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
       public String PayMoney
       {
           get
           {
               return paymoney;
           }
           set
           {
               paymoney = value;
           }
       }
    }
}
