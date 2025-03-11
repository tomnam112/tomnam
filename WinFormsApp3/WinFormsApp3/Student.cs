namespace WinFormsApp3
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public double Grade { get; set; }

        public Student(int studentID, string name, string major, double grade)
        {
            StudentID = studentID;
            Name = name;
            Major = major;
            Grade = grade;
        }
    }

}