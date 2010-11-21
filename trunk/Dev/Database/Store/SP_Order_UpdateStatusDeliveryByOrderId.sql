/***********************************************************
* Purpose : Update OrderItem By OrderItemId
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Update Order Item
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
			

END
