USE master;
DROP DATABASE IF EXISTS Practice12;
GO
CREATE DATABASE Practice12;
GO
USE Practice12;

CREATE TABLE woman(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	euro DECIMAL(16,6) NOT NULL,
	indifferent BIT,
	coin DECIMAL(15,6)
);

CREATE TABLE boy(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	pants VARCHAR(46),
	asocial BIT,
	hairstyle VARCHAR(43) NOT NULL,
	indifferent BIT NOT NULL,
	necklace INT,
	woman INT NOT NULL
	);

CREATE TABLE sister(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	lipa DECIMAL(15,9),
	necklace INT,
	shortTShirt VARCHAR(43) NOT NULL
);

CREATE TABLE fiance(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	pants VARCHAR(48) NOT NULL,
	shortTShirt VARCHAR(46) NOT NULL,
	jmbag CHAR(11),
	earing INT 
);

CREATE TABLE fiance_sister(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	fiance INT NOT NULL,
	sister INT NOT NULL
);

CREATE TABLE motherInLaw(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	mark DECIMAL(14,7),
	kuna DECIMAL(15,8),
	cardigan VARCHAR(44),
	asocial BIT NOT NULL,
	extroverted BIT,
	fiance INT
);

CREATE TABLE girl(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	glassesModel VARCHAR(34) NOT NULL,
	cardigan VARCHAR(40) NOT NULL,
	shortTShirt VARCHAR(39) NOT NULL,
	skirt VARCHAR(36) NOT NULL,
	eyeColor VARCHAR(32) NOT NULL,
	ring INT NOT NULL,
	motherInLaw INT NOT NULL
);

CREATE TABLE friend(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	lipa DECIMAL(16,10),
	asocial BIT,
	hairstyle VARCHAR(37),
	kuna DECIMAL(14,6),
	glassesModel VARCHAR(38),
	girl INT
);

ALTER TABLE boy ADD FOREIGN KEY (woman) REFERENCES woman (id);
ALTER TABLE friend ADD FOREIGN KEY (girl) REFERENCES girl (id);
ALTER TABLE girl ADD FOREIGN KEY (motherInLaw) REFERENCES motherInLaw (id);
ALTER TABLE motherInLaw ADD FOREIGN KEY (fiance) REFERENCES fiance (id);
ALTER TABLE fiance_sister ADD FOREIGN KEY (fiance) REFERENCES fiance (id);
ALTER TABLE fiance_sister ADD FOREIGN KEY (sister) REFERENCES sister (id);

--INSERTS
INSERT INTO woman (euro,indifferent,coin)
	VALUES
			('147.2',0,'14.788');

INSERT INTO boy (pants,asocial,hairstyle,indifferent,necklace,woman)
	VALUES	
			('Armani',0,'Brown short hair',0,50,1);

INSERT INTO sister (lipa,necklace,shortTShirt)
	VALUES
			('54.2',415,'Adidas'),
			('5.2',15,'Miami'),
			('504.2',45,'Sis');

INSERT INTO fiance (pants,shortTShirt,jmbag,earing)
	VALUES
			('Black pants','Nike','57412585410',1648),
			('Brown pants','Blue Elephant','58749658210',8),
			('Kaki pants','Abibas','33221144558',68);

INSERT INTO fiance_sister (fiance,sister)
	VALUES
			(1,1),
			(2,2),
			(3,3);

INSERT INTO motherInLaw (mark,kuna,cardigan,asocial,extroverted,fiance)
	VALUES
			('145.8','11.2','Grey cardigan',1,0,1),
			('45.858','18.2','Yellow cardigan',1,0,2),
			('158','169','Green cardigan',1,0,3);

INSERT INTO girl (glassesModel,cardigan,shortTShirt,skirt,eyeColor,ring,motherInLaw)
	VALUES
			('America','Frattelli','Adidas','Brown skirt','Blue',41,1),
			('Ray Ban','Black cardigan','Puma','Yellow skirt','Brown',1,2),
			('Ray San','Tally Walle','Nike','White skirt','Green',4,3);

INSERT INTO friend (lipa,asocial,hairstyle,kuna,glassesModel,girl)
	VALUES
			('41.5',0,'Black long hair','5','Ray ban',3);

UPDATE boy SET asocial = 0;

DELETE FROM friend WHERE asocial=0;

SELECT cardigan FROM motherInLaw WHERE kuna NOT IN (8,13,20,28,35);

SELECT a.shortTShirt, f.kuna, e.cardigan
FROM sister a INNER JOIN fiance_sister b	ON b.sister=a.id
INNER JOIN fiance c							ON c.id=b.fiance
INNER JOIN motherInLaw d					ON d.fiance=c.id
INNER JOIN girl e							ON e.motherInLaw=d.id
INNER JOIN friend f							ON f.girl=e.id
WHERE d.kuna > 87 AND c.shortTShirt like '%ba%'
ORDER BY e.cardigan DESC;

SELECT c.shortTShirt, c.jmbag
FROM fiance c
WHERE id NOT IN (SELECT id FROM fiance_sister);

 

			



