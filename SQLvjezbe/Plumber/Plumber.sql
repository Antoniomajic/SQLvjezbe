use master;
drop database if exists Plumber;
create database Plumber;
go
use Plumber;

create table failure(
	id int not null primary key identity(1,1),
	name varchar(50),
	description varchar(50)
);

create table repair(
	id int not null primary key identity(1,1),
	description varchar(50),
	price decimal(18,2)
);

create table apprentice(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50)
);

create table appointment(
	id int not null primary key identity(1,1),
	date datetime, 
	repair int,
	failure int,
	apprentice int
);

alter table appointment add foreign key (repair) references repair (id);
alter table appointment add foreign key (failure) references failure (id);
alter table appointment add foreign key (apprentice) references apprentice (id);

insert into repair (description,price)
	values 
			('Leakage','50');

insert into failure (name,description)
	values
			('Rusty pipe','Rust deteriorated pipe quality');

insert into apprentice (firstname,lastname)
	values
			('John','Sterling');


