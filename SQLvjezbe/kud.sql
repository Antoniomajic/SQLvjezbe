--create database kud;
--use kud;

create table kulturnoumjetnickodrustvo(
	naziv varchar(100),
	adresa varchar(100),
	email varchar(100)
);

create table nastup(
	zemlja varchar(100),
	mjesto varchar(100),
	opis varchar(200),
	trajanje int
);

create table clan(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	spol bit
);

