use master;
drop database if exists "Doctor'sOffice";
create database "Doctor'sOffice";
go
use "Doctor'sOffice";

create table person(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number char(11)
);

create table patient(
	id int not null primary key identity(1,1),
	person int not null 
);

create table therapy(
	id int not null primary key identity(1,1),
	name varchar(100),
	description varchar(300)
);

create table nurse(
	id int not null primary key identity(1,1),
	person int not null
);

create table patient_therapy(
	id int not null primary key identity(1,1),
	patient int not null,
	therapy int,
	nurse int
);

alter table patient_therapy add foreign key (nurse) references nurse (id);
alter table patient_therapy add foreign key (patient) references patient (id);
alter table patient_therapy add foreign key (therapy) references therapy (id);
alter table nurse add foreign key (person) references person(id); 
alter table patient add foreign key (person) references person(id);

insert into person (firstname,lastname,id_number)
	values
			('Harvey','May','45718547859'),
			('Callum','Jackson','45781459687'),
			('Natasha','Brooks','32568741589'),
			('Grace','Hunt','12476985325');

insert into patient (person)
	values
			('3'),
			('4');

insert into nurse (person)
	values 
			('1'),
			('2');

insert into therapy (name,description)
	values 
			('GHE','General Health Exam'),
			('GPT','High pressure treatment');

insert into patient_therapy (patient,therapy,nurse)
	values 
			('1','2','1'),
			('2','1','2');