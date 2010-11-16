using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCard.Object
{
    public class Country
    {
        private int countrid;
        private string contryname;

        public int CountryId
        {
            get
            {
                return countrid;
            }
            set
            {
                countrid = value;
            }
        }
    }
}
