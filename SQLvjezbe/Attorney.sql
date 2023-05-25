--create database odvjetnik;

--use odvjetnik;

create table odvjetnickiured(
	naziv varchar(50),
	telefon varchar(20),
	iban char(21),
	registriran bit,
	adresa varchar(100),
	email varchar(100)
);

create table odvjetnik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	licenciran bit
);

create table surdanik(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	licenciran bit
);

create table klijent(
	ime varchar(50),
	prezime varchar(50),
	oib char(11),
	email varchar(100)
);

create table slucaj(
	broj varchar(100),
	utijeku bit,
	opis varchar(200)
);



