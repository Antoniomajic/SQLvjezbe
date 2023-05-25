--create database srednjaskola;
--use srednjaskola;

create table skola(
	naziv varchar(50),
	gimnazija bit,
	adresa varchar(50)
);

create table ucenik(
	ime varchar(50),
	prezime varchar(50),
	godinarodenja char(4),
	spol bit
);

create table profesor(
	ime varchar(50),
	prezime varchar(50),
	certificiran bit
);

create table razred (
	broj int,
	odijeljenje char(2),
	maxucenika int
);



