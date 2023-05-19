use master;
drop database if exists TaxiService;
create database TaxiService collate Croatian_CI_AS;
go
use TaxiService;

create table vehicle(
	id int not null primary key identity(1,1),
	brand varchar(50) not null,
	registration varchar (50),
	max_passengers int
);

create table driver(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number varchar(11),
	vehicle int not null
);

create table [service](
	id int not null primary key identity(1,1),
	driver int not null
);

create table passenger(
	id int not null primary key identity(1,1),
	phonenumber varchar (50) not null
);

create table passenger_service(
	id int not null primary key identity(1,1),
	passenger int not null,
	[service] int not null,
	duration int,
	price decimal (18,2)
);

--RELATIONS
alter table driver add foreign key (vehicle) references vehicle(id);
alter table passenger_service add foreign key (passenger) references passenger(id);
alter table passenger_service add foreign key ([service]) references [service](id);
alter table [service] add foreign key (driver) references driver(id);

--INSERTS
insert into vehicle (brand,registration,max_passengers)
	values 
			('Audi A3','OS-457-SL','3'),
			('Škoda Octavia','ZG-364-RT','4'),
			('Renault Trafic','DJ-7888-PM','7');

insert into driver (firstname,lastname,id_number,vehicle)
	values 
			('Ante','Dujmiæ','05761983764','1'),
			('Domagoj','Perèiæ','35789145728','2'),
			('Vanja','Èasniæ','65748957810','3');

insert into passenger (phonenumber) 
	values
			('09758614785'),
			('09863585585'),
			('09148854122'),
			('09147833256'),
			('+3877849986'),
			('09754877786');

insert into [service] (driver)
	values
			('1'),
			('2'),
			('3');

insert into passenger_service (passenger,[service],duration,price)
	values
			('1','1','50','5');

