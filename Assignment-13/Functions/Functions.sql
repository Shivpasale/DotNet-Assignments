
USE Assignment13DB;



DELIMITER $$

CREATE FUNCTION GetAnnualSalary
(
    monthlySalary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)

DETERMINISTIC

BEGIN

    RETURN monthlySalary * 12;

END $$

DELIMITER ;


SELECT 
EmployeeName,
Salary,
GetAnnualSalary(Salary) AS AnnualSalary
FROM Employees;


DELIMITER $$

CREATE FUNCTION CalculateBonus
(
    salary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)

DETERMINISTIC

BEGIN

    RETURN salary * 0.10;

END $$

DELIMITER ;

SELECT
EmployeeName,
Salary,
CalculateBonus(Salary) AS Bonus
FROM Employees;