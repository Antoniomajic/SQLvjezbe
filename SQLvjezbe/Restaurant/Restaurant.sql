use master;
drop database if exists Restaurant;
go
create database Restaurant;
go
use Restaurant;

create table category(
	id int not null primary key identity(1,1),
	name varchar(50) not null
);

create table meal(
	id int not null primary key identity(1,1),
	name varchar(100),
	description varchar(100),
	category int
);
 create table drink(
	id int not null primary key identity(1,1),
	name varchar(100),
	decription varchar(100)
 );

 create table drink_meal(
	id int not null primary key identity(1,1),
	drink int,
	meal int
);

alter table meal add foreign key (category) references category(id);
alter table drink_meal add foreign key (drink) references drink(id);
alter table drink_meal add foreign key (meal) references meal(id);

insert into category (name)
	values
			('Fish meals'),
			('Meat meals'),
			('Veggie meals');

insert into meal (name,description,category)
	values 
			('Baracuda mix','Baracuda,salmon and rice','1'),
			('Full plate','Mix of different meats','2'),
			('Garden on table','Salad','3');

insert into drink (name,decription)	
	values 
			('Chardonnay','White wine'),
			('Merlot','Red wine'),
			('Coca-cola','Soda');







