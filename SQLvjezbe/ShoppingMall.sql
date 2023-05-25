use master;
drop database if exists ShoppingMall;
go
create database ShoppingMall;
go
use ShoppingMall;

create table store(
	id int not null primary key identity(1,1),
	name varchar(50) not null,
	opens time,
	closes time
);

create table employee(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null
);

create table store_employee(
	id int not null primary key identity(1,1),
	store int,
	employee int 
);

create table boss(
	id int not null primary key identity(1,1),
	employee int,
	store int
);

alter table store_employee add foreign key (store) references store (id);
alter table store_employee add foreign key (employee) references employee(id);
alter table boss add foreign key (employee) references employee(id);
alter table boss add foreign key (store) references store (id);

insert into employee (firstname,lastname)
	values
			('Mark','Collins'),
			('Jason','Palmer'),
			('Ewan','Watson'),
			('Anna','Brooks');

insert into store (name,opens,closes)
	values
			('Adidas','09:00:00','21:00:00'),
			('Deichman','08:00:00','20:00:00'),
			('H&M','07:00:00','22:00:00');

