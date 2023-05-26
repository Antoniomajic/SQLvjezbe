use master;
drop database if exists Facebook;
go
create database Facebook collate Croatian_CI_AS;
go
use Facebook;

create table person(
	id int not null primary key identity(1,1),
	firstname varchar(25) not null,
	lastname varchar(25) not null,
	dateOfBirth date,
	email varchar(50) not null,
	password varchar(60) not null,
	phonenumber int,
	photo varchar(100),
	administrator bit not null,
	status bit not null,
	active bit not null,
	uniqueid varchar(255)
);

create table post(
	id int not null primary key identity(1,1),
	title varchar(50) not null,
	note varchar(250) not null,
	timeOfPosting datetime not null,
	ipAddress varchar(20),
	person int
);


create table comment(
	id int not null primary key identity(1,1),
	timeOfCommenting datetime not null,
	description varchar(250),
	post int,
	person int
);

create table like_comment(
	id int not null primary key identity(1,1),
	person int,
	comment int
);

create table [like](
	id int not null primary key identity(1,1),
	timeOfLiking datetime not null,
	post int,
	person int
);

alter table [like] add foreign key (post) references post (id);
alter table post add foreign key (person) references person (id);
alter table comment add foreign key (post) references post (id);
alter table like_comment add foreign key (comment) references comment (id);

insert into person (firstname,lastname,dateOfBirth,email,password,phonenumber,photo,administrator,status,active,uniqueid)
	values
			('Renato','Brodiæ','1978-05-13','renatobrodic@gmail.com','12478','0978447185','null','0','0','0','Remba'),
			('Mirjana','Labas','1998-07-15','mirjanal@gmail.com','cicamica','0915521455','null','1','0','0','Admin'),
			('Dario','Petrušiæ','2001-11-17','dariopetrusic@hotmail.com','sdfjwei','0912254478','null','0','1','1','null'),
			('Vladica','Vinkoviæ','1985-05-12','asjfkdsjlf@gmaskdf.com','werttzrt','0354448551','0','0','1','0','safe');



select * from person;