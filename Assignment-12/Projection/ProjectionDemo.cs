using System;
using System.Linq;

public class ProjectionDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== PROJECTION =====");

        var students = StudentData.GetStudents();

        var result = students.Select(s => $"{s.Name} - {s.Course} - {s.Marks}");

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}