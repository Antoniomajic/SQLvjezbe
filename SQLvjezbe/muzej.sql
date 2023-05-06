--create database muzej;
--use muzej;

create table muzej(
	naziv varchar(50),
	adresa varchar(100),
	email varchar(100)
);

create table izlozba(
	dvorana varchar(50),
	naziv varchar(50),
	datumpocetka datetime
);

create table eksponat(
	naziv varchar(100),
	sifra char(15),
	opis varchar(1000)
);

create table kustos(
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table sponzor(
	ime varchar(50),
	prezime varchar(50),
	email varchar(100)
);

