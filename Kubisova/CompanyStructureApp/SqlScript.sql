create database CompanyStructureDb
go
use CompanyStructureDb

create table CompanyStructureNode(
NodeId int not null primary key identity(1,1),
CodeOfNode nvarchar(10) not null,
NameOfNode nvarchar(50) not null,
TypeOfNode int not null,
NodeAboveId int null foreign key references CompanyStructureNode(NodeId),
HeadOfNodeId int null,
)

create table Employee(
EmployeeId int not null identity(1,1) primary key,
NodeId int not null foreign key references CompanyStructureNode(NodeId),
Title nvarchar(10) null,
Name nvarchar(30) not null,
Surname varchar(30) not null,
Phone varchar(20) not null,
Email varchar(30) not null,
)

alter table CompanyStructureNode
add foreign key (HeadOfNodeId) references Employee(EmployeeId)