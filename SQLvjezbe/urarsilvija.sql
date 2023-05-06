--create database urarsilvija;
--use urarsilvija;

create table obrt(
	naziv varchar(50),
	adresa varchar(100),
	email varchar(100),
	telefon varchar(20),
	iban char(21)
);

create table urar(
	oib char(11),
	certificiran bit,
	pocetakradnogvremena time,
	krajradnogvremena time
);

create table usluga(
	cijena decimal(18,2),
	trajanje int,
	opis varchar(50)
);

create table sat(
	marka varchar(50),
	sifra char(8),
	spol bit
);

create table segrt(
	oib char(11),
	struka varchar(50),
	ime varchar(50),
	prezime varchar(50)
);

