create database Company
use Company;

create table Employees (
EmployeeID int,
FirstName nvarchar(50),
LastName nvarchar(50),
Email nvarchar(70),
PhoneNumber nvarchar(30),
HireDate date,
JobTitle nvarchar(50),
Salary decimal(10,2),
Department nvarchar(50)
);

insert into Employees(EmployeeID,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department)
values
(1,'Leyla','Hesenova','leyla@h.com','0551233344','2022-03-10','HR Specialist',2200,'HR'),
(2,'Murad','Xelilov','murad@company.az','0502253325','2019-07-21','Developer',3200,'IT'),
(3,'Gulay','Abdullayeva','gulay@ab.com','0553332113','2021-01-15','Accountant',1700,'Finance'),
(4,'Hemid','Babayev','hemid@company.az','0777171777','2023-04-28','System Admin',2700,'IT'),
(5,'Anar','Eliyev','anar@company,az','0102100110','2018-11-07','HR Assistant',1500,'HR')


select * from Employees;

select * from Employees where Salary>2000;

select * from Employees where Department='IT';

select * from Employees order by Salary desc;

select FirstName, Salary from Employees;

select * from Employees where HireDate>'2020-01-01';

select * from Employees where Email like '%company.az%';

select max(Salary) as MaxSalary from Employees;

select min(Salary) as MinSalary from Employees;

select avg(Salary) as AvgSalary from Employees;

select count(*) as TotalEmployees from Employees;

select sum(Salary) as TotalSalary from Employees;

select Department, count(*) as EmployeeCount from Employees group by Department;

select Department, avg(Salary) as AvgSalary from Employees group by Department;

select Department, max(Salary) as MaxSalary from Employees group by Department;

update Employees set Salary = 2800 where EmployeeID=1;

update Employees set Salary = Salary*1.1 where Department='IT';

update Employees set JobTitle = 'HR meneceri' where FirstName='Leyla' and LastName='Hesenova';

delete from Employees where EmployeeID=5;

insert into Employees(EmployeeID,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department)
values(6,'Leman','Agayeva','leman@agayeva.com','0707700770','2022-07-11','Intern',1300,'IT')

delete from Employees where Salary<1500;

select * from Employees where FirstName like '%a%';

select * from Employees where Salary between 2000 and 2500;

select * from Employees where Department in ('Finance','IT');
