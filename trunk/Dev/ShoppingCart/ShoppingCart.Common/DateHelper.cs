using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Common
{
    public class DateHelper
    {
        /// <summary>
        /// Mapping from String to datetime
        /// </summary>
        /// <param name="strdate">String</param>
        /// <returns>DateTime</returns>
        public static DateTime Mapping(String strdate)
        {
            String[] str = strdate.Split('/');
            DateTime date=new DateTime();
            try
            {
                if(str[2].Length>4)   
                    date = new DateTime(Convert.ToInt32(str[2].Substring(0,4)),Convert.ToInt32(str[0]),Convert.ToInt32(str[1]));
                else
                    date = new DateTime(Convert.ToInt32(str[2]), Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return date;
        }

        /// <summary>
        /// Mapping from datetime to string
        /// </summary>
        /// <param name="datetime">DateTime</param>
        /// <returns>String</returns>
        public static String Mapping(DateTime datetime)
        {
            return datetime.Month.ToString() + "/" + datetime.Day.ToString()+"/"+datetime.Year.ToString() ;
        }

        /// <summary>
        /// Compare date1 with date2
        /// </summary>
        /// <param name="date1">DateTime</param>
        /// <param name="date2">DateTime</param>
        /// <returns>DateCompareResult</returns>
        public static DateCompareResult CompareDate(DateTime date1, DateTime date2)
        {
            if (date1.Year > date2.Year)
                return DateCompareResult.Great;
            else if (date1.Year < date2.Year)
                    return DateCompareResult.Small;
            else
            {
                if (date1.Month > date2.Month)
                    return DateCompareResult.Great;
                else if (date1.Month < date2.Month)
                    return DateCompareResult.Small;
                else
                {
                    if (date1.Day > date2.Day)
                        return DateCompareResult.Great;
                    else if (date1.Day < date2.Day)
                        return DateCompareResult.Small;
                    else
                        return DateCompareResult.Equal;
                }
            }
        }


    }
}
