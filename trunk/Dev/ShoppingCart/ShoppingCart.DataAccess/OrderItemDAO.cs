using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;
using System.Data.SqlClient;
using ShoppingCart.Common;

namespace ShoppingCart.DataAccess
{
    public class OrderItemDAO :ParentDAO
    {
        public static class QUERY
        {
            public static String GET_ORDERITEM_BY_ORDERID
            {
                get
                {
                    return " SELECT OrderItem.OrderId,OrderItem.OrderItemId,OrderItem.ProductId,OrderItem.OrderQuantity,OrderItem.ExWarrantyDate,Product.CatId,CatName,OrderItem.Status,OrderItem.ProductReplace,OrderItem.QuantityReplace "+
                           " FROM OrderItem,Category,Product "+
                           " WHERE [OrderItem].OrderId = @OrderId "+
	                       " AND OrderItem.ProductId=Product.ProductId "+ 
	                       " And Product.CatId=Category.CatId";
                }
            }

            public static String DELETE_ORDERITEM_BY_ORDERID
            {
                get
                {
                    return "DELETE OrderItem WHERE OrderItemId=@OrderItemId";
                }
            }

            public static String UPDATE_STATUS_BY_ORDERITEMID
            {
                get
                {
                    return "UPDATE OrderItem SET Status=@Status WHERE OrderItem.OrderItemId=@OrderItemId ";
                }
            }

            public static String UPDATE_PRODUCT_REPLACE_BY_ORDERITEMID
            {
                get
                {
                    return "UPDATE OrderItem SET ProductReplace=@ProductReplace,QuantityReplace=@QuantityReplace WHERE OrderItem.OrderItemId=@OrderItemId ";
                }
            }
        }

        /// <summary>
        /// Get all order by order id
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>List</returns>
        public List<OrderItem> GetAllOrderItemByOrderID(int orderid)
        {
            List<OrderItem> lstorderitem= new List<OrderItem>();
            this.paramCollection = new SqlParameter[1];
            DataTable table = new DataTable();
            this.paramCollection[0] = new SqlParameter("OrderId", orderid);
            this.Fill(QUERY.GET_ORDERITEM_BY_ORDERID, this.paramCollection, table);
            if (table.Rows.Count > 0)
                OrderItem.Mapping(lstorderitem, table);
            return lstorderitem;
        }

        /// <summary>
        /// Add a orderitem
        /// </summary>
        /// <param name="orderitem">OrderItem</param>
        /// <returns>Boolean</returns>
        public Boolean AddOrderItem(OrderItem orderitem)
        {
            this.paramCollection = new SqlParameter[4];
            this.paramCollection[0] = new SqlParameter("OrderId", orderitem.OrderId);
            this.paramCollection[1] = new SqlParameter("ProductId", orderitem.ProductInfor.ProducId);
            this.paramCollection[2] = new SqlParameter("OrderQuantity", orderitem.OrderQuanity);
            this.paramCollection[3] = new SqlParameter("Status",Constant.STATUS_ORDERITEM_NEW);

            return this.ExecuteStore(StoreDAO.SP_ORDERITEM_INSERTORDERITEM, paramCollection);
        }

        /// <summary>
        /// Update orderitem by orderitemid
        /// </summary>
        /// <param name="orderitem">OrderItem</param>
        /// <returns>Boolean</returns>
        public Boolean UpdateOrderItemByOrderItemId(OrderItem orderitem)
        {
            this.paramCollection = new SqlParameter[3];

            this.paramCollection[0] = new SqlParameter("OrderItemId", orderitem.OrderItemId);
            this.paramCollection[1] = new SqlParameter("ProductId", orderitem.ProductInfor.ProducId);
            this.paramCollection[2] = new SqlParameter("OrderQuantity", orderitem.OrderQuanity);

            return this.ExecuteStore(StoreDAO.SP_ORDERITEM_UPDATEORDERITEM_BY_ORDERITEMID, paramCollection);
        }

        /// <summary>
        /// Delete orderitem By orderitemid
        /// </summary>
        /// <param name="orderitemid">String</param>
        /// <returns>Boolean</returns>
        public Boolean DeleteOrderItemByOrderItemId(String orderitemid)
        {
            this.paramCollection = new SqlParameter[1];
            this.paramCollection[0] = new SqlParameter("OrderItemId", orderitemid);
            return this.ExecuteNonQuery(QUERY.DELETE_ORDERITEM_BY_ORDERID, paramCollection);
        }

        /// <summary>
        /// Generate OrderItemId
        /// </summary>
        /// <param name="deliveryid">char</param>
        /// <param name="productid">String</param>
        /// <returns>String</returns>
        public String GenerateOrderItemId(char deliveryid,String productid)
        {
            this.paramCollection = new SqlParameter[3]; 
            this.paramCollection[0] = new SqlParameter("DeliveryId",deliveryid);
            this.paramCollection[1] = new SqlParameter("ProductId",productid);
            this.paramCollection[2] = new SqlParameter("IDNew",ColumnDetail.ORDERITEM_ORDERITEMID_TYPE,ColumnDetail.ORDERITEM_ORDERITEMID_LENGTH);
            this.paramCollection[2].Direction = ParameterDirection.Output;
            if (this.ExecuteStore(StoreDAO.SP_ORDERITEM_GENERATEORDERITEMID, paramCollection))
                return paramCollection[2].Value.ToString();
            else
                return "";
        }

        /// <summary>
        /// Update status by orderitemid
        /// </summary>
        /// <param name="orderitemid">String</param>
        /// <param name="status">char</param>
        /// <returns>Boolean</returns>
        public Boolean UpdateStatusByOrderItemId(String orderitemid,char status)
        {
            this.paramCollection = new SqlParameter[2];

            this.paramCollection[0] = new SqlParameter("OrderItemId",orderitemid);
            this.paramCollection[1] = new SqlParameter("Status", status);
          
            return this.ExecuteNonQuery(QUERY.UPDATE_STATUS_BY_ORDERITEMID, paramCollection);
        }

       
        /// <summary>
        /// Update product replace by orderitemid
        /// </summary>
        /// <param name="productreplace">String</param>
        /// <param name="quantity">int</param>
        /// <param name="orderitemid">String</param>
        /// <returns>Boolean</returns>
        public Boolean UpdateProductReplaceByOrderItemId(String productreplace,int quantity,String orderitemid)
        {
            this.paramCollection = new SqlParameter[3];

            this.paramCollection[0] = new SqlParameter("OrderItemId", orderitemid);
            this.paramCollection[1] = new SqlParameter("ProductReplace",productreplace);
            this.paramCollection[2] = new SqlParameter("QuantityReplace",quantity );

            return this.ExecuteNonQuery(QUERY.UPDATE_PRODUCT_REPLACE_BY_ORDERITEMID, paramCollection);
        }

      
    }
}
