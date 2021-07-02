USE [UNLZConsultingABM]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Proveedor_Busqueda]
AS
SELECT        NPro, Nombre
FROM            dbo.Proveedores

GO