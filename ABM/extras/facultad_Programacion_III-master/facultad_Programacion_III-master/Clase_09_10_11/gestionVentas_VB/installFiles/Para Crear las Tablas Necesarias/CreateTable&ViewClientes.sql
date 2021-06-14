use SISTEMA
go
if exists (select * from dbo.sysobjects where id = object_id(N'[Clientes]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [Clientes]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[NCliente] [int] IDENTITY(1,1) NOT NULL,
	[ApellidoCliente] [nvarchar](30) NULL,
	[NombreCliente] [nvarchar](30) NULL,
	[DocumentoCliente] [int] NULL default 0,
	[CuitCliente] [nvarchar](30) NOT NULl,
	[UsuarioCliente] [nvarchar](10) NOT NULl,
	[ClaveCliente] [nvarchar](10) NOT NULl,
	[DomicilioCliente] [nvarchar](50) NULL default '',
	[PostalCliente] [nvarchar](10) NULL default 1900,
	[LocalidadCliente] [nvarchar](10) NULL default 'Ciudad Autonoma de Bs. As.',
	[ProvinciaCliente] [nvarchar](20) NULL default 'Ciudad Autonoma de Bs. As.',
	[TelefonoCliente] [nvarchar](30) NULL default '',
	[FechaNacimientoCliente] [datetime] NULL default getdate(),
	[ComentariosCliente] [nvarchar](200) NULL default '',
	[EMailCliente] [nvarchar](35) NULL default '',
	[Estado] [bit] NULL default 0,
 CONSTRAINT [Cliente_PK] PRIMARY KEY NONCLUSTERED 
(
	[NCliente] ASC
)
) ON [PRIMARY]

GO
    
    CREATE VIEW [dbo].[ClientesBusqueda]
    AS
    SELECT     TOP (100) PERCENT NCliente, UPPER(LTRIM(ApellidoCliente) + ',  ' + LTRIM(NombreCliente)) AS ApeYNom , CuitCliente AS CUIT
    FROM         dbo.Clientes
    order by UPPER(LTRIM(ApellidoCliente) + ',  ' + LTRIM(NombreCliente))
    GO