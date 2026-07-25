CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO

CREATE TABLE Employees
(
    Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Salary DECIMAL(10,2)
);
GO