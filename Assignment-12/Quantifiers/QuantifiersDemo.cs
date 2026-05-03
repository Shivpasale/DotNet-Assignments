using System;
using System.Linq;

public class QuantifiersDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== QUANTIFIERS =====");

        var students = StudentData.GetStudents();

        // Check if any student has Marks < 35
        bool anyFail = students.Any(s => s.Marks < 35);

        // Check if any student is from Mumbai
        bool anyMumbai = students.Any(s => s.City == "Mumbai");

        // Check if all students have Marks >= 50
        bool allPass50 = students.All(s => s.Marks >= 50);

        // Check if all students have non-empty Name
        bool allNames = students.All(s => !string.IsNullOrEmpty(s.Name));

        Console.WriteLine("Any Student Failed (<35): " + anyFail);

        Console.WriteLine("Any Student From Mumbai: " + anyMumbai);

        Console.WriteLine("All Students Have Marks >= 50: " + allPass50);

        Console.WriteLine("All Students Have Names: " + allNames);
    }
}