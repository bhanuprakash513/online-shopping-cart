using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
    public class StatusUser
    {
        private int statusid;
        private string statusname;

        public int StatusId
        {
            get
            {
                return statusid;
            }

            set
            {
                statusid = value;
            }
        }
        public String StatusName
        {

            get 
            {
                return statusname;

            }
            set 
            {
                statusname = value;
            }
        }

        }
}
