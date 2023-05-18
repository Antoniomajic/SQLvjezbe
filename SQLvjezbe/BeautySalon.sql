use master;
drop database if exists BeautySalon;
go
create database BeautySalon collate Croatian_CI_AS;
go
use BeautySalon;

create table employee(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number char(11)
);

create table customer(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50),
	sex varchar(10) not null
);

create table service(
	id int not null primary key identity(1,1),
	name varchar(50) not null,
	price decimal(18,2),
	duration int 
);

create table appointment(
	id int not null primary key identity(1,1),
	date datetime not null,
	service int not null,
	customer int not null,
	employee int not null
);

alter table appointment add foreign key (service) references service (id);
alter table appointment add foreign key (employee) references employee (id);
alter table appointment add foreign key (customer) references customer (id);

insert into employee (firstname,lastname,id_number) 
values 
('Matko','Valentić',null),
('Silvana','Pintarić',null),
('Lorenc','Maroški',null);

insert into  customer (firstname,lastname,sex)
values
('Ivan','Ivanovskić','M'),
('Marijana','Oreški','Ž'),
('Ludovik','Luciš','M');

insert into  service (name,price,duration)
values
('Pedikura','10','20'),
('Maska za lice','10','30'),
('Umjetni nokti','20','60');

insert into appointment (date,service,customer,employee) 
values 
('2023-05-11 9:00:00',1,2,3),
('2023-05-11 10:00:00',3,1,2),
('2023-05-11 11:00:00',2,3,1);

update service set name='Pedicure' where id=1;
update service set name='Face mask' where id=2;
update service set name='Fake nails' where id=3;
