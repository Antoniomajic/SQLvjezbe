use master;
drop database if exists udrugazazastituzivotinja;
create database udrugazazastituzivotinja;
use udrugazazastituzivotinja;

create table osoba(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
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

insert into osoba (ime,prezime,oib)
values
('Mario','Mariæ',null),
('Marko','Markiæ',null),
('Marijan','Marijanoviæ',null),
('Martin','Martinoviæ',null),
('Matija','Matijeviæ',null);

insert into prostor (broj,kvadratura)
values 
(101,4),
(102,4),
(103,4),
(104,4),
(105,4);

insert into sticenik (prostor,osoba)
values 
('1','1'),
('2','2'),
('3','3'),
('4','4'),
('5','5');
