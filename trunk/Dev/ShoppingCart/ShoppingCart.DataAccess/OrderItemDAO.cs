using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;
using System.Data;
using System.Data.SqlClient;

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
    }
}
