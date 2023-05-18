use master;
drop database if exists Museum;
create database Museum collate Croatian_CI_AS;
go
use Museum;

create table curator(
	id int not null primary key identity(1,1),
	firstname varchar(50) not null,
	lastname varchar(50) not null,
	phone_number varchar(100)
);

create table sponsor(
	id int not null primary key identity(1,1),
	name varchar(100),
	email varchar(100)
);

create table artwork(
	id int not null primary key identity(1,1),
	name varchar(50) not null,
	description varchar(100),
	exhibition int
);

create table exhibition(
	id int not null primary key identity(1,1),
	name varchar(100),
	sponsor int not null,
	curator int not null
);

--RELATIONS--

alter table artwork add foreign key (exhibition) references exhibition (id); 
alter table exhibition add foreign key (sponsor) references sponsor (id);
alter table exhibition add foreign key (curator) references curator (id);

--INSERTS--

insert into curator (firstname,lastname,phone_number)
	values
			('Nenad','�i�i�','0917458254'),
			('Marko','�ari�','0974573256'),
			('Gabrijela','Vinkovi�','0986474117');

insert into sponsor (name,email)
	values
			('Konzum','konzum@gmail.com'),
			('Ured Predsjednika RH','predsjednik@ured.com'),
			('Veleposlanstvo Kraljevine �panjolske u RH','Spanishembassy@croatia.com');

insert into exhibition (name,sponsor,curator)
	values
			('Suvremena umjetnost',1,3),
			('Sisak u 15.-tom stolje�u',2,1),
			('Alternativna abstrakcija',3,2);

insert into artwork (name,description,exhibition)
	values
			('Vrtlog','Slika Andrije Pali�a iz 1997.g.',2),
			('Kaciga','Srednjovjekovna vojna oprema',1),
			('U�e slobode','Umjetni�ki eksponat nepoznate upotrebe',3);

update sponsor set email='spanishembassy@croatia.es' where id=3;
