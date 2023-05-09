--use  frizerskisalon;

create table djelatnica(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table korisnik(
	sifra int not null primary key identity(1,1),
	duzinakose int not null,
	usluga int,
	spol int not null
);

create table usluga(
	sifra int not null primary key identity(1,1),
	naziv varchar(50),
	cijena decimal(18,2)
);


create table termin(
	sifra int not null primary key identity(1,1),
	datum datetime not null,
	usluga int not null,
	korisnik int not null,
	djelatnica int
);


alter table termin add foreign key (usluga) references usluga (sifra);
alter table termin add foreign key (djelatnica) references djelatnica (sifra);
alter table termin add foreign key (korisnik) references korisnik (sifra);
