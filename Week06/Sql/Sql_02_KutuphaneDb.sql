/*
1) KutuphaneDb adýnda bir veri tabaný oluþturunuz.
2) Veritabanýnda aþaðýdaki tablolar bulunsun:
	Turler id, ad
	Yazarlar id,ad, soyad, cinsiyet, yas
	YayinEvleri id,ad,adres
	Uyeler id,adsoyad
	Kitaplar id,ad,yayinEvi,yazar,tur
	OduncIslemleri uyeId,kitapId,verilmeTarih,getirmeTarih
3) Yeteri kadar örnek veri giriþi de yapýnýz.
*/

USE master
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb

-- TURLER TABLOSU
CREATE TABLE Turler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)
GO
INSERT INTO Turler VALUES
	 ('Genel'), ('Dünya Klasikleri'), ('Aþk'), ('Roman'), ('Psikoloji'),
	('Gençlik'), ('Tarih')
GO


CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	dogumTarihi DATE NOT NULL,
)
GO
INSERT INTO Yazarlar VALUES
	('Ömer Seyfettin', 'E', '02-28-1882'),
	('Özdemir Asaf', 'E', '06-11-1923'),
	('Namýk Kemal', 'E', '12-21-1840'),
	('Orhan Veli Kanýk', 'E', '04-13-1914'),
	('Mehmet Akif Ersoy', 'E', '12-20-1873')
GO

CREATE TABLE YayinEvleri (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50) NOT NULL
)
GO
INSERT INTO YayinEvleri VALUES
	('Pegasus Yayýnlarý', 'Baþakþehir Mah'),
	('Harun Yayýnlarý', 'Baþakþehir Mahallesi '),
	('Özden Yayýnlarý', 'Atatürk Bulvarý'),
	('Garip Yayýnlarý', 'Beþiktaþ Mah'),
	('Özer Yayýnlarý', 'Baþakþehir Mahalle')
GO

CREATE TABLE Uyeler (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
)
GO
INSERT INTO Uyeler VALUES
	('Harun Özer', 'E'), ('Mert Muslu', 'E'), ('Doðan Akduman', 'E'), ('Emre Bozkurt', 'E'),
	('Rýdvan Haseken', 'E'), ('Gonca Güner', 'K')
GO

--id,ad,yayinEvi,yazar,tur
CREATE TABLE Kitaplar (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	yayinEviId INT NOT NULL,
	yazarId INT,
	turId INT DEFAULT 1 NOT NULL,
	FOREIGN KEY(yayinEviId) REFERENCES YayinEvleri(id) ON DELETE CASCADE,
	FOREIGN KEY (yazarId) REFERENCES Yazarlar(id) ON DELETE SET NULL,
	FOREIGN KEY (turId) REFERENCES Turler(id) ON DELETE SET DEFAULT
)
--ON DELETE CASCADE: silmenin default hali. Eðer iliþkilendirilmiþ bir key ise silmeye izin vermez.
--ON DELETE SET DEFAULT o key'e default bir deðer atayýp silebiliriz.
--ON DELETE SET NULL silinen yere null deðeri atar.
GO
INSERT INTO Kitaplar VALUES
	('Perili Köþk', 1, 1, 6),
	('Yalnýz Efe', 2, 1, 5),
	('Lavinia', 3, 2, 2),
	('Vatan yahut Silistre', 5, 3, 6),
	('Hatýralar', 4, 5, 3)
GO

CREATE TABLE OduncIslemleri (
	uyeId INT NOT NULL,
	kitapId INT NOT NULL,
	verilmeTarihi DATE,
	teslimTarihi DATE,
	FOREIGN KEY(uyeId) REFERENCES Uyeler(id),
	FOREIGN KEY(kitapId) REFERENCES Kitaplar(id)
)
GO
INSERT INTO OduncIslemleri VALUES
	(1, 1, '11-07-2022', '11-17-2022'),
	(2, 2, '11-07-2022', '11-17-2022'),
	(3, 3, '11-07-2022', '11-17-2022'),
	(4, 4, '11-07-2022', '11-17-2022'),
	(5, 5, '11-07-2022', '11-17-2022'),
	(6, 1, '11-07-2022', '11-17-2022')