use master;
drop database if exists WatchmakerSilvija;
create database WatchmakerSilvija collate Croatian_CI_AS;
go
use WatchmakerSilvija;

create table customer(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50),
	phone_number varchar(20)
);

create table watch(
	id int not null primary key identity(1,1),
	brand varchar(50),
	customer int
);

create table [service](
	id int not null primary key identity(1,1),
	name varchar(50),
	duration int,
	price decimal(18,2),
	description varchar(100)
);

create table service_watch(
	id int not null primary key identity(1,1),
	watch int,
	apprentice int,
	[service] int
);

create table apprentice(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50)
);

alter table watch add foreign key (customer) references customer (id);
alter table service_watch add foreign key (apprentice) references apprentice (id);
alter table service_watch add foreign key (watch) references watch (id);
alter table service_watch add foreign key ([service]) references [service] (id);

insert into customer (firstname,lastname,phone_number)
	values	
			('Mary','Collington','0956874578'),
			('Elizabeth','Garter','0915284571'),
			('John','Smith','0975861457');

insert into watch (brand,customer)
	values
			('Saiko','1'),
			('Rolex','2'),
			('Omega','3');

insert into [service] (name,duration,price,description)
	values
			('Minor repair','30','20','Minor repair'),
			('New battery','10','10','Battery change'),
			('Complex','60','50','Complex repair');

insert into apprentice (firstname,lastname)
	values 
			('Adam','Longevine');

insert into service_watch (watch,apprentice,[service])
	values
			('1','1','2'),
			('3','1','3'),
			('2','1','1');


