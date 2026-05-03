CREATE DATABASE Assignment13DB;

USE Assignment13DB;

CREATE TABLE Employees
(
    EmployeeId INT PRIMARY KEY AUTO_INCREMENT,
    EmployeeName VARCHAR(100),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    City VARCHAR(50)
);


INSERT INTO Employees(EmployeeName, Department, Salary, City)
VALUES
('Shivam', 'IT', 50000, 'Pune'),
('Amit', 'HR', 40000, 'Mumbai'),
('Rahul', 'IT', 60000, 'Delhi'),
('Sneha', 'Finance', 45000, 'Pune'),
('Karan', 'HR', 35000, 'Mumbai');



SELECT * FROM Employees;