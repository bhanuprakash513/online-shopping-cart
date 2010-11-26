using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

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
        public static Result IsValidEmail(String inputEmail)
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

        /// <summary>
        /// Divide page
        /// </summary>
        /// <param name="i">int</param>
        /// <param name="total">int</param>
        /// <param name="tenfile">String</param>
        /// <param name="color1">String</param>
        /// <param name="color2">String</param>
        /// <param name="nameindex">String</param>
        /// <returns></returns>
        public static List<String> ShowNumPage(int i,int total,String tenfile,String color1,String color2,String nameindex)
        {
            String str = "";
            List<String> strlist = new List<String>();
            int j = 1;
            int k = i;
            if (i > 1)
                i = i - 1;
            

            while (i <= (total) / Constant.NUM_RECORD_DIVIDE && j <= Constant.NUM_PAGE_DIVIDE)
            {
                if (k == i)
                    str = "<a href='" + tenfile + "?"+nameindex+"=" + i + "' style='color:"+color1+";background-color:"+color2+";text-decoration:none'>" + i + "</a>";
                else
                    str = "<a href='" + tenfile + "?"+nameindex+"=" + i + "' style='color:" + color1 + ";text-decoration:none'>" + i + "</a>";
                strlist.Add(str);
                i++;
                j++;
            }
            if (total % Constant.NUM_RECORD_DIVIDE != 0 && total > Constant.NUM_RECORD_DIVIDE && j <= Constant.NUM_PAGE_DIVIDE)
            {
                if (i == k)
                    str = "<a href='" + tenfile + "?"+nameindex+"=" + i + "' style='color:" + color1 + ";background-color:" + color2 + ";text-decoration:none'>" + i + "</a>";
                else
                    str = "<a href='" + tenfile + "?"+nameindex +"=" + i + "' style='color:" + color1 + ";text-decoration:none'>" + i + "</a>";
                strlist.Add(str);
                j++;
            }

            return strlist;
        }
    }
}
