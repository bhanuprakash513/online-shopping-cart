/***********************************************************
* Purpose : Update Order
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Update Order
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_Order_UpdateOrder]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_Order_UpdateOrder]
GO
CREATE PROC [SP_Order_UpdateOrder]
	@OrderId int,
	@PayDetailId int,
	@DeliveryId int,
	@PayTypeId int,
	@ShippingDate datetime,
	@OrderDate datetime,
	@ReceiverFullname nvarchar(50),
	@ReceiverAddress nvarchar(50),
	@ReceiverPhone varchar(15),
	@CountryId int,
	@City nvarchar(50),
	@State nvarchar(50),
	@Zipcode nvarchar(5),
	@TotalCost decimal(18,0)
AS
BEGIN
	

	UPDATE [ORDER]
	
		SET PayDetailId=@PayDetailId,
		DeliveryId=@DeliveryId,
		PayTypeId=@PayTypeId,
		OrderDate=@OrderDate,
		ReceiverFullname=@ReceiverFullname,
		ReceiverAddress=@ReceiverAddress,
		ReceiverPhone=@ReceiverPhone,
		CountryId=@CountryId,
		City=@City,
		State=@State,
		Zipcode=@Zipcode,
		TotalCost=@TotalCost

	WHERE OrderId=@OrderId
			
END
