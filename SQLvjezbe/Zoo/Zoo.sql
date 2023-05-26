use master;
drop database if exists Zoo;
go
create database Zoo;
go
use Zoo;

create table employee(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	IBAN varchar(50)	
);

create table [date](
	id int not null primary key identity(1,1),
	dateOfBirth datetime,
	dateOfArrival datetime,
	dateOfDeath datetime
);

create table cage(
	id int not null primary key identity(1,1),
	dimensions varchar(30),
	max_number int,
	location varchar(30)
);

create table animal(
	id int not null primary key identity(1,1),
	species varchar(50),
	name varchar(50),
	employee int,
	cage int,
	[date] int
);

alter table animal add foreign key (employee) references employee (id);
alter table animal add foreign key ([date]) references [date] (id);
alter table animal add foreign key (cage) references cage (id);

insert into employee (firstname,lastname,IBAN)
	values 
			('Mark','Anthony','31548568'),
			('John','Walsh','748555488'),
			('Mary','Smith','315741852'),
			('Mary','Smith','311144444');

insert into [date] (dateOfBirth,dateOfArrival,dateOfDeath)
	values
			('2015-04-12','2015-06-28','2022-04-11'),
			('2005-08-21','2018-12-05','2023-12-14'),
			('1995-01-01','1996-02-11','2003-08-30');

insert into cage (dimensions,max_number,location)
	values
			('40x50','20','Zone B'),
			('100*150','2','Zone A'),
			('30*45','11','Zone C');

insert into animal (species,name,employee,cage,[date])
	values 
			('Fish','Salmon','1','3','2'),
			('Wild Cat','Lion','2','1','3'),
			('Bugs','Huge Fly','3','2','1');			

update animal set name='Piranha' where id=1;
update employee set IBAN='3698555124' where id=3;
update cage set dimensions='500*1200' where id=2;

delete from employee where id=4;
