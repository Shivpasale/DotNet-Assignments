using System;
using System.IO;

class Program
{
    static int[] studentId = new int[100];
    static string[] name = new string[100];
    static int[] age = new int[100];
    static string[] course = new string[100];

    static int count = 0;

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
        studentId[count] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        name[count] = Console.ReadLine();

        Console.Write("Enter Age: ");
        age[count] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Course: ");
        course[count] = Console.ReadLine();

        count++;
        Console.WriteLine("Student Added Successfully!");
    }

    static void ViewStudents()
    {
        if (count == 0)
        {
            Console.WriteLine("No records found!");
            return;
        }

        for (int i = 0; i < count; i++)
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

        for (int i = 0; i < count; i++)
        {
            if (studentId[i] == id)
            {
                Console.Write("Enter New Name: ");
                name[i] = Console.ReadLine();

                Console.Write("Enter New Age: ");
                age[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Course: ");
                course[i] = Console.ReadLine();

                Console.WriteLine("Updated Successfully!");
                return;
            }
        }

        Console.WriteLine("Student not found!");
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            if (studentId[i] == id)
            {
                for (int j = i; j < count - 1; j++)
                {
                    studentId[j] = studentId[j + 1];
                    name[j] = name[j + 1];
                    age[j] = age[j + 1];
                    course[j] = course[j + 1];
                }

                count--;
                Console.WriteLine("Deleted Successfully!");
                return;
            }
        }

        Console.WriteLine("Student not found!");
    }

    // ✅ NEW FEATURE
    static void ExportToCSV()
    {
        string path = "students.csv";

        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("StudentId,Name,Age,Course"); // Header

            for (int i = 0; i < count; i++)
            {
                writer.WriteLine($"{studentId[i]},{name[i]},{age[i]},{course[i]}");
            }
        }

        Console.WriteLine("CSV file created successfully at: " + Path.GetFullPath(path));
    }
}