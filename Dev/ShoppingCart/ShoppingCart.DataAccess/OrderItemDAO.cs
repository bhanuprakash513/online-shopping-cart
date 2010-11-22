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
                    return " SELECT OrderItem.OrderId,OrderItem.OrderItemId,OrderItem.ProductId,OrderItem.OrderQuantity,OrderItem.ExWarrantyDate,Product.CatId,CatName "+
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

         
        }


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

        public Boolean AddOrderItem(OrderItem orderitem)
        {
            this.paramCollection = new SqlParameter[3];
            this.paramCollection[0] = new SqlParameter("OrderId", orderitem.OrderId);
            this.paramCollection[1] = new SqlParameter("ProductId", orderitem.ProductInfor.ProducId);
            this.paramCollection[2] = new SqlParameter("OrderQuantity", orderitem.OrderQuanity);

            return this.ExecuteStore(StoreDAO.SP_ORDERITEM_INSERTORDERITEM, paramCollection);
        }

        public Boolean UpdateOrderItemByOrderItemId(OrderItem orderitem)
        {
            this.paramCollection = new SqlParameter[3];

            this.paramCollection[0] = new SqlParameter("OrderItemId", orderitem.OrderItemId);
            this.paramCollection[1] = new SqlParameter("ProductId", orderitem.ProductInfor.ProducId);
            this.paramCollection[2] = new SqlParameter("OrderQuantity", orderitem.OrderQuanity);

            return this.ExecuteStore(StoreDAO.SP_ORDERITEM_UPDATEORDERITEM_BY_ORDERITEMID, paramCollection);
        }

        public Boolean DeleteOrderItemByOrderItemId(String orderitemid)
        {
            this.paramCollection = new SqlParameter[1];
            this.paramCollection[0] = new SqlParameter("OrderItemId", orderitemid);
            return this.ExecuteNonQuery(QUERY.DELETE_ORDERITEM_BY_ORDERID, paramCollection);
        }

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
    }
}
