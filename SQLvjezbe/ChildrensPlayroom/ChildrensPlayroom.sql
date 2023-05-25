use master;
drop database if exists ChildrensPlayroom;
go
create database ChildrensPlayroom;
go
use ChildrensPlayroom;


create table child(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null
);

create table teacher(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null
);

create table [group](
	id int not null primary key identity(1,1),
	name varchar(20),
	maxChildren varchar(5),
	teacher int
);

create table child_group(
	id int not null primary key identity(1,1),
	child int,
	[group] int
);

alter table [group] add foreign key (teacher) references teacher (id);
alter table child_group add foreign key (child) references child (id);
alter table child_group add foreign key ([group]) references [group] (id);

insert into child (firstname,lastname)
	values
			('Bobby','Ellis'),
			('Harrison','Morris'),
			('Amelie','Williamson'),
			('Lia','Scott');

insert into teacher (firstname,lastname)
	values
			('Carol','Black'),
			('Tiana','Burton');

insert into [group] (name,maxChildren,teacher)
	values 
			('A','10','1'),
			('B','15','2');

update teacher set lastname='Lloyd' where id=1;

