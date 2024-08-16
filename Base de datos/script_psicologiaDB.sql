/* Creacion de la base de datos si es que no existe */
create database if not exists psicologiaDB;
/* usa la base de datos */
use psicologiaDB;

/* Tablas de la base de datos */

create table pacientes(
	Matricula char(11) not null,
    Nombre varchar(40) not null,
    Apellidos varchar(40) not null,
    Telefono varchar(13) not null,
    Edad integer not null,
    Sexo varchar(25),
    OrientacionSexual varchar(25),
    primary key(Matricula)
);

create table historialPaciente(
	NumeroHistorial integer not null unique auto_increment,
    Matricula char(11) not null,
    Fecha timestamp default current_timestamp not null,
    UsoMedicamentos char(2) not null,
    Medicamentos varchar(500) not null,
    EstadoAnimo varchar(500) not null,
    primary key(NumeroHistorial),
    foreign key(Matricula)
    references psicologiadb.Pacientes(Matricula)
);

create table signosZodiacales(
	NumeroRegistro integer not null unique auto_increment,
    Matricula char(11) not null,
    Mes varchar(25) not null,
    Dia integer not null,
    Signo varchar(25) not null,
    Elemento varchar(15) not null,
    Planeta varchar(25) not null,
    PosiblesProblemas varchar(50) not null,
    Personalidad varchar(1000) not null,
	primary key(NumeroRegistro),
    foreign key(Matricula)
    references psicologiadb.Pacientes(Matricula)
);

CREATE TABLE Alimentacion (
	NumeroRegistro	integer not null auto_increment,
	Matricula	char(11) not null,
    Rayasico	varchar(4) not null,
    Tamasico	varchar(4) not null,
	Satvico	varchar(4) not null,
	Descripcion varchar(1000) not null,
    primary key(NumeroRegistro),
	foreign key(Matricula) references Pacientes(Matricula)
);

CREATE TABLE Temperamentos (
	NumeroRegistro integer not null auto_increment,
	Matricula	char(11) not null,
    Sanguineo varchar(4) not null,
	Melancolico varchar(4) not null,
	Colerico varchar(4) not null,
	Flematico	varchar(4) not null,
	Descripcion varchar(1000) not null,	
	primary key(NumeroRegistro),
	foreign key(Matricula) references Pacientes(Matricula)
);


CREATE TABLE Usuarios (
	usuario	varchar(25) not null unique,
	Nombre	varchar(30) not null,
	Apellidos varchar(35) not null,
	Telefono varchar(13) not null unique,
	Passwor varchar(16) not null,
	PRIMARY KEY(usuario)
);

create table bitacora(
idRegistro integer not null auto_increment,
usuario varchar(25) not null,
tabla varchar (50)not null,
evento varchar(50) not null,
fecha timestamp default current_timestamp not null,
primary key (idRegistro),
foreign key (usuario) references usuarios(usuario)
);
/* Creacion del usuario administrador para la base de datos */
insert into Usuarios values('Administrador','Root','Administrador','8772026795','2193S9938');

/*
SELECT idRegistro,Usuario, tabla, evento, fecha FROM bitacora INNER JOIN usuarios 
ON bitacora.idUsuario = usuarios.idUsuario;
*/