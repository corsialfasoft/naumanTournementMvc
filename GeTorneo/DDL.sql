create database GeTorneo;
use GeTorneo;
create table Ruoli(
	idRuolo int identity(1,1) not null primary key,
	Nome varchar(20)
);

create table Attributi(
	idAttributo int identity(1,1) not null primary key,
	Forza int,
	Difesa int,
	Armatura int,
	HP int,
	PExpt int
);

create table Personaggi(
	idPersonaggio int identity(1,1) not null primary key,
	Nome varchar(20),
	Descrizione nvarchar(200),
	fkAttributo int foreign key references Attributi
);

create table Utenti(
	idUtente int identity(1,1) not null primary key,
	Nome varchar(20),
	Cognome varchar(20),
	Useri nvarchar(20),
	Passwd nvarchar(20),
	fkRuolo int foreign key references Ruoli,
	fkPersonaggio int foreign key references Personaggi
);

create table Tornei(
	idTorneo int identity(1,1) not null primary key,
	Nome varchar(20),
	Durata int,
	Num_Max int,
	Regolamento nvarchar(200),
	Premio int,
	Descrizione nvarchar(200)
);

create table Iscrizioni(
	idIscrizione int identity(1,1) not null primary key,
	fkTorneo int foreign key references Tornei,
	fkUtente int foreign key references Utenti
);

drop table Personaggi;
drop table Attributi;
drop table Utenti;
drop table Tornei;
drop table Iscrizioni;
drop table Ruoli;

INSERT INTO Ruoli(Nome) VALUES('Amministratore');
INSERT INTO Ruoli(Nome) VALUES('Partecipante');
INSERT INTO Ruoli(Nome) VALUES('Arbitro');
INSERT INTO Attributi(Forza,Difesa,Armatura,HP,PExpt) VALUES(40,5,40,50,0);
INSERT INTO Attributi(Forza,Difesa,Armatura,HP,PExpt) VALUES(20,18,50,72,0);
INSERT INTO Attributi(Forza,Difesa,Armatura,HP,PExpt) VALUES(10,30,80,88,0);
INSERT INTO Personaggi(Nome,Descrizione,fkAttributo) VALUES('Teutone','Il grandissimo teutone',1);
INSERT INTO Personaggi(Nome,Descrizione,fkAttributo) VALUES('Romano','Il grandissimo romano',2);
INSERT INTO Personaggi(Nome,Descrizione,fkAttributo) VALUES('Gallo','Il grandissimo gallo',3);