--create database fakultet;
--use fakultet;


--create database student;
--drop database student;

create table student(
	maticnibroj char(5),
	ime varchar(50),
	prezime varchar(50)
);

create table rok(
	vrijemeodrzavanja datetime,
	mogucnostonlinepolaganja bit,
	brojprijava int
);

create table kolegij(
	naziv varchar(50),
	predmet varchar(50),
	sifraprofesora char(5)
);




