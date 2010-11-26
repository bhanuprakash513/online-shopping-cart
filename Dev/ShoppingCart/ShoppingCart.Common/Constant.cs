using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ShoppingCart.Common
{
    public class Constant
    {
        public static int ROLEID_ADMIN = 1;
        public static int ROLEID_EMPLOYEE = 2;
        public static int ROLEID_CUSTOMER = 3;

        public static String ROLENAME_ADMIN = "Admin";
        public static String ROLENAME_CUSTOMER = "Customer";
        public static String ROLENAME_EMPLOYEE = "Employee";

        public static int FAQ_TYPE_ID = 1;
        public static int FEEDBACK_TYPE_ID = 2;

        public static int PAYMENTTYPE_CC = 3;
        public static int PAYMENTTYPE_DD = 2;
        public static int PAYMENTTYPE_VPP = 4;
        public static int PAYMENTTYPE_CHEQUE = 1;

        public static int ID_FALSE = -1;

        public static int STATUSDELIVERYID_NEW = 1;
        public static int STATUSDELIVERYID_UNDONE = 2;
        public static int STATUSDELIVERYID_DONE = 3;
        public static int STATUSDELIVERYID_RETURN = 4;

        public static char STATUS_ORDERITEM_NEW = 'A';
        public static char STATUS_ORDERITEM_DELETE = 'D';
        public static char STATUS_ORDERITEM_REPLACE = 'R';

        public static int STATUSID_ACTIVE = 1;
        public static int STATUSID_INACTIVE = 2;

        public static int EX_WEEK_ORDER = 7;


        public static int NUM_RECORD_DIVIDE = 10;
        public static int NUM_PAGE_DIVIDE = 5;
    }
}

