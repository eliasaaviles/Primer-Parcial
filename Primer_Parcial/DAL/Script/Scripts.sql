
create database Primer_ParcialDB
use PrimerParcialDB
      

go



create table GrupoEstudiantes
(
 GrupoID int  primary key identity (1,1),
 Nombre varchar (20),
Cantidad int,
 Grupos int,
 Integrantes int
);

