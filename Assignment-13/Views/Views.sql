USE Assignment13DB;



CREATE VIEW EmployeeBasicView AS

SELECT
EmployeeId,
EmployeeName,
Department
FROM Employees;


SELECT * FROM EmployeeBasicView;



CREATE VIEW EmployeeSalaryView AS

SELECT
Department,
AVG(Salary) AS AverageSalary,
COUNT(*) AS TotalEmployees
FROM Employees
GROUP BY Department;


SELECT * FROM EmployeeSalaryView;