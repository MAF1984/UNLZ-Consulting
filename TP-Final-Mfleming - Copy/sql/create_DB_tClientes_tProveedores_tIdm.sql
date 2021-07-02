create database UNLZConsultingABM
go

USE [UNLZConsultingABM]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[NCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Apellido] [nvarchar](30) NULL,
	[Documento] [int] NULL DEFAULT ((0)),
	[CUIT] [nvarchar](30) NULL,
	[Domicilio] [nvarchar](50) NULL DEFAULT (''),
	[Postal] [nvarchar](10) NULL DEFAULT ((1900)),
	[Localidad] [nvarchar](10) NULL DEFAULT ('La Plata'),
	[Provincia] [nvarchar](20) NULL DEFAULT ('Bs. As.'),
	[Telefonos] [nvarchar](30) NULL DEFAULT (''),
	[E_Mail] [nvarchar](35) NULL DEFAULT (''),
	[FechaNacimiento] [datetime] NOT NULL DEFAULT (getdate()),
 CONSTRAINT [aaaaaClientes2_PK] PRIMARY KEY NONCLUSTERED 
(
	[NCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Proveedores](
	[NPro] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Apellido] [nvarchar](30) NULL,
	[Documento] [int] NULL DEFAULT ((0)),
	[CUIT] [nvarchar](30) NOT NULL,
	[Domicilio] [nvarchar](50) NULL DEFAULT (''),
	[Postal] [nvarchar](10) NULL DEFAULT ((1900)),
	[Localidad] [nvarchar](10) NULL DEFAULT ('La Plata'),
	[Provincia] [nvarchar](20) NULL DEFAULT ('Bs. As.'),
	[Telefonos] [nvarchar](30) NULL DEFAULT (''),
	[E_Mail] [nvarchar](30) NULL,
	[Fecha] [datetime] NULL DEFAULT (getdate()),
	[Comentarios] [nvarchar](200) NULL DEFAULT (''),
	[Estado] [bit] NULL DEFAULT ((0)),
 CONSTRAINT [aaaaProveedores2_PK] PRIMARY KEY NONCLUSTERED 
(
	[NPro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[idm](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](30) NULL,
	[Clave] [nvarchar](30) NULL,
	[Nombre] [nvarchar](30) NULL,
	[Apellido] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO