use master;
drop database if exists Kindergarten;
go
create database Kindergarten;
go
use Kindergarten;

create table child(
	id int not null primary key identity(1,1),
	date_of_birth datetime not null,
	parent_phone_number varchar(20),
	person int not null
);

create table teacher(
	id int not null primary key identity(1,1),
	qualification int,
	phone_number varchar (20),
	person int not null
);

create table person(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number char(11)
);

create table [group](
	id int not null primary key identity(1,1),
	max_children int,
	date_of_start datetime,
	teacher int
);

create table qualification(
	id int not null primary key identity(1,1),
	name varchar(200)
);

create table child_group(
	id int not null primary key identity(1,1),
	child int not null,
	[group] int not null
);

alter table teacher add foreign key (person) references person (id);
alter table child add foreign key (person) references person (id);
alter table teacher add foreign key (qualification) references qualification (id);
alter table child_group add foreign key (child) references child (id);
alter table child_group add foreign key ([group]) references [group] (id);
alter table [group] add foreign key (teacher) references teacher (id);


