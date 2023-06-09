use master;
drop database if exists Practice4;
go
create database Practice4;
go
use Practice4;

create table leftBehind(
	id int not null primary key identity(1,1),
	glassesModel varchar(43),
	introverted bit,
	kuna decimal(14,10)
);

create table fatherInLaw(
	id int not null primary key identity(1,1),
	thirdTime datetime,
	TShirt varchar(46),
	IDNumber char(11) not null,
	coin decimal(18,7) not null,
	mark decimal(12,6) not null,
	leftBehind int not null
);

create table youngMan(
	id int not null primary key identity(1,1),
	kuna decimal(15,9),
	lipa decimal(18,5),
	earing int,
	haristyle varchar(49),
	cardigan varchar(34) not null
);

create table woman(
	id int not null primary key identity(1,1),
	skirt varchar(39) not null,
	lipa decimal(18,7),
	ring int not null
);

create table woman_youngMan(
	id int not null primary key identity(1,1),
	woman int not null,
	youngMan int not null
);

create table goody(
	id int not null primary key identity(1,1),
	introverted bit,
	thirdTime datetime,
	dress varchar(44) not null,
	woman int not null
);

create table reveler(
	id int not null primary key identity(1,1),
	coin decimal(14,8),
	shortTShirt varchar(48) not null,
	colorOfEyes varchar(36) not null,
	goody int not null
);

create table friend(
	id int not null primary key identity(1,1),
	euro decimal(16,9),
	ring int not null,
	density decimal(16,5),
	IDNumber char(11) not null,
	skirt varchar(47) not null,
	reveler int not null
);

alter table fatherInLaw add foreign key (leftBehind) references leftBehind (id);
alter table woman_youngMan add foreign key (woman) references woman (id);
alter table woman_youngMan add foreign key (youngMan) references youngMan (id);
alter table goody add foreign key (woman) references woman (id);
alter table reveler add foreign key (goody) references goody (id);
alter table friend add foreign key (reveler) references reveler (id);

insert into leftBehind (glassesModel,introverted,kuna)
	values
			('Ray Ban','0','58.74');

insert into fatherInLaw (thirdTime,TShirt,IDNumber,coin,mark,leftBehind)
	values
			('2020-05-05','Adidas','52147845120','87.54','258.84','1');

insert into youngMan (kuna,lipa,earing,haristyle,cardigan)
	values
			('87','97','2','Short brown hair','Long sleeved black cardigan');

insert into woman (skirt,lipa,ring)
	values
			('Black short skirt','87',3);

insert into woman_youngMan (woman,youngMan)
	values
			(1,1);

insert into goody (introverted,thirdTime,dress,woman)
	values
			(0,'2019-01-01','Summer dress',1);

insert into reveler (coin,shortTShirt,colorOfEyes,goody)
	values
			('87.12','Alibaba','Brown',1);

insert into friend (euro,ring,density,IDNumber,skirt,reveler)
	values
			('87.36',4,'10.01','47845123698','Short black leather',1);

update fatherInLaw set TShirt='Osijek';

delete from friend where ring>17;

select dress from goody where thirdTime is null;

select a.earing, f.IDNumber, e.shortTShirt
from youngMan a inner join woman_youngMan b			on b.youngMan=a.id
inner join woman c									on c.id=b.woman
inner join goody d									on d.woman=c.id
inner join reveler e								on e.goody=d.id
inner join friend f									on f.reveler=e.id
where d.thirdTime is not null and c.lipa !=29
order by e.shortTShirt desc;

select woman.lipa, woman.ring
from woman 
where id not in (select id from woman_youngMan);

