--create database udrugazazastituzivotinja;

use udrugazazastituzivotinja;

create table osoba(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	oib char(11)
);

create table sticenik(
	sifra int not null primary key identity(1,1),
	prostor int not null,
	osoba int not null
);

create table prostor(
	sifra int not null primary key identity(1,1),
	broj char(3),
	kvadratura varchar(8)
);

alter table sticenik add foreign key (osoba) references osoba (sifra);
alter table sticenik add foreign key (prostor) references prostor (sifra);

