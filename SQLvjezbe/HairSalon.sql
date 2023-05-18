use master;

drop database if exists HairSalon;

create database HairSalon collate Croatian_CI_AS; 

use HairSalon;

create table employee(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number char(11)
);

create table customer(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
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
('Marija', 'Knežević',null),
('Matija', 'Aranđelović',null),
('Ivona', 'Martinović',null);



insert into customer (firstname,lastname,sex) 
values 
('Marko','Perić','M'),
('Ivana','Petrović','Ž'),
('Silvija','Stanković','Ž');

insert into service (name,price,duration)
values
('musko sisanje',7,20), 
('zensko sisanje',10,35), 
('pranje kose',5,15);

insert into appointment (date,service,customer,employee)
values 
('2023-05-10 10:00:00','1','1','1'),
('2023-05-10 11:00:00','2','2','3'),
('2023-05-10 10:00:00','2','3','2');

select * from service;

update service set name='Male haircut' where id=1;
update service set name='Female haircut' where id=2;
update service set name='Hair wash' where id=3;

