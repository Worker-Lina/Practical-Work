using System;

namespace InheretensPracticalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new int[] { 5, 5, 4, 4, 3 };
            var student = new Student()
            {
                Name = "Alina",
                FullName = "Chelovechkova",
                Grades = grades
            };
            Console.WriteLine($"Name: {student.Name}, FullName: {student.FullName}, grades: {student.GetAvgGrade()}");
        }
    }
}
