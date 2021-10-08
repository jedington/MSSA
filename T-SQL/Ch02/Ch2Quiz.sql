-- Question 1: List all the Customers located in Germany.

SELECT *
	FROM Sales.Customers
	WHERE country = 'Germany';

-- Question 2: Count all the Customers with "Jr." in their name (contactname).

SELECT contactname, COUNT(contactname) AS JrCount
	FROM Sales.Customers
	WHERE contactname LIKE '%Jr.%'
	GROUP BY contactname; --obligatory group by

-- Question 3: What are the three highest priced Products that we sell?

SELECT TOP(3) *
	FROM Production.Products
	ORDER BY unitprice DESC;

-- Question 4: What is the total quantity of all products that were sold?

SELECT sum(qty) AS totalProductsSold --NOT COUNT
	FROM Sales.OrderDetails;

-- Question 5: What were the top 10 products by quantity that were sold?

SELECT TOP(10) productid, SUM(qty) AS qtyCount
	FROM Sales.OrderDetails
	GROUP BY productid
	ORDER BY qtycount DESC;



-- didnt finish the bonuses

-- Extra Credit 1: Give the counts of how many Orders each employee (empid) took - from most orders to least orders.

SELECT COUNT(qty) AS totalProductsSold
	FROM Sales.Orders
	WHERE empid

--SELECT *
--	FROM Sales.Orders

-- Extra Credit 2: What are all the different prices I have charged for product id 11 over the years? I don't care about the dates, I just want a list of the prices.

SELECT DISTINCT productid, unitprice
	FROM Sales.OrderDetails
	WHERE productid = 11
	ORDER BY unitprice ASC;
	
--SELECT *
--	FROM Sales.OrderDetails