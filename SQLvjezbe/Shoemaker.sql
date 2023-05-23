use master;
drop database if exists Shoemaker;
create database Shoemaker collate Croatian_CI_AS;
go
use Shoemaker;

create table customer(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50),
	phone_number varchar(20)
);

create table shoe(
	id int not null primary key identity(1,1),
	brand varchar(50),
	number char(2),
	customer int
);

create table [service](
	id int not null primary key identity(1,1),
	name varchar(50),
	duration int,
	price decimal(18,2),
	descripction varchar(100)
);

create table shoe_service(
	id int not null primary key identity(1,1),
	shoe int,
	apprentice int not null,
	[service] int
);

create table apprentice(
	id int not null primary key identity(1,1),
	firstandlastname varchar(50)
);

alter table shoe add foreign key (customer) references customer (id);
alter table shoe_service add foreign key (apprentice) references apprentice (id);
alter table shoe_service add foreign key (shoe) references shoe (id);
alter table shoe_service add foreign key ([service]) references [service] (id);

insert into customer (firstname,lastname,phone_number)
	values 
			('Pavao','Krčelić','0978523654'),
			('Damir','Drajačić','0956358875'),
			('Danica','Vukasović','0974785123'),
			('Željka','Pretić','0912587415');

insert into shoe (brand,number,customer)
	values 
			('Nike','41','1'),
			('Adidas','44','2'),
			('Roberto','37','3'),
			('Borovo','37','3'),
			('Adidas','43','4');

insert into apprentice (firstandlastname)
	values
			('Mario Marić');


insert into  [service] (name,duration,price,descripction)
	values 
			('Jednostavni popravak','30','10','Jednostavni popravak obuće'),
			('Složeni popravak','60','20','Složeni popravak obuće'),
			('Komplicirani popravak','90','35','Teži popravak obuće');

insert into shoe_service (shoe,apprentice,[service])
	values 
			('1','1','2'),
			('2','1','3'),
			('3','1','2'),
			('4','1','1');


select * from shoe_service;

