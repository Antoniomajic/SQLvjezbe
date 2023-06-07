use master;
drop database if exists Practice2;
go
create database Practice2;
go
use Practice2;

create table fatherInLaw(
	id int not null primary key identity(1,1),
	haristyle varchar(48),
	necklace int not null,
	asocial bit not null
);

create table friend(
	id int not null primary key identity(1,1),
	glassesModel varchar(37),
	thirdTime datetime not null,
	extroverted bit not null,
	firstTime datetime,
	fatherInLaw int not null
);

create table brother(
	id int not null primary key identity(1,1),
	skirt varchar(47),
	necklace int not null,
	asocial bit not null,
	enemy int not null
	);

create table enemy(
	id int not null primary key identity(1,1),
	TShirt varchar(32),
	dress varchar(43) not null,
	lipa decimal(16,8),
	glassesModel varchar(49) not null,
	kuna decimal(12,6) not null,
	jmbag char(11),
	girl int 
);

create table girl(
	id int not null primary key identity(1,1),
	dress varchar(33) not null,
	secondTime datetime not null,
	skirt varchar(38),
	bracelet int,
	introverted int,
	TShirt varchar(40) not null,
	boy int 
);

create table boy(
	id int not null primary key identity(1,1),
	indiferent bit,
	cardigan varchar(34),
	asocial bit not null
);

create table fiance(
	id int not null primary key identity(1,1),
	bracelet int,
	hairColor varchar(37) not null,
	coin decimal(15,9),
	lipa decimal(15,8) not null,
	indiferent bit not null
);

create table boy_fiance(
	id int not null primary key identity(1,1),
	boy int not null,
	fiance int not null
);

-- RELATIONS
alter table friend add foreign key (fatherInLaw) references fatherInLaw (id);
alter table brother add foreign key (enemy) references enemy (id);
alter table enemy add foreign key (girl) references girl (id);
alter table girl add foreign key (boy) references boy (id);
alter table boy_fiance add foreign key (boy) references boy (id);
alter table boy_fiance add foreign key (fiance) references fiance (id);

-- INSERTS
insert into fatherInLaw (haristyle,necklace,asocial)
	values
			('Long curly hair','1','0');

insert into friend (glassesModel,thirdTime,extroverted,firstTime,fatherInLaw)
	values
			('Ray Ban','2021-01-01','0','2022-12-31','1');

insert into fiance (bracelet,hairColor,coin,lipa,indiferent)
	values
			('2','Blond','45.784','875.4','0'),
			(null,'Brown','5.74','85.49','1'),
			('9','Black','1545.084','8741.05501','1');


insert into boy (indiferent,cardigan,asocial)
	values
			('0','Blue cotton cardigan','0'),
			('0','Black baby cardigan','1'),
			('1','Thin gray cardigan','1');

insert into boy_fiance (boy,fiance)
	values
			(1,1);

insert into girl (dress,secondTime,skirt,bracelet,introverted,TShirt,boy)
	values
			('Long black dress','2020-01-01','Short leather black skirt','4','0','AC/DC fan T-shirt',1),
			('Long white dress','2021-08-06','Long cotton black skirt','4','0','Hello Kitty',1),
			('Wedding dress','2020-11-29','Denim skirt','4','0','Youtube Fan',1);

insert into enemy (TShirt,dress,lipa,glassesModel,kuna,jmbag,girl)
	values
			('Tattered black','Fancy yellow','10.5','Tomato','178.61','77784599886',1),
			('Elephant','Green long','7.91','Romato','78.61','52874155823',2),
			('Pikachu','Pink','45.11','Torbato','1078.61','02365410851',3);

insert into brother (skirt,necklace,asocial,enemy)
	values
			('Scottish skirt','6','0',1);

update friend set thirdTime='2020-04-30';

delete from brother where necklace <>14;

select skirt from girl where secondTime is null;

select a.coin, f.enemy, e.dress
from fiance a 
inner join boy_fiance b			on b.fiance=a.id
inner join boy c				on b.boy=c.id
inner join girl d				on d.boy=c.id
inner join enemy e				on e.girl=d.id
inner join brother f			on f.enemy=e.id
where d.secondTime is not null and c.cardigan like '%ba%'
order by e.dress desc;

select c.cardigan, c.asocial 
from boy c inner join boy_fiance b on b.boy=c.id;