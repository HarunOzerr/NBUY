--Satýþ bilgilerini tutan bir tablo yapacaðýz.
USE SampleDb

CREATE TABLE Satislar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	urunId INT NOT NULL ,
	calisanId INT NOT NULL,
	adet INT NOT NULL,
	fiyat MONEY NOT NULL,
	tarih DATETIME NOT NULL,
	FOREIGN KEY(urunId) REFERENCES Urunler(id),
	FOREIGN KEY(calisanId) REFERENCES Calisanlar(id)
)

/*
	Date: Sadece tarih bilgisi verir.
	DateTime: Tarih saat bilgisi verir.
	DateTime(2): Ölçülü ve ince zaman hesaplamalarý yapýlmasý için kullanýlabilir.
	SmallDateTime:Hassasiyet saat dakika bazýnda verir, yani DateTime(2)den daha az hassastýr.
*/