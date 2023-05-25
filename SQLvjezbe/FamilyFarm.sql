use master;
drop database if exists FamilyFarm;
go
create database FamilyFarm;
go 
use FamilyFarm;

create table material(
	id int not null primary key identity(1,1),
	name varchar(50),
	valuePerUnit decimal (18,2)
);

create table product(
	id int not null primary key identity(1,1),
	name varchar(50),
	price decimal(18,2)
);

create table product_material(
	id int not null primary key identity(1,1),
	product int,
	material int
);

create table employee(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50)
);

create table employee_product(
	id int not null primary key identity(1,1),
	employee int,
	product int
);

alter table product_material add foreign key (product) references product(id);
alter table product_material add foreign key (material) references material(id);
alter table employee_product add foreign key (employee) references employee(id);
alter table employee_product add foreign key (product) references product(id);

insert into material (name,valuePerUnit)
	values
			('Milk','1.05'),
			('Whey','0.6'),
			('Yeast','0.15');

insert into product (name,price)
	values
			('Cheese',5),
			('Milkshake','2');

insert into employee (firstname,lastname)
	values
			('Mark','Anthony'),
			('Julius','Ceaser');





