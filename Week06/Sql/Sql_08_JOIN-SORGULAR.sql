USE Northwind

-- Products tablosunda hangi CategoryId'ler geçiyor? Tekrarlamadan tekil hale getirir.
--SELECT DISTINCT CategoryId
--FROM Products

--1) Bugüne kadar hangi ülkere kargo göndermiþiz?
-- Orders tablosunda hangi ShipCountry'ler geçiyor? DISTINCT tekrarlamadan tekil hale getirir.
--SELECT DISTINCT ShipCountry
--FROM Orders

--2) Hangi ülkeye ne kadar satýþ yapmýþýz?
-- GROUP BY, DISTINCT'ten farklý olarak grup halinde getirir ve iþlem yapmamýza olanak saðlar.
--SELECT O.ShipCountry,
--SUM(OD.Quantity * OD.UnitPrice) AS 'Toplam Tutar'
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY Toplam Tutar DESC


---3) En çok satýþ yapýlan üç ülke
--SELECT TOP(3) O.ShipCountry,
--SUM(OD.Quantity * OD.UnitPrice) AS 'Toplam Tutar'
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY Toplam Tutar DESC

--4) Elimizde en çok stoðu bulunan ilk üç ürün
--SELECT TOP(3) ProductName, UnitsInStock
--FROM Products
--ORDER BY UnitsInStock DESC

--5) Hangi kategoride kaç adet ürünümüz var?
-- HAVING ile gruplama yaptýktan sonra sorgu yapabiliriz.
--SELECT C.CategoryName,
--COUNT(*) AS 'Adet'
--FROM Categories C INNER JOIN Products P 
--ON C.CategoryID = P.CategoryID
--GROUP BY C.CategoryName
--HAVING COUNT(*) > 10
--ORDER BY Adet DESC

--6) Hangi üründen kaç tane satýlmýþtýr?
--SELECT P.ProductName,
--COUNT(*) AS 'Adet'
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Adet DESC

--7) En çok kazandýran ilk üç ürün
--SELECT TOP(3) P.ProductName,
--SUM(OD.UnitPrice * OD.Quantity) AS 'Kazanç'
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Kazanç DESC


--8) Hangi kargo þirketine ne kadar ödeme yapýlmýþtýr(Freight)
--SELECT S.CompanyName,
--SUM(Freight) AS 'Yapýlan Ödeme'
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY [Yapýlan Ödeme] DESC

--9)En az ödeme yapýlan kargo þirketi
--SELECT TOP(1) S.CompanyName,
--SUM(Freight) AS 'Yapýlan Ödeme'
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY [Yapýlan Ödeme]

--10) Hangi müþteriye ne kadar tutarýnda satýþ yapýlmýþ?
--SELECT C.CompanyName,
--SUM(OD.Quantity* OD.UnitPrice) AS TOTAL
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID = O.CustomerID
--INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY CompanyName
--ORDER BY TOTAL DESC

--11) Bölgelere göre satýþ tutarlarý
--SELECT R.RegionDescription, SUM(OD.Quantity * OD.UnitPrice) AS Total FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
--INNER JOIN Territories T ON ET.TerritoryID = T.TerritoryID
--INNER JOIN Region R ON T.RegionID = R.RegionID
--INNER JOIN Orders O ON E.EmployeeID = O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY Total DESC

--12) Hangi bölgede, hangi üründen kaç paralýk satýþ yapýlmýþtýr ?
SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity * OD.UnitPrice) AS Total FROM Employees E 
INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
INNER JOIN Territories T ON ET.TerritoryID = T.TerritoryID
INNER JOIN Region R ON T.RegionID = R.RegionID
INNER JOIN Orders O ON E.EmployeeID = O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
INNER JOIN Products P ON OD.ProductID = P.ProductID
GROUP BY R.RegionDescription, P.ProductName
ORDER BY R.RegionDescription, P.ProductName, Total DESC