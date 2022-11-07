/*
1) KutuphaneDb ad�nda bir veri taban� olu�turunuz.
2) Veritaban�nda a�a��daki tablolar bulunsun:
	Turler id, ad
	Yazarlar id,ad, soyad, cinsiyet, yas
	YayinEvleri id,ad,adres
	Uyeler id,adsoyad
	Kitaplar id,ad,yayinEvi,yazar,tur
	OduncIslemleri uyeId,kitapId,verilmeTarih,getirmeTarih
3) Yeteri kadar �rnek veri giri�i de yap�n�z.
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
	 ('Genel'), ('D�nya Klasikleri'), ('A�k'), ('Roman'), ('Psikoloji'),
	('Gen�lik'), ('Tarih')
GO


CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	dogumTarihi DATE NOT NULL,
)
GO
INSERT INTO Yazarlar VALUES
	('�mer Seyfettin', 'E', '02-28-1882'),
	('�zdemir Asaf', 'E', '06-11-1923'),
	('Nam�k Kemal', 'E', '12-21-1840'),
	('Orhan Veli Kan�k', 'E', '04-13-1914'),
	('Mehmet Akif Ersoy', 'E', '12-20-1873')
GO

CREATE TABLE YayinEvleri (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50) NOT NULL
)
GO
INSERT INTO YayinEvleri VALUES
	('Pegasus Yay�nlar�', 'Ba�ak�ehir Mah'),
	('Harun Yay�nlar�', 'Ba�ak�ehir Mahallesi '),
	('�zden Yay�nlar�', 'Atat�rk Bulvar�'),
	('Garip Yay�nlar�', 'Be�ikta� Mah'),
	('�zer Yay�nlar�', 'Ba�ak�ehir Mahalle')
GO

CREATE TABLE Uyeler (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
)
GO
INSERT INTO Uyeler VALUES
	('Harun �zer', 'E'), ('Mert Muslu', 'E'), ('Do�an Akduman', 'E'), ('Emre Bozkurt', 'E'),
	('R�dvan Haseken', 'E'), ('Gonca G�ner', 'K')
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
--ON DELETE CASCADE: silmenin default hali. E�er ili�kilendirilmi� bir key ise silmeye izin vermez.
--ON DELETE SET DEFAULT o key'e default bir de�er atay�p silebiliriz.
--ON DELETE SET NULL silinen yere null de�eri atar.
GO
INSERT INTO Kitaplar VALUES
	('Perili K��k', 1, 1, 6),
	('Yaln�z Efe', 2, 1, 5),
	('Lavinia', 3, 2, 2),
	('Vatan yahut Silistre', 5, 3, 6),
	('Hat�ralar', 4, 5, 3)
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