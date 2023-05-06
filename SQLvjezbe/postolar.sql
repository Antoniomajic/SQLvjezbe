--create database postolar;

--use postolar;

create table obrt(
	naziv varchar(50),
	oib char(11),
	iban char(21)
);

create table postolar(
	oib char(11),
	radnovrijeme int,
	certificiran bit
);

create table obuca(
	marka varchar(50),
	spol bit,
	sifra char(8)
);

create table korisnik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table popravak(
	trajanje int,
	cijena decimal (18,2),
	opis varchar(100)
);

create table segrt(
	ime varchar(50),
	prezime varchar (50),
	struka varchar(50)
);

