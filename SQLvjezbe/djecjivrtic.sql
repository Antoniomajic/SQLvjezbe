use master;

drop database if exists djecjivrtic;

create database djecjivrtic;

use djecjivrtic;

create table djete(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11),
	skupina int
);

create table odgajateljica(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11),
	strucnasprema int
);

create table skupina(
	sifra int not null primary key identity(1,1),
	maxpolaznika int,
	datumpocetka datetime,
	odgajateljica int,
	djete int
);

create table strucnasprema(
	sifra int not null primary key identity(1,1),
	naziv varchar(200)
);

alter table odgajateljica add foreign key (strucnasprema) references strucnasprema (sifra);
alter table djete add foreign key (skupina) references skupina (sifra);
alter table skupina add foreign key (odgajateljica) references odgajateljica (sifra);