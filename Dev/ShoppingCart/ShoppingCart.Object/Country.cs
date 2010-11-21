using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
    public class Country
    {
        private int countryid;
        private string countryname;

        public Country()
        {
            countryid = -1;
            countryname = "";
        }

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

        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="obj">Country</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(Country obj, DataRow row)
        {

            try
            {

                if (row[ColumnName.COUNTRY_COUNTRYID] != null && row[ColumnName.COUNTRY_COUNTRYID].ToString()!="")
                    obj.CountryId = Convert.ToInt32(row[ColumnName.COUNTRY_COUNTRYID].ToString());
                if (row[ColumnName.COUNTRY_COUNTRYNAME] != null && row[ColumnName.COUNTRY_COUNTRYNAME].ToString()!="")
                    obj.CountryName = row[ColumnName.COUNTRY_COUNTRYNAME].ToString();

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

        }

        /// <summary>
        /// Mapping list
        /// </summary>
        /// <param name="lst">List</param>
        /// <param name="table">DataTable</param>
        public static void Mapping(List<Country> lst, DataTable table)
        {
            Country obj;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                obj = new Country();
                Mapping(obj, table.Rows[i]);
                lst.Add(obj);
            }
        }
          

   }
}
