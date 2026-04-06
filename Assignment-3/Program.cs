using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n==== STUDENT MANAGEMENT SYSTEM ====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. List Students");
            Console.WriteLine("5. Find by ID");
            Console.WriteLine("6. Export to CSV");
            Console.WriteLine("0. Exit");

            Console.Write("Enter choice: ");
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: UpdateStudent(); break;
                case 3: DeleteStudent(); break;
                case 4: ListStudents(); break;
                case 5: FindStudent(); break;
                case 6: ExportToCSV(); break;
                case 0: return;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    static void AddStudent()
    {
        try
        {
            Student s = new Student();

            Console.Write("Enter ID: ");
            s.StudentId = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            s.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Course: ");
            s.Course = Console.ReadLine();

            students.Add(s);
            Console.WriteLine("Student Added!");
        }
        catch
        {
            Console.WriteLine("Invalid input!");
        }
    }

    static void UpdateStudent()
    {
        Console.Write("Enter ID to update: ");
        int id;

        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Student s = students.Find(x => x.StudentId == id);

        if (s == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        Console.Write("Enter new Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter new Age: ");
        s.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter new Course: ");
        s.Course = Console.ReadLine();

        Console.WriteLine("Student Updated!");
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id;

        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Student s = students.Find(x => x.StudentId == id);

        if (s == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        students.Remove(s);
        Console.WriteLine("Student Deleted!");
    }

    static void ListStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.StudentId}, Name: {s.Name}, Age: {s.Age}, Course: {s.Course}");
        }
    }

    static void FindStudent()
    {
        Console.Write("Enter ID: ");
        int id;

        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Student s = students.Find(x => x.StudentId == id);

        if (s == null)
        {
            Console.WriteLine("Student not found!");
        }
        else
        {
            Console.WriteLine($"ID: {s.StudentId}, Name: {s.Name}, Age: {s.Age}, Course: {s.Course}");
        }
    }

    // CSV EXPORT PART
    static void ExportToCSV()
    {
        try
        {
            string filePath = @"D:\Projects\DotNet-Assignments\Assignment-3\students.csv";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("StudentId,Name,Age,Course");

                foreach (var s in students)
                {
                    writer.WriteLine($"{s.StudentId},{s.Name},{s.Age},{s.Course}");
                }
            }

            Console.WriteLine("Data exported to students.csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}