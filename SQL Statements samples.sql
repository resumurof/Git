
-- Write a SELECT statement for the Employee table
-- selecting 3 specific columns and using an alias for the table
-- and include aliases for columns as well

SELECT hre.LoginID AS [login], hre.JobTitle AS [Title],hre.HireDate AS [Date Hired]
FROM HumanResources.Employee AS hre;
GO

-- Write a SELECT statement that returns a person's full name in a single column

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name]
FROM Person.Person;
GO

-- Find out how many different types of people are represented in the Person table.

SELECT DISTINCT PersonType
FROM Person.Person;
GO

-- Use the WHERE clause to return only the records in the Employee table where the employees are 
-- married.  This is where we introduce predicates using the WHERE clause to filter rows, not columns

SELECT LoginID, JobTitle, MaritalStatus
FROM HumanResources.Employee
WHERE MaritalStatus  ='M';
GO

-- Use the IN operator to return records from the Person table
-- where the persons' first name is in a range of names 'Fred', 'Mary' and 'George'

SELECT FirstName, LastName
FROM Person.Person
WHERE FirstName IN('Fred', 'Mary', 'George');
GO

-- Use the WHERE clause to return only the records  in the Employee table where the employees are 
-- a manager of some type this example uses the % character for any number of characters

SELECT LoginID, JobTitle
FROM HumanResources.Employee
WHERE JobTitle LIKE '%manager%';
GO

-- Return the city name and the number of addresses in the table that are in each city.  
-- Rename the number of cities column to Totals

SELECT City, COUNT(*) AS Totals
FROM Person.Address
GROUP BY City;
GO

-- Mix aggregates in one query by specifying the function and including the 
-- appropriate field name in the parentheses.
-- Check the MIN, MAX, and SUM of vacation hours along with the SUM of sick 
-- days and the date of the last employee hire

SELECT MIN(VacationHours) AS [MIN Vacation], 
	MAX(VacationHours) AS [MAX Vacation], 
	SUM(VacationHours) AS [SUM Vacation], 
	SUM(SickLeaveHours) AS [SUM SickLeave], 
	MAX(HireDate) AS [Last Hire Date]
FROM HumanResources.Employee;
GO

-- Query the hire date for a value of February 15, 2003 using language neutral format

SELECT LoginID, HireDate
FROM HumanResources.Employee
WHERE HireDate = '20030215';
GO

-- Query the hire date for a value between Jan. 1, 2000 and Dec. 31, 2002

SELECT LoginID, HireDate
FROM HumanResources.Employee
WHERE HireDate BETWEEN '20000101' AND '20021231';
GO

-- Query the hire date field returning only the day portion of the date 
-- using the DATENAME function, but ask for the name of the week day

SELECT DATENAME(WEEKDAY, HireDate)
FROM HumanResources.Employee;
GO

-- Write a SELECT statement that returns a person's full name in a single column 
-- Use the COALESCE function to replace any NULL values in the MiddleName with a space
SELECT FirstName + ' ' + COALESCE(MiddleName,' ') + ' ' + LastName AS [Full Name]
FROM Person.Person;
GO

-- Query for the first and last name of sales people who have had 
-- sales last year that exceeded $2M 

SELECT FirstName, LastName
FROM Person.Person
WHERE BusinessEntityID IN
	(SELECT BusinessEntityID
	FROM Sales.SalesPerson
	WHERE SalesLastYear > 2000000);
GO