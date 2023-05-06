--create database frizerskisalon;
--use frizerskisalon;

create table salon(
	naziv varchar(50),
	adresa varchar(100),
	telefon varchar(100)
);

create table djelatnik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table usluga(
	cijena decimal(18,2),
	naziv varchar(50),
	trajanje int
);

create table korisnik(
	ime varchar(50),
	prezime varchar(50),
	spol bit
);