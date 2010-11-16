using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
         private Emloyee empship;
         private string city;
         private int state;
         private int zipcode;
         private int totalcode;
         private Country countryinfor;

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
           public Payment Paymentinfor
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
           public Emloyee EmpShip
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

    }
}