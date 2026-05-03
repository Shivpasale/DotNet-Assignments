using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public double CalculateSalary()
    {
        return Salary;
    }
}

class EmployeePrinter
{
    public void PrintEmployee(Employee emp)
    {
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Salary: " + emp.CalculateSalary());
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Name = "Shivam";
        emp.Salary = 20000;

        EmployeePrinter printer = new EmployeePrinter();
        printer.PrintEmployee(emp);
    }
}