using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
   public class Product
    {
       private string productid;
       private Category producttype;
       private string productname;
       private string price;
       private string description;
       private int warrantyday;
       private string image;
       private int quantity;

       public Product()
       {
           productid = "";
           productname = "";
           price = "0";
           description = "";
           warrantyday = 0;
           image = "";
           quantity = 0;
           producttype = new Category();
       }

       public String ProducId
       {
           get
           {
               return productid;
           }
           set
           {
               productid = value;
           }
       }
       public Category ProductType
       {
           get
           {
               return producttype;
           }
           set
           {
               producttype = value;
           }
       }
      
       public String ProductName
       {
           get
           {
               return productname;
           }
           set
           {
               productname = value;
           }
       }
       public String Price
       {
           get
           {
               return price;
           }
           set
           {
               price= value;
           }
       }
       public String Description
       {
           get
           {
               return description;
           }
           set
           {
               description = value;
           }
       }
       public int WarrantyDay
       {
           get
           {
               return warrantyday;
           }
           set
           {
               warrantyday = value;
           }
       }
       public String Image
       {
           get
           {
               return image;
           }
           set
           {
               image = value;
           }
       }
       public int Quantity
       {
           get
           {
               return quantity;
           }
           set
           {
               quantity = value;
           }
       }

       /// <summary>
       /// Mapping object
       /// </summary>
       /// <param name="obj">Product</param>
       /// <param name="row">DataRow</param>
       public static void Mapping(Product obj, DataRow row)
       {

           try
           {

               if (row[ColumnName.PRODUCT_CATID] != null && row[ColumnName.PRODUCT_CATID].ToString() != "")
                   Category.Mapping(obj.ProductType,row);
               if (row[ColumnName.PRODUCT_PRODUCTID] != null && row[ColumnName.PRODUCT_PRODUCTID].ToString() != "")
                   obj.ProducId = row[ColumnName.PRODUCT_PRODUCTID].ToString();
               if (row[ColumnName.PRODUCT_PRODUCTNAME] != null && row[ColumnName.PRODUCT_PRODUCTNAME].ToString() != "")
                   obj.ProductName= row[ColumnName.PRODUCT_PRODUCTNAME].ToString();
               if (row[ColumnName.PRODUCT_PRICE] != null && row[ColumnName.PRODUCT_PRICE].ToString() != "")
                   obj.Price= row[ColumnName.PRODUCT_PRICE].ToString();
               if (row[ColumnName.PRODUCT_DESCRIPTION] != null && row[ColumnName.PRODUCT_DESCRIPTION].ToString() != "")
                   obj.Description= row[ColumnName.PRODUCT_DESCRIPTION].ToString();
               if (row[ColumnName.PRODUCT_WARRANTYDAY] != null && row[ColumnName.PRODUCT_WARRANTYDAY].ToString() != "")
                   obj.WarrantyDay= Convert.ToInt32(row[ColumnName.PRODUCT_WARRANTYDAY].ToString());
               if (row[ColumnName.PRODUCT_IMAGE] != null && row[ColumnName.PRODUCT_IMAGE].ToString() != "")
                   obj.Image= row[ColumnName.PRODUCT_IMAGE].ToString();
               if (row[ColumnName.PRODUCT_QUANTITY] != null && row[ColumnName.PRODUCT_QUANTITY].ToString() != "")
                   obj.Quantity= Convert.ToInt32(row[ColumnName.PRODUCT_QUANTITY].ToString());

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
       public static void Mapping(List<Product> lst, DataTable table)
       {
           Product obj;
           for (int i = 0; i < table.Rows.Count; i++)
           {
               obj = new Product();
               Mapping(obj, table.Rows[i]);
               lst.Add(obj);
           }
       }

    }
}
