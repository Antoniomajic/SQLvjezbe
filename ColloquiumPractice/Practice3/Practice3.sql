use master;
drop database if exists Practice3;
go
create database Practice3;
go
use Practice3;

create table girl(
	id int not null primary key identity(1,1),
	sweatshirt varchar(49),
	mark decimal(13,7),
	secondTime datetime,
	TShirt varchar(49),
	coin decimal(15,8),
	necklace int not null
);

create table fatherInLaw(
	id int not null primary key identity(1,1),
	coin decimal(16,8) not null,
	skirt varchar(48) not null,
	haircolor varchar(36),
	ring int,
	bracelet int not null,
	girl int not null
);

create table brother(
	id int not null primary key identity(1,1),
	IDnumber char(11),
	necklace int not null,
	extroverted bit not null
);

create table friend(
	id int not null primary key identity(1,1),
	kuna decimal(16,10),
	dress varchar(37),
	lipa decimal(13,10),
	sweatshirt varchar(31),
	indifferent bit not null
);

create table friend_brother(
	id int not null primary key identity(1,1),
	friend int not null,
	brother int not null
);

create table leftBehind(
	id int not null primary key identity(1,1),
	kuna decimal(17,5),
	lipa decimal(15,6),
	TShirt varchar(36),
	glassesModel varchar(31) not null,
	friend int
);

create table firstMotherInLaw(
	id int not null primary key identity(1,1),
	introverted bit,
	kuna decimal(15,6) not null,
	euro decimal(12,9) not null,
	thirdTime datetime,
	leftBehind int not null
);

create table secondMotherInLaw(
	id int not null primary key identity(1,1),
	asocial bit,
	shortTShirt varchar(44),
	kuna decimal(13,8) not null,
	cardigan varchar(32) not null,
	firstMotherInLaw int
);

-- RELATIONS

alter table fatherInLaw add foreign key (girl) references girl (id);
alter table friend_brother add foreign key (friend) references friend (id);
alter table friend_brother add foreign key (brother) references brother (id);
alter table leftBehind add foreign key (friend) references friend (id);
alter table firstMotherInLaw add foreign key (leftBehind) references leftBehind (id);
alter table secondMotherInLaw add foreign key (firstMotherInLaw) references firstMotherInLaw (id);

--INSERTS

insert into girl (sweatshirt,mark,secondTime,TShirt,coin,necklace)
	values	
			('Adidas','97.31','2023-06-06','Nike','971.748','3');

insert into fatherInLaw (coin,skirt,haircolor,ring,bracelet,girl)
	values
			('999.45','Short','Brown','3','2',1);

insert into brother (IDnumber,necklace,extroverted)
	values	
			('85258269341','3','0');

insert into friend (kuna,dress,lipa,sweatshirt,indifferent)
	values
			('51.71','Short Dress Bamboo','34.85','Nike','0');

insert into friend_brother (friend,brother)
	values
			(1,1);

insert into leftBehind (kuna,lipa,TShirt,glassesModel,friend)
	values
			('85','15','Tally Walle','Roberto',1),
			('15','30','Long Black','Ray Ban',1),
			('5','42','Caffe Bar Ivanovec','Versace',1);

insert into firstMotherInLaw (introverted,kuna,euro,thirdTime,leftBehind)
	values
			('0','187.63','63.43','2023-06-06',1),
			('1','17.63','23.87','2005-01-15',2),
			('0','7.63','113.13','2021-08-21',3);

insert into secondMotherInLaw (asocial,shortTShirt,kuna,cardigan,firstMotherInLaw)
	values
			('1','Black T-Shirt','98.74','Long blue',1);

update fatherInLaw set skirt='Osijek';

delete from secondMotherInLaw where shortTShirt='AB';
select TShirt from leftBehind where lipa not in ('9','10','20','30','35');

select a.extroverted, f.cardigan, e.kuna
from brother a inner join friend_brother b		on b.brother=a.id
inner join friend c								on b.friend=c.id
inner join leftBehind d							on d.friend=c.id
inner join firstMotherInLaw	e					on e.leftBehind=d.id
inner join secondMotherInLaw f					on f.firstMotherInLaw=e.id
where d.lipa !=91 and c.dress like '%ba%'
order by e.kuna desc;

select friend.dress, friend.lipa
from friend 
where id not in (select id from friend_brother);














