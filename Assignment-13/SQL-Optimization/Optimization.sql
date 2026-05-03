

USE Assignment13DB;


SELECT *
FROM Employees
WHERE EmployeeName = 'Shivam';



SELECT EmployeeId,
       EmployeeName,
       Department
FROM Employees
WHERE EmployeeName = 'Shivam';



CREATE INDEX idx_name
ON Employees(EmployeeName);


DELIMITER $$

CREATE PROCEDURE GetEmployeeByCity
(
    IN cityName VARCHAR(50)
)
BEGIN

    SELECT EmployeeId,
           EmployeeName,
           Department
    FROM Employees
    WHERE City = cityName;

END $$

DELIMITER ;


CALL GetEmployeeByCity('Pune');



EXPLAIN
SELECT *
FROM Employees
WHERE EmployeeName = 'Shivam';