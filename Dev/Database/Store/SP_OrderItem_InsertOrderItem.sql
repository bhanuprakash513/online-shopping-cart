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

