--create database trgovackicentar;
--use trgovackicentar;

create table trgovackicentar(
	naziv varchar(50),
	adresa varchar(50),
	email varchar(100)
);

create table trgovina(
	naziv varchar(50),
	iban char(21),
	opis varchar(100)
);

create table osoba(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table seftrgovine(
	telefon varchar(20),
	email varchar(100)
);

create table djelatniktrgovine(
	telefon varchar(20),
	email varchar(20)
);
