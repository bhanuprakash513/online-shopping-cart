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
	@OrderItemId varchar(16),
	@OrderId int,
	@ProductId varchar(7),
	@OrderQuantity int
AS
BEGIN

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

--	DECLARE @ExWarrantyDate datetime
--	DECLARE @OrderDate datetime
--	SELECT @OrderDate=OrderDate FROM [Order] WHERE @OrderId=[Order].OrderId
--	SELECT @ExWarrantyDate=DateAdd(dd,Product.WarantyDay,@OrderDate) FROM Product Where ProductId=@ProductId

