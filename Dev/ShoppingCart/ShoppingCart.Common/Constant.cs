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

        public static int STATUSDELIVERY_DONE = 2;
        public static int STATUSDELIVERY_UNDONE = 1;
        public static int STATUSDELIVERY_RETURN = 3;
        
    }
}

