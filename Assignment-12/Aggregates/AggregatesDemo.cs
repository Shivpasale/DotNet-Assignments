using System;
using System.Linq;

public class AggregatesDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== AGGREGATES =====");

        var students = StudentData.GetStudents();

        // 1. Count Total Students
        Console.WriteLine("\n--- Total Students ---");

        int totalStudents = students.Count();

        Console.WriteLine("Total Students: " + totalStudents);

        // 2. Count Passed Students
        Console.WriteLine("\n--- Passed Students Count ---");

        int passedStudents = students.Count(s => s.Marks >= 35);

        Console.WriteLine("Passed Students: " + passedStudents);

        // 3. Find Highest Marks
        Console.WriteLine("\n--- Highest Marks ---");

        int maxMarks = students.Max(s => s.Marks);

        Console.WriteLine("Highest Marks: " + maxMarks);

        // 4. Find Lowest Marks
        Console.WriteLine("\n--- Lowest Marks ---");

        int minMarks = students.Min(s => s.Marks);

        Console.WriteLine("Lowest Marks: " + minMarks);

        // 5. Find Average Marks
        Console.WriteLine("\n--- Average Marks ---");

        double avgMarks = students.Average(s => s.Marks);

        Console.WriteLine("Average Marks: " + avgMarks);

        // 6. Total Marks Of C# Students
        Console.WriteLine("\n--- Total Marks Of C# Students ---");

        int totalCsharpMarks = students
            .Where(s => s.Course == "C#")
            .Sum(s => s.Marks);

        Console.WriteLine("Total C# Marks: " + totalCsharpMarks);
    }
}