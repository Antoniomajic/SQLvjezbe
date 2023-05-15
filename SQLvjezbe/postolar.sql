use master;
drop database if exists postolar;
create database postolar;
use postolar;

create table korisnik(
	id int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	telefon varchar(20)
);

create table obuca(
	id int not null primary key identity(1,1),
	marka varchar(50),
	broj char(2),
	korisnik int
);

create table popravak(
	id int not null primary key identity(1,1),
	segrt int,
	trajanje int,
	cijena decimal(18,2),
	opis varchar(100)
);

create table popravak_obuca(
	id int not null primary key identity(1,1),
	obuca int,
	popravak int
);

create table segrt(
	id int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

alter table obuca add foreign key (korisnik) references korisnik (id);
alter table popravak add foreign key (segrt) references segrt (id);
alter table popravak_obuca add foreign key (obuca) references obuca (id);
alter table popravak_obuca add foreign key (popravak) references popravak (id);




