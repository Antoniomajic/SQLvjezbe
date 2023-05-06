--create database salonzauljepsavanje;
--use salonzauljepsavanje;

create table salon(
	naziv varchar(50),
	adresa varchar(50),
	telefon varchar(50)
);

create table djelatnik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table usluga(
	naziv varchar(50),
	cijena decimal(18,2),
	trajanje int
);

create table korisnik(
	ime varchar(50),
	prezime varchar(50),
	spol bit
);
