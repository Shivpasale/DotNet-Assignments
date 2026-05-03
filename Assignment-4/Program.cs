﻿using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    //Use List Format
    static List<int> studentId = new List<int>();
    static List<string> name = new List<string>();
    static List<int> age = new List<int>();
    static List<string> course = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Export to CSV");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: ViewStudents(); break;
                case 3: UpdateStudent(); break;
                case 4: DeleteStudent(); break;
                case 5: ExportToCSV(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter ID: ");
        studentId.Add(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Enter Name: ");
        name.Add(Console.ReadLine());

        Console.Write("Enter Age: ");
        age.Add(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Enter Course: ");
        course.Add(Console.ReadLine());

        Console.WriteLine("Student Added Successfully!");
    }

    static void ViewStudents()
    {
        if (studentId.Count == 0)
        {
            Console.WriteLine("No records found!");
            return;
        }

        for (int i = 0; i < studentId.Count; i++)
        {
            Console.WriteLine("\nID: " + studentId[i]);
            Console.WriteLine("Name: " + name[i]);
            Console.WriteLine("Age: " + age[i]);
            Console.WriteLine("Course: " + course[i]);
        }
    }

    static void UpdateStudent()
    {
        Console.Write("Enter ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        int index = studentId.IndexOf(id);
        if (index != -1)
        {
            Console.Write("Enter New Name: ");
            name[index] = Console.ReadLine();

            Console.Write("Enter New Age: ");
            age[index] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter New Course: ");
            course[index] = Console.ReadLine();

            Console.WriteLine("Updated Successfully!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        int index = studentId.IndexOf(id);
        if (index != -1)
        {
            studentId.RemoveAt(index);
            name.RemoveAt(index);
            age.RemoveAt(index);
            course.RemoveAt(index);

            Console.WriteLine("Deleted Successfully!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    static void ExportToCSV()
    {
        string path = "D:\\Projects\\DotNet-Assignments\\Assignment-4\\students.csv";

        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("StudentId,Name,Age,Course");

            for (int i = 0; i < studentId.Count; i++)
            {
                writer.WriteLine($"{studentId[i]},{name[i]},{age[i]},{course[i]}");
            }
        }

        Console.WriteLine("CSV file created successfully at: " + Path.GetFullPath(path));
    }
}