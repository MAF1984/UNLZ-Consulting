USE AdventureWorks
GO
SELECT ProductNumber,
        Categoria =
            CASE ProductLine
                WHEN 'R' THEN 'Ruta'
                WHEN 'M' THEN 'Montania'
                WHEN 'T' THEN 'Turismo'
                WHEN 'S' THEN 'Otros Items para vender'
                ELSE 'No se vende'
                END,
        Name
            FROM Production.Product
                ORDER BY ProductNumber