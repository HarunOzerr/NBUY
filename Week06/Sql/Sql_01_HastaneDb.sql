USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO
-- Üst taraf varsa HastaneDb'yi silip yeniden oluþturur.
-- Yoksa zaten oluþturur.

USE HastaneDb
GO --Üstte belirtilen kod tamamlanmadan alt satýra geçmemesi için.

--HASTALAR TABLOSU
CREATE TABLE Hastalar(
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	adres NVARCHAR(50),
	telefon CHAR(11),
)
GO

INSERT INTO Hastalar(adSoyad, cinsiyet, adres) VALUES
	('Erencan Germirli', 'E', 'Ýstanbul'),
	('Selin Fergenç', 'K', 'Ankara'),
	('Sadi Kuloðlu', 'E', 'Ýzmir'),
	('Neþe Kalabalýk', 'K', 'Ýstanbul'),
	('Sevda Aðalar', 'K', 'Ýzmir'),
	('Nora Taþkesen', 'K', 'Ankara'),
	('Emma Çetoðlu', 'K', 'Ýstanbul'),
	('Kerem Sözcü', 'E', 'Ankara'),
	('Suat Tartar', 'E', 'Ýzmir')
GO

--BOLUMLER TABLOSU
CREATE TABLE Bolumler (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)

INSERT INTO Bolumler VALUES --Girilebilecek her alana veri giriþi yapmak istiyorsak parantez içinde belirtmek zorunda deðiliz
	('Dahiliye'), ('Nöroloji'), ('Ortopedi'),
	('Diþ'), ('Periodontoloji'), ('Genel Cerrahi')
GO

CREATE TABLE Doktorlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50),
	bolumId INT,
	FOREIGN KEY(bolumId) REFERENCES Bolumler(id)
)
GO
INSERT INTO Doktorlar VALUES
	('Ali Can', 'Ýstanbul', 1),
	('Demet Evgar', 'Bursa ', 2),
	('Sedat Kanar', 'Ýstanbul', 3),
	('Ferhunde Haným', 'Ýzmir', 1),
	('Zafer Kimki', 'Ankara', 2),
	('Hale Elveren', 'Ýstanbul', 3),
	('Tuna Sefer', 'Ankara', 4),
	('Kevser Tutku', 'Ýstanbul', 4),
	('Tutkum Kapýþmak', 'Ýzmir', 5),
	('Ýsa Canova', 'Ýzmir', 5),
	('Tuðçe Bölümsüz', 'Ýzmir', NULL)
GO

--Yukarýdaki INSERT INTO'nun son satýrýnýn alternatifi burasý:
--INSERT INTO Doktorlar(adSoyad, adres) VALUES
--	('Tuðçe Bölümsüz', 'Ýzmir')
--GO

