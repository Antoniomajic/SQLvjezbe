--drop database if exists taksisluzba;

--create database taksisluzba;
--use taksisluzba;

create table vozilo(
	id int not null primary key identity(1,1),
	marka varchar(50) not null
);

create table vozac(
	id int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11),
	vozilo int
);

create table voznja(
	id int not null primary key identity(1,1),
	vozac int not null
);

create table putnik(
	id int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null
);

create table voznja_putnik(
	id int not null primary key identity(1,1),
	putnik int not null,
	voznja int not null,
	trajanje int,
	cijena decimal(18,2)
);

alter table vozac add foreign key (vozilo) references vozilo (id);
alter table voznja_putnik add foreign key (putnik) references putnik (id);
alter table voznja_putnik add foreign key (voznja) references voznja (id);
alter table voznja add foreign key (vozac) references vozac (id);






