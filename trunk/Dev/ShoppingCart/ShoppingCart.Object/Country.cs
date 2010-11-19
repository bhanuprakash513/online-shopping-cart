using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCard.Object
{
    public class Country
    {
        private int countryid;
        private string countryname;

        public int CountryId
        {
            get
            {
                return countryid;
            }
            set
            {
                countryid = value;
            }
        }
        public String CountryName
        {
            get
            {
                return countryname;
            }
            set
            {
                countryname = value;
            }
        }


          

   }
}
