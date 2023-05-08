--create database osnovnaskola;
--use osnovnaskola;

create table skola(
	naziv varchar(50),
	adresa varchar(100),
	certificiran bit
);

create table djete(
	dob int,
	ime varchar(50),
	prezime varchar(50)
);

create table uciteljica(
	ime varchar(50),
	prezime varchar(50),
	predmet varchar(50)
);

create table radionica(
	naziv varchar(50),
	brojucionice char(3),
	opis varchar(100)
);
