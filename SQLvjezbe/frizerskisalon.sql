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
	ime varchar(50) not null,
	prezime varchar(50) not null,
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
('Marija', 'Kneževiæ',null),
('Matija', 'Aranðeloviæ',null),
('Ivona', 'Martinoviæ',null);



insert into korisnik (ime,prezime,spol) 
values 
('Marko','Periæ','M'),
('Ivana','Petroviæ','Ž'),
('Silvija','Stankoviæ','Ž');

insert into usluga (naziv,cijena,trajanje)
values
('musko sisanje',7,20), 
('zensko sisanje',10,35), 
('pranje kose',5,15);

insert into termin (datum,usluga,korisnik,djelatnica)
values 
('2023-05-10 10:00:00','1','1','1'),
('2023-05-10 11:00:00','2','2','3'),
('2023-05-10 10:00:00','2','3','2');

