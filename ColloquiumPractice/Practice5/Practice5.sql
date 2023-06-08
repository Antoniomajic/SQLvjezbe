use master;
drop database if exists Practice5;
go
create database Practice5;
go
use Practice5;

create table fiance(
	id int not null primary key identity(1,1),
	IDNumber char(11),
	lipa decimal(12,8),
	indifferent bit not null
);

create table youngMan(
	id int not null primary key identity(1,1),
	shortTShirt varchar(48) not null,
	dress varchar(30) not null,
	asocial bit,
	fiance int
);

create table girl(
	id int not null primary key identity(1,1),
	socks varchar(41) not null,
	marks decimal(17,10) not null,
	asocial bit,
	cardigan varchar(47) not null
);

create table firstFatherInLaw(
	id int not null primary key identity(1,1),
	hairColor varchar(33),
	TShirt varchar(31),
	socks varchar(31) not null,
	dress varchar(34),
	bracelet int,
	euro decimal(14,5) not null
);

create table firstFatherInLaw_girl(
	id int not null primary key identity(1,1),
	firstFatherInLaw int not null,
	girl int not null
);

create table secondFatherInLaw(
	id int not null primary key identity(1,1),
	sweater varchar(33),
	firstTime datetime not null,
	TShirt varchar(36),
	firstFatherInLaw int not null
);

create table motherInLaw(
	id int not null primary key identity(1,1),
	pants varchar(43) not null,
	earing int not null,
	necklace int,
	cardigan varchar(49) not null,
	glassesModel varchar(31) not null,
	thirdTime datetime not null,
	secondFatherInLaw int not null
);

create table leftBehind(
	id int not null primary key identity(1,1),
	TShirt varchar(33),
	necklace int not null,
	socks varchar(44),
	hairstyle varchar(42),
	motherInLaw int not null
);

alter table leftBehind add foreign key (motherInLaw) references motherInLaw (id);
alter table motherInLaw add foreign key (secondFatherInLaw) references secondFatherInLaw (id);
alter table secondFatherInLaw add foreign key (firstFatherInLaw) references firstFatherInLaw (id);
alter table firstFatherInLaw_girl add foreign key (firstFatherInLaw) references firstFatherInLaw (id);
alter table firstFatherInLaw_girl add foreign key (girl) references girl (id);
alter table youngMan add foreign key (fiance) references fiance (id);

insert into fiance (IDNumber,lipa,indifferent)
	values
			('05841589654','78','0');

insert into youngMan (shortTShirt,dress,asocial,fiance)
	values
			('Adidas','Short blue summer dress','1',1);

insert into girl (socks,marks,asocial,cardigan)
	values
			('Blue socks','87.39','1','Black'),
			('White socks','5.39','1','White'),
			('Simpsons socks','1006.39','0','Cotton yellow');

insert into firstFatherInLaw (hairColor,TShirt,socks,dress,bracelet,euro)
	values
			('Blonde','Mariababel','White socks','Short black dress',2,'96.12'),
			('Brown','NK Varteks','Short socks','Long black dress',3,'1008.12'),
			('Black','Caffe Bar Limenka','White socks','Long white dress',55,'906.12');

insert into secondFatherInLaw (sweater,firstTime,TShirt,firstFatherInLaw)
	values
			('Puma sports','2001-02-05','FC Barcelona Shirt',1),
			('NK Osijek','1981-06-17','Brown Shirt',2),
			('Versace','1999-06-27','Yellow Shirt',3);

insert into motherInLaw (pants,earing,necklace,cardigan,glassesModel,thirdTime,secondFatherInLaw)
	values
			('White pants',3,2,'Blue cardigan','Ray Ban','1977-07-15',1),
			('Black pants',0,18,'White cardigan','Lidl','2007-01-30',2),
			('Short denim pants',8,null,'MOnte Vista cardigan','Armani','2012-12-12',3);

insert into leftBehind (TShirt,necklace,socks,hairstyle,motherInLaw)
	values
			('Summer T-Shirt',4,'Lotto','Long brown hair',1);

insert into firstFatherInLaw_girl (firstFatherInLaw,girl)
	values
			(3,1),
			(3,1),
			(2,2);

update youngMan set dress='Osijek';

delete from leftBehind where necklace=17;

select TShirt from secondFatherInLaw where firstTime is null;

select a.asocial, f.hairstyle, e.earing
from girl a inner join firstFatherInLaw_girl b	on b.girl=a.id
inner join firstFatherInLaw c					on b.firstFatherInLaw=c.id
inner join secondFatherInLaw d					on d.firstFatherInLaw=c.id
inner join motherInLaw e						on e.secondFatherInLaw=d.id
inner join leftBehind f							on f.motherInLaw=e.id
where d.firstTime is not null and c.TShirt like '%ba%'
order by e.earing desc;

select distinct c.TShirt, c.socks
from firstFatherInLaw c inner join firstFatherInLaw_girl b on b.firstFatherInLaw=c.id;








