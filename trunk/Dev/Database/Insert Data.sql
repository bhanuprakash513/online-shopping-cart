-- CardType --
INSERT INTO CardType(CardTypeName) VALUES ('Master Card')
INSERT INTO CardType(CardTypeName) VALUES ('Visa Card')
INSERT INTO CardType(CardTypeName) VALUES ('Amex Card')
INSERT INTO CardType(CardTypeName) VALUES ('Discover Card')

--Category--

INSERT INTO Category(CatId,CatName) VALUES (11,'Doll')
INSERT INTO Category(CatId,CatName) VALUES (22,'Bag')
INSERT INTO Category(CatId,CatName) VALUES (33,'Soap')

--Country --
INSERT INTO Country(CountryName) VALUES ('America')
INSERT INTO Country(CountryName) VALUES ('France')
INSERT INTO Country(CountryName) VALUES ('Vietnam')


--PaymentType--
INSERT INTO PaymentType(PayTypeName) VALUES ('Cheque')
INSERT INTO PaymentType(PayTypeName) VALUES ('Demand Draft')
INSERT INTO PaymentType(PayTypeName) VALUES ('Credit Card')
INSERT INTO PaymentType(PayTypeName) VALUES ('VPP')

--DeliveryType --
INSERT INTO DeliveryType(DeliveryId,DeliveryName,DeliveryCost) VALUES (1,'Post Office','500')
INSERT INTO DeliveryType(DeliveryId,DeliveryName,DeliveryCost) VALUES (2,'Manually','0')

--StatusDelivery--
INSERT INTO StatusDelivery(StatusDeliveryName) VALUES ('Undone')
INSERT INTO StatusDelivery(StatusDeliveryName) VALUES ('Done')

--StatusPaid--
INSERT INTO StatusPaid(StatusPaidName) VALUES ('Not pay')
INSERT INTO StatusPaid(StatusPaidName) VALUES ('Paid')


--FeedbackType--

INSERT INTO FeedbackType(FeedTypeName) VALUES ('FAQ')
INSERT INTO FeedbackType(FeedTypeName) VALUES ('Feedback')

--Role--
INSERT INTO Role(RoleName) VALUES ('Admin')
INSERT INTO Role(RoleName) VALUES ('Employee')
INSERT INTO Role(RoleName) VALUES ('Member')

--StatusUser--
INSERT INTO StatusUser(StatusUserName) VALUES ('Active')
INSERT INTO StatusUser(StatusUserName) VALUES ('Inactive')

--User--
INSERT INTO Users(Username,Password,Fullname,Gender,Address,Email,RoleId,PhoneNumber,StatusId)
	VALUES ('admin','admin','Nguyen Huu Sang','Male','56/7 Bui Minh Truc','zlshanglz@yahoo.com','1','01265375101','1')
INSERT INTO Users(Username,Password,Fullname,Gender,Address,Email,RoleId,PhoneNumber,StatusId)
	VALUES ('employee','employee','Tran Phan Quoc Hai','Male','under bridge','cltbquochai@yahoo.com','1','0919097097','1')
INSERT INTO Users(Username,Password,Fullname,Gender,Address,Email,RoleId,PhoneNumber,StatusId)
	VALUES ('member','member','Pham Hong Tam','Male','next into Hai address','ketuhanh27989@yahoo.com','1','0906024094','1')

--Product--
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000001','11','American doll','500','Very beautiful','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000002','11','Janpan doll','300','Very beautiful','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000003','11','China doll','200','Very beautiful','365','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000004','22','American bag','1500','Very beautiful','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000005','22','Janpan bag','1300','Very beautiful','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000006','22','China bag','1200','Very beautiful','365','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000007','33','LifeBoy','500','anti-microbe','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000008','33','SafeGuard','300','','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000009','33','Lux','200','','365','','100')


-------PaymentDetail--
INSERT INTO PaymentDetail(PaymentName,Title,ReleaseDate,ReleasePlace,BankName,Account,Pay)
VALUES ('Cheque','Cheque','12/13/2010','Nguyen Chi Thanh Q5','ACB Bank','123456789','5000')

--Feedback--
INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId) VALUES ('How to buy online your product','blap blap blap ...',8,'1')
INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId) VALUES ('How to use your search feature','blap blap blap ...',8,'1')

INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId) VALUES ('I am very satisfy with your service','','9','2')
INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId) VALUES ('You done well','','9','2')


---------Order--
INSERT INTO Order (PayDetailId,DeliveryId,UserIdShip,UserIdCheck,PayTypeId,CustId,ShippingDate,StatusPaidId,StatusDeliveryId,OrderDate
ReceiverFullname,ReceiverAddress,ReceiverPhone,CountryId,City,State,Zipcode,TotalCost)
VALUES (1,1,2,2,1,3,12/13/2010,1,1,12/13/2010,'Pham Hong Tam','under bridge','0906024094','3','HCM','Q5','12345','5000')

INSERT INTO Order(PayDetailId,DeliveryId,UserIdShip,UserIdCheck,PayTypeId,CustId,ShippingDate,StatusPaidId,StatusDeliveryId,OrderDate
ReceiverFullname,ReceiverAddress,ReceiverPhone,CountryId,City,State,Zipcode,TotalCost)
VALUES (2,2,2,2,1,3,12/13/2010,1,1,12/13/2010,'Pham Hong Tam','under bridge','0906024094','3','HCM','Q5','12345','5000')


--OrderItem--
INSERT INTO OrderItem(OrderItemId,OrderId,ProductId,OrderQuantity,ExWarrantyDate) VALUES ('1',1,'0000001',20,12/13/2010)
INSERT INTO OrderItem(OrderItemId,OrderId,ProductId,OrderQuantity,ExWarrantyDate) VALUES ('2',2,'0000002',20,12/13/2010)


















