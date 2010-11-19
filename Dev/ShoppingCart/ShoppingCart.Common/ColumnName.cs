using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Common
{
    public class ColumnName
    {   
        //*******************************TABLE***************************************
        //***************************CARD TYPE***************************************
        public static String CARDTYPE_CARDTYPEID = "CardTypeId";
        public static String CARDTYPE_CARDTYPENAME = "CardTypeName";

        //***************************CATEGORY***************************************
        public static String CATEGORY_CATID= "CatId";
        public static String CATEGORY_CATNAME = "CatName";

        //***************************COUNTRY****************************************
        public static String COUNTRY_COUNTRYID = "CountryId";
        public static String COUNTRY_COUNTRYNAME = "CountryName";
        
        //***************************DELIVERY****************************************

        public static String DELIVERY_DELIVERYID = "DeliveryId";
        public static String DELIVERY_DELIVERYNAME = "DeliveryName";
        public static String DELIVERY_DELIVERYCOST = "DeliveryCost";

        //***************************FEEDBACK***************************************
        public static String FEEDBACK_FEEDID = "FeedId";
        public static String FEEDBACK_QUESTION="Question";
        public static String FEEDBACK_ANSWER="Answer";
        public static String FEEDBACK_USERID="UserId";
        public static String FEEDBACK_FEEDTYPEID = "FeedTypeId";
        public static String FEEDBACK_DATEWRITE = "DateWrite";

        //***************************FEEDBACK TYPE***************************************

        public static String FEEDBACKTYPE_FEEDTYPEID = "FeedTypeId";
        public static String FEEDBACKTYPE_FEEDTYPENAME = "FeedTypeName";


        //**************************ORDER************************************************
        public static String ORDER_ORDERID = "OrderId";
        public static String ORDER_PAYDETAILID="PayDetailId";
        public static String ORDER_DELIVERYID="DeliveryId";
        public static String ORDER_USERIDSHIP="UserIdShip";
        public static String ORDER_USERIDCHECK="UserIdCheck";
        public static String ORDER_PAYTYPEID="PayTypeId";
        public static String ORDER_CUSTID="CustId";
        public static String ORDER_SHIPPINGDATE = "ShippingDate";
        public static String ORDER_STATUSPAIDID = "StatusPaidId";
        public static String ORDER_STATUSDELIVERYID="StatusDeliveryId";
        public static String ORDER_ORDERDATE="OrderDate";
        public static String ORDER_RECEIVERFULLNAME="ReceiverFullName";
        public static String ORDER_RECEIVERADDRESS="ReceiverAddress";
        public static String ORDER_RECEIVERPHONE="ReceiverPhone";
        public static String ORDER_COUNTRYID="CountryId";
        public static String ORDER_CITY="City";
        public static String ORDER_STATE = "State";
        public static String ORDER_ZIPCODE = "Zipcode";
        public static String ORDER_TOTALCOST = "TotalCost";

        //**************************ORDER ITEM************************************************
        public static String ORDERITEM_ORDERITEMID = "OrderItemId";
        public static String ORDERITEM_ORDERID="OrderId";
        public static String ORDERITEM_PRODUCTID="ProductId";
        public static String ORDERITEM_ORDERQUANTITY="OrderQuantity";
        public static String ORDERITEM_EXWARRANTYDATE = "ExWarrantyDate";

        //**************************PAYMENT DETAIL************************************************

        public static String PAYMENTDETAIL_PAYDETAILID = "PayDetailId";
        public static String PAYMENTDETAIL_PAYMENTNAME = "PaymentName";
        public static String PAYMENTDETAIL_CARDTYPEID="CardTypeId";
        public static String PAYMENTDETAIL_TITLE="Title";
        public static String PAYMENTDETAIL_RELEASEDATE="ReleaseDate";
        public static String PAYMENTDETAIL_RELEASEPLACE="ReleasePlace";
        public static String PAYMENTDETAIL_BANKNAME="BankName";
        public static String PAYMENTDETAIL_ACCOUNT="Account";
        public static String PAYMENTDETAIL_PAY="Pay";
        public static String PAYMENTDETAIL_PAYPLACE="PayPlace";
        public static String PAYMENTDETAIL_PAYWAY="PayWay";
        public static String PAYMENTDETAIL_EXPIRATIONDATE="ExpirationDate";
        public static String PAYMENTDETAIL_DRAWERNAME="DrawerName";
        public static String PAYMENTDETAIL_PAYERNAME="PayerName";
        public static String PAYMENTDETAIL_CCNUMBER = "CCNumber";
        public static String PAYMENTDETAIL_CVV="CVV";
        public static String PAYMENTDETAIL_SECURITYNUMBER = "SecurityNumber";

        //**************************PAYMENT TYPE************************************************
        public static String PAYMENTTYPE_PAYTYPEID = "PayTypeId";
        public static String PAYMENTTYPE_PAYTYPENAME = "PayTypeName";


        //**************************PRODUCT*****************************************************
        public static String PRODUCT_PRODUCTID = "ProductId";
        public static String PRODUCT_CATID = "CatId";
        public static String PRODUCT_PRODUCTNAME = "ProductName";
        public static String PRODUCT_PRICE="Price";
        public static String PRODUCT_DESCRIPTION="Description";
        public static String PRODUCT_WARRANTYDAY="WarrantyDay";
        public static String PRODUCT_IMAGE="Image";
        public static String PRODUCT_QUANTITY = "Quantity";

        //**************************ROLE*************************************************
        public static String ROLE_ROLEID = "RoleId";
        public static String ROLE_ROLENAME = "RoleName";

        //***************************STATUS DELIVERY**************************************
        public static String STATUSDELIVERY_STATUSDELIVERYID = "StatusDeliveryId";
        public static String STATUSDELIVERY_STATUSDELIVERYNAME = "StatusDeliveryName";


        //*****************************STATUS PAID***************************************
        public static String STATUSPAID_STATUSPAIDID = "StatusPaidId";
        public static String STATUSPAID_STATUSPAIDNAME = "StatusPaidName";


        //*****************************STATUS USER***************************************
        public static String STATUSUSER_STATUSUSERID = "StatusUserId";
        public static String STATUSUSER_STATUSUSERNAME = "StatusUserName";



        //*****************************USER**********************************************
        public static String USER_USERID = "UserId";
        public static String USER_USERNAME="Username";
        public static String USER_PASSWORD="Password";
        public static String USER_FULLNAME="Fullname";
        public static String USER_GENDER="Gender";
        public static String USER_ADDRESS="Address";
        public static String USER_EMAIL="Email";
        public static String USER_ROLEID="RoleId";
        public static String USER_PHONENUMBER="PhoneNumber";
        public static String USER_STATUSID="StatusId";


        //*******************************DATE
        public static String DATE_DATE = "Date";
        

    }
}
