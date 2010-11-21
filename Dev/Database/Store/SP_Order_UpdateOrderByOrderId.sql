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
