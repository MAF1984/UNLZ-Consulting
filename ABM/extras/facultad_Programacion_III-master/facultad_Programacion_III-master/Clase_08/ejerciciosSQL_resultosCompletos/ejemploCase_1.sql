USE AdventureWorks

GO

SELECT ProductNumber, 
        CATEGORIA =
            CASE ProductLine
                WHEN 'R' THEN 'Ruta'
                WHEN 'M' THEN 'Monta�a'
                WHEN 'T' THEN 'Turismo'
                WHEN 'S' THEN 'Otros Items para vender'
                ELSE 'No se vende'
            END,
        Name
            FROM Production.Product
                ORDER BY ProductNumber