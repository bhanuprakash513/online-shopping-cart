using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Common;
using System.Data;

namespace ShoppingCart.Object
{
    public class CardType
    {
        private int cardtypeid;
        private string cardtypename;

        public int CardTypeId
        {
            get
            {
                return cardtypeid;
            }
            set
            {
                cardtypeid = value;
            }
        }

        public String CardTypeName
        {
            get
            {
                return cardtypename;
            }

            set
            {
                cardtypename = value;
            }
        }

        /// <summary>
        /// Mapping object
        /// </summary>
        /// <param name="obj">CardType</param>
        /// <param name="row">DataRow</param>
        public static void Mapping(CardType obj, DataRow row)
        {
            try
            {
                if (row[ColumnName.CARDTYPE_CARDTYPEID] != null)
                    obj.CardTypeId = Convert.ToInt32(row[ColumnName.CARDTYPE_CARDTYPEID].ToString());
                if (row[ColumnName.CARDTYPE_CARDTYPENAME] != null)
                    obj.CardTypeName = row[ColumnName.CARDTYPE_CARDTYPENAME].ToString();

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
        public static void Mapping(List<CardType> lst, DataTable table)
        {
            CardType obj;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                obj = new CardType();
                Mapping(obj, table.Rows[i]);
                lst.Add(obj);
            }
        }
    }
}
