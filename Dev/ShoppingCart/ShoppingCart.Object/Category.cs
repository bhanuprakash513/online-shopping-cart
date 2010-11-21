using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
   public class Category
    {
       private string catid;
       private string catname;

       public Category()
       {
           catid = "";
           catname = "";
       }

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

       /// <summary>
       /// Mapping object
       /// </summary>
       /// <param name="obj">Category</param>
       /// <param name="row">DataRow</param>
       public static void Mapping(Category obj, DataRow row)
       {
           try
           {
               if (row[ColumnName.CATEGORY_CATID] != null && row[ColumnName.CATEGORY_CATID].ToString() != "")
                   obj.CatId = row[ColumnName.CATEGORY_CATID].ToString();
               if (row[ColumnName.CATEGORY_CATNAME] != null && row[ColumnName.CATEGORY_CATNAME].ToString() != "")
                   obj.CatName = row[ColumnName.CATEGORY_CATNAME].ToString();

           }
           catch (Exception e)
           {
               Console.Write(e.Message);
           }
       }


       /// <summary>
       /// Mapping list
       /// </summary>
       /// <param name="lst">List</param>
       /// <param name="table">DataTable</param>
       public static void Mapping(List<Category> lst, DataTable table)
       {
           Category obj;
           for (int i = 0; i < table.Rows.Count; i++)
           {
               obj = new Category();
               Mapping(obj, table.Rows[i]);
               lst.Add(obj);
           }
       }
    }
}
