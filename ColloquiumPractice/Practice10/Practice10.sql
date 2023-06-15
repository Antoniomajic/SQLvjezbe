USE master;
DROP DATABASE IF EXISTS Practice10;
GO
CREATE DATABASE Practice10;
GO
USE Practice10;

CREATE TABLE fiance(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	thirdTime DATETIME,
	firstTime DATETIME,
	skirt VARCHAR(32) NOT NULL,
	euro DECIMAL(16,10)
);

CREATE TABLE sister(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	skirt VARCHAR(46) NOT NULL,
	eyeColor VARCHAR(49),
	indifferent BIT,
	sweatshirt VARCHAR(32) NOT NULL,
	secondTime DATETIME,
	firstTime DATETIME NOT NULL,
	fiance INT
);

CREATE TABLE enemy(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	density DECIMAL(15,10) NOT NULL,
	sweatshirt VARCHAR(32) NOT NULL,
	marks DECIMAL(15,7),
	hairstyle VARCHAR(49) NOT NULL
);

CREATE TABLE fatherInLaw(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	lipa DECIMAL(15,9),
	euro DECIMAL(15,10) NOT NULL,
	hairstyle VARCHAR(37) NOT NULL
);

CREATE TABLE fatherInLaw_enemy(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	fatherInLaw INT NOT NULL,
	enemy INT NOT NULL
);

CREATE TABLE motherInLaw(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	euro DECIMAL(17,9),
	socks VARCHAR(43),
	kuna DECIMAL(13,9),
	TShirt VARCHAR(30),
	introverted BIT NOT NULL,
	fatherInLaw INT
);

CREATE TABLE youngMan(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	pants VARCHAR(48) NOT NULL,
	lipa DECIMAL(18,6),
	hairstyle VARCHAR(35) NOT NULL,
	ring INT,
	marks DECIMAL(12,6) NOT NULL,
	motherInLaw INT
);

CREATE TABLE woman(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	marks DECIMAL(13,9) NOT NULL,
	TShirt VARCHAR(45),
	indifferent BIT,
	firstTime DATETIME,
	youngMan INT 
);


--RELATIONS
ALTER TABLE sister ADD FOREIGN KEY (fiance) REFERENCES fiance (id);
ALTER TABLE woman ADD FOREIGN KEY (youngMan) REFERENCES youngMan (id);
ALTER TABLE youngMan ADD FOREIGN KEY (motherInLaw) REFERENCES motherInLaw (id);
ALTER TABLE motherInLaw ADD FOREIGN KEY (fatherInLaw) REFERENCES fatherInLaw (id);
ALTER TABLE fatherInLaw_enemy ADD FOREIGN KEY (fatherInLaw) REFERENCES  fatherInLaw (id);
ALTER TABLE fatherInLaw_enemy ADD FOREIGN KEY (enemy) REFERENCES enemy (id);

--INSERTS
INSERT INTO fiance (thirdTime,firstTime,skirt,euro)
	VALUES
			('2015-12-12','1997-01-01','Short skirt','458.661');

INSERT INTO sister (skirt,eyeColor,indifferent,sweatshirt,secondTime,firstTime,fiance)
	VALUES 
			('Short skirt','Blue',1,'Adidas','2007-01-09','2005-06-18',1);

INSERT INTO enemy (density,sweatshirt,marks,hairstyle)
	VALUES
			('154.77','Nike','450.11','Short hair'),
			('15.707','Bike','5.11','Long hair'),
			('14.7','Cike','45.1','Curly hair');

INSERT INTO fatherInLaw (lipa,euro,hairstyle)
	VALUES
			('457','51','Short hair'),
			('4','510','Medium short hair'),
			('57','1','Long hair');

INSERT INTO fatherInLaw_enemy (fatherInLaw,enemy)
	VALUES
			(1,1),
			(2,2),
			(3,3);

INSERT INTO motherInLaw (euro,socks,kuna,TShirt,introverted,fatherInLaw)
	VALUES
			('457.66','Grey socks','777.51','Blue T-Shirt',0,1),
			('57.66','Gay socks','7.51','Gray T-Shirt',1,3),
			('45.66','Groovy socks','77.51','Black T-Shirt',0,2);

INSERT INTO youngMan (pants,lipa,hairstyle,ring,marks,motherInLaw)
	VALUES
			('Blue pants','1','Short hair',501,'44.61',1),
			('Black pants','471','Wavy hair',5,'404.61',2),
			('Gray pants','100','Long hair',null,'4.61',3);

INSERT INTO woman (marks,TShirt,indifferent,firstTime,youngMan)
	VALUES	
			('100.1','Puma',0,'1999-12-12',1);

UPDATE sister SET eyeColor = 'Osijek';

DELETE FROM woman WHERE marks <> 14.81;

SELECT kuna FROM motherInLaw WHERE socks like '%ana%';

SELECT a.marks, f.indifferent, e.lipa
FROM enemy a 
INNER JOIN fatherInLaw_enemy b	ON b.enemy=a.id
INNER JOIN fatherInLaw c		ON c.id=b.fatherInLaw
INNER JOIN motherInLaw d		ON d.fatherInLaw=c.id
INNER JOIN youngMan e			ON e.motherInLaw=d.id
INNER JOIN woman f				ON f.youngMan=e.id
WHERE d.socks like 'a%' AND c.euro <> 22
ORDER BY e.lipa DESC;

SELECT fatherInLaw.euro, fatherInLaw.hairstyle 
FROM fatherInLaw
WHERE id NOT IN (SELECT id FROM fatherInLaw_enemy);




