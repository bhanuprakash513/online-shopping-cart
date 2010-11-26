using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Validate email
        /// </summary>
        /// <param name="inputEmail">String</param>
        /// <returns>Result</returns>
        public Result IsValidEmail(String inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return Result.Succeed;
            else
                return Result.Failed;
        }
    }
}
