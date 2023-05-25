--create database nakladnik;
--use nakladnik;

create table nakladnik(
	naziv varchar(100),
	email varchar(100),
	iban char(21)
);

create table djelo(
	naziv varchar(200),
	sifra char(23),
	autor varchar(100),
	godinaizdanja char(4)
);




