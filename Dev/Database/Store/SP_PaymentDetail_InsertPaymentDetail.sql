/***********************************************************
* Purpose : Insert Payment Detail
* Author : Tam Kute
* Date: 21-11-2010
* Description: Insert Payment Detail
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_PaymentDetail_InsertPaymentDetail]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_PaymentDetail_InsertPaymentDetail]
GO
CREATE PROC [SP_PaymentDetail_InsertPaymentDetail]
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
	INSERT INTO PaymentDetail
	(
		PaymentName,
		CardTypeId,
		Title,
		ReleaseDate,
		ReleasePlace,
		BankName,
		Account,
		Pay,
		PayPlace,
		PayWay,
		ExpirationDate,
		DrawerName,
		PayerName,
		CCNumber,
		CVV,	
		SecurityNumber
	)
	VALUES
	(
		@PaymentName,
		@CardTypeId,
		@Title,
		@ReleaseDate,
		@ReleasePlace,
		@BankName,
		@Account,
		@Pay,
		@PayPlace,
		@PayWay,
		@ExpirationDate,
		@DrawerName,
		@PayerName,
		@CCNumber,
		@CVV,	
		@SecurityNumber
	)
END
