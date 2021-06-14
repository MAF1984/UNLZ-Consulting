USE [Northwind]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[Factura]
AS
SELECT  TOP (100) PERCENT dbo.Customers.ID AS NCli,
            dbo.Customers.CompanyName AS Cliente,
            dbo.Orders.OrderID AS NFact,
            dbo.Orders.OrderDate AS FFac,
            dbo.[Order Details].UnitPrice AS Precio,
            dbo.[Order Details].UnitPrice * 21 / 100 AS IVA,
            dbo.[Order Details].UnitPrice * 21 / 100 + dbo.[Order Details].UnitPrice AS PconIVA,
            dbo.[Order Details].Quantity AS Cant,
            (dbo.[Order Details].UnitPrice * 21 / 100 + dbo.[Order Details].UnitPrice) * dbo.[Order Details].Quantity AS SubTotal,
            dbo.Products.ProductName AS Producto
    FROM
        dbo.Customers
        INNER JOIN dbo.Orders
            ON dbo.Customers.ID = dbo.Orders.ID
        INNER JOIN dbo.[Order Details]
            ON dbo.Orders.OrderID = dbo.[Order Details].OrderID
        INNER JOIN dbo.Products
            ON dbo.[Order Details].ProductID = dbo.Products.ProductID

GO


