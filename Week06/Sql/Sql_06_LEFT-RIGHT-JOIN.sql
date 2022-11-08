USE Northwind
--SELECT * 
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID = O.CustomerID

-------------------------LEFT JOIN----------------------------
-- Customers tablosundaki kay�tlar�n tamam�n� getirir. Orders tablosundan da e�le�enleri getirir.
-- Yani LEFT JOIN sol tablodaki kay�tlar�n tamam�n� getirir. Sa�daki tablodanda e�le�enleri getirir.
-- Where ko�ulu verek sadece OrderID'si NULL olanlar� getirtiyoruz
--SELECT C.CompanyName 
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

-- RIGHT JOIN sa� tablodaki kay�tlar�n tamam�n� getirir. Soldaki tablodan da e�le�enleri getirir.
--SELECT C.CompanyName 
--FROM Orders O RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--Hen�z hi� sat�lmam�� �r�nler
--Select P.ProductName, OD.ProductID
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE OD.ProductID IS NULL

--Hen�z sat�� yapamam�� �al��anlar� listeleyin.
Select E.FirstName+ ' ' +  E.LastName AS 'Ad Soyad'
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID = O.EmployeeID
WHERE O.EmployeeID IS NULL