drop database if exists Proyecto;
create database Proyecto;
use Proyecto;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(1,'Ana','123456',120);

create table cliente(
IDCliente int PRIMARY KEY not null,
Nombre varchar(30) not null,
Apellido varchar(40) not null,
FechaNacimiento date not null,
DNI int not null unique,
Genero ENUM('F','M','Prefiero no decir') not null,
Direccion varchar(60) not null,
Telefono varchar(30) not null,
FechaInscripcion date not null,
AptoFisico ENUM('Sí','No') not null,
Socio ENUM('Sí','No') not null
);