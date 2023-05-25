use master;
drop database if exists HighSchool;
go
create database HighSchool collate Croatian_CI_AS;
go
use HighSchool;

create table student(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50),
	sex char(1),
	class int
);

create table professor(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50),
	id_number char(11)
);

create table class(
	id int not null primary key identity(1,1),
	name varchar(3),
	maxstudents varchar(2)
);

create table class_professor(
	id int not null primary key identity(1,1),
	class int not null,
	professor int not null
);

alter table student add foreign key (class) references class (id);
alter table class_professor add foreign key (class) references class (id);
alter table class_professor add foreign key (professor) references professor (id);

select * from professor;

insert into class (name,maxstudents)
	values
			('1.A','20'),
			('1.B','22'),
			('1.C','21');

insert into student (firstname,lastname,sex,class)
	values
			('Matej','Kokot','M','1'),
			('Dinko','Frijang','M','1'),
			('Zdravko','Krajinović','M','2'),
			('Marija','Džaja','Ž','3');

insert into professor (firstname,lastname,id_number)
	values
			('Matija','Braut','91064433687'),
			('Ante','Župan','14082055968'),
			('Edita','Panjić','79628991552'),
			('Manuela','Rak','56002245214');

insert into class_professor (class,professor)
	values
			('1','1'),
			('1','2'),
			('2','2'),
			('3','3');

update professor set firstname='Boris' where id=1;
	

