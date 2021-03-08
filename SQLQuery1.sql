select * from Customers;
SELECT CompanyName,City FROM Customers;
select distinct companyName, city from Customers;
select * from customers where Country ='Mexico';
select * from customers where City In ('paris','London');
select * from Products where UnitPrice = 15;
select * from Products where UnitPrice > 15;
select * from Products where UnitPrice < 15;
select * from Products where UnitPrice >= 15;
select * from Products where UnitPrice <= 15;
select * from Products where UnitPrice <> 15;
select * from Products where UnitPrice between 45 and 60;
select * from Customers where Country='Germany' AND City='Berlin' or PostalCode = '12208';
SELECT * FROM Customers WHERE City='Berlin' OR City='München';
select * from customers where not Country = 'Germany';
select * from customers where Country = 'Germany' and (City = 'Berlin' or City = 'München');
SELECT * FROM Customers WHERE NOT Country='Germany' AND NOT Country='USA';
select * from customers order by Country desc;
SELECT * FROM Customers ORDER BY Country asc, CompanyName;
INSERT INTO Customers (CustomerID, CompanyName, ContactName, Address, City, PostalCode, Country) VALUES ('Yahya','Yahya', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Turkey');
select * from Customers where CustomerID = 'Yahya';
SELECT Region, ContactTitle FROM Customers WHERE Region IS NULL;
SELECT * FROM Customers WHERE Region is NULL;
SELECT CompanyName, ContactName, Address FROM Customers WHERE Address IS not NULL;
UPDATE Customers SET ContactName = 'Yahya Schmidt', City= 'Bursa' WHERE CustomerID = 'Yahya';
UPDATE Customers SET CompanyName='Meryem Ana Holding', ContactName ='Yahya Erdoğan', ContactTitle = 'Müdür', Address = 'Nilüfer 16', 
Region ='Marmara', PostalCode = '16050', Phone = '0697 987 45 23', Fax = '0897 676 34 12' where City = 'Bursa';
SELECT TOP 2 PERCENT * FROM Customers;
SELECT TOP 3 * FROM Customers WHERE Country='Turkey';
select * from Products;
select min(UnitPrice) as smallestPrice from Products;
select max(UnitPrice) as largestPrice from Products;
SELECT COUNT(ProductID) FROM Products;
SELECT AVG(UnitPrice) FROM Products;
SELECT SUM(Quantity) FROM [Order Details];
select* from [Order Details]
SELECT * FROM Customers WHERE CompanyName LIKE 'm%';
SELECT * FROM Customers WHERE CompanyName LIKE '%g';
SELECT * FROM Customers WHERE ContactName LIKE '%ah%';
SELECT * FROM Customers WHERE ContactName LIKE '%_h%';
SELECT * FROM Customers WHERE ContactName LIKE '%a_%';
SELECT * FROM Customers WHERE ContactName LIKE 'y%n';
SELECT * FROM Customers WHERE City LIKE 'ber%';
SELECT * FROM Customers WHERE Country IN ('Germany', 'France', 'UK');
SELECT * FROM Customers WHERE Country IN ('turkey');
SELECT * FROM Customers WHERE Country IN (SELECT Country FROM Suppliers);
SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 20 AND CategoryID NOT IN (1,2,3);
select * from products where CategoryID between  1 and 2;
select * from products where CategoryID not between  1 and 2;
select * from Products where ProductName not between 'Bardak' and 'Süslü bardak' order by ProductName desc; 
select * from Orders where OrderDate BETWEEN '1996-07-01' AND '1996-07-31';
SELECT CustomerID AS [Id Numarası], ContactName AS Müşteri FROM Customers;
SELECT CustomerID AS "Id Numarası", ContactName AS Müşteri FROM Customers;
SELECT ContactName as "Müşteri Adı", Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS "Adres Bilgisi" FROM Customers;
SELECT o.OrderID, o.OrderDate, o.ShipAddress, c.Country, c.CompanyName FROM Customers AS c, Orders AS o WHERE c.CompanyName='Around the Horn' AND c.CustomerID=o.CustomerID;
select * from Customers where CompanyName ='Around the Horn';
select * from Orders where CustomerID ='Arout';
SELECT ContactName as "Müşteri Adı", Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS "Adres Bilgisi" FROM Customers where CustomerID ='Arout';
SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate FROM Orders INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;
select * from Customers where CompanyName ='Hanari Carnes';
select * from Orders where CustomerID ='Hanar';
SELECT ContactName as "Müşteri Adı", Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS "Adres Bilgisi" FROM Customers where CustomerID ='Hanar';
SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate FROM Orders full outer JOIN Customers ON Orders.CustomerID=Customers.CustomerID;
SELECT Orders.OrderID, Customers.CompanyName FROM Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;
SELECT Orders.OrderID, Customers.CustomerName, Shippers.ShipperName FROM ((Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID) INNER JOIN Shippers ON Orders.ShipperID = Shippers.ShipperID);  --Üç tabloyu birleştirmek amç
select * from Shippers;
SELECT Orders.OrderID, Employees.LastName, Employees.FirstName FROM Orders RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID ORDER BY Orders.OrderID desc;
SELECT Customers.CompanyName, Orders.OrderID FROM Customers LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID ORDER BY Customers.CompanyName;
SELECT Customers.ContactName, Orders.OrderID FROM Customers FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID ORDER BY Orders.OrderDate;
SELECT A.ContactName AS CustomerName1, B.ContactName AS CustomerName2, A.City FROM Customers A, Customers B WHERE A.CustomerID <> B.CustomerID AND A.City = B.City ORDER BY A.City;
SELECT City FROM Customers UNION SELECT City FROM Suppliers ORDER BY City;
SELECT City FROM Customers UNION ALL SELECT City FROM Suppliers ORDER BY City;
SELECT City, Country FROM Customers WHERE Country='Germany' UNION SELECT City, Country FROM Suppliers WHERE Country='Germany' ORDER BY City;
SELECT City, Country FROM Customers WHERE Country='Germany' UNION ALL SELECT City, Country FROM Suppliers WHERE Country='Germany' ORDER BY City;
SELECT 'Customer' AS Type, ContactName, City, Country FROM Customers UNION SELECT 'Supplier', ContactName, City, Country FROM Suppliers;
SELECT Customers.CompanyName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders LEFT JOIN Customers ON Orders.CustomerID = Customers.CustomerID GROUP BY CompanyName;
SELECT COUNT(CustomerID) as "Müşteri Saysısı", Country FROM Customers GROUP BY Country order by count (Country) asc;
select * from Customers where Country ='Turkey';
SELECT COUNT(CustomerID), Country FROM Customers GROUP BY Country ORDER BY COUNT(CustomerID)  DESC;
SELECT COUNT(CustomerID), Country FROM Customers GROUP BY Country HAVING COUNT(CustomerID) > 5;
SELECT COUNT(CustomerID), Country FROM Customers GROUP BY Country HAVING COUNT(CustomerID) < 5 ORDER BY COUNT(CustomerID) DESC;
SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders FROM (Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID) GROUP BY LastName HAVING COUNT(Orders.OrderID) > 10;
SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID WHERE LastName = 'Davolio' OR LastName = 'Fuller' GROUP BY LastName HAVING COUNT(Orders.OrderID) > 10;
SELECT CompanyName, SupplierID FROM Suppliers WHERE EXISTS (SELECT ProductName FROM Products WHERE Products.SupplierID = Suppliers.supplierID AND UnitPrice< 20);
SELECT CompanyName FROM Suppliers WHERE EXISTS (SELECT ProductName FROM Products WHERE Products.SupplierID = Suppliers.supplierID AND UnitPrice = 24);
SELECT ProductName FROM Products WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity = 54);
select * from Products where ProductName = 'Chartreuse verte';
SELECT ProductName FROM Products WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] where Quantity > 99 );
SELECT ProductName FROM Products WHERE ProductID = ALL (SELECT ProductID FROM [Order Details] WHERE Quantity = 69);
SELECT OrderID, Quantity,
CASE
    WHEN Quantity > 30 THEN 'The quantity is greater than 30'
    WHEN Quantity = 30 THEN 'The quantity is 30'
    ELSE 'The quantity is under 30'
END AS QuantityText
FROM [Order Details];
SELECT CompanyName, City, Country
FROM Customers
ORDER BY
(CASE
    WHEN City IS NULL THEN Country
    ELSE City
END);
SELECT ProductName, UnitPrice * (UnitsInStock + UnitsOnOrder) FROM Products;
SELECT ProductName, UnitPrice * (UnitsInStock + ISNULL(UnitsOnOrder, 0)) FROM Products;
--CREATE PROCEDURE SelectAllCustomers AS SELECT * FROM Customers GO;
EXEC SelectAllCustomers;

/*Select all the columns
of all the records
in the Customers table:*/
SELECT * FROM Customers;

/*SELECT * FROM Customers;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM Categories;*/
SELECT * FROM Suppliers;

SELECT CompanyName, /*City,*/ Country FROM Customers;
SELECT * FROM Customers WHERE (CompanyName LIKE 'L%' OR CompanyName LIKE 'R%' /*OR CompanyName LIKE 'S%' OR CompanyName LIKE 'T%'*/ OR CompanyName LIKE 'W%') AND Country='USA' ORDER BY CompanyName;


select p.productName as 'Ürün Adı', sum(od.Quantity * od.Unitprice) as 'Her Bir Üründen Kazanılan Miktar' from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID group by ProductName /*order by ProductName asc*/;

CREATE DATABASE testDB;





