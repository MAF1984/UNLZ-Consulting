use SISTEMA
go
if exists (select * from dbo.sysobjects where id = object_id(N'[Proveedores]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [Proveedores]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[NProveedor] [int] IDENTITY(1,1) NOT NULL,
	[ApellidoProveedor] [nvarchar](30) NULL,
	[NombreProveedor] [nvarchar](30) NULL,
	[DocumentoProveedor] [int] NULL default 0,
	[CuitProveedor] [nvarchar](30) NOT NULl,
	[DomicilioProveedor] [nvarchar](50) NULL default '',
	[PostalProveedor] [nvarchar](10) NULL default 1900,
	[LocalidadProveedor] [nvarchar](10) NULL default 'Ciudad Autonoma de Bs. As.',
	[ProvinciaProveedor] [nvarchar](20) NULL default 'Ciudad Autonoma de Bs. As.',
	[TelefonoProveedor] [nvarchar](30) NULL default '',
	[FechaNacimientoProveedor] [datetime] NULL default getdate(),
	[ComentariosProveedor] [nvarchar](200) NULL default '',
	[EMailProveedor] [nvarchar](35) NULL default '',
	[Estado] [bit] NULL default 0,
 CONSTRAINT [Proveedor_PK] PRIMARY KEY NONCLUSTERED 
(
	[NProveedor] ASC
)
) ON [PRIMARY]

GO
    
    CREATE VIEW [dbo].[ProveedoresBusqueda]
    AS
    SELECT     TOP (100) PERCENT NProveedor, UPPER(LTRIM(ApellidoProveedor) + ',  ' + LTRIM(NombreProveedor)) AS ApeYNom, CuitProveedor AS CUIT
    FROM         dbo.Proveedores
    order by UPPER(LTRIM(ApellidoProveedor) + ',  ' + LTRIM(NombreProveedor))
    GO