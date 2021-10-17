-- Ex 3

USE TSQLV4;

-- 5
SELECT C.custid, C.companyname
	FROM Sales.Customers AS C
		LEFT OUTER JOIN Sales.Orders AS O
			ON C.custid = O.custid
	WHERE O.orderid IS NULL
	ORDER BY C.custid;

--6
SELECT C.custid, C.companyname, O.orderid, O.orderdate
	FROM Sales.Customers AS C
		LEFT OUTER JOIN Sales.Orders AS O
			ON C.custid = O.custid
	WHERE orderdate LIKE '2016-02-12';

-- 1-1
SELECT E.empid, E.firstname, E.lastname, N.n
	FROM HR.Employees AS E
		CROSS JOIN dbo.Nums AS N
	WHERE N.n <= 5
	ORDER BY N.n

-- quiz sample 1
SELECT empid, firstname, lastname
	FROM HR.Employees
	ORDER BY lastname;

-- quiz sample 2
SELECT H.empid, H.firstname, H.lastname, O.orderid
	FROM HR.Employees AS H
		INNER JOIN Sales.Orders AS O
		ON H.empid = O.empid
	ORDER BY H.lastname ASC;

-- quiz sample 3
SELECT contactname
	FROM Sales.Customers
	WHERE contactname LIKE N'%PAUL%';

-- quiz sample 4
SELECT C.custid, C.contactname, O.orderid
	FROM Sales.Customers AS C
		INNER JOIN Sales.Orders AS O
		ON C.custid = O.custid
	WHERE C.contactname LIKE N'%PAUL%';

-- quiz sample 5
SELECT shipperid, companyname
	FROM Sales.Shippers
	ORDER BY shipperid;
