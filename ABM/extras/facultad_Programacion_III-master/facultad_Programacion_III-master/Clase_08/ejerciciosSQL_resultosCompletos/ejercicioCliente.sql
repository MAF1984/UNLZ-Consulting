CREATE PROC EjercicioCliente (@NroCliente VarChar(5))
    AS

SELECT *
    FROM Orders
    WHERE CustomerID = @NroCliente
