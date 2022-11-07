-- Sayfa sayýsý 300den büyük eþit olan kitaplarý listeleyin.
USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300

--stok adedi 90-113 arasýndakileri listeleyin.
--SELECT * FROM Kitaplar WHERE stok >= 90 and stok <= 300
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113

-- Sayfa sayýsý en çok olandan en az olana doðru sýralayalým.
--SELECT * FROM Kitaplar ORDER BY sayfaSayisi DESC

-- Türe göre küçükten büyüðe sýralayalým.
SELECT * FROM Kitaplar ORDER BY turId, sayfaSayisi DESC

