create database samouprava;

use samouprava;

create table zupanija(
	sifra int not null primary key identity(1,1),
	naziv varchar(100) not null,
	zupan int
);

create table zupan(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50)
);

create table opcina(
	sifra int not null primary key identity(1,1),
	zupanija int not null,
	naziv varchar(50) not null
);

create table mjesto(
	sifra int not null primary key identity(1,1),
	opcina int not null,
	naziv varchar(50)
);

alter table zupanija add foreign key (zupan) references zupan (sifra);
alter table mjesto add foreign key (opcina) references opcina (sifra);
alter table opcina add foreign key (zupanija) references zupanija (sifra);
