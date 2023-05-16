use master;
drop database if exists salonzauljepsavanje;

create database salonzauljepsavanje;

use salonzauljepsavanje;

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
	spol varchar(10) not null
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

insert into djelatnica (ime,prezime,oib) 
values 
('Matko','Valentiæ',null),
('Silvana','Pintariæ',null),
('Lorenc','Maroški',null);

insert into  korisnik (ime,prezime,spol)
values
('Matko','Valentiæ','M'),
('Silvana','Pintariæ','Ž'),
('Lorenc','Maroški','M');

insert into  usluga (naziv,cijena,trajanje)
values
('Pedikura','10','20'),
('Maska za lice','10','30'),
('Umjetni nokti','20','60');

insert into termin (datum,usluga,korisnik,djelatnica) 
values 
('2023-05-11 9:00:00',1,2,3),
('2023-05-11 10:00:00',3,1,2),
('2023-05-11 11:00:00',2,3,1);
