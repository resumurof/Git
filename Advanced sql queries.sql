

USE TSQL2012
GO
select productid,productname, P1.UnitPrice  from Production.Products as P1
where P1.UnitPrice = (select MIN(UnitPrice) from Production.Products as P2 
where P1.productid = P2.productid
GROUP BY productid)

--*********************************************************************
USE AdventureWorks2012
GO
SELECT a.FirstName, a.LastName
FROM Person.Person AS a
where Exists (select * from HumanResources.Employee as b where a.BusinessEntityID = b.BusinessEntityID and LastName = 'Johnson')

--*********************************************************************

SELECT a.FirstName, a.LastName
FROM Person.Person AS a
WHERE a.LastName IN
(SELECT a.LastName
    FROM HumanResources.Employee AS b
    WHERE a.BusinessEntityID = b.BusinessEntityID
    AND a.LastName = 'Johnson');
--*********************************************************************
--To return products and their corresponding list price for all products that have been sold at least once
SELECT p.ProductID, p.ListPrice 
FROM Production.Product AS p 
where EXISTS (select 1 from Sales.SalesOrderDetail as SOD
where SOD.ProductID = p.ProductID)

--Customers who did not place orders since beginning of 2008

USE TSQL2012
GO
select * from Sales.Customers as C
where NOT EXISTS (
select * from Sales.Orders as O where O.custid = C.custid and  orderdate > '2008-01-01 00:00:00.000')
GO
