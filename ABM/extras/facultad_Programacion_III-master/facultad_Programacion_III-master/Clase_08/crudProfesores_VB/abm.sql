use abm
go
if exists (select * from dbo.sysobjects where id = object_id(N'[profesores]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [profesores]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Profesores](
	[NProf] [int] IDENTITY(1,1) NOT NULL,
	[ApellidoProf] [nvarchar](30) NULL,
	[NombreProf] [nvarchar](30) NULL,
	[Documento-Prof] [int] NULL default 0,
	[DomicilioProf] [nvarchar](50) NULL default '',
	[PostalProf] [nvarchar](10) NULL default 1900,
	[LocalidadProf] [nvarchar](10) NULL default 'La Plata',
	[ProvinciaProf] [nvarchar](20) NULL default 'Bs. As.',
	[TeléfonosProf] [nvarchar](30) NULL default '',
	[FechaNacimientoProf] [datetime] NULL default getdate(),
	[ComentariosProf] [nvarchar](200) NULL default '',
	[E-Mail-Prof] [nvarchar](35) NULL default '',
	[Estado] [bit] NULL default 0,
 CONSTRAINT [aaaaaProfesores2_PK] PRIMARY KEY NONCLUSTERED 
(
	[NProf] ASC
)
) ON [PRIMARY]

GO
    
    CREATE VIEW [dbo].[Profesores_Búsqueda]
    AS
    SELECT     TOP (100) PERCENT NProf, UPPER(LTRIM(Apellidoprof) + ',  ' + LTRIM(Nombreprof)) AS ApeYNom
    FROM         dbo.Profesores
    order by UPPER(LTRIM(Apellidoprof) + ',  ' + LTRIM(Nombreprof))
    GO