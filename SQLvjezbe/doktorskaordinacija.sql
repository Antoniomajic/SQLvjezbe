--create database doktorskaordinacija;

--use doktorskaordinacija;

create table ordinacija(
	adresa varchar(100),
	telefon varchar(50),
	iban char(21)
);

create table doktor(
	oib char(11),
	licenca bit,
	specijalizacija varchar(100)
);

create table pacijent(
	oib char(11),
	mbo char(9),
	dopunsko bit
	);

create table medicinskasestra(
		oib char(11),
		licenca bit,
		kodnibroj char(2)
	);

