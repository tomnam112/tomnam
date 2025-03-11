using WinFormsApp3;

using System.Collections.Generic;

public class Advisor
{
    public int AdvisorID { get; set; }
    public string Name { get; set; }
    public string Major { get; set; }
    public List<Student> Students { get; set; }

    public Advisor(int advisorID, string name, string major)
    {
        AdvisorID = advisorID;
        Name = name;
        Major = major;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}

