CREATE DATABASE SirketDb
GO

USE SirketDb

CREATE TABLE Departmanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL
)

--Departmanlar tablosuna ad ekliyoruz.
INSERT INTO Departmanlar(ad) VALUES ('Muhasebe'),('Teknik'),('Satýþ'),('ÝK'),('Yönetim')

/*
	Ýsci, Muhasebe Uzmaný, Satýþçý, ÝK Uzmaný, ÝK Stajyeri, Yönetici, Yönetici Yardýmcýsý
*/

USE SirketDb
CREATE TABLE Unvanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL
)

INSERT INTO Unvanlar(ad) VALUES
	('Ýþçi'),
	('Muhasebe Uzmaný'),
	('Satýþçý'),
	('ÝK Uzmaný'),
	('ÝK Stajyeri'),
	('Yönetici'),
	('Yönetici Yardýmcýsý')



USE SirketDb
CREATE TABLE Iller (
	id CHAR(2) NOT NULL PRIMARY KEY,
	ad NVARCHAR(MAX) NOT NULL
)

INSERT INTO Iller(id, ad) VALUES
	('34', 'Ýstanbul'),
	('06', 'Ankara'),
	('35', 'Ýzmir'),
	('58', 'Sivas'),
	('41', 'Ýzmit')



USE SirketDb
CREATE TABLE Ilceler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL,
	ilId CHAR(2) NOT NULL,
	FOREIGN KEY(ilId) REFERENCES Iller(id)
)

INSERT INTO Ilceler (ad, ilId) VALUES
	('Kadýköy', '34'),
	('Beþiktaþ', '34'),
	('Avcýlar', '34'),
	('Konak', '35'),
	('Yenimahalle', '06'),
	('Çankaya', '06'),
	('Suþehri', '58')



USE SirketDb
CREATE TABLE Personeller(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(25) NOT NULL,
	soyad NVARCHAR(25) NOT NULL,
	cinsiyet BIT NOT NULL,
	dogumTarihi DATE NOT NULL,
	ikametgahIlceId INT NOT NULL,
	iseBaslamaTarihi DATE NOT NULL,
	departmanId INT NOT NULL,
	unvanId INT NOT NULL,
	maas MONEY NOT NULL,
	FOREIGN KEY(ikametgahIlceId) REFERENCES Ilceler(id),
	FOREIGN KEY(departmanId) REFERENCES Departmanlar(id),
	FOREIGN KEY(unvanId) REFERENCES Unvanlar(id)
)

INSERT INTO Personeller(ad, soyad, cinsiyet, dogumTarihi, ikametgahIlceId, iseBaslamaTarihi, departmanId, unvanId, maas) VALUES
	('Alican','Kabak',0,'1999-05-15',1,'2021-11-10',1,3,12500),
	('Harun','Özer',0,'1999-05-15',2,'2021-11-10',2,2,16879),
	('Sude','Ýpçeken',1,'1999-05-15',3,'2021-11-10',3,1,4560),
	('Yaþar','Gülenyüz',0,'1999-05-15',4,'2021-11-10',4,7,7861),
	('Kemal','Ekþisurat',0,'1999-05-15',5,'2021-11-10',5,6,3259),
	('Zeliha','Güler',1,'1999-05-15',6,'2021-11-10',1,5,4893),
	('Arda','Tepe',0,'1999-05-15',7,'2021-11-10',2,4,94321),
	('Kadriye','Güner',1,'1999-05-15',1,'2021-11-10',3,3,47654),
	('Fatih','Canöz',0,'1999-05-15',2,'2021-11-10',4,2,32147),
	('Selçuk','Taþ',0,'1999-05-15',3,'2021-11-10',5,1,14963)



USE SirketDb
CREATE TABLE Projeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	baslamaTarihi DATE NOT NULL,
	planlananBitisTarihi DATE NOT NULL
)

INSERT INTO Projeler(ad, baslamaTarihi, planlananBitisTarihi) VALUES
	('Mutlu Çocuklar', '2022-05-05', '2022-08-05'),
	('Temiz Üsküdar', '2022-05-05', '2022-08-05'),
	('Kirli Kadýköy', '2022-05-05', '2022-08-05'),
	('Haydi Gençler Elele', '2022-05-05', '2022-08-05')
