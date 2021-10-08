-- Answer 1a
SELECT categoryid, categoryname, description
	FROM Production.Categories
	ORDER BY categoryname ASC;

-- Answer 1b
SELECT C.categoryid, C.categoryname, C.description, P.productname, P.unitprice
	FROM Production.Categories AS C
		INNER JOIN Production.Products AS P
		ON C.categoryid = P.categoryid
	ORDER BY C.categoryname;

---------------------------------------------------------------
---------------------------------------------------------------

-- Answer 2a
SELECT productid, productname, supplierid, unitprice
	FROM Production.Products
	WHERE productname LIKE N'%A%Z%' 
		OR productname LIKE N'%Z%A%';

-- Answer 2b
SELECT P.productid, P.productname, P.supplierid, S.companyname 
	FROM Production.Products AS P
		INNER JOIN Production.Suppliers AS S
		ON P.supplierid = S.supplierid
	WHERE P.productname LIKE N'%A%Z%' 
		OR P.productname LIKE N'%Z%A%';

---------------------------------------------------------------
---------------------------------------------------------------

-- Answer 3a
SELECT supplierid, companyname, country, postalcode, phone
	FROM Production.Suppliers
	ORDER BY supplierid ASC;

-- Answer 3b
SELECT S.supplierid, S.companyname, S.country, S.postalcode, S.phone, P.productname
	FROM Production.Suppliers AS S
		INNER JOIN Production.Products AS P
		ON S.supplierid = P.supplierid
	WHERE P.discontinued = 0
	ORDER BY supplierid ASC;

---------------------------------------------------------------
---------------------------------------------------------------

-- Answer 4
SELECT O.orderid, O.custid, O.orderdate, C.companyname, C.contactname
	FROM Sales.Orders AS O
		INNER JOIN Sales.Customers AS C
		ON O.custid = C.custid
	WHERE C.contacttitle = 'Owner';