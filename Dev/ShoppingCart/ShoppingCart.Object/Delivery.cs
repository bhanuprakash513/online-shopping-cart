using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ShoppingCart.Object
{
   public class Delivery
    {
       private StatusDelivery status;
       private DeliveryType type;

       public Delivery()
       {
           status = new StatusDelivery();
           type = new DeliveryType();
       }

       public StatusDelivery Status
       {
           get
           {
               return status;
           }
           set
           {
               status = value;
           }
       }
       public DeliveryType Type
       {
           get
           {
               return type;
           }
           set
           {
               type = value;
           }
       }


       /// <summary>
       /// Mapping object
       /// </summary>
       /// <param name="obj">Delivery</param>
       /// <param name="row">DataRow</param>
       public static void Mapping(Delivery obj, DataRow row)
       {
           StatusDelivery.Mapping(obj.Status, row);
           DeliveryType.Mapping(obj.Type, row);
       }

       /// <summary>
       /// Mapping list
       /// </summary>
       /// <param name="lst">List</param>
       /// <param name="table">DataTable</param>
       public static void Mapping(List<Delivery> lst, DataTable table)
       {
           Delivery obj;
           for (int i = 0; i < table.Rows.Count; i++)
           {
               obj = new Delivery();
               Mapping(obj, table.Rows[i]);
               lst.Add(obj);
           }
       }
    }
}
