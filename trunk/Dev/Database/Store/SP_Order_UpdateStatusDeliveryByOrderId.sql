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
			
	IF @StatusDeliveryId = 3
	BEGIN
		IF @ShippingDate = NULL OR @ShippingDate = ''
			SET @ShippingDate=GETDATE()

		UPDATE [Order]
		SET		
				ShippingDate=@ShippingDate
		WHERE OrderId=@OrderId
		DECLARE array CURSOR FOR
		(
						SELECT OrderItem.OrderItemId,WarantyDay,[OrderItem].ProductId,OrderItem.OrderQuantity
						FROM OrderItem,Product
						WHERE OrderId=@OrderId And Product.ProductId=[OrderItem].ProductId  
		)
		OPEN array 
							
				 DECLARE @OrderItemId varchar(16)
				 DEClARE @WarantyDay int
				 DECLARE @ProductId varchar(7)
				 DECLARE @OrderQuantity int
				 DECLARE @Count int
				 FETCH NEXT FROM array INTO @OrderItemId,@WarantyDay,@ProductId,@OrderQuantity
				 
				 WHILE @@FETCH_STATUS=0
				 BEGIN
					
				 SELECT @Count=Quantity-@OrderQuantity FROM Product
					 IF @Count>=0
					 BEGIN
						UPDATE OrderItem
							SET ExWarrantyDate=DateAdd(dd,@WarantyDay,@ShippingDate) 
						WHERE OrderItemId=@OrderItemId

						UPDATE Product 
							SET Product.Quantity=Product.Quantity-@OrderQuantity
						WHERE Product.ProductId=@ProductId
					 END 
					FETCH NEXT FROM array INTO @OrderItemId,@WarantyDay,@ProductId,@OrderQuantity
					
				 END
			   
		CLOSE array 			
		DEALLOCATE array 
	END
END
