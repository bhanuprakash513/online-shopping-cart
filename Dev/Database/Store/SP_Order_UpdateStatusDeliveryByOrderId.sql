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
				StatusDeliveryId=@StatusDeliveryId,
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
