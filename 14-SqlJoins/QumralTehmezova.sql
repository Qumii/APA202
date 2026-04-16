create database CompanyDB
use CompanyDB

create table Countries(
Id int primary key identity,
[Name] nvarchar(50) not null,
)

create table Cities(
Id int primary key identity,
[Name] nvarchar(50) not null,
CountryId int foreign key references Countries(id)
)


create table Employees(
Id int primary key identity,
[Name] nvarchar(50) not null,
Surname nvarchar(50),
Age int,
Salary decimal(6,2),
Position nvarchar(50),
IsDeleted bit,
CityId int foreign key references Cities(id)
)


select e.Name, e.Surname,c.Name as City, k.Name as Country
from Employees as e
join Cities as c 
on e.CityId = c.Id
join Countries as k 
on c.CountryId = k.Id


select e.Name, e.Surname, k.Name as Country
from Employees as e
join Cities as c 
on e.CityId = c.Id
join Countries as k 
on c.CountryId = k.Id
where e.Salary > 2000;

select e.Name, e.Surname, e.Salary , k.Name as Country
from Employees as e
join Cities as c 
on e.CityId = c.Id
join Countries as k 
on c.CountryId = k.Id
where e.Salary > 2000;


select c.Name as City, k.Name as Country
from Cities as c 
join Countries as k 
on c.CountryId = k.Id


select e.Name, e.Surname,e.Age,e.Position,e.IsDeleted,e.Salary,c.Name as City, k.Name as Country
from Employees as e
join Cities as c 
on e.CityId = c.Id
join Countries as k 
on c.CountryId = k.Id
where e.Position = 'Reseption'


select e.Name, e.Surname,c.Name as City, k.Name as Country
from Employees as e
join Cities as c 
on e.CityId = c.Id
join Countries as k 
on c.CountryId = k.Id
where e.IsDeleted = 1
