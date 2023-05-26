use master;
drop database if exists SelfGovernment;
go
create database SelfGovernment;
go
use SelfGovernment;


create table county(
	id int not null primary key identity(1,1),
	name varchar(100) not null,
	district_mayor int
);

create table district_mayor(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50)
);

create table municipality(
	id int not null primary key identity(1,1),
	county int not null,
	name varchar(50) not null
);

create table town(
	id int not null primary key identity(1,1),
	municipality int not null,
	name varchar(50)
);

alter table county add foreign key (district_mayor) references district_mayor (id);
alter table town add foreign key (municipality) references municipality (id);
alter table municipality add foreign key (county) references county (id);
