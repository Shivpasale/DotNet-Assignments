using System;
using System.Linq;

public class PagingDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== PAGING =====");

        var students = StudentData.GetStudents();

        // 1. Get Top 2 Students By Marks
        Console.WriteLine("\n--- Top 2 Students By Marks ---");

        var top2 = students
            .OrderByDescending(s => s.Marks)
            .Take(2);

        foreach (var s in top2)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }

        // 2. Get Page 2 (pageSize = 2) sorted by StudentId
        Console.WriteLine("\n--- Page 2 (PageSize = 2) ---");

        int pageSize = 2;
        int pageNumber = 2;

        var page2 = students
            .OrderBy(s => s.StudentId)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);

        foreach (var s in page2)
        {
            Console.WriteLine($"{s.StudentId} - {s.Name}");
        }

        // 3. Skip First 2 Highest Marks and Take Next 2
        Console.WriteLine("\n--- Skip Top 2 and Take Next 2 ---");

        var rankingStyle = students
            .OrderByDescending(s => s.Marks)
            .Skip(2)
            .Take(2);

        foreach (var s in rankingStyle)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }
    }
}