
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_OrderItem_GenerateOrderItemId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_OrderItem_GenerateOrderItemId]
GO
CREATE PROC [SP_OrderItem_GenerateOrderItemId]
	@DeliveryId char,	
	@ProductId varchar(7),
	@IDNew varchar(16) output
AS
BEGIN
	DECLARE @LengthId int;
		SET @LengthId=8;
	DECLARE @Str varchar(16);
	SET @Str=''
	DECLARE @Num int;
	DECLARE @LengthStr int;
	DECLARE @Count int;
	DECLARE @MaxId int;
	SET @MaxId=99999999;
	WITH [TEMP] AS
	(
		SELECT Substring(OrderItemId,9,@LengthId)
		AS OrderItemId 
		FROM OrderItem 
		WHERE ProductId=@ProductId
	) 
	SELECT TOP 1 @Str=[TEMP].OrderItemId FROM [TEMP] ORDER BY [TEMP].OrderItemId DESC;
	IF @Str='' OR @Str=NULL
	BEGIN
		SET @IDNew = @DeliveryId+@ProductId+'00000001'
	END
	ELSE
	BEGIN

		SET @Str=CAST (CAST(@Str AS int) As Varchar)
		SET @Num=CAST(@Str AS int)+1
		SET @LengthStr=Len(CAST(@Num AS VarChar))
		SET @Str=CAST(@Num AS int)
		IF @Num>@MaxId
		BEGIN

			SET @IDNew = NULL
		END
		ELSE
		BEGIN
			SET @Count=@LengthId-@LengthStr

			WHILE @Count != 0
			BEGIN

				SET @Str='0'+@Str
				SET	@Count=@Count-1
				
			END;
			SET @IDNew = @DeliveryId+@ProductId+@Str
		END

	END
	
END

