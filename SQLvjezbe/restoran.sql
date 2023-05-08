--create database restoran;
--use restoran;

create table restoran(
	naziv varchar(50),
	adresa varchar(100),
	telefon varchar(20)
);

create table pice(
	naziv varchar(50),
	opis varchar(50),
	cijena decimal(18,2)
);

create table jelo(
	naziv varchar(50),
	opis varchar(100),
	cijena decimal(18,2)
);

create table kategorija(
	naziv varchar(50),
	opis varchar(100)
);

