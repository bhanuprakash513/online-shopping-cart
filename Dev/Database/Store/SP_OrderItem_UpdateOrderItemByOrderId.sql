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
	@OrderId varchar(7),
	@OrderQuantity int

AS
BEGIN
	DECLARE @ExWarrantyDate datetime
	DECLARE @OrderDate datetime
	SELECT @OrderDate=OrderDate FROM [Order] WHERE @OrderId=[Order].OrderId
	SELECT @ExWarrantyDate=DateAdd(dd,Product.WarantyDay,@OrderDate) FROM Product Where ProductId=@ProductId

	UPDATE [OrderItem]
	
		SET		ExWarrantyDate=@ExWarrantyDate,
				ProductId=@ProductId,
				OrderQuantity=@OrderQuantity
	WHERE OrderItemId=@OrderItemId
			
END
