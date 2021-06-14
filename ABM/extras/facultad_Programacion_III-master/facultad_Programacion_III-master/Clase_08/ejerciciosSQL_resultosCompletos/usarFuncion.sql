 USE Northwind GO
SELECT  CompanyName
       ,dbo.Promocion(Customerid) AS Promo
FROM Customers