USE [Sistema]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Usuarios_Busqueda]
AS
SELECT        NUsuario, Nombre, Contraseņa
FROM            dbo.Usuarios

GO