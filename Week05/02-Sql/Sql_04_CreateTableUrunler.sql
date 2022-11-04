USE SampleDb

/*
	Urunler tablosu
	-id
	-ad
	-stokMiktari
	-fiyat
*/

CREATE TABLE Urunler (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(25) NOT NULL,
	stokMiktari INT NOT NULL,
	fiyat MONEY NOT NULL
)