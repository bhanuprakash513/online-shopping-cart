using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;
using ShoppingCard.Object;
using System.Data.SqlClient;
using System.Data;
using ShoppingCart.Common.DatabaseTableAdapters;

namespace ShoppingCart.DataAccess
{
    public class ProductDAO : ParentDAO
    {
        ProductCategoryTableAdapter procatadapter;
        public ProductDAO()
        {
            procatadapter= new ProductCategoryTableAdapter();
        }

        public Database.ProductCategoryDataTable GetAllProduct()
        {
            Database.ProductCategoryDataTable table = new Database.ProductCategoryDataTable();
            procatadapter.Fill(table);
            return table;
        }

        public Product GetProductById(String id)
        {
            Database.ProductCategoryDataTable table = this.GetAllProduct();
            Product productobject = new Product();
            Category categoryobject = new Category();
            foreach (Database.ProductCategoryRow thisrow in table.Rows)
            {
                if (thisrow.ProductId == id)
                {
                    productobject.ProducId = thisrow.ProductId;
                    productobject.ProductName = thisrow.ProductName;
                    productobject.Price = Convert.ToString(thisrow.Price);
                    productobject.Description = thisrow.Description;
                    productobject.Image = thisrow.Image;
                    productobject.Quantity = thisrow.Quantity;
                    productobject.WarrantyDay = thisrow.WarantyDay;
                    productobject.ProductType.CatName = thisrow.CatName;
                }

            }
            return productobject;
        }

        public Boolean AddProduct(Product productobject)
        {
            string sql = "INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity)" +
                    " VALUES (@ProductId,@CatId,@ProductName,@Price,@Description,@WarantyDay,@Image,@Quantity)";
            SqlParameter[] paras = new SqlParameter[8];
            paras[0] = new SqlParameter("@ProductId", productobject.ProducId);
            paras[1] = new SqlParameter("@CatId", productobject.ProductType.CatId);
            paras[2] = new SqlParameter("@ProductName", productobject.ProductName);
            paras[3] = new SqlParameter("@Price", productobject.Price);
            paras[4] = new SqlParameter("@Description", productobject.Description);
            paras[5] = new SqlParameter("@WarantyDay", productobject.WarrantyDay);
            paras[6] = new SqlParameter("@Image", productobject.Image);
            paras[7] = new SqlParameter("@Quantity", productobject.Quantity);


            return this.ExecuteNonQuery(sql, paras);
        }

        public Boolean EditProduct(Product productobject)
        {
            string sql = "UPDATE Product " +
                    "SET CatId=@CatId,ProductName=@ProductName,Price=@Price,Description=@Description,WarantyDay=@WarantyDay,Image=@Image,Quantity=@Quantity" +
                    "WHERE ProductId=@ProductId";
            SqlParameter[] paras = new SqlParameter[8];
            paras[0] = new SqlParameter("@ProductId", productobject.ProducId);
            paras[1] = new SqlParameter("@CatId", productobject.ProductType.CatId);
            paras[2] = new SqlParameter("@ProductName", productobject.ProductName);
            paras[3] = new SqlParameter("@Price", productobject.Price);
            paras[4] = new SqlParameter("@Description", productobject.Description);
            paras[5] = new SqlParameter("@WarantyDay", productobject.WarrantyDay);
            paras[6] = new SqlParameter("@Image", productobject.Image);
            paras[7] = new SqlParameter("@Quantity", productobject.Quantity);


            return this.ExecuteNonQuery(sql, paras);
        }

        public Boolean DeleteProduct(int productid)
        {
            string sql = "DELETE Product WHERE ProductId = @ProductId";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@ProductId", productid);
            return this.ExecuteNonQuery(sql, paras);
        }

        public Database.ProductCategoryDataTable GetProductByProductName(string productname)
        {
            Database.ProductCategoryDataTable table = new Database.ProductCategoryDataTable();
            string sql = "SELECT * FROM ProductCategory WHERE ProductName like '%" + productname + "%'";
            this.Fill(sql, table);
            return table;
        }

        public Database.ProductCategoryDataTable GetProductByCategory(int category)
        {
            Database.ProductCategoryDataTable table = new Database.ProductCategoryDataTable();
            string sql = "SELECT * FROM ProductCategory WHERE CatId = " + category;
            this.Fill(sql, table);
            return table;
        }

        /// <summary>
        /// Auto generate id of product
        /// </summary>
        /// <returns>String</returns>
        public String GenerateProductID()
        {
            try
            {
                this.paramCollection = new SqlParameter[1];
                this.paramCollection[0] = new SqlParameter("IDNew", ColumnDetail.PRODUCT_PRODUCTID_TYPE, ColumnDetail.PRODUCT_PRODUCTID_LENGTH);
                this.paramCollection[0].Direction = ParameterDirection.Output;
                if (this.ExecuteStore(StoreDAO.SP_PRODUCT_GENERATEPRODUCTID,paramCollection))
                    return paramCollection[0].Value.ToString();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return "";
        }
    }
}
