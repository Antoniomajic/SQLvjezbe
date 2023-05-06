--create database taksisluzba;
--use taksisluzba;

create table tvrtka(
	naziv varchar(50),
	adresa varchar(100),
	telefon varchar(20)
);

create table vozilo(
	marka varchar(20),
	godiste char(4),
	operativan bit
);

create table vozac(
	ime varchar(50),
	prezime varchar(50),
	telefon varchar(20),
);

create table voznja(
	cijena decimal(18,2),
	trajanje int,
	kilometraza decimal (4,2)
);

create table putnik(
	oib char(11),
	polaziste varchar(100),
	destinacija varchar(100)
);
