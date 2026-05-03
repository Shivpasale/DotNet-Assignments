using System;
using System.Linq;

public class FilteringDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== FILTERING =====");

        var students = StudentData.GetStudents();

        // 1. Get all students
        Console.WriteLine("\n--- All Students ---");

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }

        // 2. Students whose Marks > 50
        Console.WriteLine("\n--- Students With Marks > 50 ---");

        var marksAbove50 = students.Where(s => s.Marks > 50);

        foreach (var s in marksAbove50)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }

        // 3. Students with Course = C#
        Console.WriteLine("\n--- Students With Course C# ---");

        var csharpStudents = students.Where(s => s.Course == "C#");

        foreach (var s in csharpStudents)
        {
            Console.WriteLine($"{s.Name} - {s.Course}");
        }

        // 4. Students whose City = Pune
        Console.WriteLine("\n--- Students From Pune ---");

        var puneStudents = students.Where(s => s.City == "Pune");

        foreach (var s in puneStudents)
        {
            Console.WriteLine($"{s.Name} - {s.City}");
        }

        // 5. Students who are Passed
        Console.WriteLine("\n--- Passed Students ---");

        var passedStudents = students.Where(s => s.Marks >= 35);

        foreach (var s in passedStudents)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }

        // 6. Students admitted after StudentId > 2
        Console.WriteLine("\n--- Students Admitted After ID 2 ---");

        var admittedAfter2 = students.Where(s => s.StudentId > 2);

        foreach (var s in admittedAfter2)
        {
            Console.WriteLine($"{s.StudentId} - {s.Name}");
        }
    }
}