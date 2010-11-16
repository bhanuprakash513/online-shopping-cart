using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
   public class Product
    {
       private int productid;
       private Category producttype;
       private string productname;
       private string price;
       private string description;
       private int warrantyday;
       private string image;
       private int quantity;

       public int ProducId
       {
           get
           {
               return productid;
           }
           set
           {
               productid = value;
           }
       }
       public Category ProductType
       {
           get
           {
               return producttype;
           }
           set
           {
               producttype = value;
           }
       }
      
       public String ProductName
       {
           get
           {
               return productname;
           }
           set
           {
               productname = value;
           }
       }
       public String Price
       {
           get
           {
               return price;
           }
           set
           {
               price= value;
           }
       }
       public String Description
       {
           get
           {
               return description;
           }
           set
           {
               description = value;
           }
       }
       public int WarrantyDay
       {
           get
           {
               return warrantyday;
           }
           set
           {
               warrantyday = value;
           }
       }
       public String Image
       {
           get
           {
               return image;
           }
           set
           {
               image = value;
           }
       }
       public int Quantity
       {
           get
           {
               return quantity;
           }
           set
           {
               quantity = value;
           }
       }
 


    }
}
