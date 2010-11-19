using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCard.Object;

namespace ShoppingCart.Object
{
    public class PaymentCheque : Payment
    {
        private string title;
        private DateTime releasedate;
        private string releaseplace;
        private string bankname;
        private string account;
        private int pay;

        public PaymentCheque()
        {
            releasedate = new DateTime();
        }

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

        public DateTime ReleaseDate
        {
            get
            {
                return releasedate;
            }
            set
            {
                releasedate = value;
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
        public String BankName
        {
            get
            {
                return bankname;
            }
            set
            {
                bankname = value;
            }
        }
        public String Account
        {
            get
            {
                return account;
            }
            set
            {
                account = value;
            }
        }
        public int Pay
        {
            get
            {
                return pay;
            }
            set
            {
                pay = value;
            }
        }

    }
}
