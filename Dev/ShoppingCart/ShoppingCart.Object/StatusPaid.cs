using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
   public class StatusPaid
    {
       private int statuspayid;
       private string statuspayname;

       public int StatusPayId
       {
           get
           {
               return statuspayid;
           }
           set
           {
               statuspayid = value;
           }
       }
       public String StatusPayName
       {
           get
           {
               return statuspayname;
           }
           set
           {
               statuspayname = value;
           }
       }

       /// <summary>
       /// Mapping object
       /// </summary>
       /// <param name="obj">StatusPaid</param>
       /// <param name="table">DataTable</param>
       public static void Mapping(StatusPaid obj, DataRow row)
       {
           try
           {
               if(row[ColumnName.STATUSPAID_STATUSPAIDID]!=null)
                   obj.StatusPayId=Convert.ToInt32(row[ColumnName.STATUSPAID_STATUSPAIDID].ToString());

               if (row[ColumnName.STATUSPAID_STATUSPAIDNAME] != null)
                   obj.StatusPayName = row[ColumnName.STATUSPAID_STATUSPAIDNAME].ToString();

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
       public static void Mapping(List<StatusPaid> lst, DataTable table)
       {
           StatusPaid obj;
           for (int i = 0; i < table.Rows.Count; i++)
           {
               obj = new StatusPaid();
               Mapping(obj, table.Rows[i]);
               lst.Add(obj);
           }
       }
    }
}
