/* Entity Frame Wor Scaffold scripts 

Scaffold Syntax - 
Scaffold-DbContext [-Connection] [-Provider] [-OutputDir] [-Context] [-Schemas>] [-Tables>] 
                    [-DataAnnotations] [-Force] [-Project] [-StartupProject] [<CommonParameters>]

Scaffold-DbContext "Server=localhost;Database=Linq;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir EntitiesModels

*/


Create table Department(
DepartmentId numeric(18,0) primary key Identity(1,1),
DepartmentName  varchar(100)
)


Create table Employee (
EmployeeId numeric(18,0) primary key Identity(1,1),
Name  varchar(100),
Age int,
DepartmentId numeric(18,0) foreign key references Department(DepartmentId),
)

Create table Accounts (
AccountId numeric(18,0) primary key Identity(1,1),
EmployeeId numeric(18,0) foreign key references Employee(EmployeeId),
Salary numeric(18,0)
)


select * from Employee 
select * from Department 
select * from Accounts