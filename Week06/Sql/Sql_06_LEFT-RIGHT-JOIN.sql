USE Northwind
--SELECT * 
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID = O.CustomerID

-------------------------LEFT JOIN----------------------------
-- Customers tablosundaki kayýtlarýn tamamýný getirir. Orders tablosundan da eþleþenleri getirir.
-- Yani LEFT JOIN sol tablodaki kayýtlarýn tamamýný getirir. Saðdaki tablodanda eþleþenleri getirir.
-- Where koþulu verek sadece OrderID'si NULL olanlarý getirtiyoruz
--SELECT C.CompanyName 
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

-- RIGHT JOIN sað tablodaki kayýtlarýn tamamýný getirir. Soldaki tablodan da eþleþenleri getirir.
--SELECT C.CompanyName 
--FROM Orders O RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--Henüz hiç satýlmamýþ ürünler
--Select P.ProductName, OD.ProductID
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE OD.ProductID IS NULL

--Henüz satýþ yapamamýþ çalýþanlarý listeleyin.
Select E.FirstName+ ' ' +  E.LastName AS 'Ad Soyad'
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID = O.EmployeeID
WHERE O.EmployeeID IS NULL