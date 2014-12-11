use TelerikAcademy
--task 4: Write a SQL query to find all information about all departments (use "TelerikAcademy" database).

select * 
from Departments

-------------------------------------------------------------------------------------

--task 5: Write a SQL query to find all department names.

select Name
from Departments

-------------------------------------------------------------------------------------

--task 6: Write a SQL query to find the salary of each employee.

select FirstName + ' ' + LastName as Employee, Salary
from Employees	

-------------------------------------------------------------------------------------

--task 7: Write a SQL to find the full name of each employee.

select FirstName + ' ' + MiddleName + ' ' + LastName as Fullname
from Employees

-------------------------------------------------------------------------------------

--task 8: Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

select FirstName + '.' + LastName + '@telerik.com' as [Full Email Addresses]
from Employees

-------------------------------------------------------------------------------------

--task 9: Write a SQL query to find all different employee salaries.

select 
	distinct Salary
from Employees

-------------------------------------------------------------------------------------

--task 10: Write a SQL query to find all information about the employees whose job title is “Sales Representative“.

select *
from Employees
where JobTitle = 'Sales Representative'

-------------------------------------------------------------------------------------

--task 11: Write a SQL query to find the names of all employees whose first name starts with "SA".

select FirstName + ' ' + LastName as Name
from Employees
where FirstName like 'SA%'

-------------------------------------------------------------------------------------

--task 12: Write a SQL query to find the names of all employees whose last name contains "ei".

select FirstName + ' ' + LastName as Name
from Employees
where LastName like '%ei%'

-------------------------------------------------------------------------------------

--task 13: Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

select FirstName + ' ' + LastName as Name, Salary
from Employees
where Salary between 20000 and 30000

-------------------------------------------------------------------------------------

--task 14: Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

select FirstName + ' ' + LastName as Name, Salary
from Employees
where Salary in (25000, 14000, 12500, 23600)

-------------------------------------------------------------------------------------

--task 15: Write a SQL query to find all employees that do not have manager

select FirstName + ' ' + LastName as [Employee with no manage]
from Employees
where ManagerID is null

-------------------------------------------------------------------------------------

--task 16: Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.

select FirstName + ' ' + LastName as Name, Salary
from Employees
where Salary > 50000
order by Salary desc

-------------------------------------------------------------------------------------

--task 17: Write a SQL query to find the top 5 best paid employees.

select top 5 FirstName + ' ' + LastName as [Top 5 Best Paid Employees], Salary
from Employees
order by Salary desc

-------------------------------------------------------------------------------------

--task 18: Write a SQL query to find all employees along with their address. Use inner join with ON clause.

select e.FirstName + ' ' + e.LastName as Name, a.AddressText
from Employees e
	inner join Addresses a
		on e.AddressID = a.AddressID

-------------------------------------------------------------------------------------

--task 19: Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).

select e.FirstName + ' ' + e.LastName as Name, a.AddressText
from Employees e, Addresses a
where e.AddressID = a.AddressID

-------------------------------------------------------------------------------------

--task 20: Write a SQL query to find all employees along with their manager.

select e.FirstName + ' ' + e.LastName as [Employee Name], m.EmployeeID as [Manager ID], m.FirstName + ' ' + m.LastName as [Manager Name]
from Employees e 
	inner join Employees m
		on e.ManagerID = m.EmployeeID

-------------------------------------------------------------------------------------

--task 21: Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.

select e.FirstName + ' ' + e.LastName as [Employee Name], 
	a.AddressText,
	m.EmployeeID as [Manager ID], m.FirstName + ' ' + m.LastName as [Manager Name]
from Employees e 
	inner join Addresses a
		on e.AddressID = a.AddressID
	inner join Employees m
		on e.ManagerID = m.EmployeeID

-------------------------------------------------------------------------------------

--task 22: Write a SQL query to find all departments and all town names as a single list. Use UNION.

select Name
from Departments
union
select Name
from Towns

-------------------------------------------------------------------------------------

--task 23: Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

--Right Outer Join
select e.FirstName + ' ' + e.LastName as [Employee Name],
	m.FirstName + ' ' + m.LastName as [Manager Name]
from Employees e 
	right outer join Employees m
		on e.ManagerID = m.EmployeeID

--Left Outer Join
select e.FirstName + ' ' + e.LastName as [Employee Name],
	m.FirstName + ' ' + m.LastName as [Manager Name]
from Employees e 
	left outer join Employees m
		on e.ManagerID = m.EmployeeID

-------------------------------------------------------------------------------------

--task 24: Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.

select e.FirstName + ' '+ e.LastName as [Employee Name], year(e.HireDate) as [Hire Year], d.Name
from Employees e
	inner join Departments d 
	on e.DepartmentID = d.DepartmentID
where d.Name in ('Sales','Finance') and year(e.HireDate) between 1995 and 2005
order by year(e.HireDate)