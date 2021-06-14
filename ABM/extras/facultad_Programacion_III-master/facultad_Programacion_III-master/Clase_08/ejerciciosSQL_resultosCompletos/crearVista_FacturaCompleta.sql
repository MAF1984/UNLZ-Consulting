USE Northwind
GO
CREATE VIEW FacturaCompleta AS
	SELECT Factura.NCli,
		   Factura.Cliente,
		   Factura.NFact,
		   Factura.FFac,
		   Factura.Producto,
		   Factura.Precio,
		   Factura.IVA,
		   Factura.PconIVA,
		   Factura.Cant,
		   Factura.SubTotal,
		   FacturaTotal.Total
		FROM Factura
			INNER JOIN FacturaTotal
				ON Factura.NFact = FacturaTotal.NFact