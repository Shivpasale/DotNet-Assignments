using System.Collections.Generic;

public static class StudentData
{
    public static List<Student> GetStudents()
    {
        return new List<Student>
        {
            new Student { StudentId = 1, Name = "Shivam", Course = "C#", Marks = 78, City = "Pune" },
            new Student { StudentId = 2, Name = "Harry", Course = "Java", Marks = 45, City = "Mumbai" },
            new Student { StudentId = 3, Name = "Keshav", Course = "Python", Marks = 88, City = "Pune" },
            new Student { StudentId = 4, Name = "Kartik", Course = "Java", Marks = 92, City = "Delhi" },
            new Student { StudentId = 5, Name = "Rohit", Course = "C#", Marks = 35, City = "Mumbai" }
        };
    }
}