--drop database if exists muzej;

--create database muzej;

--use muzej;

-- create database muzej;

-- use muzej;

create table kustos(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	email varchar(100)
);

create table sponzor(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null
);

create table djelo(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	opis varchar(100),
	izlozba int not null
);

create table izlozba(
	sifra int not null primary key identity(1,1),
	naziv varchar(100),
	sponzor int not null,
	kustos int not null,
	djelo int not null
);

alter table djelo add foreign key (izlozba) references izlozba (sifra); 
alter table izlozba add foreign key (sponzor) references sponzor (sifra);
alter table izlozba add foreign key (kustos) references kustos (sifra);


