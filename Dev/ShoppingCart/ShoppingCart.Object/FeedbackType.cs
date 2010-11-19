using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

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


         /// <summary>
         /// Mapping object
         /// </summary>
         /// <param name="obj">FeedbackType</param>
         /// <param name="row">DataRow</param>
         public static void Mapping(FeedbackType obj, DataRow row)
         {
             try
             {
                 if (row[ColumnName.FEEDBACKTYPE_FEEDTYPEID]!=null)
                    obj.FeedTypeId = Convert.ToInt32(row[ColumnName.FEEDBACKTYPE_FEEDTYPEID].ToString());
                 if(row[ColumnName.FEEDBACKTYPE_FEEDTYPENAME]!=null)
                    obj.FeedTypeName = row[ColumnName.FEEDBACKTYPE_FEEDTYPENAME].ToString();
             }
             catch (Exception e)
             {
                 Console.Write(e.Message);
             }
         }

         /// <summary>
         /// Mapping List
         /// </summary>
         /// <param name="lst">List</param>
         /// <param name="table">DataTable</param>
         public static void Mapping(List<FeedbackType> lst, DataTable table)
         {
             FeedbackType obj;
             for (int i = 0; i < table.Rows.Count; i++)
             {
                 obj = new FeedbackType();
                 Mapping(obj,table.Rows[i]);
                 lst.Add(obj);
             }
         }

    }
}
