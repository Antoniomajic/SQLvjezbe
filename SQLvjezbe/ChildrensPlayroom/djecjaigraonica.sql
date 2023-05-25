--create database djecjaigraonica;

--use djecjaigraonica;

create table igraonica(
	adresa varchar(100),
	naziv varchar(50),
	iban char(21),
	email varchar(100),
	pocetakradnogvremena time,
	krajradnogvremena time
);

create table djete(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	godinarodenja char(4),
	spol bit
);

create table skupina(
	broj int,
	maksimalnodjece int,
	dob int
);

create table teta(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	telefon varchar(20)
);


