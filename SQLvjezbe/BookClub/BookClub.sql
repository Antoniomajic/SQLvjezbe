use master;
drop database if exists BookCLub;
go
create database BookCLub;
go
use BookCLub;

create table member(
	id int not null primary key identity(1,1),
	firstname varchar(50),
	lastname varchar(50),
	id_number char(11)
);

create table book_owner(
	id int not null primary key identity(1,1),
	member int
);

create table book(
	id int not null primary key identity(1,1),
	book_owner int,
	title varchar(50),
	author varchar(200)
);

create table member_book(
	id int not null primary key identity(1,1),
	member int,
	book int
);

alter table book_owner add foreign key (member) references member (id);
alter table member_book add foreign key (member) references member (id);
alter table member_book add foreign key (book) references book (id);
alter table book add foreign key (book_owner) references book_owner (id);

insert into member (firstname,lastname,id_number)
	values
			('Alfred','Richardson','48874800397'),
			('Cooper','Cole','26986714984'),
			('Martha','Carr','97977621965');

insert into book_owner (member)
	values
			('1'),
			('2'),
			('3');

insert into book (book_owner,title,author)
	values
			('1','The Girl','Hugh Michaels'),
			('2','Mask','Marry Carrick'),
			('2','Six Crows','Leigh Bardugo'),
			('3','Blood','Eleanor Shearer');

update book set author='Matt Noble' where id=2;





