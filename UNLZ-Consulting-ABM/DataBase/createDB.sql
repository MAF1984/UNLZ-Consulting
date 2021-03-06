--creacion de base de datos--
create database UNLZConsultingAMB
go
use UNLZConsultingAMB

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--creacion Tabla idm users/pass--
create table Idm 
(
Id int identity (1,1) not null primary key,
Usuario nvarchar (30) null,
Clave nvarchar (30) null,
Nombre nvarchar (30) null, 
Apellido nvarchar (30) null  
)


--creacion de tablas Clientes--
create table clientes 
(
Id int identity (1,1) not null primary key,
Apellido nvarchar (30) null,
Nombre nvarchar (30) null,
Documento nvarchar (50) null default 0,
FechaNacimiento date null default getdate(),
Estado bit null default 0, 
Cuit nvarchar (50) null default 0,
Domicilio nvarchar (50) null default '',
Localidad nvarchar (20) null default 'CABA',
Postal nvarchar (10) null default 1001,
Provincia nvarchar (30) null default 'Buenos Aires',
Telefono nvarchar (30) null default '',
Email nvarchar (35) null default '',
Comentarios nvarchar (200) null default ''
)

--creacion de tablas Proveedores--
create table Proveedores 
(
Id int identity (1,1) not null primary key,
Apellido nvarchar (30) null,
Nombre nvarchar (30) null,
Documento nvarchar (50) null default 0,
Cuit nvarchar (50) null default 0,
Domicilio nvarchar (50) null default '',
CodigoPostal nvarchar (10) null default 1001,
Localidad nvarchar (20) null default 'CABA',
Provincia nvarchar (30) null default 'Buenos Aires',
Telefono nvarchar (30) null default '',
FechaNacimiento date null default getdate(),
Email nvarchar (35) null default '',
Comentarios nvarchar (200) null default '',
Estado bit null default 0,
)


--Inserts en tablas 
---insert de datos en tabla clientes--
insert into idm (Usuario,Clave, Nombre, Apellido) values ('jlgomez','123456','Jorge','Gomez')
insert into idm (Usuario,Clave, Nombre, Apellido) values ('mfleming84','123456','Mariano','Fleming')
go

---insert de datos en tabla clientes--
insert into Clientes (Apellido,Nombre,Documento,Cuit,Domicilio,Postal,Localidad,Provincia,Telefono,FechaNacimiento,Email,Comentarios) values ('Gomez','jorge','32145574','27-32145574-7','Davel 2054','1854','Longchamps','Buenos Aires','42973033','2008-11-11','jgomez@gmail.com','Primer cliente de la aplicacion')
go

---insert de datos en tabla clientes--
insert into Proveedores (Apellido,Nombre,Documento,Cuit,Domicilio,Postal,Localidad,Provincia,Telefono,FechaNacimiento,Email,Comentarios) values ('Gomez','juan','32145574','27-32145574-7','Davel 2054','1854','Longchamps','Buenos Aires','42973033','2008-11-11','jgomez@gmail.com','Primer cliente de la aplicacion')
go


---Stored procedures
---CLIENTES

--SP Select tabla Clientes
create proc ClientesBusqueda
@Id int identity (1,1),
@Apellido nvarchar (30) null,
@Cuit nvarchar (50) null default 0,
as
BEGIN
select TOP 10 COUNT(*) from clientes
WHERE 
go

--SP Insert tabla Clientes 
create proc InsClientes
@Apellido nvarchar(30),
@Nombre nvarchar(30),
@Documento nvarchar(50),
@Cuit nvarchar (50),
@Domicilio nvarchar(50),
@CodigoPostal nvarchar(10),
@Localidad nvarchar(20) ,
@Provincia nvarchar(30),
@Telefono nvarchar(30),
@FechaNacimiento date,
@Email nvarchar (35),
@Comentarios nvarchar(200)

as
insert into Clientes values (@Apellido,@nombre,@Documento,@Cuit,@Domicilio,@CodigoPostal,@Localidad,@Provincia,@Telefono,@FechaNacimiento,@Comentarios,@Email)
go

--SP Delete tabla Clientes
create proc DelClientes
@idclient int
as
delete from Clientes where Id=@idclient
go

--SP Update tabla Clientes 
create proc EditClientes
@Apellido nvarchar(30),
@Nombre nvarchar(30),
@Documento nvarchar(50),
@Cuit nvarchar (50),
@Domicilio nvarchar(50),
@CodigoPostal nvarchar(10),
@Localidad nvarchar(20) ,
@Provincia nvarchar(30),
@Telefono nvarchar(30),
@FechaNacimiento date,
@Email nvarchar (35),
@Comentarios nvarchar(200),
@Id int

as
update Clientes set Apellido=@Apellido Nombre=@nombre Documento=@Documento Cuit=@Cuit Domicilio=@Domicilio CodigoPostal=@CodigoPostal Localidad=@Localidad Provincia=@Provincia Telefono=@Telefono FechaNacimiento=@FechaNacimiento Comentarios=@Comentarios Email=@Email  where Id=@Id
go