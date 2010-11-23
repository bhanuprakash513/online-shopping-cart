/***********************************************************
* Purpose : Update status delivery  By OrderId
* Author : Tam Kute
* Date: 21-11-2010S
* Description: Update status delivery 
***********************************************************/

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].SP_Order_UpdateStatusDeliveryByOrderId') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].SP_Order_UpdateStatusDeliveryByOrderId
GO
CREATE PROC SP_Order_UpdateStatusDeliveryByOrderId
	@StatusDeliveryId int,
	@ShippingDate datetime,	
	@OrderId int
AS
BEGIN
	IF @StatusDeliveryId=3
	BEGIN
		DECLARE @StatusOrder int
		SELECT @StatusOrder=StatusDeliveryId FROM [Order] WHERE [Order].OrderId=@OrderId
		
					 DECLARE @OrderItemId varchar(16)
					 DEClARE @WarantyDay int
					 DECLARE @ProductId varchar(7)
					 DECLARE @ProductReplace varchar(7)
					 DECLARE @Status char
					 DECLARE @QuantityReplace int
					 DECLARE @OrderQuantity int
					 DECLARE @Count int
					 DECLARE @Money decimal(18,0)
					 SET @Money=0

			

		IF @StatusOrder = 1
		BEGIN
			DECLARE array CURSOR FOR
			(
				SELECT [OrderItem].OrderItemId,[OrderItem].ProductId,[OrderItem].OrderQuantity
						,[OrderItem].Status,[OrderItem].ProductReplace,[OrderItem].QuantityReplace
						,[Product].WarantyDay
				FROM OrderItem,Product
				WHERE OrderId=@OrderId And Product.ProductId=[OrderItem].ProductId  
			)
			
			--------------------------------------XU LY GIAO HANG--------------------------------------
			
			OPEN array 

					 FETCH NEXT FROM array INTO @OrderItemId,@ProductId,@OrderQuantity,@Status,@ProductReplace,@QuantityReplace,@WarantyDay
					 
					 WHILE @@FETCH_STATUS=0
					 BEGIN
						
						IF @Status='A'
						BEGIN
							--------------------TINH TRANG DON HANG MOI---------------------------
							
							SELECT @Count=[Product].Quantity-@OrderQuantity 
							FROM Product 
							WHERE [Product].ProductId=@ProductId
							
							IF @Count>=0
							BEGIN
								-----------------UPDATE NGAY BAO HANH
								UPDATE OrderItem
									SET ExWarrantyDate=DateAdd(dd,@WarantyDay,@ShippingDate) 
								WHERE OrderItemId=@OrderItemId

								-----------------UPDATE SO LUONG SAN PHAM TRONG KHO
								UPDATE Product 
									SET Product.Quantity=Product.Quantity-@OrderQuantity
								WHERE Product.ProductId=@ProductId
			
							END	
									
							-----------------------------------------------------------------------
						END
						FETCH NEXT FROM array INTO @OrderItemId,@ProductId,@OrderQuantity,@Status,@ProductReplace,@QuantityReplace,@WarantyDay
						
					 END

			CLOSE array 			
			DEALLOCATE array 
		END
		IF @StatusOrder = 4
		BEGIN
			--------------------------------------XU LY TRA HANG--------------------------------------
			DECLARE array CURSOR FOR
			(
				SELECT [OrderItem].OrderItemId,[OrderItem].ProductId,[OrderItem].OrderQuantity
						,[OrderItem].Status,[OrderItem].ProductReplace,[OrderItem].QuantityReplace
						,[Product].WarantyDay
				FROM OrderItem,Product
				WHERE OrderId=@OrderId And Product.ProductId=[OrderItem].ProductId  
			)

			OPEN array 
								
					 FETCH NEXT FROM array INTO @OrderItemId,@ProductId,@OrderQuantity,@Status,@ProductReplace,@QuantityReplace,@WarantyDay
					 
					 WHILE @@FETCH_STATUS=0
					 BEGIN
						
			
						IF @Status='R'
						BEGIN
							--------------------TINH TRANG THAY THE SAN PHAM----------------------
							SELECT @Count=[Product].Quantity-@QuantityReplace,@WarantyDay=[Product].WarantyDay FROM Product WHERE [Product].ProductId=@ProductId
							IF @Count>=0
							BEGIN
								--------------------UPDATE LAI KHO TRUOC KHI THAY THE SAN PHAM KHAC-------------------------------
								UPDATE Product
									SET Quantity=Quantity+@OrderQuantity
								WHERE	ProductId=@ProductId						

								--------------------UPDATE ORDERITEM CAC SAN PHAM THAY THE THANH SAN PHAM CHINH-------------------
									
								UPDATE OrderItem 
									SET ProductId=@ProductReplace,OrderQuantity=@QuantityReplace, 
											ProductReplace=NULL,QuantityReplace=NULL
								WHERE OrderItemId=@OrderItemId 
									
								
								-----------------UPDATE TINH TRANG ORDERITEM	
								UPDATE OrderItem
									SET Status='A'
								WHERE OrderItemId=@OrderItemId
						
								---------------------- TINH TOAN SO LUONG LAI---------------------
								
								UPDATE OrderItem
									SET ExWarrantyDate=DateAdd(dd,@WarantyDay,@ShippingDate) 
								WHERE OrderItemId=@OrderItemId
								
								-----------------UPDATE SO LUONG SAN PHAM TRONG KHO
								UPDATE Product 
									SET Quantity=Quantity-@QuantityReplace
								WHERE Product.ProductId=@ProductReplace
								
								

							END	
							-----------------------------------------------------------------------
						END
						ELSE IF @Status='D'
						BEGIN
							--------------------TINH TRANG XOA SAN PHAM---------------------------
							DELETE OrderItem WHERE OrderItemId=@OrderItemId
							UPDATE Product 
									SET Product.Quantity=Product.Quantity+@OrderQuantity
							WHERE Product.ProductId=@ProductId
								
							-----------------------------------------------------------------------
						END
					
						FETCH NEXT FROM array INTO @OrderItemId,@ProductId,@OrderQuantity,@Status,@ProductReplace,@QuantityReplace,@WarantyDay
					
					 END
						----------------------CAP NHAT LAI TIEN THANH TOAN----------------------------
						SELECT @Money=SUM(Price*[OrderItem].OrderQuantity)
						FROM OrderItem,Product 
						WHERE OrderItem.OrderId=1 AND Product.ProductId=OrderItem.ProductId	

						DECLARE @PayDetailId int
						SELECT @PayDetailId=PayDetailId From [Order] WHERE OrderId=@OrderId
						UPDATE PaymentDetail SET Pay=@Money WHERE PayDetailId=@PayDetailId

						SELECT @Money=@Money+DeliveryCost FROM DeliveryType,[Order] WHERE [Order].DeliveryId = DeliveryType.DeliveryId
						
						UPDATE [Order] SET ExtraMoney=TotalCost-@Money WHERE OrderId=@OrderId
						UPDATE [Order] SET TotalCost=@Money WHERE OrderId=@OrderId
						--------------------------------------------------------------------------------
			CLOSE array 			
			DEALLOCATE array 
			
		END	
			--------------------------------------------------------------------------------------------
			-------------------------------CAP NHAT NGAY GIAO HANG
			IF @ShippingDate = NULL OR @ShippingDate = ''
				SET @ShippingDate=GETDATE()
			
			UPDATE [Order]
			SET		
					ShippingDate=@ShippingDate
			WHERE OrderId=@OrderId			
			--------------------------------------------------------------------------------------------
	END
	UPDATE [Order]
	SET	StatusDeliveryId=@StatusDeliveryId
	WHERE OrderId=@OrderId
END
