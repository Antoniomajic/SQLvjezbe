use master;
drop database Practice6;
go
create database Practice6;
go
use Practice6;

create table fatherInLaw(
	id int not null primary key identity(1,1),
	extroverted bit not null,
	skirt varchar(30) not null,
	TShirt varchar(44) not null,
	firstTime datetime not null
);

create table motherInLaw(
	id int not null primary key identity(1,1),
	pants varchar(48) not null,
	skirt varchar(42) not null,
	necklace int not null,
	thirdTime datetime not null,
	sweatshirt varchar(32) not null,
	bracelet int not null,
	fatherInLaw int
);

create table leftBehind(
	id int not null primary key identity(1,1),
	firstTime datetime not null,
	shortTShirt varchar(39) not null,
	secondTime datetime,
	mark decimal(14,10)
);

create table friend(
	id int not null primary key identity(1,1),
	dress varchar(35),
	ring int not null,
	introverted bit,
	hairstyle varchar(36) not null
);

create table friend_leftBehind(
	id int not null primary key identity(1,1),
	friend int not null,
	leftBehind int not null
);

create table brother(
	id int not null primary key identity(1,1),
	earing int not null,
	thirdTime datetime not null,
	bracelet int not null,
	pants varchar(31),
	friend int
);

create table woman(
	id int not null primary key identity(1,1),
	coin decimal(14,8) not null,
	bracelet int not null,
	sweatshirt varchar(40) not null,
	dress varchar(30),
	pants varchar(32),
	brother int not null
);

create table boy(
	id int not null primary key identity(1,1),
	firstTime datetime,
	glassesModel varchar(41),
	earing int,
	woman int not null
);

--RELATIONS
alter table motherInLaw add foreign key (fatherInLaw) references fatherInLaw (id);
alter table friend_leftBehind add foreign key (friend) references friend (id);
alter table friend_leftBehind add foreign key (leftBehind) references leftBehind (id);
alter table brother add foreign key (friend) references friend (id);
alter table woman add foreign key (brother) references brother (id);
alter table boy add foreign key (woman) references woman (id);

--INSERTS
insert into fatherInLaw (extroverted,skirt,TShirt,firstTime)
	values
			('0','Versace','Nike','2014-05-09');

insert into motherInLaw (pants,skirt,necklace,thirdTime,sweatshirt,bracelet,fatherInLaw)
	values
			('Long black pants','Versace',8,'2011-06-18','Adidas',4,1);

insert into leftBehind (firstTime,shortTShirt,secondTime,mark)
	values
			('2000-06-11','Alibaba','2004-09-07','997.35'),
			('2013-01-16','Marlboro','2014-05-15','997.35'),
			('2015-08-21','Smoking','2024-08-30','997.35');

insert into friend (dress,ring,introverted,hairstyle)
	values
			('Summer dress',75,'1','Long curly black hair'),
			('Winter dress',219,'0','Long curly brown hair'),
			('Sping dress',18,'1','Short straight black hair');

insert into friend_leftBehind (friend,leftBehind)
	values
			(1,1),
			(2,1),
			(2,3);

insert into brother (earing,thirdTime,bracelet,pants,friend)
	values
			(7,'1997-11-08',7,'Levis Pants',1),
			(17,'1987-11-08',1,'Black Pants',1),
			(707,'2007-11-08',345,'Cheap Red Pants',1);

insert into woman (coin,bracelet,sweatshirt,dress,pants,brother)
	values
			('411087.236985',3,'Greenpeace','Red cocktail dress','White pants',1),
			('878995.24',6,'Didas','Wedding dress','Brown pants',3),
			('362.2',13,'Babooysa','Tihaljica','Sugar pants',2);

insert into boy (firstTime,	glassesModel,earing,woman)
	values
			('2009-06-17','Tokio',4,1);

update motherInLaw set skirt='Osijek';

delete from boy where glassesModel <'AB';

select bracelet from brother where thirdTime is null;

select a.secondTime, f.woman, e.bracelet
from leftBehind a inner join friend_leftBehind b	on b.leftBehind=a.id
inner join friend c									on b.friend=c.id
inner join brother d								on d.friend=c.id
inner join woman e									on e.brother=d.id
inner join boy f									on f.woman=e.id
where d.thirdTime is not null and c.ring=219
order by e.bracelet desc;

select friend.ring, friend.introverted 
from friend 
where id not in (select id from friend_leftBehind);