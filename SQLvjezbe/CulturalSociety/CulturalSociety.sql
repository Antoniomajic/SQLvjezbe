use master;
drop database if exists CulturalSociety;
go
create database CulturalSociety collate Croatian_CI_AS;
go 
use CulturalSociety;

create table member(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number char(11)
);

create table performance(
	id int not null primary key identity(1,1),
	name varchar(100)
);

create table city(
	id int not null primary key identity(1,1),
	cityName varchar(50),
	country varchar(50)
);

create table member_performance(
	id int not null primary key identity(1,1),
	member int,
	performance int
);

create table performance_city(
	id int not null primary key identity(1,1),
	performance int,
	city int
);

alter table member_performance add foreign key (member) references member (id);
alter table member_performance add foreign key (performance) references performance (id);
alter table performance_city add foreign key (performance) references performance (id);
alter table performance_city add foreign key (city) references city (id);

insert into member (firstname,lastname,id_number)
	values 
			('Zvonimir','BoŽić','29154674946'),
			('Branimir','Stojanović','50849782101'),
			('Petra','Zorić','32980992260');

insert into performance (name)
	values 
			('Nastup KUD-a');

insert into city (cityName,country)
	values
			('Osijek','Hrvatska'),
			('Pečuh','Mađarska');

update city set country='Mađarska' where id=2;






