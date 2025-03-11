using System;
using System.Collections.Generic;
using WinFormsApp3;

class Program
{
    static List<Student> students = new List<Student>();
    static List<Advisor> advisors = new List<Advisor>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Advisor-Student Management Program!");

        // ตัวอย่างการเพิ่มข้อมูล
        Advisor advisor1 = new Advisor(101, "Dr. Smith", "Computer Science");
        Student student1 = new Student(1, "John Doe", "Computer Science", 3.9);

        advisor1.AddStudent(student1);
        advisors.Add(advisor1);
        students.Add(student1);

        // แสดงนักศึกษาที่ได้เกรดสูงสุด
        ShowTopStudent();
    }

    static void ShowTopStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Student topStudent = students[0];
        foreach (var student in students)
        {
            if (student.Grade > topStudent.Grade)
            {
                topStudent = student;
            }
        }
        Console.WriteLine($"Top student: {topStudent.Name}, Grade: {topStudent.Grade}");
    }
}
