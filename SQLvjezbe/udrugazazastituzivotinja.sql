--create database Udrugazazastituzivotinja;

--use udrugazazastituzivotinja;

create table udruga(
	naziv varchar(100),
	adresa varchar(100),
	email varchar(100)
);

create table djelatnik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table sticenik(
	sifra char(5),
	spol bit,
	dob_mjeseci int
);

create table prostor(
	broj char(3),
	kvadratura varchar(8),
	vrsta varchar(50)
);

