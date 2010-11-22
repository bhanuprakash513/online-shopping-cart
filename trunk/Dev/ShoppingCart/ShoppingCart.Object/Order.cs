using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;
using ShoppingCart.Object;

namespace ShoppingCard.Object
{
     public class Order
    {
         private int orderid;
         private PaymentCC paymentccinfor;
         private PaymentDD paymentddinfor;
         private PaymentCheque paymentchequeinfor;
         private List<OrderItem> listorderitem;
         private DateTime shippingdate;
         private DateTime orderdate;
         private Customer custinfor;
         private string receiverfullname;
         private string receveraddress;
         private string receverphone;
         private Delivery deliveryinfor;
         private int empidcheck;
         private Employee empship;
         private string city;
         private string state;
         private string zipcode;
         private string totalcode;
         private Country countryinfor;
         private string extramoney;
         private string note;
         private Payment paymentinfor;
         public Order()
         {
             orderid = -1;
             listorderitem = new List<OrderItem>();
             shippingdate = new DateTime();
             orderdate = new DateTime();
             custinfor = new Customer();
             deliveryinfor = new Delivery();
             empship = new Employee();
             receiverfullname = "";
             receveraddress = "";
             receverphone = "";
             empidcheck = -1;
             city = "";
             state = "";
             zipcode = "";
             totalcode = "0";
             paymentinfor = new PaymentCC();
             countryinfor = new Country();
             extramoney = "0";
         }

         public int OrderId
         {
             get
             {
                 return orderid;
             }
             set
             {
                 orderid = value;
             }
         }
         public PaymentCC PaymentCCInfor
         {
             get
             {
                 return paymentccinfor;
             }
             set
             {
                 paymentccinfor= value;
             }
         }

         public PaymentDD PaymentDDInfor
         {
             get
             {
                 return paymentddinfor;
             }
             set
             {
                 paymentddinfor = value;
             }
         }

         public Payment PaymentInfor
         {
             get
             {
                 return paymentinfor;
             }
             set
             {
                 paymentinfor = value;
             }
         }

         public PaymentCheque PaymentChequeInfor
         {
             get
             {
                 return paymentchequeinfor;
             }
             set
             {
                 paymentchequeinfor = value;
             }
         }

         public List<OrderItem> ListOrderItem
         {
             get
             {
                return listorderitem;
             }
             set
             {
                listorderitem = value;
             }
         }
         public DateTime ShippingDate
         {
             get
             {
                return shippingdate;
             }
             set
             {
                shippingdate = value;
             }
         }
         public DateTime OrderDate
         {
             get
             {
                return orderdate;
             }
             set
             {
                orderdate = value;
             }
         }
         public Customer CustInfor
         {
             get
             {
                return custinfor;
             }
             set
             {
                custinfor = value;
             }
         }
         public String ReceiverFullname
         {
             get
             {
                return receiverfullname;
             }
             set
             {
                receiverfullname = value;
             }
         }
         public String ReceiverAddress
         {
             get
             {
                return receveraddress;
             }
             set
             {
                receveraddress = value;
             }
         }
         
         public String ReceiverPhone
         {
             get
             {
                return receverphone;
             }
             set
             {
                receverphone = value;
             }
         }
         
         public Delivery DeliveryInfo  
         {
             get 
             {
                 return deliveryinfor; 
             }
             set
             {
                 deliveryinfor = value;
             }  
         }
           
         public int EmpIdCheck  
         {  
             get
             {
                 return empidcheck;  
             }             
             set
             {
                 empidcheck = value;
             }  
         }
           
         public Employee EmpShip  
         {
             get
             {
                 return empship;  
             }
             set
             {
                empship = value;
             }  
         }
           public String City
           {
               get
               {
                   return city;
               }
               set
               {
                   city = value;
               }
           }
           public String State
           {
               get
               {
                   return state;
               }
               set
               {
                   state = value;
               }
           }
           public String Zipcode
           {
               get
               {
                   return zipcode;
               }
               set
               {
                  zipcode = value;
               }
           }
           public String TotalCost
           {
               get
               {
                   return totalcode;
               }
               set
               {
                   totalcode = value;
               }
           }
           public Country CountryInfor
           {
               get
               {
                   return countryinfor;
               }
               set
               {
                  countryinfor = value;
               }
           }

         public String ExtraMoney
         {
             get
             {
                 return extramoney;
             }
             set
             {
                 extramoney = value;
             }
         }

         public String Note
         {
             get
             {
                 return note;
             }
             set
             {
                 note = value;
             }
         }

           /// <summary>
           /// Mapping object
           /// </summary>
           /// <param name="obj">Order</param>
           /// <param name="row">DataRow</param>
           public static void Mapping(Order obj, DataRow row)
           {

               try
               {
                   if (row[ColumnName.ORDER_CITY] != null && row[ColumnName.ORDER_CITY].ToString()!="")
                       obj.City = row[ColumnName.ORDER_CITY].ToString();
                   if (row[ColumnName.ORDER_ORDERID] != null && row[ColumnName.ORDER_ORDERID].ToString() != "")
                       obj.OrderId = Convert.ToInt32(row[ColumnName.ORDER_ORDERID]);
                   Delivery.Mapping(obj.DeliveryInfo, row);
    
                   if (row[ColumnName.ORDER_USERIDSHIP] != null && row[ColumnName.ORDER_USERIDSHIP].ToString() != "")
                       obj.EmpShip.UserId = Convert.ToInt32(row[ColumnName.ORDER_USERIDSHIP].ToString());
                   if (row[ColumnName.ORDER_USERIDCHECK] != null && row[ColumnName.ORDER_USERIDCHECK].ToString() != "")
                       obj.EmpIdCheck = Convert.ToInt32(row[ColumnName.ORDER_USERIDCHECK].ToString());
                   if (row[ColumnName.ORDER_CUSTID] != null && row[ColumnName.ORDER_CUSTID].ToString() != "")
                       obj.CustInfor.UserId = Convert.ToInt32(row[ColumnName.ORDER_CUSTID].ToString());
                  
                   
                   if (row[ColumnName.ORDER_SHIPPINGDATE] != null && row[ColumnName.ORDER_SHIPPINGDATE].ToString() != "")
                       obj.ShippingDate = DateHelper.Mapping(row[ColumnName.ORDER_SHIPPINGDATE].ToString());
                   if (row[ColumnName.ORDER_ORDERDATE] != null && row[ColumnName.ORDER_ORDERDATE].ToString() != "")
                       obj.OrderDate= DateHelper.Mapping(row[ColumnName.ORDER_ORDERDATE].ToString());
                   if (row[ColumnName.ORDER_RECEIVERFULLNAME] != null && row[ColumnName.ORDER_RECEIVERFULLNAME].ToString() != "")
                       obj.ReceiverFullname = row[ColumnName.ORDER_RECEIVERFULLNAME].ToString();
                   if (row[ColumnName.ORDER_RECEIVERADDRESS] != null && row[ColumnName.ORDER_RECEIVERADDRESS].ToString() != "")
                       obj.ReceiverAddress = row[ColumnName.ORDER_RECEIVERADDRESS].ToString();
                   if (row[ColumnName.ORDER_RECEIVERPHONE] != null && row[ColumnName.ORDER_RECEIVERPHONE].ToString() != "")
                       obj.ReceiverPhone = row[ColumnName.ORDER_RECEIVERPHONE].ToString();
                   if (row[ColumnName.ORDER_CITY] != null && row[ColumnName.ORDER_CITY].ToString() != "")
                       obj.City = row[ColumnName.ORDER_CITY].ToString();
                   if (row[ColumnName.ORDER_STATE] != null && row[ColumnName.ORDER_STATE].ToString() != "")
                       obj.State = row[ColumnName.ORDER_STATE].ToString();
                   if (row[ColumnName.ORDER_ZIPCODE] != null && row[ColumnName.ORDER_ZIPCODE].ToString() != "")
                       obj.Zipcode = row[ColumnName.ORDER_ZIPCODE].ToString();
                   if (row[ColumnName.ORDER_TOTALCOST] != null && row[ColumnName.ORDER_TOTALCOST].ToString() != "")
                       obj.TotalCost = row[ColumnName.ORDER_TOTALCOST].ToString();
                   if (row[ColumnName.ORDER_EXTRAMONEY] != null && row[ColumnName.ORDER_EXTRAMONEY].ToString() != "")
                       obj.ExtraMoney = row[ColumnName.ORDER_EXTRAMONEY].ToString();

                   if (row[ColumnName.ORDER_NOTE] != null && row[ColumnName.ORDER_NOTE].ToString() != "")
                       obj.Note = row[ColumnName.ORDER_NOTE].ToString();

                   
                   

                   Country.Mapping(obj.CountryInfor, row);


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
           public static void Mapping(List<Order> lst, DataTable table)
           {
               Order obj;
               for (int i = 0; i < table.Rows.Count; i++)
               {
                   obj = new Order();
                   Mapping(obj, table.Rows[i]);
                   lst.Add(obj);
               }
           }
    }
}