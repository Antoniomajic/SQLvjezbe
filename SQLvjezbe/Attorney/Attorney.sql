use master;
drop database if exists Attorney;
go
create database Attorney;
go 
use Attorney;

create table client(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null
);

create table [case](
	id int not null primary key identity(1,1),
	codename varchar(50) not null,
	description varchar(100),
	client int not null
);

create table assistant(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null
);

create table assistant_case(
	id int not null primary key identity(1,1),
	assistant int,
	[case] int
);

alter table [case] add foreign key (client) references client (id);
alter table assistant_case add foreign key (assistant) references assistant (id);
alter table assistant_case add foreign key ([case]) references [case] (id);

insert into client (firstname,lastname)
	values 
			('Louis','Riley'),
			('Samouel','Ma'),
			('Isabel','Lawson');

insert into [case] (codename,description,client)
	values
			('KSL-5891/478','Breach of contract','1'),
			('IUK-879/4111','Violation of privacy','3'),
			('KKII/4787/44','Damaged goods','2');

insert into assistant (firstname,lastname)
	values
			('Darcy','Hughes'),
			('Eric','Riley');







