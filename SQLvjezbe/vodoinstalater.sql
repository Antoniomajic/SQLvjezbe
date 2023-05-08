--create database vodoinstalater;
--use vodoinstalater;

create table vodoinstalaterskiobrt(
	iban char(21),
	telefon varchar(20),
	email varchar(100)
);

create table vodoinstalater(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	registriran bit,
);

create table segrt(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table kvar(
	naziv varchar(50),
	opis varchar(200),
	trajanjepopravka int,
	cijenapopravka decimal(18,2)
);

create table popravak(
	broj varchar(50),
	trajanje int, 
	sudjelovanjesegrta bit,
	cijena decimal(18,2),
);

