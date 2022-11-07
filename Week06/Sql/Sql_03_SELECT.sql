
--USE HastaneDb
--SELECT * FROM Bolumler

--USE HastaneDb
--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad as 'Ad Soyad',adres as Adres FROM Doktorlar

---------------------F�LTRELEME---------------------
--SELECT * FROM Doktorlar WHERE id=5 --id'si 5 olan doktoru listele.
--SELECT * FROM Doktorlar WHERE adSoyad = 'Tuna Sefer' --adSoyad tuna sefer olan ki�iyi listele.
--SELECT * FROM Doktorlar WHERE adSoyad != 'Tuna Sefer' --adSoyad tuna sefer olmayan ki�ileri listele.
--SELECT * FROM Doktorlar WHERE NOT adSoyad = 'Tuna Sefer' --�sttekinin fark� yaz�lm�� hali != veya NOT olarak.
--SELECT * FROM Doktorlar WHERE id = 3 or id=6
--SELECT * FROM Doktorlar WHERE bolumId = 5 AND adres = '�zmir' -- bolumId 5 olanlar� ve adresi izmir olanlar� listele.
--SELECT * FROM Doktorlar WHERE id >= 6 --id'si 6'dan b�y�k olanlar� listele.

-- -----------------------L�STELEME---------------------------------
--SELECT * FROM Doktorlar WHERE adres IN ('�STANBUL', 'ANKARA') --adres'in i�inde istanbul ve ankara olanlar� listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 't%' --adSoyad'�nda ilk harfi t olup geri kalanlar� ne olursa olsun listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'tut%' --adSoyad'�n�n ilk 3 harfi tut olanlar� listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%Evgar' --adSoyad'� evgar ile bitenleri listeler.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%c%' --adSoyad'�nda c harfi ge�enleri listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%' --adSoyad'�nda 2. harfi e olanlar� listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'd_m%' --adSoyad'�nda ilk harfi d 3. harfi m olanlar� listele.

-- -------------------SIRALAMA------------------------
--SELECT * FROM Doktorlar ORDER BY adSoyad -- adSoyad'lar� alfabetik olarak s�ralar.
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC --adSoyad'lar� alfabetik olarak tersten s�ralar.
--SELECT * FROM Doktorlar ORDER BY bolumId DESC --bolumId'leri b�y�kten k����e s�ralar.
--SELECT * FROM Doktorlar ORDER BY adres
--SELECT * FROM Doktorlar ORDER BY adres, adSoyad

-- -------------------HESAPLAMA------------------------
USE KutuphaneDb
--SELECT * FROM Kitaplar
--SELECT MIN(sayfaSayisi) AS 'En Az Sayfa Say�s�' FROM Kitaplar
--SELECT MAX(sayfaSayisi) AS 'En Y�ksek Sayfa Say�s�' FROM Kitaplar
--SELECT COUNT(*) FROM Kitaplar --Toplam kay�t say�s�n� g�sterir.

USE HastaneDb
--SELECT COUNT(*) FROM Doktorlar
--SELECT COUNT(bolumId) FROM Doktorlar --bolumId si dolu olan kay�tlar� g�sterir.

USE KutuphaneDb
--SELECT AVG(sayfaSayisi) as 'Ortalama Sayfa Say�s�' from Kitaplar
--SELECT SUM(stok) as 'Ortalama Stok Adeti' FROM Kitaplar
--SELECT SUM(stok * sayfaSayisi) FROM Kitaplar

-- ---------------------STRING-------------------------
USE HastaneDb
--SELECT LEN('HARUN �ZER') AS 'Toplam Karakter Uzunlu�u'
--SELECT adSoyad, LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--	adSoyad,
--	LEFT(adSoyad,3) as '�lk 3 Karakter',
--	LEN(adSoyad) as 'Uzunluk'
--FROM Doktorlar

--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'B�Y�K',
--	LOWER(adSoyad) as 'k���k'
--FROM Doktorlar

--SELECT
--	REPLACE('Harun �zer', 'n', 'Merhaba')

--SELECT
--	LOWER(REPLACE('Harun �zer', ' ', '')) + '@benimfirmam.com'

--SELECT
--	adSoyad,
--	REPLACE(LOWER(adSoyad), ' ', '') + '@firma.com'  as 'Mail Adresi'
--FROM Doktorlar

--Sercan Furkan ad�nda, Amasyada ya�ayan, b�l�m� 3 olan doktoru
--kaydedecek sorguyu yaz�n�z.
--INSERT INTO Doktorlar VALUES
--	('Sercan Furkan', 'Amasya', 3)

------------------G�NCELLEME----------------------------
--UPDATE Doktorlar SET adSoyad = 'Sercan Ahmet Furkan'
--WHERE id = 12 --id'si 12 olan ki�inin adSoyad de�i�tirir.

--UPDATE Doktorlar SET adSoyad = 'Al Sana Yeni �sim' --Doktorlar tablosundaki b�t�n adSoyadlar� de�i�tirir.


--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi * 1.2

----------------------S�LME------------------------
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id = 6

USE HastaneDb
DELETE FROM Doktorlar WHERE bolumId IS NULL