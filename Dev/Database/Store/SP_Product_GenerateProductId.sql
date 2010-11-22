
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SP_Product_GenerateProductId]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[SP_Product_GenerateProductId]
GO
CREATE PROC [SP_Product_GenerateProductId]
	@IDNew varchar(7) output
AS
BEGIN
	DECLARE @LengthId int;
		SET @LengthId=7
	DECLARE @Str varchar(7);
	DECLARE @Num int;
	DECLARE @LengthStr int;
	DECLARE @Count int;
	DECLARE @MaxId int;
	SET @MaxId=9999999

	SELECT TOP 1 @Str=ProductId FROM Product ORDER BY ProductId DESC;

	SET @Str=CAST (CAST(@Str AS int) As Varchar)
	SET @Num=CAST(@Str AS int)+1
	SET @LengthStr=Len(@Str)
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
		SET @IDNew = @Str
	END
END

