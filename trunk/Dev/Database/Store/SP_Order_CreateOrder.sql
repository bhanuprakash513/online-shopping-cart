/***********************************************************
* Purpose : Create Order
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Create Order
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_Order_CreateOrder]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_Order_CreateOrder]
GO
CREATE PROC [SP_Order_CreateOrder]
	@PayDetailId int,
	@DeliveryId int,
	@PayTypeId int,
	@CustId int,
	@ReceiverFullname nvarchar(50),
	@ReceiverAddress nvarchar(50),
	@ReceiverPhone varchar(15),
	@CountryId int,
	@City nvarchar(50),
	@State nvarchar(50),
	@Zipcode nvarchar(5),
	@TotalCost decimal(18,0),
	@Note nvarchar(max)
AS
BEGIN
	DECLARE @StatusPaidId int	
	DECLARE @StatusDeliveryId int

	SET @StatusPaidId=1
	SET @StatusDeliveryId=1
	INSERT INTO [ORDER]
	(
		PayDetailId,
		DeliveryId,
		PayTypeId,
		CustId,
		OrderDate,
		ReceiverFullname,
		ReceiverAddress,
		ReceiverPhone,
		CountryId,
		City,
		State,
		Zipcode,
		TotalCost,
		StatusPaidId,
		StatusDeliveryId,
		Note
	)
	VALUES
	(
		@PayDetailId,
		@DeliveryId,
		@PayTypeId,
		@CustId,
		GETDATE(),
		@ReceiverFullname,
		@ReceiverAddress,
		@ReceiverPhone,
		@CountryId,
		@City,
		@State,
		@Zipcode,
		@TotalCost,
		@StatusPaidId,
		@StatusDeliveryId,
		@Note
	)	
END
