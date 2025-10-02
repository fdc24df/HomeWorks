namespace week9;
using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int EnrollmentYear { get; set; }

    private static Random random = new Random();

    public Student(string name, int age, int enrollmentYear)
    {
        Name = name;
        Age = age;
        EnrollmentYear = enrollmentYear;
    }

    public string ChooseRandomSubject()
    {
        List<string> subjects = new List<string> { "Mathematics", "Chemistry", "English", "History", "Physics" };
        int index = random.Next(subjects.Count);
        return subjects[index];
    }

    public int YearsLeftToGraduate()
    {
        int currentYear = 2025; 
        int studyDuration = 4;
        int yearsDone = currentYear - EnrollmentYear;
        int yearsLeft = studyDuration - yearsDone;
        return Math.Max(yearsLeft, 0);
    }
}

class Teacher
{
    public string Name { get; set; }
    public bool Certified { get; set; }

    private static Random random = new Random();

    public Teacher(string name, bool certified)
    {
        Name = name;
        Certified = certified;
    }

    public string CheckStudentSubject(string subject)
    {
        switch (subject)
        {
            case "Mathematics":
                int a = random.Next(1, 11);
                int b = random.Next(1, 11);
                return $"Sum of random numbers: {a} + {b} = {a + b}";
            case "Chemistry":
                return "H2O, CO2, NaCl";
            case "English":
                return "This is an English sentence.";
            default:
                return $"I am not competent in {subject}.";
        }
    }
}

class Program
{
    static void Main()
    {
        
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter student age: ");
        int studentAge = int.Parse(Console.ReadLine());

        Console.Write("Enter enrollment year: ");
        int enrollmentYear = int.Parse(Console.ReadLine());

        Student student = new Student(studentName, studentAge, enrollmentYear);

        Console.Write("Enter teacher name: ");
        string teacherName = Console.ReadLine();

        Console.Write("Is the teacher certified? (true/false): ");
        bool certified = bool.Parse(Console.ReadLine());

        Teacher teacher = new Teacher(teacherName, certified);

        Console.Write("Enter a subject: ");
        string subject = Console.ReadLine();

        // Output
        Console.WriteLine($"\nStudent chose: {subject}");
        Console.WriteLine($"Years left to graduate: {student.YearsLeftToGraduate()}");
        Console.WriteLine($"Teacher response: {teacher.CheckStudentSubject(subject)}");
    }
}
