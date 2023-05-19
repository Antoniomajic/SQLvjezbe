use master;
drop database if exists Faculty;
create database Faculty collate Croatian_CI_AS;
go
use Faculty;

create table student(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number char(11)
);

create table course(
	id int not null primary key identity(1,1),
	name varchar(100),
	description varchar (200)
);

create table term(
	id int not null primary key identity(1,1),
	date datetime,
	course int
);

create table student_term(
	id int not null primary key identity(1,1),
	student int not null,
	term int not null
);

alter table student_term add foreign key (student) references student (id);
alter table student_term add foreign key (term) references term (id);
alter table term add foreign key (course) references course (id);

insert into student (firstname,lastname,id_number)
	values
			('Zlatko','Panjiæ','21378764202'),
			('Emil','Hadžiæ','71346581854'),
			('Duje','Ivanoviæ','50484497824'),
			('Ivana','Bogdan','94359048825'),
			('Manuela','Mitroviæ','53835662727');

insert into course (name,description)
	values	
			('Osnove ekonomije 1','Prvi kolegij iz ekonomije;osnove ekonomske misli, temeljna ekonomska naèela'),
			('Raèunovodstvo 1','Drugi kolegij iz ekonomije; teorijsko i praktièno znanje iz podruèja raèunovodstva');

insert into term (date,course)
	values 
			('2023-03-15 09:00:00','1'),
			('2023-03-28 12:00:00','1'),
			('2023-04-07 09:00:00','2'),
			('2023-04-21 09:00:00','2');

insert into student_term (student,term)
	values
			('1','1'),
			('1','2'),
			('2','1'),
			('2','2'),
			('3','1'),
			('3','2'),
			('4','1'),
			('4','2'),
			('5','1'),
			('5','2');

update student set firstname='Ivona' where id=4;
