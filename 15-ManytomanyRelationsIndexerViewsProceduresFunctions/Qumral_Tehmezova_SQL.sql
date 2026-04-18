create database CompanyMM
use CompanyMM


create table Employees(
EmployeeId int primary key identity,
FirstName nvarchar(50) not null,
LastName nvarchar(50),
BirthDate date check (BirthDate < '2008-01-01'),
Email nvarchar(100) unique
)


create table Projects(
ProjectId int primary key identity,
ProjectName nvarchar(50),
StartDate date,
EndDate date,
check (EndDate is null or EndDate >= StartDate)
)

create table EmployeeProjects(
EmployeeId int,
ProjectId int,
AssignedDate date default (current_date),
primary key (EmployeeId, ProjectId),
foreign key (EmployeeId) references Employees(EmployeeId) on delete cascade,
foreign key (ProjectId) references Projects(ProjectId) on delete cascade
)


select * from Employees
select * from Projects

select e.FirstName,e.LastName, p.ProjectName 
from Employees as e
join EmployeeProjects as ep
on e.EmployeeId = ep.EmployeeId
join Projects as p 
on ep.ProjectId = p.ProjectId

select p.ProjectName, COUNT(ep.EmployeeId) as EmployeesCount
from Projects as p
left join EmployeeProjects as ep
on p.ProjectId = ep.ProjectId
group by p.ProjectName


select e.FirstName, e.LastName, COUNT(ep.ProjectId) as ProjectsCount
from Employees as e
join EmployeeProjects as ep
on e.EmployeeId = ep.EmployeeId
group by e.EmployeeId,e.FirstName,e.LastName
having COUNT(ep.ProjectId)>2


create view EmployeeProjectView as
select e.EmployeeId, e.FirstName + ' ' + e.LastName as FullName, p.ProjectId,p.ProjectName, ep.AssignedDate
from Employees as e
join EmployeeProjects as ep 
on e.EmployeeId = ep.EmployeeId
join Projects as p
on ep.ProjectId = p.ProjectId

select * from EmployeeProjectView where EmployeeId = 1

create procedure sp_AssignEmployeeToProject @empId int , @projId int 
as
begin 
if not exists(
select 1 from EmployeeProjects where EmployeeId = @empId and ProjectId = @projId
)
begin
insert into EmployeeProjects(EmployeeId,ProjectId)
values(@empId,@projId)
end
end



create function fn_GetProjectCount(@empId int) 
returns int 
as
begin 
declare @count int
select @count = COUNT(*) from EmployeeProjects where EmployeeId = @empId
return @count
end


select dbo.fn_GetProjectCount(1) as ProjectsCount


exec sp_AssignEmployeeToProject 5,3

select * from EmployeeProjects where EmployeeId = 5

delete from EmployeeProjects where EmployeeId = 3

