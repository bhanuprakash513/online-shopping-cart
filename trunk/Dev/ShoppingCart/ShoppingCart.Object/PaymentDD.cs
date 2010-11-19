using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;

namespace ShoppingCart.Object
{
    public class PaymentDD : Payment
    {
        private string title;
        private string payway;
        private string payplace;
        private string payername;
        private string releaseplace;
        private string drawername;


        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public String PayWay
        {
            get
            {
                return payway;
            }
            set
            {
                payway = value;
            }
        }
        public String PayPlace
        {
            get
            {
                return payplace;
            }
            set
            {
                payplace = value;
            }
        }
        public String PayerName
        {
            get
            {
                return payername;
            }
            set
            {
                payername = value;
            }
        }
        public String ReleasePlace
        {
            get
            {
                return releaseplace;
            }
            set
            {
                releaseplace = value;
            }
        }
        public String DrawerName
        {
            get
            {
                return drawername;
            }
            set
            {
                drawername = value;
            }
        }

    }
}
