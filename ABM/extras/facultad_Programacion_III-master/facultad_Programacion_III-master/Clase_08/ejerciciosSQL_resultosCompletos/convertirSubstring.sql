SELECT  SUBSTRING(Name,1,30) AS NombreProducto
       ,ListPrice
       ,CONVERT(INT,ListPrice)
FROM Production.Product
WHERE CONVERT(INT,ListPrice) LIKE '3%' 