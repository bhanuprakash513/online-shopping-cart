using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.Object
{
     public class OrderItem
    {
         private int orderitemid;
         private int orderid;
         private Product productinfo;
         private int orderquantity;

         public OrderItem()
         {
             productinfo = new Product();
         }
    
         public int OrderItemId
         {
             get
             {
                 return orderitemid;
             }
             set
             {
                 orderitemid = value;
             }
         }
         public int OrderId
         {
             get
             {
                 return orderid;
             }
             set
             {
                 orderid = value;
             }
         }
         public Product Productinfor
         {
             get
             {
                 return productinfo;
             }
             set
             {
                 productinfo = value;
             }
         }
         public int OrderQuanity
         {
             get
             {
                 return orderquantity;
             }
             set
             {
                 orderquantity = value;
             }
         }
    }
}
