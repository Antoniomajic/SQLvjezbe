--create database samostan;

--use samostan;

create table samostan(
	naziv varchar(50),
	adresa varchar(100),
	email varchar(100)
);

create table svecenik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table nadredenisvecenik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table posao(
	naziv varchar(50),
	opis varchar(100),
	trajanje int
);

