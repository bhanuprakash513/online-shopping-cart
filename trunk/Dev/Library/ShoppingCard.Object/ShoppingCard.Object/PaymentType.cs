using
System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
    public class PaymentType
    {
        private int paytypeid;
        private string paytypename;

        public int PayTypeId
        {
            get
            {
                return paytypeid;
            }
            set
            {
                paytypeid = value;
            }
        }
        public String PayTypeName
        {
            get
            {
                return paytypename;
            }
            set
            {
                paytypename = value;
            }

        }
    }
}
