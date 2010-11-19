using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Common
{
    public class StringHelper
    {

        /// <summary>
        /// Positive Integer return true, else return false
        /// </summary>
        /// <param name="num">String</param>
        /// <returns>Boolean</returns>
        public static Boolean IsPositiveInteger(String num)
        {
            String str = "0987654321";
            int i;
            for (i = 0; i < num.Length; i++)
            {
                int j;
                for (j = 0; j < str.Length; j++)
                {
                    if (str[j] == num[i])
                        j = str.Length;
                }

                if (j != str.Length + 1)
                    i = num.Length;
            }

            if (i != num.Length + 1)
                return true;
            return false;
        }
    }
}
