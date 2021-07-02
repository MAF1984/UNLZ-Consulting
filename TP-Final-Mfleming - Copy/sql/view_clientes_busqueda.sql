USE [UNLZConsultingABM]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Clientes_Busqueda]
AS
SELECT        NCliente, UPPER(LTRIM(Nombre)) AS ApeyNom
FROM            dbo.Clientes

GO
