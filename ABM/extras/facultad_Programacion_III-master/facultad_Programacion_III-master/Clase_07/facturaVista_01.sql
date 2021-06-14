SELECT TOP(100)
	PERCENT dbo.Customers.CustomerID AS NCLi,
	dbo.Customers.CompanyName AS Cliente, 
	dbo.Orders.OrderID AS NFact,    
	dbo.Orders.OrderDate AS FFac,
	dbo.Products.ProductName AS Producto,
	dbo.[Order Details].UnitPrice AS Precio,
	dbo.[Order Details].UnitPrice * 21/100 AS IVA,
	dbo.[Order Details].UnitPrice * 21/100 + dbo.[Order Details].UnitPrice AS PconIVA, 
	dbo.[Order Details].Quantity AS Cant,
	(dbo.[Order Details].UnitPrice * 21/100 + dbo.[Order Details].UnitPrice) * dbo.[Order Details].Quantity AS Subtotal
		FROM dbo.Customers
			INNER JOIN  dbo.Orders            
				ON dbo.Customers.CustomerID = dbo.Orders.CustomerID 
			INNER JOIN dbo.[Order Details]    
				ON dbo.Orders.OrderID = dbo.[Order Details].OrderID 
			INNER JOIN dbo.Products        
				ON dbo.[Order Details].ProductID = dbo.Products.ProductID
				WHERE(dbo.Orders.OrderID = 10643) 
					ORDER BY Producto