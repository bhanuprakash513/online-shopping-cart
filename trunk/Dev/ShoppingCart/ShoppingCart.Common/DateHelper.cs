using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Common
{
    public class DateHelper
    {

        public static DateTime Mapping(String strdate)
        {
            String[] str = strdate.Split('/');
            DateTime date=new DateTime();
            try
            {
                date = new DateTime(Convert.ToInt32(str[2].Substring(0,4)),Convert.ToInt32(str[0]),Convert.ToInt32(str[1]));
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return date;
        }
    }
}
