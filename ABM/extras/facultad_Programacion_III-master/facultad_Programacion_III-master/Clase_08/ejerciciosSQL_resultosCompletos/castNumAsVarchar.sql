SELECT 'EL PRECIO ES ' + CAST(ListPrice AS VARCHAR(12)) AS PrecioLista
    FROM Production.Product
        WHERE ListPrice BETWEEN 350.00 AND 400.00:
