-- EXERCISE 2
-- Should use C or O, or whatever values is after AS.
SELECT C.custid, C.companyname, O.orderid, O.orderdate
	FROM Sales.Customers AS C
		INNER JOIN Sales.Orders AS O
	ON C.custid = O.custid;

-- EXERCISE 3
SELECT C.custid, count(DISTINCT O.orderid) AS numorders, SUM(OD.qty) AS totalqty
	FROM Sales.Customers AS C
		INNER JOIN Sales.Orders AS O
			ON C.custid = O.custid
		INNER JOIN Sales.OrderDetails AS OD
			ON O.orderid = OD.orderid
	WHERE C.country = 'USA'
	GROUP BY C.custid
	ORDER BY C.custid;

-- EXERCISE 4
SELECT C.custid, C.companyname, O.orderid, O.orderdate
	FROM Sales.Customers AS C
		LEFT OUTER JOIN Sales.Orders AS O
			ON C.custid = O.custid
	ORDER BY C.custid, O.orderid;