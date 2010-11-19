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
         private int state;
         private int zipcode;
         private int totalcode;
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
           public int State
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
           public int Zipcode
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
           public int TotalCost
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
                   //UserIdShip,CustId,UserIdCheck,PayDetailId dung DAO khac
                   
                   
              
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