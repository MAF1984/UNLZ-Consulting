USE AdventureWorks

GO

SELECT ProductNumber,
       Name,
       [RangoDePrecio] = 'Rango de precio ' +
            CASE
                WHEN ListPrice = 0
                    THEN 'que no es para venta'
                WHEN ListPrice < 50
                    THEN 'por debajo de $ 50'
                WHEN ListPrice <= 50 AND ListPrice < 250
                    THEN 'por debajo de $250'
                WHEN ListPrice >= 50 AND ListPrice < 1000
                    THEN 'por debajo de $1000'
                ELSE 'por sobre $ 1000'
            END
                FROM Production.Product
                    ORDER BY ProductNumber