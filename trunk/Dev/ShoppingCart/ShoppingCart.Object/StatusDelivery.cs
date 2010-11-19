using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
   public class StatusDelivery
    {
       private int statusdeliveryid;
       private string statusdeliveryname;
       
       public int StatusDeliveryId
       {
           get 
           {
               return statusdeliveryid;
           }
           set
           {
               statusdeliveryid = value;
           }
       }
       public String StatusDeliveryName
       {
           get
           {
               return statusdeliveryname;
           }
           set
           {
               statusdeliveryname = value;
           }
       }

       /// <summary>
       /// Mapping object
       /// </summary>
       /// <param name="obj">StatusDelivery</param>
       /// <param name="row">DataRow</param>
       public static void Mapping(StatusDelivery obj, DataRow row)
       {
           try
           {
               if (row[ColumnName.STATUSDELIVERY_STATUSDELIVERYID] != null)
                   obj.StatusDeliveryId = Convert.ToInt32(row[ColumnName.STATUSDELIVERY_STATUSDELIVERYID]);

               if (row[ColumnName.STATUSDELIVERY_STATUSDELIVERYNAME] != null)
                   obj.StatusDeliveryName = row[ColumnName.STATUSDELIVERY_STATUSDELIVERYID].ToString();
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
       public static void Mapping(List<StatusDelivery> lst, DataTable table)
       {
           StatusDelivery obj;
           for (int i = 0; i < table.Rows.Count; i++)
           {
               obj = new StatusDelivery();
               Mapping(obj, table.Rows[i]);
               lst.Add(obj);
           }
       }
    }
}
