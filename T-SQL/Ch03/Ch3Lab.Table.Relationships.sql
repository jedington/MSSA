-- Lab
SELECT * FROM Sales.Orders

SELECT * FROM Sales.OrderDetails WHERE orderid = 10255;

SELECT * FROM Production.Categories

SELECT * FROM Production.Products WHERE categoryid = 1;

SELECT * FROM Sales.Customers

SELECT * FROM Sales.Orders WHERE custid = 1;


-- Ex
SELECT * FROM Production.Products

SELECT * FROM Sales.OrderDetails WHERE productid = 1;

SELECT * FROM Production.Suppliers

SELECT * FROM Production.Products WHERE supplierid = 6;

SELECT * FROM Sales.Shippers

SELECT * FROM Sales.Orders WHERE shipperid = 2;