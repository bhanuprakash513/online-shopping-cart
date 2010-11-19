using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.Object
{
   public class Category
    {
       private string catid;
       private string catname;

       public String CatId
       {
           get
           {
               return catid;
           }
           set
           {
               catid = value;
           }
       }
       public String CatName
       {
           get
           {
               return catname;
           }
           set
           {
               catname = value;
           }
       }

    }
}
