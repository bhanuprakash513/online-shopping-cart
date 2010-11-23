using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;
using System.Data;

namespace ShoppingCard.Object
{
     public class OrderItem
    {
         private string orderitemid;
         private int orderid;
         private Product productinfo;
         private int orderquantity;
         private DateTime exwarrantydate;
         private char status;
         private Product productreplace;
         private int quantityreplace;

         public OrderItem()
         {
             orderitemid ="";
             orderid = -1;
             productinfo = new Product();
             orderquantity = 0;
             status = '\0';
             exwarrantydate = new DateTime();
             productreplace = new Product();
             quantityreplace = 0;
         }
         
         public Product ProductReplace
         {
             get
             {
                 return productreplace;
             }
             set
             {
                 productreplace = value;
             }
         }

         public int QuantityReplace
         {
             get
             {
                 return quantityreplace;
             }
             set
             {
                 quantityreplace = value;
             }
         }

         public String OrderItemId
         {
             get
             {
                 return orderitemid;
             }
             set
             {
                 orderitemid = value;
             }
         }
         public int OrderId
         {
             get
             {
                 return orderid;
             }
             set
             {
                 orderid = value;
             }
         }
         public Product ProductInfor
         {
             get
             {
                 return productinfo;
             }
             set
             {
                 productinfo = value;
             }
         }
         public int OrderQuanity
         {
             get
             {
                 return orderquantity;
             }
             set
             {
                 orderquantity = value;
             }
         }

         public char Status
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

         public DateTime ExWarrantyDate
         {
             get
             {
                 return exwarrantydate;
             }
             set
             {
                 exwarrantydate = value;
             }
         }

         /// <summary>
         /// Mapping object
         /// </summary>
         /// <param name="obj">OrderItem</param>
         /// <param name="row">DataRow</param>
         public static void Mapping(OrderItem obj, DataRow row)
         {

             try
             {

                 if (row[ColumnName.ORDERITEM_ORDERID] != null && row[ColumnName.ORDERITEM_ORDERID].ToString() != "")
                     obj.OrderId= Convert.ToInt32(row[ColumnName.ORDERITEM_ORDERID].ToString());
                 if (row[ColumnName.ORDERITEM_ORDERITEMID] != null && row[ColumnName.ORDERITEM_ORDERITEMID].ToString() != "")
                     obj.OrderItemId = row[ColumnName.ORDERITEM_ORDERITEMID].ToString();
                 if (row[ColumnName.ORDERITEM_ORDERQUANTITY] != null && row[ColumnName.ORDERITEM_ORDERQUANTITY].ToString() != "")
                    obj.OrderQuanity = Convert.ToInt32(row[ColumnName.ORDERITEM_ORDERQUANTITY].ToString());
                 if (row[ColumnName.ORDERITEM_EXWARRANTYDATE] != null && row[ColumnName.ORDERITEM_EXWARRANTYDATE].ToString() != "")
                    DateHelper.Mapping(row[ColumnName.ORDERITEM_EXWARRANTYDATE].ToString());
                 if (row[ColumnName.ORDERITEM_STATUS] != null && row[ColumnName.ORDERITEM_STATUS].ToString() != "")
                    obj.Status = Convert.ToChar(row[ColumnName.ORDERITEM_STATUS]);
                if (row[ColumnName.ORDERITEM_PRODUCTREPLACE] != null && row[ColumnName.ORDERITEM_PRODUCTREPLACE].ToString() != "")
                    obj.ProductReplace.ProducId = row[ColumnName.ORDERITEM_PRODUCTREPLACE].ToString();
                if (row[ColumnName.ORDERITEM_QUANTITYREPLACE] != null && row[ColumnName.ORDERITEM_QUANTITYREPLACE].ToString() != "")
                    obj.QuantityReplace= Convert.ToInt32(row[ColumnName.ORDERITEM_QUANTITYREPLACE].ToString());
                 Product.Mapping(obj.ProductInfor, row);

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
         public static void Mapping(List<OrderItem> lst, DataTable table)
         {
             OrderItem obj;
             for (int i = 0; i < table.Rows.Count; i++)
             {
                 obj = new OrderItem();
                 Mapping(obj, table.Rows[i]);
                 lst.Add(obj);
             }
         }
    }
}
