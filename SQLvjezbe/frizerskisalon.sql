use master;

drop database if exists frizerskisalon;

create database frizerskisalon;

use frizerskisalon;

create table djelatnica(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11)
);

create table korisnik(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	spol bit not null
);

create table usluga(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	cijena decimal(18,2),
	trajanje int 
);

create table termin(
	sifra int not null primary key identity(1,1),
	datum datetime not null,
	usluga int not null,
	korisnik int not null,
	djelatnica int not null
);

alter table termin add foreign key (usluga) references usluga (sifra);
alter table termin add foreign key (djelatnica) references djelatnica (sifra);
alter table termin add foreign key (korisnik) references korisnik (sifra);
