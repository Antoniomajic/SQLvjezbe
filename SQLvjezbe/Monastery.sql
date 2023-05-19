use master;
drop database if exists Monastery;
create database Monastery collate Croatian_CI_AS;
go
use Monastery;

create table monk(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	id_number varchar(20),
	supervisor int
);

create table work(
	id int not null primary key identity(1,1),
	name varchar(50),
	description varchar(50),
	duration int
);

create table monk_work(
	id int not null primary key identity(1,1),
	monk int not null,
	work int not null
);

--RELATIONS--

alter table monk_work add foreign key (monk) references monk (id);
alter table monk_work add foreign key (work) references work (id);
alter table monk add foreign key (supervisor) references monk (id);

select * from work;

--INSERTS INTO TABLES--
insert into monk (firstname,lastname,id_number,supervisor)
	values
			('Hrvoje','Papiæ','14571854759','5'),
			('Vedran','Boroviæ','45781369586','3'),
			('Ljudevit','Milèiæ','45698732589','4'),
			('Ivica','Stilinoviæ','98753641259','2'),
			('Danijel','Šprem','97325817586','1');

insert into work (name,description,duration)
	values
			('Povrtlarstvo','Rad u vrtu','60'),
			('Pivarstvo','Proizvodnja piva','60'),
			('Vinarstvo','Proizvodnja vina','60');

insert into monk_work (monk,work)
	values
			('1','1'),
			('1','2'),
			('2','3'),
			('3','3'),
			('3','2'),
			('4','1'),
			('4','3'),
			('5','2'),
			('5','1');

update work set duration='120' where id=3;

