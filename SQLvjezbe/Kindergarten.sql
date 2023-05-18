use master;
drop database if exists Kindergarten;
go
create database Kindergarten collate Croatian_CI_AS;
go
use Kindergarten;

create table child(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null
);

create table qualification(
	id int not null primary key identity(1,1),
	name varchar(200)
);

create table teacher(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	qualification int 
);

create table [group](
	id int not null primary key identity(1,1),
	max_children int,
	date_of_start datetime,
	teacher int
);


create table child_group(
	id int not null primary key identity(1,1),
	child int not null,
	[group] int not null
);

alter table teacher add foreign key (qualification) references qualification (id);
alter table child_group add foreign key (child) references child (id);
alter table child_group add foreign key ([group]) references [group] (id);
alter table [group] add foreign key (teacher) references teacher (id);

insert into qualification (name)
	values 
			('Kindergarten Teacher'),
			('Pedagogue')


insert into teacher (firstname,lastname,qualification) 
	values
			('Elizabeta','Majcen','1'),
			('Bla�enka','Stojkovi�','1'),
			('�eljka','Fi�ter','2');

insert into child (firstname,lastname)
	values
			('�ime','Josipovi�'),
			('David','Matija�evi�'),
			('Ilija','Kramer'),
			('Josipa','Jakovi�'),
			('�arko','Volarev'),
			('Viktorija','�eni�'),
			('Dra�enka','Kozul'),
			('Nikola','Katavi�'),
			('Branko','Ili�'),
			('Lucija','Krizmani�'),
			('Aleksandar','Bubi�'),
			('Oliver','Lovren�i�'),
			('Ivana','Repar');

insert into [group] (max_children,date_of_start,teacher)
	values
			(10,'2023-01-05 07:00:00',1),
			(10,'2023-01-05 07:00:00',2),
			(10,'2023-01-05 07:00:00',3);

insert into child_group (child,[group])
	values	
			(1,1),
			(2,1),
			(3,1),
			(4,1),
			(5,1),
			(6,2),
			(7,2),
			(8,2),
			(9,2),
			(10,3),
			(11,3),
			(12,3),
			(13,3);

update qualification set name='Assistant Kindergarten Teacher' where id=2;