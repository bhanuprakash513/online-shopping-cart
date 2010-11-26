using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Object;
using System.Data;

namespace ShoppingCart.DataAccess
{
    public class DeliveryTypeDAO : ParentDAO
    {
        public static class QUERY
        {
            public static String GET_ALL
            {
                get
                {
                    return "SELECT * FROM DeliveryType";
                }
            }

            public static String GET_DELIVERYTYPE_BY_DELIVERYID
            {
                get
                {
                    return "SELECT * FROM DeliveryType WHERE DeliveryId=@DeliveryId";
                }
            }

        }

        /// <summary>
        /// Get all delivery type
        /// </summary>
        /// <returns>List</returns>
        public List<DeliveryType> GetAll()
        {
            List<DeliveryType> lstdeliverytype = new List<DeliveryType>();
            DataTable table = new DataTable();
            this.Fill(QUERY.GET_ALL, table);
            if (table.Rows.Count > 0)
               DeliveryType.Mapping(lstdeliverytype, table);
            return lstdeliverytype;
        }

        /// <summary>
        /// Get delivery type by deliveryid
        /// </summary>
        /// <param name="deliveryid">char</param>
        /// <returns>DeliveryType</returns>
        public DeliveryType GetDeliveryTypeByDeliveryId(Char deliveryid)
        {
            DeliveryType deliverytype = new DeliveryType();
            DataTable table = new DataTable();
            paramCollection = new System.Data.SqlClient.SqlParameter[1];
            paramCollection[0] = new System.Data.SqlClient.SqlParameter("DeliveryId", deliveryid);
            this.Fill(QUERY.GET_DELIVERYTYPE_BY_DELIVERYID,paramCollection,table);
            if (table.Rows.Count > 0)
                DeliveryType.Mapping(deliverytype, table.Rows[0]);
            return deliverytype;
        }
    }
}
