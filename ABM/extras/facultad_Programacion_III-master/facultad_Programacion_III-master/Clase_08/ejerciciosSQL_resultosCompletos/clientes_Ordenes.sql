SELECT  TOP (100) PERCENT dbo.Customers.CustomerID AS NCli
       ,dbo.Customers.CompanyName                  AS Cliente
       ,dbo.Orders.OrderID                         AS NumFac
       ,dbo.Orders.OrderDate                       AS FechaFac
FROM dbo.Customers
INNER JOIN dbo.Orders
ON dbo.Customers.CustomerID = dbo.Orders.CustomerID
WHERE (dbo.Customers.CustomerID = N'ALFKI')
ORDER BY NumFac