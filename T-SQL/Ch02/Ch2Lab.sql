--  SELECT *
-- 		FROM Sales.Customers
-- 		WHERE country = 'USA' 
-- 			OR country = 'Canada' 
-- 			OR country = 'Mexico';

-- 1 - Customers in North America
	SELECT *
		FROM Sales.Customers
		WHERE country IN ('USA', 'Mexico', 'Canada');

-- 2 - Orders placed in April, 2015
	SELECT * 
		FROM Sales.Orders
		WHERE orderdate BETWEEN '2015-04-01' AND '2015-04-30';

-- 3 - Cheese sold
	SELECT *
		FROM Production.Products
		WHERE categoryid = 4;

-- 4 - Employees shipped products to Germany
	SELECT DISTINCT empid
		FROM Sales.Orders
		WHERE shipcountry = 'Germany' 
			AND shippeddate LIKE N'%-12-%';

-- 5 - Product 19 orders, customer took discount, with total amount + net amount
	SELECT (unitprice * qty) AS 'Total Amount', (unitprice * qty * (1 - discount)) AS 'Net Amount'
		FROM Sales.OrderDetails
		WHERE productid = 19 
			AND discount != 0.000;

-- 6 - list of employees by title-first-lastname
	SELECT title, firstname, lastname
		FROM HR.Employees;

-- 7 - customers, first name customer rep
	SELECT companyname, 
			--LEN(contactname), 
			--RIGHT(contactname, 10),
			--CHARINDEX(', ', contactname),
			TRIM(RIGHT(contactname, LEN(contactname) - CHARINDEX(', ', contactname))) AS 'Contact'
		FROM Sales.Customers

-- 8 - list of customer contacts alphabetically by last name
	SELECT contactname
		FROM Sales.Customers
		ORDER BY contactname;

-- 9 - dried fruit name
	SELECT productname, productid
		FROM Production.Products
		WHERE categoryid = 7 -- Production.Categories table
			AND discontinued = 1;

-- 10 - days old from DOB
	SELECT DATEDIFF(day, '19940120', GETDATE()) AS 'Days Old'; 