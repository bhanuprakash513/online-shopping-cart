using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCart.Object
{
   public class Payment
    {
       private int payid;
       private PaymentType paytype;
       private StatusPaid status;
       private string paymoney;

       public Payment()
       {
           paytype = new PaymentType();
           status = new StatusPaid();
           payid = -1;
       }

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
