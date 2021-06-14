SELECT
    TOP (100) PERCENT dbo.Orders.OrderID AS NFact,
    SUM((dbo.[Order Details].UnitPrice * 21 / 100 + dbo.[Order Details].UnitPrice) * dbo.[Order Details].Quantity) AS Total
		FROM dbo.Customers
			INNER JOIN dbo.Orders 
				ON dbo.Customers.CustomerID = dbo.Orders.CustomerID
			INNER JOIN dbo.[Order Details] 
				ON dbo.Orders.OrderID = dbo.[Order Details].OrderID
			INNER JOIN dbo.Products 
				ON dbo.[Order Details].ProductID = dbo.Products.ProductID
					GROUP BY dbo.Orders.OrderID