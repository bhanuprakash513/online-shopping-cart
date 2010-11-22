
--SP_OrderItem_GenerateOrderItemId.sql

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_OrderItem_GenerateOrderItemId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_OrderItem_GenerateOrderItemId]
GO
CREATE PROC [SP_OrderItem_GenerateOrderItemId]
	@DeliveryId char,	
	@ProductId varchar(7),
	@IDNew varchar(16) output
AS
BEGIN
	DECLARE @LengthId int;
		SET @LengthId=8;
	DECLARE @Str varchar(16);
	SET @Str=''
	DECLARE @Num int;
	DECLARE @LengthStr int;
	DECLARE @Count int;
	DECLARE @MaxId int;
	SET @MaxId=99999999;
	WITH [TEMP] AS
	(
		SELECT Substring(OrderItemId,9,@LengthId)
		AS OrderItemId 
		FROM OrderItem 
		WHERE ProductId=@ProductId
	) 
	SELECT TOP 1 @Str=[TEMP].OrderItemId FROM [TEMP] ORDER BY [TEMP].OrderItemId DESC;
	IF @Str='' OR @Str=NULL
	BEGIN
		SET @IDNew = @DeliveryId+@ProductId+'00000001'
	END
	ELSE
	BEGIN

		SET @Str=CAST (CAST(@Str AS int) As Varchar)
		SET @Num=CAST(@Str AS int)+1
		SET @LengthStr=Len(@Str)
		SET @Str=CAST(@Num AS int)
		IF @Num>@MaxId
		BEGIN

			SET @IDNew = NULL
		END
		ELSE
		BEGIN
			SET @Count=@LengthId-@LengthStr

			WHILE @Count != 0
			BEGIN

				SET @Str='0'+@Str
				SET	@Count=@Count-1
				
			END;
			SET @IDNew = @DeliveryId+@ProductId+@Str
		END

	END
	
END


GO

--SP_OrderItem_InsertOrderItem.sql
/***********************************************************
* Purpose : Insert Order Item
* Author : Tam Kute
* Date: 21-11-2010
* Description: Insert Order Item
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_OrderItem_InsertOrderItem]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_OrderItem_InsertOrderItem]
GO
CREATE PROC [SP_OrderItem_InsertOrderItem]
	@OrderId int,
	@ProductId varchar(7),
	@OrderQuantity int
AS
BEGIN	
	DECLARE @DeliveryId char
	SELECT @DeliveryId=[Order].DeliveryId FROM [Order] WHERE [Order].OrderId=@OrderId
	DECLARE @OrderItemId Varchar(16) 
	EXEC [SP_OrderItem_GenerateOrderItemId] '1','0000002',@OrderItemId output
	
	INSERT INTO OrderItem
	(
		OrderItemId,
		OrderId,
		ProductId,
		OrderQuantity
	)
	VALUES
	(
		@OrderItemId,
		@OrderId,
		@ProductId,
		@OrderQuantity
	)
END


GO

--SP_OrderItem_UpdateOrderItemByOrderItemId.sql
/***********************************************************
* Purpose : Update OrderItem By OrderItemId
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Update Order Item
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_OrderItem_UpdateOrderItemByOrderItemId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_OrderItem_UpdateOrderItemByOrderItemId]
GO
CREATE PROC [SP_OrderItem_UpdateOrderItemByOrderItemId]
	@OrderItemId varchar(16),
	@ProductId varchar(7),
	@OrderQuantity int

AS
BEGIN
	UPDATE [OrderItem]
		SET		
				ProductId=@ProductId,
				OrderQuantity=@OrderQuantity
	WHERE OrderItemId=@OrderItemId
			
END

GO

--SP_Order_CreateOrder.sql
/***********************************************************
* Purpose : Create Order
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Create Order
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_Order_CreateOrder]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_Order_CreateOrder]
GO
CREATE PROC [SP_Order_CreateOrder]
	@PayDetailId int,
	@DeliveryId int,
	@PayTypeId int,
	@CustId int,
	@ReceiverFullname nvarchar(50),
	@ReceiverAddress nvarchar(50),
	@ReceiverPhone varchar(15),
	@CountryId int,
	@City nvarchar(50),
	@State nvarchar(50),
	@Zipcode nvarchar(5),
	@TotalCost decimal(18,0),
	@Note nvarchar(max)
AS
BEGIN
	DECLARE @StatusPaidId int	
	DECLARE @StatusDeliveryId int

	SET @StatusPaidId=1
	SET @StatusDeliveryId=1
	INSERT INTO [ORDER]
	(
		PayDetailId,
		DeliveryId,
		PayTypeId,
		CustId,
		OrderDate,
		ReceiverFullname,
		ReceiverAddress,
		ReceiverPhone,
		CountryId,
		City,
		State,
		Zipcode,
		TotalCost,
		StatusPaidId,
		StatusDeliveryId,
		Note
	)
	VALUES
	(
		@PayDetailId,
		@DeliveryId,
		@PayTypeId,
		@CustId,
		GETDATE(),
		@ReceiverFullname,
		@ReceiverAddress,
		@ReceiverPhone,
		@CountryId,
		@City,
		@State,
		@Zipcode,
		@TotalCost,
		@StatusPaidId,
		@StatusDeliveryId,
		@Note
	)	
END

GO

--SP_Order_DeleteOrderByOrderId.sql
/***********************************************************
* Purpose : Delete Order
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Delete Order
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_Order_DeleteOrderByOrderId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_Order_DeleteOrderByOrderId]
GO
CREATE PROC [SP_Order_DeleteOrderByOrderId]
	@OrderId int
AS
BEGIN
	DECLARE @PayDetailId int
	SELECT @PayDetailId=PayDetailId FROM [Order] WHERE OrderId=@OrderId
	DELETE PaymentDetail WHERE PayDetailId=@PayDetailId;
	DELETE OrderItem WHERE OrderId=@OrderId
	DELETE [Order] WHERE OrderId=@OrderId
END

GO

--SP_Order_UpdateOrderByOrderId.sql
/***********************************************************
* Purpose : Update Order By OrderId
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Update Order By OrderId
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_Order_UpdateOrderByOrderId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_Order_UpdateOrderByOrderId]
GO
CREATE PROC [SP_Order_UpdateOrderByOrderId]
	@OrderId int,
	@DeliveryId int,
	@PayTypeId int,
	@ReceiverFullname nvarchar(50),
	@ReceiverAddress nvarchar(50),
	@ReceiverPhone varchar(15),
	@CountryId int,
	@City nvarchar(50),
	@State nvarchar(50),
	@Zipcode nvarchar(5),
	@TotalCost decimal(18,0),
	@ExtraMoney decimal(18,0),
	@Note nvarchar(max)
AS
BEGIN
	

	UPDATE [ORDER]
	
		SET 
		DeliveryId=@DeliveryId,
		PayTypeId=@PayTypeId,
		ReceiverFullname=@ReceiverFullname,
		ReceiverAddress=@ReceiverAddress,
		ReceiverPhone=@ReceiverPhone,
		CountryId=@CountryId,
		City=@City,
		State=@State,
		Zipcode=@Zipcode,
		TotalCost=@TotalCost,
		Note=@Note,
		ExtraMoney=@ExtraMoney

	WHERE OrderId=@OrderId
			
END

GO

--SP_Order_UpdateStatusDeliveryByOrderId.sql
/***********************************************************
* Purpose : Update status delivery  By OrderId
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Update status delivery 
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].SP_Order_UpdateStatusDeliveryByOrderId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].SP_Order_UpdateStatusDeliveryByOrderId
GO
CREATE PROC SP_Order_UpdateStatusDeliveryByOrderId
	@StatusDeliveryId varchar(16),
	@ShippingDate datetime,	
	@OrderId varchar(7)
AS
BEGIN
	UPDATE [Order]
		SET		
				StatusDeliveryId=@StatusDeliveryId
	WHERE OrderId=@OrderId
			
	IF @StatusDeliveryId = 2
	BEGIN
		IF @ShippingDate = NULL OR @ShippingDate = ''
			SET @ShippingDate=GETDATE()

		UPDATE [Order]
		SET		
				ShippingDate=@ShippingDate
		WHERE OrderId=@OrderId
		DECLARE array CURSOR FOR
		(
						SELECT OrderItem.OrderItemId,WarantyDay
						FROM OrderItem,Product
						WHERE OrderId=@OrderId And Product.ProductId=[OrderItem].ProductId  
		)
		OPEN array 
							
				 DECLARE @OrderItemId varchar(16)
				 DEClARE @WarantyDay int
				 
				 FETCH NEXT FROM array INTO @OrderItemId,@WarantyDay
				 
				 WHILE @@FETCH_STATUS=0
				 BEGIN
						

					UPdATE OrderItem
						SET ExWarrantyDate=DateAdd(dd,@WarantyDay,@ShippingDate) 
					Where OrderItemId=@OrderItemId


				 
					 FETCH NEXT FROM array INTO @OrderItemId,@WarantyDay
				
				 END
			   
		CLOSE array 			
		DEALLOCATE array 
	END
END

GO

--SP_PaymentDetail_InsertPaymentDetail.sql
/***********************************************************
* Purpose : Insert Payment Detail
* Author : Tam Kute
* Date: 21-11-2010
* Description: Insert Payment Detail
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_PaymentDetail_InsertPaymentDetail]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_PaymentDetail_InsertPaymentDetail]
GO
CREATE PROC [SP_PaymentDetail_InsertPaymentDetail]
	@PaymentName	nvarchar(50),
	@CardTypeId		int,
	@Title			nvarchar(max),
	@ReleaseDate	datetime,
	@ReleasePlace	nvarchar(max),
	@BankName		nvarchar(max),
	@Account		nvarchar(max),
	@Pay			decimal(18,0),
	@PayPlace		nvarchar(max),
	@PayWay			nvarchar(max),
	@ExpirationDate datetime,
	@DrawerName		nvarchar(50),
	@PayerName		nvarchar(50),
	@CCNumber		nvarchar(50),
	@CVV			nvarchar(50),
	@SecurityNumber nvarchar(50)
AS
BEGIN
	IF @CardTypeId = -1
		SET @CardTypeId=NULL
	INSERT INTO PaymentDetail
	(
		PaymentName,
		CardTypeId,
		Title,
		ReleaseDate,
		ReleasePlace,
		BankName,
		Account,
		Pay,
		PayPlace,
		PayWay,
		ExpirationDate,
		DrawerName,
		PayerName,
		CCNumber,
		CVV,	
		SecurityNumber
	)
	VALUES
	(
		@PaymentName,
		@CardTypeId,
		@Title,
		@ReleaseDate,
		@ReleasePlace,
		@BankName,
		@Account,
		@Pay,
		@PayPlace,
		@PayWay,
		@ExpirationDate,
		@DrawerName,
		@PayerName,
		@CCNumber,
		@CVV,	
		@SecurityNumber
	)
END


GO

--SP_PaymentDetail_UpdatePaymentDetailByPayDetailId.sql
/***********************************************************
* Purpose : Update Payment Detail By PayDetailId
* Author : Tam Kute
* Date: 21-11-2010
* Description: Update Payment Detail By PayDetailId
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_PaymentDetail_UpdatePaymentDetailByPayDetailId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_PaymentDetail_UpdatePaymentDetailByPayDetailId]
GO
CREATE PROC [SP_PaymentDetail_UpdatePaymentDetailByPayDetailId]
	@PayDetailId int,
	@PaymentName	nvarchar(50),
	@CardTypeId		int,
	@Title			nvarchar(max),
	@ReleaseDate	datetime,
	@ReleasePlace	nvarchar(max),
	@BankName		nvarchar(max),
	@Account		nvarchar(max),
	@Pay			decimal(18,0),
	@PayPlace		nvarchar(max),
	@PayWay			nvarchar(max),
	@ExpirationDate datetime,
	@DrawerName		nvarchar(50),
	@PayerName		nvarchar(50),
	@CCNumber		nvarchar(50),
	@CVV			nvarchar(50),
	@SecurityNumber nvarchar(50)
AS
BEGIN
	IF @CardTypeId = -1
		SET @CardTypeId=NULL
	UPDATE PaymentDetail
	SET
		PaymentName=@PaymentName,
		CardTypeId=@CardTypeId,
		Title=@Title,
		ReleaseDate=@ReleaseDate,
		ReleasePlace=@ReleasePlace,
		BankName=@BankName,
		Account=@Account,
		Pay=@Pay,
		PayPlace=@PayPlace,
		PayWay=@PayWay,
		ExpirationDate=@ExpirationDate,
		DrawerName=@DrawerName,
		PayerName=@PayerName,
		CCNumber=@CCNumber,
		CVV=@CVV,	
		SecurityNumber=@SecurityNumber
	WHERE
		PayDetailId=@PayDetailId
	
END
	
GO

--SP_Product_GenerateProductId.sql

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_Product_GenerateProductId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_Product_GenerateProductId]
GO
CREATE PROC [SP_Product_GenerateProductId]
	@IDNew varchar(7) output
AS
BEGIN
	DECLARE @LengthId int;
		SET @LengthId=7
	DECLARE @Str varchar(7);
	DECLARE @Num int;
	DECLARE @LengthStr int;
	DECLARE @Count int;
	DECLARE @MaxId int;
	SET @MaxId=9999999
	SET @Str=''
	SELECT TOP 1 @Str=ProductId FROM Product ORDER BY ProductId DESC;
	IF @Str=''
	BEGIN
		SET @IDNew = '0000001'
	END
	ELSE
	BEGIN
	
		SET @Str=CAST (CAST(@Str AS int) As Varchar)
		SET @Num=CAST(@Str AS int)+1
		SET @LengthStr=Len(@Str)
		SET @Str=CAST(@Num AS int)
		IF @Num>@MaxId
		BEGIN

			SET @IDNew = NULL
		END
		ELSE
		BEGIN
			SET @Count=@LengthId-@LengthStr

			WHILE @Count != 0
			BEGIN

				SET @Str='0'+@Str
				SET	@Count=@Count-1
				
			END;
			SET @IDNew = @Str
		END
	END
END


GO
