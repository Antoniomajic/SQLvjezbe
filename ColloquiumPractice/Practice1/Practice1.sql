use master;
drop database if exists Practice1;
go
create database Practice1;
go
use Practice1;

-- 1. CREATE TABLES AND RELATIONS BETWEEN THEM

create table girl(
	id int not null primary key identity(1,1),
	coin decimal(16,5) not null,
	density decimal(18,6) not null,
	lipa decimal(13,10),
	necklace int not null,
	hairColor varchar(38),
	skirt varchar(36),
	fatherInLaw int 
);

create table fatherInLaw(
	id int not null primary key identity(1,1),
	necklace int,
	density decimal(14,9),
	pants varchar(41) not null
);

create table youngMan(
	id int not null primary key identity(1,1),
	skirt varchar(50) not null,
	kuna decimal(16,8) not null,
	nextTime datetime,
	asocial bit,
	extroverted bit not null,
	sweatshirt varchar(48) not null,
	man int
);

create table man(
	id int not null primary key identity(1,1),
	colorOfEyes varchar(50) not null,
	pants varchar(30),
	glassesModel varchar(43),
	marks decimal(14,5) not null,
	woman int not null
);

create table woman(
	id int not null primary key identity(1,1),
	thirdTime datetime,
	pants varchar(46),
	TShirt varchar(31) not null,
	idNumber char(11) not null,
	colorOfEyes varchar(39) not null,
	dress varchar(44),
	sister int not null
);

create table sister(
	id int not null primary key identity(1,1),
	introverted bit,
	dress varchar(31) not null,
	marks decimal(16,6),
	pants varchar(46) not null,
	bracelet int not null
);

create table secondFatherInLaw(
	id int not null primary key identity(1,1),
	colorOfEyes varchar(40) not null,
	ring int,
	sweatshirt varchar(41),
	lipa decimal(13,8),
	euro decimal(12,7),
	shirt varchar(35)
);


create table sister_secondFatherInLaw(
	id int not null primary key identity(1,1),
	sister int not null,
	secondFatherInLaw int not null
);

--RELATIONS

alter table girl add foreign key (fatherInLaw) references fatherInLaw (id);
alter table youngMan add foreign key (man) references man (id);
alter table man add foreign key (woman) references woman (id);
alter table woman add foreign key (sister) references sister (id);
alter table sister_secondFatherInLaw add foreign key (sister) references sister (id);
alter table sister_secondFatherInLaw add foreign key (secondFatherInLaw) references secondFatherInLaw (id);

--1. INSERTS

insert  into fatherInLaw (necklace,density,pants)
	values
			('1','9.5','Amadeus pants');

insert into girl (coin,density,lipa,necklace,hairColor,skirt,fatherInLaw)
	values 
			('45.78','38.61','97.41','2','Black','Short skirt',1);

insert into secondFatherInLaw (colorOfEyes,ring,sweatshirt,lipa,euro,shirt)
	values
			('Brown','5','Puma','1005.36','558.741','Yellow shirt'),
			('Grey','1','Adidas','5.87','9997.41059','Yellow shirt'),
			('Blue','2','Nike','378.41','41.870','Yellow shirt');

insert into sister (introverted,dress,marks,pants,bracelet)
	values 
			('1','Blue summer dress','87.11','Denim','3'),
			('0','Cocktail dress','7.1','Brown','0'),
			('1','Long baby blue dress','182.16','Slim fit black','3');

insert into sister_secondFatherInLaw (sister,secondFatherInLaw)
	values
			(1,1),
			(2,3),
			(3,2);

insert into woman (thirdTime,pants,TShirt,idNumber,colorOfEyes,dress,sister)
	values
			(null,'Armani','Blue','78451263958','Light Blue','Short','2'),
			('2021-08-14 00:00:00','Smart','Brown','54781245914','Brown','Long dress','1'),
			(null,'Blue','Brown','00369528715','Brown','Yellow summer dress','3');

insert into man (colorOfEyes,pants,glassesModel,marks,woman)
	values
			('Brown','Black Pants','Ray Ban','587.52','3'),
			('Brown','Grey Pants','Ricardo','115.741','2'),
			('Brown','Light Brown Pants','Ray Sun','107854.967','1');

insert into youngMan (skirt,kuna,nextTime,asocial,extroverted,sweatshirt,man)
	values
			('Short Grey Skirt','584.74',null,'0','0','Adidas Blue','2');

-- 2. CHANGE ALL RECORDS IN COLUMN DENSITY IN "GIRL" TABLE TO 15.77

update girl set density=15.77;

-- 3. DELETE RECORDS FROM youngMan TABLE WHERE VALUE OF kuna COLUMN > 15.78
delete from youngMan where kuna>15.78;

-- 4. SELECT TShirt FROM TABLE woman WHERE VALUE OF COLUMN pants CONTAINS LETTERS ana
select * from woman where TShirt like '&ana&';

-- 5. SELECT sweatshirt FROM TABLE secondFatherInLaw, asocial FROM TABLE youngMan & pants FROM TABLE man WHERE VALUES OF COLUMN pants FROM TABLE woman START WITH LETTER A AND THAT VALUES OF COLUMN dress FROM VALUE sister
-- CONTAINS ROW OF LETTER BA. ORDER DATA BY pants FROM TABLE man DOWNWARDS.

select distinct a.sweatshirt, f.asocial, e.pants
from secondFatherInLaw a 
inner join sister_secondFatherInLaw b			on b.secondFatherInLaw=a.id
inner join sister c								on c.id=b.sister
inner join woman d								on d.sister=c.id
inner join man e								on e.woman=d.id
inner join youngMan f							on f.man=e.id
where d.pants like 'A%' and c.dress like '%ba%'
order by e.pants;

-- 6. SELECT COLUMN dress & marks FROM TABLE sister WHOSE PRIMARY KEY IS NOT IN TABLE sister_secondFatherInLaw
select distinct c.dress, c.marks
from sister c inner join sister_secondFatherInLaw b on b.sister=c.id;










