----CREATE DB ShoppingCart----
CREATE DATABASE ShoppingCart
Go
Use ShoppingCart
----CREATE TABLE Role----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN Role TABLE----
INSERT INTO Role(RoleName) VALUES ('Admin')
INSERT INTO Role(RoleName) VALUES ('Employee')
INSERT INTO Role(RoleName) VALUES ('Member')
----CREATE TABLE CardType----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CardType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CardType](
	[CardTypeId] [int] IDENTITY(1,1) NOT NULL,
	[CardTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CardType] PRIMARY KEY CLUSTERED 
(
	[CardTypeId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN CardType TABLE----
INSERT INTO CardType(CardTypeName) VALUES ('Master Card')
INSERT INTO CardType(CardTypeName) VALUES ('Visa Card')
INSERT INTO CardType(CardTypeName) VALUES ('Amex Card')
INSERT INTO CardType(CardTypeName) VALUES ('Discover Card')
----CREATE TABLE FeedBackType----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FeedBackType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FeedBackType](
	[FeedTypeId] [int] IDENTITY(1,1) NOT NULL,
	[FeedTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FeedBackType] PRIMARY KEY CLUSTERED 
(
	[FeedTypeId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN FeedBackType TABLE----
INSERT INTO FeedbackType(FeedTypeName) VALUES ('FAQ')
INSERT INTO FeedbackType(FeedTypeName) VALUES ('Feedback')
----CREATE TABLE PaymentType----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaymentType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PaymentType](
	[PayTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PayTypeName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Pay] PRIMARY KEY CLUSTERED 
(
	[PayTypeId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN PaymentType TABLE----
INSERT INTO PaymentType(PayTypeName) VALUES ('Cheque')
INSERT INTO PaymentType(PayTypeName) VALUES ('Demand Draft')
INSERT INTO PaymentType(PayTypeName) VALUES ('Credit Card')
INSERT INTO PaymentType(PayTypeName) VALUES ('VPP')
----CREATE TABLE Country----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Country](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN Country TABLE----
INSERT INTO Country (CountryName) VALUES ('Afghanistan')
INSERT INTO Country (CountryName) VALUES ('Albania')
INSERT INTO Country (CountryName) VALUES ('Algeria')
INSERT INTO Country (CountryName) VALUES ('American Samoa')
INSERT INTO Country (CountryName) VALUES ('Andorra')
INSERT INTO Country (CountryName) VALUES ('Angola')
INSERT INTO Country (CountryName) VALUES ('Anguilla')
INSERT INTO Country (CountryName) VALUES ('Antarctica')
INSERT INTO Country (CountryName) VALUES ('Antigua and Barbuda')
INSERT INTO Country (CountryName) VALUES ('Argentina')
INSERT INTO Country (CountryName) VALUES ('Armenia')
INSERT INTO Country (CountryName) VALUES ('Aruba')
INSERT INTO Country (CountryName) VALUES ('Australia')
INSERT INTO Country (CountryName) VALUES ('Austria')
INSERT INTO Country (CountryName) VALUES ('Azerbaijan')
INSERT INTO Country (CountryName) VALUES ('Bahamas')
INSERT INTO Country (CountryName) VALUES ('Bahrain')
INSERT INTO Country (CountryName) VALUES ('Bangladesh')
INSERT INTO Country (CountryName) VALUES ('Barbados')
INSERT INTO Country (CountryName) VALUES ('Belarus')
INSERT INTO Country (CountryName) VALUES ('Belgium')
INSERT INTO Country (CountryName) VALUES ('Belize')
INSERT INTO Country (CountryName) VALUES ('Benin')
INSERT INTO Country (CountryName) VALUES ('Bermuda')
INSERT INTO Country (CountryName) VALUES ('Bhutan')
INSERT INTO Country (CountryName) VALUES ('Bolivia')
INSERT INTO Country (CountryName) VALUES ('Bosnia and Herzegovina')
INSERT INTO Country (CountryName) VALUES ('Botswana')
INSERT INTO Country (CountryName) VALUES ('Bouvet Island')
INSERT INTO Country (CountryName) VALUES ('Brazil')
INSERT INTO Country (CountryName) VALUES ('British Indian Ocean Territory')
INSERT INTO Country (CountryName) VALUES ('Brunei Darussalam')
INSERT INTO Country (CountryName) VALUES ('Bulgaria')
INSERT INTO Country (CountryName) VALUES ('Burkina Faso')
INSERT INTO Country (CountryName) VALUES ('Burundi')
INSERT INTO Country (CountryName) VALUES ('Cambodia')
INSERT INTO Country (CountryName) VALUES ('Cameroon')
INSERT INTO Country (CountryName) VALUES ('Canada')
INSERT INTO Country (CountryName) VALUES ('Cape Verde')
INSERT INTO Country (CountryName) VALUES ('Cayman Islands')
INSERT INTO Country (CountryName) VALUES ('Central African Republic')
INSERT INTO Country (CountryName) VALUES ('Chad')
INSERT INTO Country (CountryName) VALUES ('Chile')
INSERT INTO Country (CountryName) VALUES ('China')
INSERT INTO Country (CountryName) VALUES ('Christmas Island')
INSERT INTO Country (CountryName) VALUES ('Cocos (Keeling) Islands')
INSERT INTO Country (CountryName) VALUES ('Colombia')
INSERT INTO Country (CountryName) VALUES ('Comoros')
INSERT INTO Country (CountryName) VALUES ('Congo')
INSERT INTO Country (CountryName) VALUES ('Cook Islands')
INSERT INTO Country (CountryName) VALUES ('Costa Rica')
INSERT INTO Country (CountryName) VALUES ('Cote Divoire')
INSERT INTO Country (CountryName) VALUES ('Croatia')
INSERT INTO Country (CountryName) VALUES ('Cuba')
INSERT INTO Country (CountryName) VALUES ('Cyprus')
INSERT INTO Country (CountryName) VALUES ('Czech Republic')
INSERT INTO Country (CountryName) VALUES ('Denmark')
INSERT INTO Country (CountryName) VALUES ('Djibouti')
INSERT INTO Country (CountryName) VALUES ('Dominica')
INSERT INTO Country (CountryName) VALUES ('Dominican Republic')
INSERT INTO Country (CountryName) VALUES ('Easter Island')
INSERT INTO Country (CountryName) VALUES ('Ecuador')
INSERT INTO Country (CountryName) VALUES ('Egypt')
INSERT INTO Country (CountryName) VALUES ('El Salvador')
INSERT INTO Country (CountryName) VALUES ('Equatorial Guinea')
INSERT INTO Country (CountryName) VALUES ('Eritrea')
INSERT INTO Country (CountryName) VALUES ('Estonia')
INSERT INTO Country (CountryName) VALUES ('Ethiopia')
INSERT INTO Country (CountryName) VALUES ('Falkland Islands (Malvinas)')
INSERT INTO Country (CountryName) VALUES ('Faroe Islands')
INSERT INTO Country (CountryName) VALUES ('Fiji')
INSERT INTO Country (CountryName) VALUES ('Finland')
INSERT INTO Country (CountryName) VALUES ('France')
INSERT INTO Country (CountryName) VALUES ('French Guiana')
INSERT INTO Country (CountryName) VALUES ('French Polynesia')
INSERT INTO Country (CountryName) VALUES ('French Southern Territories')
INSERT INTO Country (CountryName) VALUES ('Gabon')
INSERT INTO Country (CountryName) VALUES ('Gambia')
INSERT INTO Country (CountryName) VALUES ('Georgia')
INSERT INTO Country (CountryName) VALUES ('Germany')
INSERT INTO Country (CountryName) VALUES ('Ghana')
INSERT INTO Country (CountryName) VALUES ('Gibraltar')
INSERT INTO Country (CountryName) VALUES ('Greece')
INSERT INTO Country (CountryName) VALUES ('Greenland')
INSERT INTO Country (CountryName) VALUES ('Grenada')
INSERT INTO Country (CountryName) VALUES ('Guadeloupe')
INSERT INTO Country (CountryName) VALUES ('Guam')
INSERT INTO Country (CountryName) VALUES ('Guatemala')
INSERT INTO Country (CountryName) VALUES ('Guinea')
INSERT INTO Country (CountryName) VALUES ('Guyana')
INSERT INTO Country (CountryName) VALUES ('Haiti')
INSERT INTO Country (CountryName) VALUES ('Honduras')
INSERT INTO Country (CountryName) VALUES ('Hong Kong')
INSERT INTO Country (CountryName) VALUES ('Hungary')
INSERT INTO Country (CountryName) VALUES ('Iceland')
INSERT INTO Country (CountryName) VALUES ('India')
INSERT INTO Country (CountryName) VALUES ('Indonesia')
INSERT INTO Country (CountryName) VALUES ('Iran')
INSERT INTO Country (CountryName) VALUES ('Iraq')
INSERT INTO Country (CountryName) VALUES ('Ireland')
INSERT INTO Country (CountryName) VALUES ('Israel')
INSERT INTO Country (CountryName) VALUES ('Italy')
INSERT INTO Country (CountryName) VALUES ('Jamaica')
INSERT INTO Country (CountryName) VALUES ('Japan')
INSERT INTO Country (CountryName) VALUES ('Jordan')
INSERT INTO Country (CountryName) VALUES ('Kazakhstan')
INSERT INTO Country (CountryName) VALUES ('Kenya')
INSERT INTO Country (CountryName) VALUES ('Kiribati')
INSERT INTO Country (CountryName) VALUES ('Korea, North')
INSERT INTO Country (CountryName) VALUES ('Korea, South')
INSERT INTO Country (CountryName) VALUES ('Kosovo')
INSERT INTO Country (CountryName) VALUES ('Kuwait')
INSERT INTO Country (CountryName) VALUES ('Kyrgyzstan')
INSERT INTO Country (CountryName) VALUES ('Laos')
INSERT INTO Country (CountryName) VALUES ('Latvia')
INSERT INTO Country (CountryName) VALUES ('Lebanon')
INSERT INTO Country (CountryName) VALUES ('Lesotho')
INSERT INTO Country (CountryName) VALUES ('Liberia')
INSERT INTO Country (CountryName) VALUES ('Libyan Arab Jamahiriya')
INSERT INTO Country (CountryName) VALUES ('Liechtenstein')
INSERT INTO Country (CountryName) VALUES ('Lithuania')
INSERT INTO Country (CountryName) VALUES ('Luxembourg')
INSERT INTO Country (CountryName) VALUES ('Macau')
INSERT INTO Country (CountryName) VALUES ('Macedonia')
INSERT INTO Country (CountryName) VALUES ('Madagascar')
INSERT INTO Country (CountryName) VALUES ('Malawi')
INSERT INTO Country (CountryName) VALUES ('Malaysia')
INSERT INTO Country (CountryName) VALUES ('Maldives')
INSERT INTO Country (CountryName) VALUES ('Mali')
INSERT INTO Country (CountryName) VALUES ('Malta')
INSERT INTO Country (CountryName) VALUES ('Marshall Islands')
INSERT INTO Country (CountryName) VALUES ('Martinique')
INSERT INTO Country (CountryName) VALUES ('Mauritania')
INSERT INTO Country (CountryName) VALUES ('Mauritius')
INSERT INTO Country (CountryName) VALUES ('Mayotte')
INSERT INTO Country (CountryName) VALUES ('Mexico')
INSERT INTO Country (CountryName) VALUES ('Micronesia, Federated States of')
INSERT INTO Country (CountryName) VALUES ('Moldova, Republic of')
INSERT INTO Country (CountryName) VALUES ('Monaco')
INSERT INTO Country (CountryName) VALUES ('Mongolia')
INSERT INTO Country (CountryName) VALUES ('Montenegro')
INSERT INTO Country (CountryName) VALUES ('Montserrat')
INSERT INTO Country (CountryName) VALUES ('Morocco')
INSERT INTO Country (CountryName) VALUES ('Mozambique')
INSERT INTO Country (CountryName) VALUES ('Myanmar')
INSERT INTO Country (CountryName) VALUES ('Namibia')
INSERT INTO Country (CountryName) VALUES ('Nauru')
INSERT INTO Country (CountryName) VALUES ('Nepal')
INSERT INTO Country (CountryName) VALUES ('Netherlands')
INSERT INTO Country (CountryName) VALUES ('New Caledonia')
INSERT INTO Country (CountryName) VALUES ('New Zealand')
INSERT INTO Country (CountryName) VALUES ('Nicaragua')
INSERT INTO Country (CountryName) VALUES ('Nigeria')
INSERT INTO Country (CountryName) VALUES ('Norfolk Island')
INSERT INTO Country (CountryName) VALUES ('Northern Mariana Islands')
INSERT INTO Country (CountryName) VALUES ('Norway')
INSERT INTO Country (CountryName) VALUES ('Oman')
INSERT INTO Country (CountryName) VALUES ('Pakistan')
INSERT INTO Country (CountryName) VALUES ('Palau')
INSERT INTO Country (CountryName) VALUES ('Palestinian Territory')
INSERT INTO Country (CountryName) VALUES ('Panama')
INSERT INTO Country (CountryName) VALUES ('Papua New Guinea')
INSERT INTO Country (CountryName) VALUES ('Paraguay')
INSERT INTO Country (CountryName) VALUES ('Peru')
INSERT INTO Country (CountryName) VALUES ('Philippines')
INSERT INTO Country (CountryName) VALUES ('Pitcairn')
INSERT INTO Country (CountryName) VALUES ('Poland')
INSERT INTO Country (CountryName) VALUES ('Portugal')
INSERT INTO Country (CountryName) VALUES ('Puerto Rico')
INSERT INTO Country (CountryName) VALUES ('Qatar')
INSERT INTO Country (CountryName) VALUES ('Romania')
INSERT INTO Country (CountryName) VALUES ('Russia')
INSERT INTO Country (CountryName) VALUES ('Rwanda')
INSERT INTO Country (CountryName) VALUES ('Saint Helena')
INSERT INTO Country (CountryName) VALUES ('Samoa')
INSERT INTO Country (CountryName) VALUES ('San Marino')
INSERT INTO Country (CountryName) VALUES ('Saudi Arabia')
INSERT INTO Country (CountryName) VALUES ('Senegal')
INSERT INTO Country (CountryName) VALUES ('Serbia and Montenegro')
INSERT INTO Country (CountryName) VALUES ('Seychelles')
INSERT INTO Country (CountryName) VALUES ('Sierra Leone')
INSERT INTO Country (CountryName) VALUES ('Singapore')
INSERT INTO Country (CountryName) VALUES ('Slovakia')
INSERT INTO Country (CountryName) VALUES ('Solomon Islands')
INSERT INTO Country (CountryName) VALUES ('Somalia')
INSERT INTO Country (CountryName) VALUES ('South Africa')
INSERT INTO Country (CountryName) VALUES ('South Georgia and The South Sandwich Islands')
INSERT INTO Country (CountryName) VALUES ('Spain')
INSERT INTO Country (CountryName) VALUES ('Sri Lanka')
INSERT INTO Country (CountryName) VALUES ('Sudan')
INSERT INTO Country (CountryName) VALUES ('Suriname')
INSERT INTO Country (CountryName) VALUES ('Svalbard and Jan Mayen')
INSERT INTO Country (CountryName) VALUES ('Swaziland')
INSERT INTO Country (CountryName) VALUES ('Sweden')
INSERT INTO Country (CountryName) VALUES ('Switzerland')
INSERT INTO Country (CountryName) VALUES ('Syria')
INSERT INTO Country (CountryName) VALUES ('Taiwan')
INSERT INTO Country (CountryName) VALUES ('Tajikistan')
INSERT INTO Country (CountryName) VALUES ('Tanzania, United Republic of')
INSERT INTO Country (CountryName) VALUES ('Thailand')
INSERT INTO Country (CountryName) VALUES ('Timor-leste')
INSERT INTO Country (CountryName) VALUES ('Togo')
INSERT INTO Country (CountryName) VALUES ('Tokelau')
INSERT INTO Country (CountryName) VALUES ('Tonga')
INSERT INTO Country (CountryName) VALUES ('Trinidad and Tobago')
INSERT INTO Country (CountryName) VALUES ('Tunisia')
INSERT INTO Country (CountryName) VALUES ('Turkey')
INSERT INTO Country (CountryName) VALUES ('Turkmenistan')
INSERT INTO Country (CountryName) VALUES ('Turks and Caicos Islands')
INSERT INTO Country (CountryName) VALUES ('Tuvalu')
INSERT INTO Country (CountryName) VALUES ('Uganda')
INSERT INTO Country (CountryName) VALUES ('Ukraine')
INSERT INTO Country (CountryName) VALUES ('United Arab Emirates')
INSERT INTO Country (CountryName) VALUES ('United Kingdom')
INSERT INTO Country (CountryName) VALUES ('United States')
INSERT INTO Country (CountryName) VALUES ('United States Minor Outlying Islands')
INSERT INTO Country (CountryName) VALUES ('Uruguay')
INSERT INTO Country (CountryName) VALUES ('Uzbekistan')
INSERT INTO Country (CountryName) VALUES ('Vanuatu')
INSERT INTO Country (CountryName) VALUES ('Vatican City')
INSERT INTO Country (CountryName) VALUES ('Venezuela')
INSERT INTO Country (CountryName) VALUES ('Vietnam')
INSERT INTO Country (CountryName) VALUES ('Virgin Islands, British')
INSERT INTO Country (CountryName) VALUES ('Virgin Islands, U.S.')
INSERT INTO Country (CountryName) VALUES ('Wallis and Futuna')
INSERT INTO Country (CountryName) VALUES ('Western Sahara')
INSERT INTO Country (CountryName) VALUES ('Yemen')
INSERT INTO Country (CountryName) VALUES ('Zambia')
INSERT INTO Country (CountryName) VALUES ('Zimbabwe')
INSERT INTO Country (CountryName) VALUES ('Others')
----CREATE TABLE StatusUser----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StatusUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StatusUser](
	[StatusUserId] [int] IDENTITY(1,1) NOT NULL,
	[StatusUserName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusUser] PRIMARY KEY CLUSTERED 
(
	[StatusUserId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN StatusUser TABLE----
INSERT INTO StatusUser(StatusUserName) VALUES ('Active')
INSERT INTO StatusUser(StatusUserName) VALUES ('Inactive')
----CREATE TABLE StatusDelivery----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StatusDelivery]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StatusDelivery](
	[StatusDeliveryId] [int] IDENTITY(1,1) NOT NULL,
	[StatusDeliveryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusDelivery] PRIMARY KEY CLUSTERED 
(
	[StatusDeliveryId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN Status Delivery TABLE----
INSERT INTO StatusDelivery(StatusDeliveryName) VALUES ('New')
INSERT INTO StatusDelivery(StatusDeliveryName) VALUES ('Undone')
INSERT INTO StatusDelivery(StatusDeliveryName) VALUES ('Done')
INSERT INTO StatusDelivery(StatusDeliveryName) VALUES ('Return')
----CREATE TABLE DeliveryType----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeliveryType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DeliveryType](
	[DeliveryId] [char](1) NOT NULL,
	[DeliveryName] [nvarchar](50) NOT NULL,
	[DeliveryCost] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DeliveryType] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN DeliveryType TABLE----
INSERT INTO DeliveryType(DeliveryId,DeliveryName,DeliveryCost) VALUES ('1','Post Office','50')
INSERT INTO DeliveryType(DeliveryId,DeliveryName,DeliveryCost) VALUES ('2','Manually','0')
INSERT INTO DeliveryType(DeliveryId,DeliveryName,DeliveryCost) VALUES ('3','EMS','100')
----CREATE TABLE StatusPaid----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StatusPaid]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StatusPaid](
	[StatusPaidId] [int] IDENTITY(1,1) NOT NULL,
	[StatusPaidName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusPaid] PRIMARY KEY CLUSTERED 
(
	[StatusPaidId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN StatusPaid TABLE----
INSERT INTO StatusPaid(StatusPaidName) VALUES ('Not pay')
INSERT INTO StatusPaid(StatusPaidName) VALUES ('Paid')
----CREATE TABLE Category----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Category](
	[CatId] [varchar](2) NOT NULL,
	[CatName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CatId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN Category TABLE----
INSERT INTO Category(CatId,CatName) VALUES ('11','Doll')
INSERT INTO Category(CatId,CatName) VALUES ('22','Hand Bags')
INSERT INTO Category(CatId,CatName) VALUES ('33','Soap')
INSERT INTO Category(CatId,CatName) VALUES ('44','Gifts')
INSERT INTO Category(CatId,CatName) VALUES ('55','Files')
INSERT INTO Category(CatId,CatName) VALUES ('66','Greeting Cards')
INSERT INTO Category(CatId,CatName) VALUES ('77','Wallets')
INSERT INTO Category(CatId,CatName) VALUES ('88','Toys')
INSERT INTO Category(CatId,CatName) VALUES ('99','Others')
----CREATE TABLE User----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[Fullname] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[RoleId] [int] NOT NULL,
	[PhoneNumber] [varchar](15) NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN User TABLE----
INSERT INTO [User](Username,Password,Fullname,Gender,Address,Email,RoleId,PhoneNumber,StatusId)
	VALUES ('admin','admin','Nguyen Huu Sang','Female','56/7 Bui Minh Truc','zlshanglz@yahoo.com',1,'01265375101',1)
INSERT INTO [User](Username,Password,Fullname,Gender,Address,Email,RoleId,PhoneNumber,StatusId)
	VALUES ('employee','employee','Pham Hong Tam','Female','next into Viet address','ketuhanh27989@yahoo.com',2,'0906024094',1)
INSERT INTO [User](Username,Password,Fullname,Gender,Address,Email,RoleId,PhoneNumber,StatusId)
	VALUES ('member1','member2','Tran Phan Quoc Hai','Male','14 Nguyen Trong Tri','cltbquochai@yahoo.com',3,'0919097097',1)
INSERT INTO [User](Username,Password,Fullname,Gender,Address,Email,RoleId,PhoneNumber,StatusId)
	VALUES ('member2','member2','Nguyen Duc Viet','Female','Abc','ducviet@yahoo.com',3,'0919097097',1)
----CREATE TABLE PaymentDetail----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaymentDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PaymentDetail](
	[PayDetailId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentName] [nvarchar](50) NOT NULL,
	[CardTypeId] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[ReleaseDate] [datetime] NULL,
	[ReleasePlace] [nvarchar](max) NULL,
	[BankName] [nvarchar](max) NULL,
	[Account] [nvarchar](max) NULL,
	[Pay] [decimal](18, 0) NULL,
	[PayPlace] [nvarchar](max) NULL,
	[PayWay] [nvarchar](max) NULL,
	[ExpirationDate] [datetime] NULL,
	[DrawerName] [nvarchar](50) NULL,
	[PayerName] [nvarchar](50) NULL,
	[CCNumber] [nvarchar](50) NULL,
	[CVV] [nvarchar](50) NULL,
	[SecurityNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_PaymentDetail] PRIMARY KEY CLUSTERED 
(
	[PayDetailId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN PaymentDetail TABLE----
INSERT PaymentDetail(PaymentName,Title,ReleaseDate,ReleasePlace,BankName,Account,Pay)
VALUES('Cheque','Return for Tam',getdate(),'United Kingdom','Bank of England','11111',1000)
INSERT PaymentDetail(PaymentName,Title,ReleaseDate,ReleasePlace,BankName,Account,Pay)
VALUES('Demand Draft','Return for Tam',getdate(),'Ha Noi,VietNam','Techcombank','11111',1000)
INSERT PaymentDetail(PaymentName,Title,ReleaseDate,ReleasePlace,BankName,Account,Pay)
VALUES('Credit Card','Return for Tam',getdate(),'Ho Chi Minh City, VietNam','Vietcombank','11111',1000)
----CREATE TABLE Feedback----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Feedback]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Feedback](
	[FeedId] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](max) NULL,
	[Answer] [nvarchar](max) NULL,
	[UserId] [int] NULL,
	[FeedTypeId] [int] NULL,
	[DateWrite] [datetime] NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[FeedId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN Feedback TABLE----
INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId,DateWrite) VALUES ('How to buy online your product','It is very simple',1,1,getdate())
INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId,DateWrite) VALUES ('How to use your search feature','It is very simple',1,1,getdate())

INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId,DateWrite) VALUES ('I am very satisfy with your service','Thank You Very Much',3,2,getdate())
INSERT INTO Feedback(Question,Answer,UserId,FeedTypeId,DateWrite) VALUES ('You done well','Thank You Very Much',4,2,getdate())
----CREATE TABLE Order----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[PayDetailId] [int] NOT NULL,
	[DeliveryId] [char](1) NOT NULL,
	[UserIdShip] [int] NULL,
	[UserIdCheck] [int] NULL,
	[PayTypeId] [int] NOT NULL,
	[CustId] [int] NOT NULL,
	[ShippingDate] [datetime] NULL,
	[StatusPaidId] [int] NOT NULL,
	[StatusDeliveryId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[ReceiverFullname] [nvarchar](50) NOT NULL,
	[ReceiverAddress] [nvarchar](50) NOT NULL,
	[ReceiverPhone] [varchar](15) NOT NULL,
	[CountryId] [int] NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[Zipcode] [nvarchar](5) NOT NULL,
	[TotalCost] [decimal](18, 0) NOT NULL,
	[ExtraMoney] [decimal](18, 0) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Delivery_1] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN Order TABLE----
INSERT [Order]
(
	PayDetailID,DeliveryId,PayTypeId,
	CustId,StatusPaidId,StatusDeliveryId,
	OrderDate,ReceiverFullname,ReceiverAddress,
	ReceiverPhone,CountryId,City,
	State,ZipCode,TotalCost
)
VALUES
(
	1,1,1,
	4,1,1,
	getdate(),N'Thay Hoa','HungVuongAptech',
	'2342423',1,'Las Vegas',
	'Texa','1234',1050			
)
----CREATE TABLE OrderItem----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OrderItem](
	[OrderItemID] [varchar](16) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [varchar](7) NOT NULL,
	[OrderQuantity] [int] NOT NULL,
	[ExWarrantyDate] [datetime] NULL,
	[Status] [char](1) NOT NULL,
	[ProductReplace] [varchar](7) NULL,
	[QuantityReplace] [int] NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[OrderItemID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN OrderItem TABLE----
INSERT INTO OrderItem(OrderItemId,OrderId,ProductId,OrderQuantity,ExWarrantyDate,Status) VALUES('1000000100000001',1,'0000001',1,DateAdd(dd,365,Getdate()),'A')
INSERT INTO OrderItem(OrderItemId,OrderId,ProductId,OrderQuantity,ExWarrantyDate,Status) VALUES('1000000200000001',1,'0000002',1,DateAdd(dd,365,Getdate()),'A')
INSERT INTO OrderItem(OrderItemId,OrderId,ProductId,OrderQuantity,ExWarrantyDate,Status) VALUES('1000000300000001',1,'0000003',1,DateAdd(dd,365,Getdate()),'A')
----CREATE TABLE Product----
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Product](
	[ProductId] [varchar](7) NOT NULL,
	[CatId] [varchar](2) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[WarantyDay] [int] NOT NULL,
	[Image] [nvarchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
----INSERT DATA IN Product TABLE----
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000001','11','American doll','500','Very beautiful','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000002','11','Janpan doll','300','Very beautiful','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000003','11','China doll','200','Very beautiful','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000004','11','Barbie doll','500','Very beautiful','365','','50')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000005','11','Cicciobello Love Care Baby Doll','70','Very beautiful','365','','25')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000006','11','Baby Alive Caucasian Doll','52','Very beautiful','365','','10')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000007','11','Baby Dolls','70','Very beautiful','365','','25')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000008','11','DollHouse','52','Very beautiful','365','','10')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000009','11','Disney Dolls','100','Very beautiful','365','','10')


INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000010','22','Making Memories Slice Signature Series Handbag','1500','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000011','22','Prezzo Cafe Paris Mini Handbag Purse','1300','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000012','22','Embassy Solid Genuine Lambskin Leather Hobo Sling-Backpack Purse','1200','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000013','22','Sizzix 655500 Accessory - Sidekick Handbag, White with Black, Gray and Pink Polka Dots','1500','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000014','22','Black Large Vicky Zebra Print Faux Leather Satchel Bag Handbag Purse','1300','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000015','22','New Blue Large Vicky Zebra Print Faux Leather Satchel Bag Handbag Purse','1200','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000016','22','Large Snake Print Leather Handbag Purse By Fash','1500','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000017','22','Patent Ellie Purses - Purple, Burgundy or Black & Brown','1300','Very Fashion','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000018','22','Extra-Large Madison Satchel','1200','Very Fashion','365','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000019','33','Dissolving Soap Sheets','500','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000020','33','Travelon TSA Carry-on Compliant Toiletry Sheets','300','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000021','33','Lewis N Clark 755SMK Soap Dish - Smoke','200','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000022','33','Gianna Rose La Chihuahua Soap Box','500','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000023','33','Fight Club SOAP PATCH','300','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000024','33','SQUEEM Soap SQSOAP','200','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000025','33','Fortune Cookie Soaps','500','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000026','33','Dove Sensitive Skin Beauty Bar','300','Bland','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000027','33','Lever 2000 Moisturizing Bar, Fresh Aloe','200','Bland','','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000037','44','Numi Tea Bamboo Flowering Tea Gift Set by Numi','500','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000038','44','The Gift by Susan Boyle','300','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000039','44','Wine.com Happy Birthday 3-Pound Gift Box by Wine.com','200','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000040','44','Spa-in-a-basket by Unique Gifts','500','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000041','44','Burts Bees Bundle of Joy Baby Basket by Burts Bees','300','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000042','44','Wine.com Something Sweet & Savory Gift Basket by Wine.com','200','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000043','44','Rubbermaid FG3P1600CRNCR 40-Inch Gift-Wrap Organizer ','500','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000044','44','Vanilla Milk Gift Set by Gift Warehouse','300','Very Nice','30','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000045','44','Vacu Vin Stainless Steel Wine Saver Gift Set','200','Very Nice','30','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000046','55','New York Fire Patrol','500','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000047','55','English Historical Documents','300','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000048','55','GR 4 DOCUMENT-BASED QUESTIONS FOR by TEACHER CREATED RESOURCES','200','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000049','55','Document by R.E.M. - Original recording reissued','500','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000050','55','The Document by Blink 182 ','300','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000051','55','Document (R.E.M. No. 5) by R.E.M.','200','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000052','55','Decision Points ','500','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000053','55','The Confession','300','Good','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000054','55','The Adventures and the Memoirs of Sherlock Holmes','200','Good','0','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000055','66','30 Handmade All Occasion Greeting Cards with Decorative Reusable Organizer Box by Paper Magic','500','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000056','66','THE ORIGINAL POP UPS - 013 - WEDDING CAKE - WEDDING CARD by The Original Pop Ups','300','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000057','66','70 Christmas Holiday Greeting Note Cards & Envelopes Box Set','200','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000058','66','Make Your Own Cards by Made By Hands','500','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000059','66','Off Ramp Humorous Birthday Card Assortment 3 by Off Ramp','300','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000060','66','BIRTHDAY CARD Greeting Cards Candy Mold Chocolate','200','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000061','66','Handmade Happy Birthday Card by From The Earth','500','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000062','66','THE ORIGINAL POP UPS - 013 - WEDDING CAKE - WEDDING CARD','300','Nice','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000063','66','Hortense B. Hewitt Wedding Accessories Thank You Cards','200','Nice','0','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000064','77','Geoffrey Beene Mens Mirage Slim Passcase Wallet by Geoffrey Beene','500','Very fashion & cool','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000065','77','Tommy Hilfiger Mens Cambridge Trifold Wallet by Tommy Hilfiger','300','Very fashion & cool','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000066','77','Nautica Mens Multi Card Passcase by Nautica','200','Very fashion & cool','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000067','77','Carhartt Mens Two Tone Trifold Wallet by Carhartt','500','Very fashion & cool','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000068','77','Guess Mens Credit Card Trifold by GUESS','300','Very fashion & cool','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000069','77','Carhartt Mens Long Neck Front Pocket Wallet by Carhartt','200','Very fashion & cool','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000070','77','Fine Leather Hand Crafted Mans Mans Mens Mens Mini Wallet Credit Card Holder with Magnetic Money Clip by VB','500','Very fashion & cool','','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000071','77','Kenneth Cole REACTION Mens Passcase Wallet by Kenneth Cole REACTION','300','Very fashion & cool','365','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000072','77','Geoffrey Beene Mens Passcase Billfold by Geoffrey Beene','200','Very fashion & cool','365','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000073','88','Fisher-Price Brilliant Basics Babys First Blocks by Fisher Price','500','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000074','88','Baby Einstein Take Along Tunes by KIDS II','300','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000075','88','Manhattan Toy Winkel by Manhattan Toy','200','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000076','88','Baby Einstein Bendy Ball by KIDS II','500','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000077','88','Munchkin Mozart Magic Cube by Munchkin','300','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000078','88','Sassy Ring O Links Rattle Developmental Toy by Sassy','200','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000079','88','Vulli Sophie the Giraffe Teether by Vulli','500','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000080','88','Alex Tub Tunes Water Flutes by Alex','300','Nice & Safe','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000081','88','Lamaze Jacques the Peacock by Learning Curve','200','Nice & Safe','0','','100')

INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000082','99','Toy Story 3 (2010)','300','Great','0','','100')
INSERT INTO Product(ProductId,CatId,ProductName,Price,Description,WarantyDay,Image,Quantity) VALUES ('0000083','99','How to Train Your Dragon (Single Disc Edition) (2010)','200','Good','0','','100')

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[UserStatusRole]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[UserStatusRole]
AS
SELECT     dbo.[User].UserId, dbo.[User].Username, dbo.[User].Password, dbo.[User].Fullname, dbo.[User].Gender, dbo.[User].Address, dbo.[User].Email, 
                      dbo.[User].PhoneNumber, dbo.StatusUser.StatusUserName, dbo.Role.RoleName, dbo.[User].RoleId, dbo.[User].StatusId
FROM         dbo.Role INNER JOIN
                      dbo.[User] ON dbo.Role.RoleId = dbo.[User].RoleId INNER JOIN
                      dbo.StatusUser ON dbo.[User].StatusId = dbo.StatusUser.StatusUserId
' 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Role"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 101
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 125
               Right = 406
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "StatusUser"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 101
               Right = 422
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'UserStatusRole'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'UserStatusRole'

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[ProductCategory]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[ProductCategory]
AS
SELECT     dbo.Product.*, dbo.Category.CatName
FROM         dbo.Category INNER JOIN
                      dbo.Product ON dbo.Category.CatId = dbo.Product.CatId
' 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Category"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 95
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Product"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'ProductCategory'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'ProductCategory'

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_StatusUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_StatusUser] FOREIGN KEY([StatusId])
REFERENCES [dbo].[StatusUser] ([StatusUserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PaymentDetail_CardType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PaymentDetail]'))
ALTER TABLE [dbo].[PaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDetail_CardType] FOREIGN KEY([CardTypeId])
REFERENCES [dbo].[CardType] ([CardTypeId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Feedback_FeedBackType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Feedback]'))
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_FeedBackType] FOREIGN KEY([FeedTypeId])
REFERENCES [dbo].[FeedBackType] ([FeedTypeId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Feedback_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[Feedback]'))
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Country]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_DeliveryType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_DeliveryType] FOREIGN KEY([DeliveryId])
REFERENCES [dbo].[DeliveryType] ([DeliveryId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Payment] FOREIGN KEY([PayTypeId])
REFERENCES [dbo].[PaymentType] ([PayTypeId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_PaymentDetail]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_PaymentDetail] FOREIGN KEY([PayDetailId])
REFERENCES [dbo].[PaymentDetail] ([PayDetailId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_PaymentDetail1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_PaymentDetail1] FOREIGN KEY([PayDetailId])
REFERENCES [dbo].[PaymentDetail] ([PayDetailId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_StatusDelivery]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_StatusDelivery] FOREIGN KEY([StatusDeliveryId])
REFERENCES [dbo].[StatusDelivery] ([StatusDeliveryId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_StatusPaid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_StatusPaid] FOREIGN KEY([StatusPaidId])
REFERENCES [dbo].[StatusPaid] ([StatusPaidId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_User5]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User5] FOREIGN KEY([UserIdShip])
REFERENCES [dbo].[User] ([UserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_User6]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User6] FOREIGN KEY([UserIdCheck])
REFERENCES [dbo].[User] ([UserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_User7]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User7] FOREIGN KEY([CustId])
REFERENCES [dbo].[User] ([UserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Product]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_ProductReplace]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_ProductReplace] FOREIGN KEY([ProductReplace])
REFERENCES [dbo].[Product] ([ProductId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Product_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CatId])
REFERENCES [dbo].[Category] ([CatId])

-----CREATE INDEX 
CREATE UNIQUE INDEX IX_User_Username ON [User](Username)
CREATE UNIQUE INDEX IX_Order_PayDetailId ON [Order](PayDetailId)
