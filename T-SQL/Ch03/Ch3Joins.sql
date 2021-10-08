SELECT * FROM HR.Employees;				-- 9 employees

SELECT * FROM Production.Categories;	-- 8 categories

SELECT * FROM Sales.Shippers;			-- 3 shippers

SELECT C.*, S.*
	FROM Production.Categories AS C
		CROSS JOIN Sales.Shippers AS S

SELECT *
	FROM Sales.Orders
	WHERE orderid = 10248
	ORDER BY orderid;

SELECT *
	FROM Sales.Customers
	WHERE custid = 85;

SELECT O.*, C.*
	FROM Sales.Orders AS O
		INNER JOIN Sales.Customers AS C
			ON O.custid = C.custid
	WHERE O.orderid <= 10250;

-- sloppy method (cross join)
SELECT O.*, E.*
	FROM Sales.Orders AS O
		CROSS JOIN HR.Employees AS E
	WHERE O.orderid = 10248
		AND O.empid = E.empid;

-- better method (inner join)
SELECT O.*, E.*
	FROM Sales.Orders AS O
		INNER JOIN HR.Employees AS E
			ON O.empid = E.empid
	WHERE O.orderid <= 10255;

SELECT O.*, S.*
	FROM Sales.Orders AS O
		INNER JOIN Sales.Shippers AS S
			ON O.shipperid = S.shipperid
	WHERE O.orderid <= 10255;

SELECT O.*, C.*, E.empid, E.firstname, E.lastname
	FROM Sales.Orders AS O
		INNER JOIN Sales.Customers AS C
			ON O.custid = C.custid
		INNER JOIN HR.Employees AS E
			ON O.empid = E.empid
	WHERE O.orderid <= 10255;


SELECT O.*, OD.*, S.*, E.empid, E.firstname, E.lastname, C.*
	FROM Sales.Orders AS O
		INNER JOIN Sales.Shippers AS S
			ON O.shipperid = S.shipperid
		INNER JOIN HR.Employees AS E
			ON O.empid = E.empid
		INNER JOIN Sales.Customers AS C
			ON O.custid = C.custid
		INNER JOIN Sales.OrderDetails AS OD
			ON OD.orderid = O.orderid
   WHERE O.orderid <= 10250;

SELECT OD.*, OD.unitprice * OD.qty AS total, E.*, C.*, P.*, O.*
	FROM Sales.OrderDetails AS OD
		INNER JOIN Sales.Orders AS O
			ON OD.orderid = O.orderid
		INNER JOIN Production.Products AS P
			ON OD.productid = P.productid
		INNER JOIN Production.Categories AS C
			ON P.categoryid = C.categoryid
		INNER JOIN HR.Employees AS E
			ON O.empid = E.empid
	WHERE OD.orderid <= 10250
	ORDER BY O.orderid, OD.productid;

SELECT Ord.orderdate, O.*, P.*
	FROM Sales.OrderDetails AS O
		INNER JOIN Production.Products AS P
			ON O.productid = P.productid
		INNER JOIN Sales.Orders AS Ord
			ON Ord.orderid = O.orderid
	WHERE O.productid = 11
	ORDER BY Ord.orderdate;

-- CROSS JOIN		No ON clause
-- INNER JOIN		ON clause required
-- OUTER JOIN		ON clause required
--		LEFT OUTER JOIN
--		RIGHT OUTER JOIN

SELECT C.custid, C.companyname
	FROM Sales.Customers AS C
		INNER JOIN Sales.Orders AS O
			ON C.custid = O.custid
	ORDER BY C.custid, O.orderid; -- 830 orders for customers