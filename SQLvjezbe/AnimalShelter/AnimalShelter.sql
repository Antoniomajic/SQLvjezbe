use master;
drop database if exists AnimalShelter;
go
create database AnimalShelter collate Croatian_CI_AS;
go
use AnimalShelter;

create table person(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number char(11)
);

create table animal(
	id int not null primary key identity(1,1),
	cage int not null,
	person int not null
);

create table cage(
	id int not null primary key identity(1,1),
	number char(3),
	dimensions varchar(50)
);

alter table animal add foreign key (person) references person (id);
alter table animal add foreign key (cage) references cage (id);

insert into person (firstname,lastname,id_number)
values
('Mario','Marić',null),
('Marko','Markić',null),
('Marijan','Marijanović',null),
('Martin','Martinović',null),
('Matija','Matijević',null);

insert into cage (number,dimensions)
values 
(101,4),
(102,4),
(103,4),
(104,4),
(105,4);

insert into animal (cage,person)
values 
('1','1'),
('2','2'),
('3','3'),
('4','4'),
('5','5');
