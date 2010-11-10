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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeliveryType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DeliveryType](
	[DeliveryId] [int] NOT NULL,
	[DeliveryName] [nvarchar](50) NOT NULL,
	[DeliveryCost] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DeliveryType] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[PayDetailId] [int] NOT NULL,
	[DeliveryId] [int] NOT NULL,
	[UserIdShip] [int] NOT NULL,
	[UserIdCheck] [int] NOT NULL,
	[PayTypeId] [int] NOT NULL,
	[ShippingDate] [datetime] NOT NULL,
	[StatusPaidId] [int] NOT NULL,
	[StatusDeliveryId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[ShippingFullname] [nvarchar](50) NOT NULL,
	[ShippingAddress] [nvarchar](50) NOT NULL,
	[ShippingPhone] [varchar](15) NOT NULL,
	[PaymentFullname] [nvarchar](50) NOT NULL,
	[PaymentAddress] [nvarchar](50) NOT NULL,
	[PaymentPhone] [varchar](15) NOT NULL,
	[TotalCost] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Delivery_1] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
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
	[ExWarrantyDate] [datetime] NOT NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[OrderItemID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
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
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[FeedId] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PaymentDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PaymentDetail](
	[PayDetailId] [int] IDENTITY(1,1) NOT NULL,
	[Beneficiary] [nvarchar](50) NULL,
	[PaymentName] [nvarchar](50) NOT NULL,
	[CardTypeId] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[ReleaseDate] [datetime] NULL,
	[ReleasePlace] [nvarchar](max) NULL,
	[BankName] [nvarchar](max) NULL,
	[Account] [nvarchar](max) NULL,
	[Pay] [decimal](18, 0) NULL,
	[PayPlace] [nvarchar](max) NULL,
	[OwnerName] [nvarchar](50) NULL,
	[PayWay] [nvarchar](max) NULL,
	[ExpirationDate] [datetime] NULL,
	[DrawerName] [nvarchar](50) NULL,
	[PayerName] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Zipcode] [nvarchar](5) NULL,
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
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_StatusUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_StatusUser] FOREIGN KEY([StatusId])
REFERENCES [dbo].[StatusUser] ([StatusUserId])
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
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([UserIdShip])
REFERENCES [dbo].[User] ([UserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Order_User1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User1] FOREIGN KEY([UserIdCheck])
REFERENCES [dbo].[User] ([UserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Product_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CatId])
REFERENCES [dbo].[Category] ([CatId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Product]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Feedback_FeedBackType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Feedback]'))
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_FeedBackType] FOREIGN KEY([FeedTypeId])
REFERENCES [dbo].[FeedBackType] ([FeedTypeId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Feedback_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[Feedback]'))
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PaymentDetail_CardType]') AND parent_object_id = OBJECT_ID(N'[dbo].[PaymentDetail]'))
ALTER TABLE [dbo].[PaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDetail_CardType] FOREIGN KEY([CardTypeId])
REFERENCES [dbo].[CardType] ([CardTypeId])
