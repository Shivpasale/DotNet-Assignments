using System;
using System.Linq;

public class SortingDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== SORTING =====");

        var students = StudentData.GetStudents();

        // 1. Sort By Marks
        Console.WriteLine("\n--- Sort By Marks ---");

        var sortMarks = students.OrderBy(s => s.Marks);

        foreach (var s in sortMarks)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }

        // 2. Sort By Name
        Console.WriteLine("\n--- Sort By Name ---");

        var sortName = students.OrderBy(s => s.Name);

        foreach (var s in sortName)
        {
            Console.WriteLine($"{s.Name}");
        }

        // 3. Sort By Course Then Marks
        Console.WriteLine("\n--- Sort By Course Then Marks ---");

        var sortCourseMarks = students
            .OrderBy(s => s.Course)
            .ThenBy(s => s.Marks);

        foreach (var s in sortCourseMarks)
        {
            Console.WriteLine($"{s.Course} - {s.Name} - {s.Marks}");
        }

        // 4. Sort By City Then Name
        Console.WriteLine("\n--- Sort By City Then Name ---");

        var sortCityName = students
            .OrderBy(s => s.City)
            .ThenBy(s => s.Name);

        foreach (var s in sortCityName)
        {
            Console.WriteLine($"{s.City} - {s.Name}");
        }
    }
}