
USE Assignment13DB;



CREATE TABLE EmployeeLog
(
    LogId INT PRIMARY KEY AUTO_INCREMENT,
    EmployeeName VARCHAR(100),
    ActionPerformed VARCHAR(50)
);


DELIMITER $$

CREATE TRIGGER BeforeEmployeeInsert
BEFORE INSERT
ON Employees
FOR EACH ROW

BEGIN

    IF NEW.Salary < 0 THEN
        SET NEW.Salary = 0;
    END IF;

END $$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER AfterEmployeeInsert
AFTER INSERT
ON Employees
FOR EACH ROW

BEGIN

    INSERT INTO EmployeeLog(EmployeeName, ActionPerformed)
    VALUES(NEW.EmployeeName, 'INSERTED');

END $$

DELIMITER ;


INSERT INTO Employees(EmployeeName, Department, Salary, City)
VALUES('Rakesh', 'IT', 70000, 'Pune');


SELECT * FROM EmployeeLog;