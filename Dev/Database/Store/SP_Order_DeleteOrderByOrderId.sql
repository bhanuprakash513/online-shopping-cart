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
