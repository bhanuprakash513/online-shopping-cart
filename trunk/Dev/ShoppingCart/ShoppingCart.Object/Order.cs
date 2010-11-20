using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ShoppingCart.Common;

namespace ShoppingCard.Object
{
     public class Order
    {
         private int orderid;
         private Payment paymentinfo;
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

         public Order()
         {
             listorderitem = new List<OrderItem>();
             shippingdate = new DateTime();
             orderdate = new DateTime();
             custinfor = new Customer();
             deliveryinfor = new Delivery();
             empship = new Employee();
             countryinfor = new Country();
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
         public Payment PaymentInfor
         {
             get
             {
                 return paymentinfo;
             }
             set
             {
                 paymentinfo= value;
             }
         }
         public List<OrderItem> LisOrderItem
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

           /// <summary>
           /// Mapping object
           /// </summary>
           /// <param name="obj">Order</param>
           /// <param name="row">DataRow</param>
           public static void Mapping(Order obj, DataRow row)
           {

               try
               {
                   if (row[ColumnName.ORDER_CITY] != null)
                       obj.City = row[ColumnName.ORDER_CITY].ToString();
                   if (row[ColumnName.ORDER_ORDERID] != null)
                       obj.OrderId = Convert.ToInt32(row[ColumnName.ORDER_ORDERID]);
                   Delivery.Mapping(obj.DeliveryInfo, row);
                   if (row[ColumnName.ORDER_USERIDSHIP] != null)
                       obj.EmpShip.UserId = Convert.ToInt32(row[ColumnName.ORDER_USERIDSHIP].ToString());
                   if (row[ColumnName.ORDER_USERIDCHECK] != null)
                       obj.EmpIdCheck = Convert.ToInt32(row[ColumnName.ORDER_USERIDCHECK].ToString());
                   if (row[ColumnName.ORDER_CUSTID] != null)
                       obj.CustInfor.UserId = Convert.ToInt32(row[ColumnName.ORDER_CUSTID].ToString());
                   if (row[ColumnName.ORDER_PAYDETAILID] != null)
                       obj.PaymentInfor.PayId= Convert.ToInt32(row[ColumnName.ORDER_PAYDETAILID].ToString());
                   if (row[ColumnName.ORDER_PAYTYPEID] != null)
                       obj.PaymentInfor.PayType.PayTypeId =Convert.ToInt32(row[ColumnName.ORDER_PAYTYPEID].ToString());
                   if (row[ColumnName.ORDER_SHIPPINGDATE] != null)
                       obj.ShippingDate = DateHelper.Mapping(row[ColumnName.ORDER_SHIPPINGDATE].ToString());
                   if (row[ColumnName.ORDER_ORDERDATE] != null)
                       obj.OrderDate= DateHelper.Mapping(row[ColumnName.ORDER_ORDERDATE].ToString());
                   if (row[ColumnName.ORDER_RECEIVERFULLNAME] != null)
                       obj.ReceiverFullname = row[ColumnName.ORDER_RECEIVERFULLNAME].ToString();
                   if (row[ColumnName.ORDER_RECEIVERADDRESS] != null)
                       obj.ReceiverAddress = row[ColumnName.ORDER_RECEIVERADDRESS].ToString();
                   if (row[ColumnName.ORDER_RECEIVERPHONE] != null)
                       obj.ReceiverPhone = row[ColumnName.ORDER_RECEIVERPHONE].ToString();
                   if (row[ColumnName.ORDER_CITY] != null)
                       obj.City = row[ColumnName.ORDER_CITY].ToString();
                   if (row[ColumnName.ORDER_STATE] != null)
                       obj.State = row[ColumnName.ORDER_STATE].ToString();
                   if (row[ColumnName.ORDER_ZIPCODE] != null)
                       obj.Zipcode = row[ColumnName.ORDER_ZIPCODE].ToString();
                   if (row[ColumnName.ORDER_TOTALCOST] != null)
                       obj.TotalCost = row[ColumnName.ORDER_TOTALCOST].ToString();
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