--create database opg;

--use opg;

create table opg(
	naziv varchar(50),
	iban char(21),
	registriran bit
);

create table sirovina(
	naziv varchar(50),
	vrijemesadnje date,
	trajanjeuzgoja int
);

create table proizvod(
	naziv varchar(50),
	cijena decimal(18,2),
	vrijemezaproizvodnju int
);

create table djelatnik(
	ime varchar(50),
	prezime varchar(50),
	telefon varchar(20)
);


