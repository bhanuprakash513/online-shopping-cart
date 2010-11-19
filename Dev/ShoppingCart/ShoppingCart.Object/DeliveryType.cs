using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
   public class DeliveryType
    {
       private char deliveryid;
       private string deliveryname;
       private string deliverycost;

       public char DeliveryId
       {
           get
           {
               return deliveryid;
           }
           set
           {
               deliveryid = value;
           }
       }
       public String DeliveryName
       {
           get
           {
               return deliveryname;
           }
           set
           {
               deliveryname= value;
           }
       }
       public String DeliveryCost
       {
           get
           {
               return deliverycost ;
           }
           set
           {
               deliverycost = value;
           }
       }

       /// <summary>
       /// Mapping object
       /// </summary>
       /// <param name="obj">DeliveryType</param>
       /// <param name="row">DataRow</param>
       public static void Mapping(DeliveryType obj, DataRow row)
       {

           try
           {
                if(row[ColumnName.DELIVERY_DELIVERYID]!=null)
                    obj.DeliveryId=Convert.ToChar(row[ColumnName.DELIVERY_DELIVERYID]);
                    
                if(row[ColumnName.DELIVERY_DELIVERYNAME]!=null)
                    obj.DeliveryName=row[ColumnName.DELIVERY_DELIVERYNAME].ToString();

                if (row[ColumnName.DELIVERY_DELIVERYCOST] != null)
                    obj.DeliveryCost = row[ColumnName.DELIVERY_DELIVERYCOST].ToString();

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
       public static void Mapping(List<DeliveryType> lst, DataTable table)
       {
           DeliveryType obj;
           for (int i = 0; i < table.Rows.Count; i++)
           {
               obj = new DeliveryType();
               Mapping(obj, table.Rows[i]);
               lst.Add(obj);
           }
       }
    }
}
