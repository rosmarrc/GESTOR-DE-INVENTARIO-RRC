create database CapaDeDatosGestor
use CapaDeDatosGestor
CREATE TABLE Usuarios(
ID int identity(1,1) primary key,
Nombre VARCHAR(30),
Apellido VARCHAR(30),
Nom_Usuario VARCHAR(30),
Contrasenia VARCHAR(30),
Tipo VARCHAR(30)
);

CREATE PROC SP_CrearUsuario
@Nombre VARCHAR(30),
@Apellido VARCHAR(30),
@Nom_Usuario VARCHAR(30),
@Contrasenia VARCHAR(30),
@Tipo VARCHAR(30)
as
Insert into Usuarios values(@Nombre, @Apellido , @Nom_Usuario , @Contrasenia, @Tipo)
Go

CREATE TABLE Articulos(
ID int identity(1,1) primary key,
Descripcion VARCHAR(30),
Costo INT,
Precio INT,
Unidades INT
);

