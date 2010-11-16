using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
   public class Category
    {
       private int catid;
       private string catname;

       public int CatId
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
