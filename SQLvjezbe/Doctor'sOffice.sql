use master;
drop database if exists doktorskaordinacija;
create database doktorskaordinacija;
use doktorskaordinacija;

create table pacijent(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11)
	);

create table terapija(
	sifra int not null primary key identity(1,1),
	naziv varchar(100),
	opis varchar(300)
);

create table terapija_pacijenta(
	sifra int not null primary key identity(1,1),
	pacijent int not null,
	terapija int
);

create table medicinska_sestra(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11),
	terapija int
);

alter table medicinska_sestra add foreign key (terapija) references terapija (sifra);
alter table terapija_pacijenta add foreign key (pacijent) references pacijent (sifra);
alter table terapija_pacijenta add foreign key (terapija) references terapija (sifra);

