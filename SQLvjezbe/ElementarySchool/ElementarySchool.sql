use master;
drop database if exists ElementarySchool;
go
create database ElementarySchool;
go 
use ElementarySchool;

create table child (
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	age char(2)
);

create table workshop(
	id int not null primary key identity(1,1),
	name varchar(50),
	maxChildren varchar(2),
	teacher int
);

create table teacher(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null
);

create table child_workshop(
	id int not null primary key identity(1,1),
	child int,
	workshop int
);


alter table workshop add foreign key (teacher) references teacher (id);
alter table child_workshop add foreign key (child) references child(id);
alter table child_workshop add foreign key (workshop) references workshop(id);


insert into child (firstname,lastname,age)
	values
			('Leon','Porter','8'),
			('Edwin','Kelly','9'),
			('Cayden','Poole','7'),
			('Patrick','Morris','8'),
			('Patricia','Rogers','8'),
			('Agnes','Watson','9');

insert into teacher (firstname,lastname)
	values 
			('Gabrielle','Spencer'),
			('Lia','Simpson'),
			('Mark','Walsh');

insert into workshop (name,maxChildren,teacher)
	values 
			('Profession','5','1'),
			('Basic Math','3','2'),
			('Animals','3','3');

insert into child_workshop (child,workshop)
	values
			('1','1'),
			('1','3'),
			('2','2'),
			('3','1'),
			('4','2'),
			('5','3');

update child set firstname='Cameron' where id=3;
