using System;
using System.Linq;

public class GroupingDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== GROUPING =====");

        var students = StudentData.GetStudents();

        // 1. Group By Course
        Console.WriteLine("\n--- Group By Course ---");

        var groupCourse = students.GroupBy(s => s.Course);

        foreach (var group in groupCourse)
        {
            Console.WriteLine("\nCourse: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name);
            }
        }

        // 2. Group By City
        Console.WriteLine("\n--- Group By City ---");

        var groupCity = students.GroupBy(s => s.City);

        foreach (var group in groupCity)
        {
            Console.WriteLine("\nCity: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name);
            }
        }

        // 3. Course + Count
        Console.WriteLine("\n--- Course Wise Count ---");

        var courseCount = students
            .GroupBy(s => s.Course);

        foreach (var group in courseCount)
        {
            Console.WriteLine(group.Key + " : " + group.Count());
        }

        // 4. City + Average Marks
        Console.WriteLine("\n--- City Wise Average Marks ---");

        var cityAvg = students
            .GroupBy(s => s.City);

        foreach (var group in cityAvg)
        {
            Console.WriteLine(group.Key + " : " + group.Average(s => s.Marks));
        }

        // 5. Course With Highest Total Marks
        Console.WriteLine("\n--- Course With Highest Total Marks ---");

        var topCourse = students
            .GroupBy(s => s.Course)
            .Select(g => new
            {
                Course = g.Key,
                TotalMarks = g.Sum(s => s.Marks)
            })
            .OrderByDescending(g => g.TotalMarks)
            .First();

        Console.WriteLine(topCourse.Course + " : " + topCourse.TotalMarks);
    }
}