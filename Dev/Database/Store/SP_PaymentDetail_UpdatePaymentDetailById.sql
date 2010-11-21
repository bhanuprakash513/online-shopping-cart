/***********************************************************
* Purpose : Update Payment Detail By PayDetailId
* Author : Tam Kute
* Date: 21-11-2010
* Description: Update Payment Detail By PayDetailId
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_PaymentDetail_UpdatePaymentDetailByPayDetailId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_PaymentDetail_UpdatePaymentDetailByPayDetailId]
GO
CREATE PROC [SP_PaymentDetail_UpdatePaymentDetailByPayDetailId]
	@PayDetailId int,
	@PaymentName	nvarchar(50),
	@CardTypeId		int,
	@Title			nvarchar(max),
	@ReleaseDate	datetime,
	@ReleasePlace	nvarchar(max),
	@BankName		nvarchar(max),
	@Account		nvarchar(max),
	@Pay			decimal(18,0),
	@PayPlace		nvarchar(max),
	@PayWay			nvarchar(max),
	@ExpirationDate datetime,
	@DrawerName		nvarchar(50),
	@PayerName		nvarchar(50),
	@CCNumber		nvarchar(50),
	@CVV			nvarchar(50),
	@SecurityNumber nvarchar(50)
AS
BEGIN
	IF @CardTypeId = -1
		SET @CardTypeId=NULL
	UPDATE PaymentDetail
	SET
		PaymentName=@PaymentName,
		CardTypeId=@CardTypeId,
		Title=@Title,
		ReleaseDate=@ReleaseDate,
		ReleasePlace=@ReleasePlace,
		BankName=@BankName,
		Account=@Account,
		Pay=@Pay,
		PayPlace=@PayPlace,
		PayWay=@PayWay,
		ExpirationDate=@ExpirationDate,
		DrawerName=@DrawerName,
		PayerName=@PayerName,
		CCNumber=@CCNumber,
		CVV=@CVV,	
		SecurityNumber=@SecurityNumber
	WHERE
		PayDetailId=@PayDetailId
	
END
	