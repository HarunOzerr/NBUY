-- Sayfa say�s� 300den b�y�k e�it olan kitaplar� listeleyin.
USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300

--stok adedi 90-113 aras�ndakileri listeleyin.
--SELECT * FROM Kitaplar WHERE stok >= 90 and stok <= 300
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113

-- Sayfa say�s� en �ok olandan en az olana do�ru s�ralayal�m.
--SELECT * FROM Kitaplar ORDER BY sayfaSayisi DESC

-- T�re g�re k���kten b�y��e s�ralayal�m.
SELECT * FROM Kitaplar ORDER BY turId, sayfaSayisi DESC

