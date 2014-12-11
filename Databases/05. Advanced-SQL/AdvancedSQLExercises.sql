--use TelerikAcademy
--task 1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. Use a nested SELECT statement.

--select FirstName + ' ' + LastName as Name, Salary
--from Employees
--where Salary = (select MAX(Salary) from Employees)

----------------------------------------------------------------------------------------------------
--task 2.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

--select FirstName + ' ' + LastName as Name, Salary
--from Employees
--where Salary <= (select min(Salary) from Employees)*1.1

----------------------------------------------------------------------------------------------------
--task 3.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department. Use a nested SELECT statement.

--select e.FirstName + ' ' + ISNULL(e.MiddleName, '') + ' ' + e.LastName as Name, e.Salary, e.DepartmentID, d.Name
--from Employees e
--	inner join Departments d
--	on e.DepartmentID = d.DepartmentID
--where Salary = 
--	(select min(Salary) from Employees
--		where DepartmentID = e.DepartmentID)

----------------------------------------------------------------------------------------------------
--task 4.Write a SQL query to find the average salary in the department #1.

--select avg(Salary) as [Average Salary in Department 1]
--from Employees
--where DepartmentID = 1

----------------------------------------------------------------------------------------------------
--task 5.Write a SQL query to find the average salary  in the "Sales" department.

--select avg(e.Salary) as [Average Salary in "Sales"]
--from Employees e
--	inner join Departments d
--	on e.DepartmentID = d.DepartmentID
--where d.Name = 'Sales'

----------------------------------------------------------------------------------------------------
--task 6.Write a SQL query to find the number of employees in the "Sales" department.

--select COUNT(e.EmployeeID) as [Number of employees in "Sales"]
--from Employees e
--	inner join Departments d
--	on e.DepartmentID = d.DepartmentID
--where d.Name = 'Sales'

----------------------------------------------------------------------------------------------------
--task 7.Write a SQL query to find the number of all employees that have manager.

--select COUNT(*) as [Number of employees with manager]
--from Employees e
--	inner join Employees m
--	on e.ManagerID = m.EmployeeID

----------------------------------------------------------------------------------------------------
--task 8.Write a SQL query to find the number of all employees that have no manager.

--select COUNT(*) as [Number of employees without manager]
--from Employees e
--where e.ManagerID is null

----------------------------------------------------------------------------------------------------
--task 9.Write a SQL query to find all departments and the average salary for each of them.

--select avg(e.Salary) as [Average Salary], d.Name
--from Employees e
--	inner join Departments d
--	on e.DepartmentID = d.DepartmentID
--group by d.DepartmentID, d.Name

----------------------------------------------------------------------------------------------------
--task 10.Write a SQL query to find the count of all employees in each department and for each town.

--select COUNT(e.EmployeeID) as Number, d.Name as [Department Name], t.Name as [Town Name]
--from Employees e
--	inner join Departments d
--	on e.DepartmentID = d.DepartmentID
--	inner join Addresses a
--	on e.AddressID = a.AddressID
--	inner join Towns t
--	on a.TownID = t.TownID
--group by d.Name, t.Name
--order by Number

----------------------------------------------------------------------------------------------------
--task 11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

--select m.FirstName + ' ' + m.LastName as Name
--from Employees e
--	inner join Employees m
--	on e.ManagerID = m.EmployeeID
--group by m.FirstName, m.LastName
--having COUNT(m.EmployeeID)=5

----------------------------------------------------------------------------------------------------
--task 12.Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

--select e.FirstName + ' ' + e.LastName as [Employee Name], coalesce(m.FirstName + ' ' + m.LastName, 'No manager') as [Manager Name]
--from Employees e
--	left join Employees m
--	on e.ManagerID = m.EmployeeID

----------------------------------------------------------------------------------------------------
--task 13.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

--select FirstName + ' ' + LastName as Name
--from Employees
--where LEN(LastName)=5

----------------------------------------------------------------------------------------------------
--task 14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds". Search in  Google to find how to format dates in SQL Server.

--select convert(nvarchar, GETDATE(), 13) as [Current Date]

----------------------------------------------------------------------------------------------------
--task 15.Write a SQL statement to create a table Users. Users should have username, password, full name and last login time. Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint. Define the primary key column as identity to facilitate inserting records. Define unique constraint to avoid repeating usernames. Define a check constraint to ensure the password is at least 5 characters long.

--create table Users (
--	UserID int identity,
--	Username nvarchar(50) not null,
--	Pass nvarchar(100),
--	Fullname nvarchar(100) not null,
--	LastLogin datetime,
--	constraint PK_Users primary key(UserID),
--	constraint UC_Username unique(Username),
--	constraint CC_Pass check(len(Pass)>=5)
--)
--go

--set identity_insert [dbo].[Users] ON
--go
--insert [dbo].[Users]([UserID], [Username], [Pass], [Fullname], [LastLogin]) VALUES (1, 'milen', '123456', 'Milen Georgiev', getdate())
--go
--insert [dbo].[Users]([UserID], [Username], [Pass], [Fullname], [LastLogin]) VALUES (2, 'pesho', '123456', 'Peter Penkov', CAST('2014-08-24 09:44:44.444' AS DateTime))
--go
--insert [dbo].[Users]([UserID], [Username], [Pass], [Fullname], [LastLogin]) VALUES (3, 'missy', '123456', 'Missy Elliott', getdate())
--go
--set identity_insert [dbo].[Users] off

----------------------------------------------------------------------------------------------------
--task 16.Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. Test if the view works correctly.

--create view [UsersFromToday] as
--select *
--from Users
--where day(LastLogin)=day(getdate())
--go

--select * from UsersFromToday

------------------------------------------------------------------------------------------------------
----task 17.Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). Define primary key and identity column.

--create table Groups(
--	GroupID int identity,
--	GroupName nvarchar(50) not null,
--	constraint PK_Groups primary key(GroupID),
--	constraint UC_Groups unique(GroupName)
--)
--go

------------------------------------------------------------------------------------------------------
----task 18.Write a SQL statement to add a column GroupID to the table Users. Fill some data in this new column and as well in the Groups table. Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

--alter table Users add GroupID int
--go

--set identity_insert [dbo].[Groups] ON
--insert [dbo].[Groups]([GroupID], [GroupName]) VALUES (1, 'Super User')
--insert [dbo].[Groups]([GroupID], [GroupName]) VALUES (2, 'Noob')
--insert [dbo].[Groups]([GroupID], [GroupName]) VALUES (3, 'Guest')
--insert [dbo].[Groups]([GroupID], [GroupName]) VALUES (4, 'User')
--insert [dbo].[Groups]([GroupID], [GroupName]) VALUES (5, 'Administrator')
--go
--set identity_insert [dbo].[Groups] OFF

--update Users set GroupID = 1 where UserID = 1
--update Users set GroupID = 2 where UserID = 2
--update Users set GroupID = 3 where UserID = 3
--update Users set GroupID = 4 where UserID = 4
--update Users set GroupID = 5 where UserID = 5
--go

--alter table Users 
--add constraint FK_Users_Groups
--	foreign key(GroupID)
--	references Groups(GroupID)
--go

------------------------------------------------------------------------------------------------------
----task 19.Write SQL statements to insert several records in the Users and Groups tables.

--set identity_insert [dbo].[Groups] ON
--insert [dbo].[Users] ([UserID], [Username], [Pass], [Fullname], [LastLogin]) VALUES (4, 'Dre', '123456', 'Dr. Dre', CAST(N'2013-08-18 00:00:00.000' AS DateTime))
--go
--insert [dbo].[Users] ([UserID], [Username], [Pass], [Fullname], [LastLogin]) VALUES (5, 'Snoop', '123456', 'Snoop dogg', getdate())
--go
--set identity_insert [dbo].[Groups] OFF

------------------------------------------------------------------------------------------------------
----task 20.Write SQL statements to update some of the records in the Users and Groups tables.

--update Users
--set GroupID =
--	(select GroupID from Groups where GroupName = 'Administrator')
--where Username = 'Dre'
--update Users
--set GroupID =
--	(select GroupID from Groups where GroupName = 'Guest')
--where Username = 'milen'

------------------------------------------------------------------------------------------------------
----task 21.Write SQL statements to delete some of the records from the Users and Groups tables.

--delete from Users
--where Username = 'milen'

--delete from Groups
--where GroupName = 'Noob'

------------------------------------------------------------------------------------------------------
----task 22.Write SQL statements to insert in the Users table the names of all employees from the Employees table. Combine the first and last names as a full name. For username use the first letter of the first name + the last name (in lowercase). Use the same for the password, and NULL for last login time.

--insert into [dbo].[Users](Username, Fullname, Pass, LastLogin)
--select left(lower(e.FirstName),1) + lower(e.LastName) as Username,
--e.FirstName + ' ' + e.LastName as Fullname,
--left(lower(e.FirstName),1) + lower(e.LastName) as Pass, null
--from Employees e
--where(1 + len(e.LastName)) >=5
--and left(lower(e.FirstName),1) + lower(e.LastName) <> 'ahill'
--go

------------------------------------------------------------------------------------------------------
----task 23.Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.

--update [dbo].[Users] set LastLogin = convert(datetime, '01.01.2004', 104)
--where Username = 'pesho'
--go

--update [dbo].[Users] set Pass = null
--where LastLogin <= convert(datetime, '10.03.2010', 104)
--go

------------------------------------------------------------------------------------------------------
----task 24.Write a SQL statement that deletes all users without passwords (NULL password).

--delete from Users
--where Pass is null
--go

------------------------------------------------------------------------------------------------------
----task 25.Write a SQL query to display the average employee salary by department and job title.

--select avg(e.Salary) as [Average Salary], e.JobTitle, d.Name
--from Employees e
--	inner join Departments d
--	on d.DepartmentID = e.DepartmentID
--group by d.Name, e.JobTitle

------------------------------------------------------------------------------------------------------
----task 26.Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

--select ms.Name, ms.JobTitle, ms.MinSalary, emp.FirstName + ' ' + emp.LastName as Name 
--from (select d.Name, d.DepartmentID, e.JobTitle, min(e.Salary) as MinSalary from Employees e
--		inner join Departments d
--		on d.DepartmentID = e.DepartmentID
--		group by d.Name, d.DepartmentID, e.JobTitle) ms
--	inner join Employees emp 
--	on emp.Salary = ms.MinSalary and emp.JobTitle = ms.JobTitle and emp.DepartmentID = ms.DepartmentID

------------------------------------------------------------------------------------------------------
----task 27.Write a SQL query to display the town where maximal number of employees work.

--select t.Name as [Town Name], COUNT(e.EmployeeID) as EmployeeCount 
--from Employees e
--	inner join Addresses a on e.AddressID = a.AddressID
--	inner join Towns t on a.TownID = t.TownID
--group by t.Name
--having COUNT(e.EmployeeID) =
--	(select MAX(c.EmployeeCount) from
--	(select t.Name, COUNT(e.EmployeeID) as EmployeeCount 
--	from Employees e
--		inner join Addresses a on e.AddressID = a.AddressID
--		inner join Towns t on a.TownID = t.TownID
--		group by t.Name) c)

--------------------------------------------------------------------------------------------------------
------task 28.Write a SQL query to display the number of managers from each town.

--select t.Name, count(distinct(e.ManagerID)) as [Manager Name]
--from Employees e
--	inner join Employees m
--	on e.ManagerID = m.EmployeeID
--	inner join Addresses a
--	on e.AddressID = a.AddressID
--	inner join Towns t
--	on a.TownID = t.TownID
--group by t.Name

--------------------------------------------------------------------------------------------------------
------task 29.Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments). Don't forget to define  identity, primary key and appropriate foreign key. 
	--Issue few SQL statements to insert, update and delete of some data in the table.
	--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers. For each change keep the old record data, the new record data and the command (insert / update / delete).

--create table WorkHours(
--	WorkHourEntryID int identity,
--	EntryDate date not null,
--	Task nvarchar(100) not null,
--	EntryHours int not null,
--	EntryComments nvarchar(200),
--	EmployeeID int not null,
--	constraint PK_WorkHourEntryID primary key(WorkHourEntryID),
--	constraint CC_Hours check(EntryHours>0 and EntryHours<=24)
--)
--go

--alter table [dbo].[WorkHours] with check add constraint [FK_WorkHours_Employees] foreign key([EmployeeID])
--references [dbo].[Employees] ([EmployeeID])
--go

---- Work Hours Logs
--create table WorkHoursLogs(
--	LogID int identity,
--	WorkHourEntryIDOld int,
--	EntryDateOld date,
--	TaskOld nvarchar(100),
--	EntryHoursOld int,
--	EntryCommentsOld nvarchar(200),
--	EmployeeIDOld int,
--	WorkHourEntryIDNew int,
--	EntryDateNew date,
--	TaskNew nvarchar(100),
--	EntryHoursNew int,
--	EntryCommentsNew nvarchar(200),
--	EmployeeIDNew int,
--	CommandType nvarchar(10),
--	constraint PK_LogID primary key(LogID)
--)
--go

--create trigger tr_WorkHoursInsert on WorkHours for insert
--as
--insert into WorkHoursLogs (WorkHourEntryIDOld,EntryDateOld,TaskOld,EntryHoursOld,EntryCommentsOld,
--EmployeeIDOld,WorkHourEntryIDNew,EntryDateNew,TaskNew,EntryHoursNew,EntryCommentsNew,
--EmployeeIDNew,CommandType)
--select NULL, NULL, NULL, NULL, NULL, NULL,
--i.WorkHourEntryID, i.EntryDate, i.Task, i.EntryHours, i.EntryComments, i.EmployeeID,'insert'
--from WorkHours w 
--	inner join inserted i 
--	on w.WorkHourEntryID = i.WorkHourEntryID
--go

--create trigger tr_WorkHoursUpdate on WorkHours for update
--as
--insert into WorkHoursLogs (WorkHourEntryIDOld,EntryDateOld,TaskOld,EntryHoursOld,EntryCommentsOld,
--EmployeeIDOld,WorkHourEntryIDNew,EntryDateNew,TaskNew,EntryHoursNew,EntryCommentsNew,
--EmployeeIDNew,CommandType)
--select d.WorkHourEntryID, d.EntryDate, d.Task, d.EntryHours, d.EntryComments, d.EmployeeID,
--i.WorkHourEntryID, i.EntryDate, i.Task, i.EntryHours, i.EntryComments, i.EmployeeID,'update'
--from deleted d
--	inner join inserted i on d.WorkHourEntryID = i.WorkHourEntryID
--go

--create trigger tr_WorkHoursDelete on WorkHours for delete
--as
--insert into WorkHoursLogs (WorkHourEntryIDOld,EntryDateOld,TaskOld,EntryHoursOld,EntryCommentsOld,
--EmployeeIDOld,WorkHourEntryIDNew,EntryDateNew,TaskNew,EntryHoursNew,EntryCommentsNew,
--EmployeeIDNew,CommandType)
--select d.WorkHourEntryID, d.EntryDate, d.Task, d.EntryHours, d.EntryComments, d.EmployeeID,
--NULL, NULL, NULL, NULL, NULL, NULL,'delete'
--from deleted d
--go

--insert into WorkHours (EntryDate, Task, EntryHours, EntryComments, EmployeeID)
--VALUES (CONVERT(date, '20140712', 13), 'Slacking', 8, 'no comment', 1),
--(CONVERT(date, '20140511', 13), 'Digging', 4, NULL, 3),
--(CONVERT(date, '20140713', 13), 'More Slacking', 4, 'work', 1),
--(CONVERT(date, '20140611', 13), 'Working', 12, 'work', 2),
--(CONVERT(date, '20140530', 13), 'Meeting', 5, NULL , 4)
--go

--update WorkHours
--set EntryHours = 8, Task = 'Something important', EntryComments = 'Have no time!'
--where EmployeeID=1 and EntryDate = CONVERT(date, '20140713', 13)
--go

--delete from WorkHours
--where EmployeeID = 4

------------------------------------------------------------------------------------------------------
----task 30.Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. At the end rollback the transaction.

--begin tran
--alter table Departments drop [FK_Departments_Employees]
--delete from Employees
--where DepartmentID = (select DepartmentID from Departments where Name = 'Sales')
--delete from Departments
--where Name = 'Sales'
--rollback tran
--go

------------------------------------------------------------------------------------------------------
----task 31.Start a database transaction and drop the table EmployeesProjects. Now how you could restore back the lost table data?

--begin tran
--drop table EmployeesProjects
--rollback tran
--go

------------------------------------------------------------------------------------------------------
----task 32.Find how to use temporary tables in SQL Server. Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.

--begin tran
--select * into #TempTable 
--from EmployeesProjects
--drop table EmployeesProjects
--commit

--create table [dbo].[EmployeesProjects](
--	[EmployeeID] [int] NOT NULL,
--	[ProjectID] [int] NOT NULL,
--	constraint [PK_EmployeesProjects] primary key clustered
--	(
--		[EmployeeID] asc,
--		[ProjectID] asc
--	)with (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
--) ON [PRIMARY]
--go

--alter table [dbo].[EmployeesProjects] with check add constraint [FK_EmployeesProjects_Employees] foreign key([EmployeeID])
--references [dbo].[Employees] ([EmployeeID])
--go

--alter table [dbo].[EmployeesProjects] check constraint [FK_EmployeesProjects_Employees]
--go

--alter table [dbo].[EmployeesProjects] with check add constraint [FK_EmployeesProjects_Projects] foreign key([ProjectID])
--references [dbo].[Projects] ([ProjectID])
--go

--alter table [dbo].[EmployeesProjects] check constraint [FK_EmployeesProjects_Projects]
--go

--insert into EmployeesProjects
--select * from #TempTable
--go


