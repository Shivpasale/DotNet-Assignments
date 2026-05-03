using System;
using System.Linq;

public class ElementDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== ELEMENT OPERATORS =====");

        var students = StudentData.GetStudents();

        // 1. Get First Student From Pune
        Console.WriteLine("\n--- First Student From Pune ---");

        var puneStudent = students.First(s => s.City == "Pune");

        Console.WriteLine($"{puneStudent.Name} - {puneStudent.City}");

        // 2. First Student From Delhi Using Safe Method
        Console.WriteLine("\n--- First Student From Delhi (Safe Method) ---");

        var delhiStudent = students.FirstOrDefault(s => s.City == "Delhi");

        if (delhiStudent != null)
        {
            Console.WriteLine($"{delhiStudent.Name} - {delhiStudent.City}");
        }
        else
        {
            Console.WriteLine("No Student Found");
        }

        // 3. Student With StudentId = 4
        Console.WriteLine("\n--- Student With ID = 4 ---");

        var student4 = students.SingleOrDefault(s => s.StudentId == 4);

        if (student4 != null)
        {
            Console.WriteLine($"{student4.Name} - {student4.StudentId}");
        }

        // 4. Student With Highest Marks
        Console.WriteLine("\n--- Student With Highest Marks ---");

        var topper = students
            .OrderByDescending(s => s.Marks)
            .First();

        Console.WriteLine($"{topper.Name} - {topper.Marks}");
    }
}