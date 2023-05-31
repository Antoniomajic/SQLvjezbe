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

