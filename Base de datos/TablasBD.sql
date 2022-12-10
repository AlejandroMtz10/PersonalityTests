Create database PsicologiaDB;

Use PsicologiaDB;

CREATE TABLE Pacientes (
	Matricula	char(11) NOT NULL UNIQUE,
	Nombre	VARCHAR(40) NOT NULL,
	Apellidos	VARCHAR(40) NOT NULL,
	Telefono	VARCHAR(13) NOT NULL,
	Edad	INTEGER NOT NULL,
	PRIMARY KEY(Matricula)
);

CREATE TABLE HistorialPaciente (
	NumeroHistorial	INTEGER NOT NULL UNIQUE ,
	Matricula char(11) NOT NULL UNIQUE,
	Fecha date not null,
	UsoMedicamentos varchar(2) NOT NULL,
	Antecedentes varchar(1000),
	PRIMARY KEY(NumeroHistorial),
	FOREIGN KEY(Matricula) REFERENCES Pacientes(Matricula)
);

CREATE TABLE SignosZodiacales(
	NumeroRegistro INTEGER NOT NULL UNIQUE,
	Signo	varchar(25) NOT NULL,
	Elemento	varchar(15) NOT NULL,
	Planeta	varchar(25) NOT NULL,
	Descripcion varchar (100) NOT NULL,
	Matricula char(11) NOT NULL UNIQUE,
	PRIMARY KEY(NumeroRegistro),
	FOREIGN KEY(Matricula) REFERENCES Pacientes(Matricula)
);

CREATE TABLE Alimentacion (
	NumeroRegistro	INTEGER NOT NULL UNIQUE,
	Rayasico	varchar(4) NOT NULL,
	Tamasico	varchar(4) NOT NULL,
	Satvico	varchar(4) NOT NULL,
	Descripcion varchar(1000) NOT NULL,
	Matricula	char(11) NOT NULL UNIQUE,
	FOREIGN KEY(Matricula) REFERENCES Pacientes(Matricula),
	PRIMARY KEY(NumeroRegistro)
);

CREATE TABLE Temperamentos (
	NumeroRegistro INTEGER NOT NULL UNIQUE,
	Sanguineo varchar(4) NOT NULL,
	Melancolico varchar(4) NOT NULL,
	Colerico varchar(4) NOT NULL,
	Flematico	varchar(4) NOT NULL,
	Descripcion varchar(1000) NOT NULL,
	Matricula	char(11) NOT NULL UNIQUE,
	FOREIGN KEY(Matricula) REFERENCES Pacientes(Matricula),
	PRIMARY KEY(NumeroRegistro)
);


CREATE TABLE Usuarios (
	IdUsuario	INTEGER NOT NULL UNIQUE,
	Nombre	varchar(30) NOT NULL,
	Apellidos varchar(35) NOT NULL,
	Telefono varchar(13) NOT NULL UNIQUE,
	Usuario varchar(25) NOT NULL UNIQUE,
	Passwor varchar(16) NOT NULL,
	PRIMARY KEY(IdUsuario)
);

insert into Usuarios values(1,'Administrador','Root','8771187598','Administrador','2193S9938');