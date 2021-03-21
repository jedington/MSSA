-- 1. What are all of my Products?

SELECT productid, productname
	FROM Production.Products;

-- 2. What are all of my Products . . . in alphabetical order?

SELECT *
	FROM Production.Products
	ORDER BY productname DESC;

-- 3. What are all of my Products . . . in order of category (category id)?

SELECT *
	FROM Production.Products
	ORDER BY categoryid, productname;


-- 4. What are all of my Products . . . in order of price from Highest to Lowest?

SELECT *
	FROM Production.Products
	ORDER BY unitprice DESC;

-- 4B. top 5 highest priced products

SELECT TOP(5) *
	FROM Production.Products
	ORDER BY unitprice DESC;

-- 5. How many products do I sell?

SELECT COUNT(productname)
	FROM Production.Products
	WHERE discontinued < 1;


-- 6. How many products do I sell in each Category (category id)?

SELECT categoryid, COUNT(*) AS total
	FROM Production.Products
	WHERE discontinued = 0
	GROUP BY categoryid;

-- 7. How many products do I sell in each Category in order of category with most number of products down to category with least number of products.

SELECT categoryid, COUNT(*) AS total
	FROM Production.Products
	WHERE discontinued = 0
	GROUP BY categoryid
	ORDER BY total DESC;
	-- 	ORDER BY COUNT(*) DESC;

-- 8. What is the average product price by category. Category 1: average price = $10.02, Category 2: average price = 20.34.

SELECT SUM(unitprice) / COUNT(productid) AS averagePrice, AVG(unitprice), categoryid
	FROM Production.Products
	GROUP BY categoryid;

-- 9. What is the average product price by category - in order of average price from highest to lowest.

--SELECT SUM(unitprice) / COUNT(productid) AS averagePrice, AVG(unitprice), categoryid
	FROM Production.Products
	GROUP BY categoryid
	ORDER BY averagePrice DESC;
	-- ORDER BY AVG(unitprice) DESC;

-- 10. Using a SELECT on the Products table, what are all my different category ids

SELECT DISTINCT categoryid, COUNT(categoryid) AS categoryidCount
	FROM Production.Products
	GROUP BY categoryid;



--1		(20 Points) List all the Customers which have your initials (in order) in their name somewhere.

SELECT contactname
	FROM Sales.Customers
	WHERE contactname LIKE '%E%J%';

--2		(20 Points) How many Customers have your initials (in order) in their name somewhere (contactname)?


SELECT COUNT(contactname) AS contactCount
	FROM Sales.Customers
	WHERE contactname LIKE '%E%J%';

--3		(20 Points) List all the Orders that were shipped to Albuquerque.

SELECT *
	FROM Sales.Orders
	WHERE shipcity = 'Albuquerque';

--4		(20 Points) Give the counts of how many orders were shipped to each country - from most orders to least orders.

SELECT shipcountry, COUNT(orderid) AS orderCount
	FROM Sales.Orders
	GROUP BY shipcountry
	ORDER BY orderCount DESC;

--5		(20 Points) <another query / question goes here>
--6		Extra Credit (5 Points) Give the counts of how many Orders each Customer (custid) placed - from most orders to least orders.

SELECT custid, COUNT(orderid) AS orderCount
	FROM Sales.Orders
	GROUP BY custid
	ORDER BY orderCount DESC;
