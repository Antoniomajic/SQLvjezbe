--create database djecjivrtic;
--use djecjivrtic;

create table vrtic(
	naziv varchar(50),
	adresa varchar(100),
	email varchar(100)
);

create table djete(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	godiste char(4)
);

create table odgajatelj(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	strucnasprema varchar(100)
);

create table skupina(
	maxpolaznika char(2),
	datumpocetka datetime,
	prostorija char(2)
);
