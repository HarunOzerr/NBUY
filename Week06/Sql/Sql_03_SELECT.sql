
--USE HastaneDb
--SELECT * FROM Bolumler

--USE HastaneDb
--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad as 'Ad Soyad',adres as Adres FROM Doktorlar

---------------------FÝLTRELEME---------------------
--SELECT * FROM Doktorlar WHERE id=5 --id'si 5 olan doktoru listele.
--SELECT * FROM Doktorlar WHERE adSoyad = 'Tuna Sefer' --adSoyad tuna sefer olan kiþiyi listele.
--SELECT * FROM Doktorlar WHERE adSoyad != 'Tuna Sefer' --adSoyad tuna sefer olmayan kiþileri listele.
--SELECT * FROM Doktorlar WHERE NOT adSoyad = 'Tuna Sefer' --üsttekinin farký yazýlmýþ hali != veya NOT olarak.
--SELECT * FROM Doktorlar WHERE id = 3 or id=6
--SELECT * FROM Doktorlar WHERE bolumId = 5 AND adres = 'Ýzmir' -- bolumId 5 olanlarý ve adresi izmir olanlarý listele.
--SELECT * FROM Doktorlar WHERE id >= 6 --id'si 6'dan büyük olanlarý listele.

-- -----------------------LÝSTELEME---------------------------------
--SELECT * FROM Doktorlar WHERE adres IN ('ÝSTANBUL', 'ANKARA') --adres'in içinde istanbul ve ankara olanlarý listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 't%' --adSoyad'ýnda ilk harfi t olup geri kalanlarý ne olursa olsun listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'tut%' --adSoyad'ýnýn ilk 3 harfi tut olanlarý listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%Evgar' --adSoyad'ý evgar ile bitenleri listeler.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%c%' --adSoyad'ýnda c harfi geçenleri listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%' --adSoyad'ýnda 2. harfi e olanlarý listele.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'd_m%' --adSoyad'ýnda ilk harfi d 3. harfi m olanlarý listele.

-- -------------------SIRALAMA------------------------
--SELECT * FROM Doktorlar ORDER BY adSoyad -- adSoyad'larý alfabetik olarak sýralar.
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC --adSoyad'larý alfabetik olarak tersten sýralar.
--SELECT * FROM Doktorlar ORDER BY bolumId DESC --bolumId'leri büyükten küçüðe sýralar.
--SELECT * FROM Doktorlar ORDER BY adres
--SELECT * FROM Doktorlar ORDER BY adres, adSoyad

-- -------------------HESAPLAMA------------------------
USE KutuphaneDb
--SELECT * FROM Kitaplar
--SELECT MIN(sayfaSayisi) AS 'En Az Sayfa Sayýsý' FROM Kitaplar
--SELECT MAX(sayfaSayisi) AS 'En Yüksek Sayfa Sayýsý' FROM Kitaplar
--SELECT COUNT(*) FROM Kitaplar --Toplam kayýt sayýsýný gösterir.

USE HastaneDb
--SELECT COUNT(*) FROM Doktorlar
--SELECT COUNT(bolumId) FROM Doktorlar --bolumId si dolu olan kayýtlarý gösterir.

USE KutuphaneDb
--SELECT AVG(sayfaSayisi) as 'Ortalama Sayfa Sayýsý' from Kitaplar
--SELECT SUM(stok) as 'Ortalama Stok Adeti' FROM Kitaplar
--SELECT SUM(stok * sayfaSayisi) FROM Kitaplar

-- ---------------------STRING-------------------------
USE HastaneDb
--SELECT LEN('HARUN ÖZER') AS 'Toplam Karakter Uzunluðu'
--SELECT adSoyad, LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--	adSoyad,
--	LEFT(adSoyad,3) as 'Ýlk 3 Karakter',
--	LEN(adSoyad) as 'Uzunluk'
--FROM Doktorlar

--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'BÜYÜK',
--	LOWER(adSoyad) as 'küçük'
--FROM Doktorlar

--SELECT
--	REPLACE('Harun Özer', 'n', 'Merhaba')

--SELECT
--	LOWER(REPLACE('Harun Özer', ' ', '')) + '@benimfirmam.com'

--SELECT
--	adSoyad,
--	REPLACE(LOWER(adSoyad), ' ', '') + '@firma.com'  as 'Mail Adresi'
--FROM Doktorlar

--Sercan Furkan adýnda, Amasyada yaþayan, bölümü 3 olan doktoru
--kaydedecek sorguyu yazýnýz.
--INSERT INTO Doktorlar VALUES
--	('Sercan Furkan', 'Amasya', 3)

------------------GÜNCELLEME----------------------------
--UPDATE Doktorlar SET adSoyad = 'Sercan Ahmet Furkan'
--WHERE id = 12 --id'si 12 olan kiþinin adSoyad deðiþtirir.

--UPDATE Doktorlar SET adSoyad = 'Al Sana Yeni Ýsim' --Doktorlar tablosundaki bütün adSoyadlarý deðiþtirir.


--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi * 1.2

----------------------SÝLME------------------------
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id = 6

USE HastaneDb
DELETE FROM Doktorlar WHERE bolumId IS NULL