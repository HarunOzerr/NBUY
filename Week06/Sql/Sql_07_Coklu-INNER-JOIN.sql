--Hangi bölgede hangi üründen kaç adet satýþ yapýlmýþtýr?
SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity) AS Adet FROM Employees E
INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
INNER JOIN Territories T ON ET.TerritoryID = T.TerritoryID
INNER JOIN Region R ON T.RegionID = R.RegionID
INNER JOIN Orders O ON E.EmployeeID = O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
INNER JOIN Products P ON OD.ProductID = P.ProductID
GROUP BY R.RegionDescription, P.ProductName
ORDER BY R.RegionDescription, P.ProductName, Adet
