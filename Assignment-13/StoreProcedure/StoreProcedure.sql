USE Assignment13DB;


DELIMITER $$

CREATE PROCEDURE GetAllEmployees()
BEGIN
    SELECT * FROM Employees;
END $$

DELIMITER ;


CALL GetAllEmployees();



DELIMITER $$

CREATE PROCEDURE GetEmployeesByDepartment
(
    IN dept VARCHAR(50)
)
BEGIN
    SELECT * 
    FROM Employees
    WHERE Department = dept;
END $$

DELIMITER ;


CALL GetEmployeesByDepartment('IT');