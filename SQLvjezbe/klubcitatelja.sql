--create database klubcitatelja;

--use klubcitatelja;

create table klub(
	facebookgrupa varchar(200),
);

create table citatelj(
	ime varchar(50),
	prezime varchar(50),
	email varchar(100)
);

create table knjiga(
	naziv varchar(200),
	sifra varchar(20),
	izdanje int,
	dostupnost bit
);

create table vlasnikknjige(
	sifra char(4)
);
