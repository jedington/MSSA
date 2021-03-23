-- Ex SQL Ch 2: Single Table Queries

USE TSQLV4;

------ Exercise 1 -- orders placed from June 2015
SELECT orderid, orderdate, custid, empid
	FROM Sales.Orders
	WHERE orderdate LIKE '2015-06-%%'
	ORDER BY orderid;

------ Exercise 2 -- orders placed on the last day of a month
SELECT orderid, orderdate, custid, empid
	FROM Sales.Orders
	WHERE orderdate = EOMONTH(orderdate)
	ORDER BY orderid;

------ Exercise 3 -- employee last name with E two or more times
SELECT empid, firstname, lastname
	FROM HR.Employees
	WHERE lastname LIKE N'%e%e%';

------ Exercise 4 -- orders with a total value more than qty*unitprice
SELECT orderid, SUM(qty*unitprice) AS Plus10kValue
	FROM Sales.OrderDetails
	GROUP BY orderid
	HAVING SUM(qty*unitprice) > 10000
	ORDER BY Plus10kValue DESC;



----------------------------------------------------- Accidentally did all questions from 93-95.

------ Exercise 5 -- last name starts with lower case letter, collation (Latin1_General_CS_AS)
SELECT empid, lastname
	FROM HR.Employees
	WHERE lastname COLLATE Latin1_General_CS_AS LIKE N'[^A-Z]%';

------ Exercise 6 -- explain difference between two given queries
SELECT empid, COUNT(*) AS numorders -- Query 1
	FROM Sales.Orders
	WHERE orderdate < '20160501'
	GROUP BY empid;
-- WHERE clause takes what is given by FROM and filters 'row(s)'.

SELECT empid, COUNT(*) AS numorders -- Query 2
	FROM Sales.Orders
	GROUP BY empid
	HAVING MAX(orderdate) < '20160501';
-- HAVING clause is reliant on GROUP BY in order to filter 'group(s)'.

------ Exercise 7 -- return three shipped-to countries with highest avg freight in 2015
SELECT TOP (3) shipcountry, AVG(freight) AS HighestAvgFreight
	FROM Sales.Orders
	WHERE orderdate LIKE '2015-%%-%%'
	GROUP BY shipcountry
	ORDER BY HighestAvgFreight DESC;