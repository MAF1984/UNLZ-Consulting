USE Northwind

GO

CREATE FUNCTION PromocionTwo(@CustomerId nchar(5)) RETURNS Money AS

BEGIN

DECLARE @Sal Money, 
        @Cant INT = (SELECT COUNT(OrderId) 
                        FROM ORDERS 
                            WHERE CustomerId=@CustomerId)

SET @Sal = CASE

    WHEN @Cant > 1 
        AND @Cant < 3 THEN 10
    WHEN @Cant >= 3 
        AND @Cant < 7 THEN 15
    WHEN @Cant >= 7 THEN 20
    ELSE 0

END

RETURN @Sal

END