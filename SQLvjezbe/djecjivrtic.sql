use master;
drop database if exists djecjivrtic;
create database djecjivrtic;
use djecjivrtic;

create table djete(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11)
);

create table odgajateljica(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	oib char(11),
	strucnasprema int
);

create table skupina(
	sifra int not null primary key identity(1,1),
	maxpolaznika int,
	datumpocetka datetime,
	odgajateljica int
);

create table strucnasprema(
	sifra int not null primary key identity(1,1),
	naziv varchar(200)
);

create table djete_skupina(
	sifra int not null primary key identity(1,1),
	djete int not null,
	skupina int not null
);

alter table odgajateljica add foreign key (strucnasprema) references strucnasprema (sifra);
alter table skupina add foreign key (odgajateljica) references odgajateljica (sifra);
alter table djete_skupina add foreign key (djete) references djete (sifra);
alter table djete_skupina add foreign key (skupina) references skupina (sifra);


insert into strucnasprema (naziv) values ('Odgojitelj predškolske djece'), ('Pedagog');

insert into odgajateljica (ime,prezime,oib,strucnasprema)
values 
('Ivana','Ivanoviæ',null,'1'),
('Ivona','Ivanovska',null,'1'),
('Filip','Filipoviæ',null,'1'),
('Marta','Joviæ',null,'2');

insert into djete (ime,prezime,oib)
values
('Vedrana','Bešiæ',null),
('Nikola','Bilobrk',null),
('Silvije','Mesariæ',null),
('Božidar','Špiljak',null),
('Stjepan','Kruljac',null),
('Aleksandra','Ðujiæ',null),
('Andrea','Tadiæ',null),
('Gabrijela','Lekiæ',null),
('Ivo','Malenica',null),
('Petra','Kaliniæ',null),
('Igor','Subotiæ',null),
('Janica','Šajiæ',null),
('Mislav','Olujiæ',null);

insert into skupina (maxpolaznika,datumpocetka,odgajateljica)
values 
(10,'2023-05-10 07:00:00','1'),
(10,'2023-05-10 07:00:00','2'),
(10,'2023-05-10 07:00:00','3');

insert into djete_skupina (djete,skupina)
values
('1','1'),('2','1'),('3','1'),('4','1'),
('5','2'),('6','2'),('7','2'),('8','2'),
('9','3'),('10','3'),('11','3'),('12','3'),('13','3');


