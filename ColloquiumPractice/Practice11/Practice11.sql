USE master;
DROP DATABASE IF EXISTS Practice11;
GO
CREATE DATABASE Practice11;
GO
USE Practice11;

CREATE TABLE enemy(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	bracelet INT NOT NULL,
	coins DECIMAL(12,8) NOT NULL,
	haircolor VARCHAR(39) NOT NULL,
	density DECIMAL(14,10),
	introverted INT NOT NULL,
	asocial BIT 
);

CREATE TABLE man(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	marks DECIMAL(16,5),
	coins DECIMAL(13,10),
	earing INT,
	bracelet INT NOT NULL,
	density DECIMAL(12,6),
	enemy INT NOT NULL
);

CREATE TABLE youngMan(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	necklace INT NOT NULL,
	hairstyle VARCHAR(35),
	secondTime DATETIME NOT NULL,
	pants VARCHAR(41) NOT NULL
);

CREATE TABLE fatherInLaw(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	jmbag CHAR(11),
	kuna DECIMAL(16,5) NOT NULL,
	cardigan VARCHAR(45) NOT NULL
);

CREATE TABLE fatherInLaw_youngMan(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	fatherInLaw INT NOT NULL,
	youngMan INT NOT NULL
);

CREATE TABLE motherInLaw(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	bracelet INT NOT NULL,
	socks VARCHAR(39) NOT NULL,
	dress VARCHAR(31),
	fatherInLaw INT NOT NULL
);

CREATE TABLE girl(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	shortTShirt VARCHAR(45) NOT NULL,
	ring INT,
	extroverted BIT NOT NULL,
	TShirt VARCHAR(42) NOT NULL,
	introverted BIT NOT NULL,
	motherInLaw INT 
);

CREATE TABLE secondMotherInLaw(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	socks VARCHAR(33)  NOT NULL,
	secondTime DATETIME,
	TShirt VARCHAR(40) NOT NULL,
	dress VARCHAR(30) NOT NULL,
	hairColor VARCHAR(37) NOT NULL,
	girl INT NOT NULL
);

--RELATIONS 
ALTER TABLE man ADD FOREIGN KEY (enemy) REFERENCES enemy (id);
ALTER TABLE fatherInLaw_youngMan ADD FOREIGN KEY (fatherInLaw) REFERENCES fatherInLaw (id);
ALTER TABLE fatherInLaw_youngMan ADD FOREIGN KEY (youngMan) REFERENCES youngMan (id);
ALTER TABLE motherInLaw ADD FOREIGN KEY (fatherInLaw) REFERENCES fatherInLaw (id);
ALTER TABLE girl ADD FOREIGN KEY (motherInLaw) REFERENCES motherInLaw (id);
ALTER TABLE secondMotherInLaw ADD FOREIGN KEY (girl) REFERENCES girl (id);

--INSERTS

INSERT INTO enemy (bracelet,coins,haircolor,density,introverted,asocial)
	VALUES
			(78,'11.4','Brown','15.7',1,1);

INSERT INTO man (marks,coins,earing,bracelet,density,enemy)
	VALUES
			('14.55','41.87',1006,1005787,'1.4',1);

INSERT INTO youngMan (necklace,hairstyle,secondTime,pants)
	VALUES
			(13,'Short hair','2005-11-28','Black pants');

INSERT INTO fatherInLaw (jmbag,kuna,cardigan)
	VALUES
			('11155544487','8.7','Black cardigan'),
			('33567894512','147.8','White cardigan'),
			('00214596364','7.8','Gray cardigan');

INSERT INTO fatherInLaw_youngMan (fatherInLaw,youngMan)
	VALUES
			(1,1),
			(2,1),
			(3,1);

INSERT INTO motherInLaw (bracelet,socks,dress,fatherInLaw)
	VALUES
			(4,'Black socks','Long baby blue dress',1),
			(404,'White socks','Summer dress',2),
			(14,'Indian socks','Long black dress',3);

INSERT INTO girl (shortTShirt,ring,extroverted,TShirt,introverted,motherInLaw)
	VALUES
			('Black T-Shirt',549,0,'Adidas',0,1),
			('Pink T-Shirt',54,1,'Adidasler',1,2),
			('White T-Shirt',5,0,'Abibas',1,3);

INSERT INTO secondMotherInLaw (socks,secondTime,TShirt,dress,hairColor,girl)
	VALUES	
			('Anabela socks','1997-01-15','Nike','Short black dress','Black',1);

UPDATE man SET coins = 15.70;

DELETE FROM secondMotherInLaw WHERE secondTime='2019-04-08';

SELECT dress FROM secondMotherInLaw WHERE  socks like '%ana%';

SELECT a.secondTime, f.dress, e.ring 
FROM youngMan a inner join fatherInLaw_youngMan b ON b.youngMan=a.id
inner join fatherInLaw c ON b.fatherInLaw=c.id
inner join motherInLaw d ON d.fatherInLaw=c.id
inner join girl e	     ON e.motherInLaw=d.id
inner join secondMotherInLaw f ON f.girl=e.id
WHERE d.socks like 'a%' and c.kuna <> 21
ORDER BY e.ring DESC;

SELECT c.kuna, c.cardigan
FROM fatherInLaw c
WHERE c.id not in (SELECT id FROM fatherInLaw_youngMan); 




