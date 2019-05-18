CREATE DATABASE OrganizationalStructure;
GO

USE OrganizationalStructure;
GO

CREATE TABLE Sections (
ID int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
Name nvarchar (50) NOT NULL,
Code nvarchar (10) UNIQUE NOT NULL,
OrganizationalLevel int NOT NULL,
ManagerID int NULL,
SuperiorSectionID int FOREIGN KEY REFERENCES Sections(ID) NULL
);
GO

CREATE TABLE Employees (
ID int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
FirstName nvarchar (50) NOT NULL,
LastName nvarchar (50) NOT NULL,
Title nvarchar (20) NULL,
Phone nvarchar (20) NOT NULL,
Email nvarchar (100) NOT NULL,
DepartmentCode nvarchar (10) FOREIGN KEY REFERENCES Sections(Code) NULL
);
GO

ALTER TABLE Sections 
ADD FOREIGN KEY (ManagerID) REFERENCES Employees(ID);
GO 