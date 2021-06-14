CREATE PROC Cosa (@NroCliente VarChar(5))

AS

SELECT *
    FROM Orders
    WHERE CustomerID = @NroCliente
