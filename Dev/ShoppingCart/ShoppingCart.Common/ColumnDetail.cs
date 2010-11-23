using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ShoppingCart.Common
{
    public class ColumnDetail
    {

        public static int ORDERITEM_ORDERITEMID_LENGTH = 16;
        public static SqlDbType ORDERITEM_ORDERITEMID_TYPE
        {
            get
            {
                return SqlDbType.VarChar;
            }
        }

        public static int PRODUCT_PRODUCTID_LENGTH = 7;
        public static SqlDbType PRODUCT_PRODUCTID_TYPE
        {
            get
            {
                return SqlDbType.VarChar;
            }
        }

    }
}
