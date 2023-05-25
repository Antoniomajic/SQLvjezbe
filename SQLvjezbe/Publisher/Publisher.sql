use master;
drop database if exists Publisher;
go
create database Publisher;
go
use Publisher;

create table publisher(
	id int not null primary key identity(1,1),
	name varchar(50) not null
);

create table book(
	id int not null primary key identity(1,1),
	title varchar(100) not null,
	dateOfPublishment date,
	author varchar(200) not null
);

create table city(
	id int not null primary key identity(1,1),
	name varchar(50) not null,
	ZIPcode varchar(15) not null
);

create table publisher_book(
	id int not null primary key identity(1,1),
	publisher int,
	book int
);

create table publisher_city(
	id int not null primary key identity(1,1),
	publisher int,
	city int
);

alter table publisher_book add foreign key (publisher) references publisher (id);
alter table publisher_book add foreign key (book) references book (id);
alter table publisher_city add foreign key (publisher) references publisher (id);
alter table publisher_city add foreign key (city) references city (id);

insert into publisher (name)
	values
			('Donovan Books'),
			('School Book'),
			('Novarum');

insert into book (title,dateOfPublishment,author)
	values
			('Smaller','1997-08-28','Heather Christie'),
			('A Million To One','2001-01-12','Tony Faggioli'),
			('Pieces of Light','2012-12-01','Charles Ferny');

insert into city (name,ZIPcode)
	values
			('Colorado Springs','80911'),
			('Topeka','66614'),
			('Rochester','14617');

update book set title='Smaller to Smaller' where id=1;









