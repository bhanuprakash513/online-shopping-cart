using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
     public class FeedbackType
    {
         private int feedtypeid;
         private string feedtypename;

         public int FeedTypeId
         {
             get 
             {
                 return feedtypeid;
             }
             set
             {
                 feedtypeid = value;
             }
         }
         public String FeedTypeName
         {
             get
             {
                 return feedtypename;
             }
             set
             {
                 feedtypename = value;
             }
         }
    }
}
