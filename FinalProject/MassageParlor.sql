use master;
drop database if exists MassageParlor;
go
create database MassageParlor collate Croatian_CI_AS;
go
use MassageParlor;

create table customer(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	contact varchar(50)
);

create table massage(
	id int not null primary key identity(1,1),
	name varchar(50),
	description varchar(100),
	duration int,
	price decimal(18,2)
);

create table appointment(
	id int not null primary key identity(1,1),
	dateAndTime datetime,
	customer int
);

create table appointment_massage(
	id int not null primary key identity(1,1),
	appointment int,
	massage int,
	quantity int
);


alter table appointment_massage add foreign key (appointment) references appointment (id);
alter table appointment_massage add foreign key (massage) references massage (id);
alter table appointment add foreign key (customer) references customer (id);


insert into customer (firstname,lastname,contact)
	values 
			('Domagoj','Krizmaniæ','0972254785'),
			('Josipa','Lisica','031/105-454'),
			('Tihomir','Šimunković','tihomir.simunkovic@gmail.com');

insert into massage (name,description,duration,price)
	values
			('Masaža ruku','Dubinska masaža obje ruke, masaža dlanova i šake, nadlaktice i podlaktice','10','5'),
			('Masaža lica','Dubinska masaža lica sa eteričnim uljima','20','7'),
			('Masaža leđa','Dubinska masaža leđa uključujući vrat i ramena','30','10');

insert into appointment (dateAndTime,customer)
	values
			('2023-05-31 10:00:00','1'),
			('2023-05-31 11:00:00','2'),
			('2023-05-31 12:00:00','3');

insert into appointment_massage (appointment,massage,quantity)
	values
			('1','1','2'),
			('2','3','1'),
			('3','2','1');