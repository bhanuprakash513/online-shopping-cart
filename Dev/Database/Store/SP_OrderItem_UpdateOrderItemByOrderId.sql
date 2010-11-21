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
	UPDATE [OrderItem]
	
		SET		
				ProductId=@ProductId,
				OrderQuantity=@OrderQuantity
	WHERE OrderItemId=@OrderItemId
			
END
