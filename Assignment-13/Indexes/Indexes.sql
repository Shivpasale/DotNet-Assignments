USE Assignment13DB;


CREATE INDEX idx_employee_name
ON Employees(EmployeeName);


CREATE INDEX idx_department_city
ON Employees(Department, City);


SHOW INDEXES FROM Employees;

SELECT *
FROM Employees
WHERE EmployeeName = 'Shivam';