using System;
using System.Linq;
using System.Collections.Generic;

public class DictionaryDemo
{
    public static void Run()
    {
        Console.WriteLine("\n===== DICTIONARY / LOOKUP =====");

        var students = StudentData.GetStudents();

        // 1. Dictionary<int, Student> by StudentId
        Console.WriteLine("\n--- Dictionary By StudentId ---");

        Dictionary<int, Student> studentDict =
            students.ToDictionary(s => s.StudentId);

        foreach (var item in studentDict)
        {
            Console.WriteLine(item.Key + " -> " + item.Value.Name);
        }

        // 2. Dictionary<string, List<Student>> by Course
        Console.WriteLine("\n--- Dictionary By Course ---");

        var courseDict = students
            .GroupBy(s => s.Course)
            .ToDictionary(g => g.Key, g => g.ToList());

        foreach (var item in courseDict)
        {
            Console.WriteLine("\nCourse: " + item.Key);

            foreach (var s in item.Value)
            {
                Console.WriteLine(s.Name);
            }
        }

        // 3. Lookup By City
        Console.WriteLine("\n--- Lookup By City (Pune Students) ---");

        var cityLookup = students.ToLookup(s => s.City);

        var puneStudents = cityLookup["Pune"];

        foreach (var s in puneStudents)
        {
            Console.WriteLine(s.Name + " - " + s.City);
        }
    }
}