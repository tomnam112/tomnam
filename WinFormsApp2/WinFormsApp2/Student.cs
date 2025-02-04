namespace WinFormsApp2
{
    public class Student
    {
        private double gpaSum = 0;
        private int count = 0;
        private double minGPA = double.MaxValue;

        public void SetGPA(double gpa)
        {
            gpaSum += gpa;
            count++;
            if (gpa < minGPA) minGPA = gpa;
        }

        public double GetGPAX()
        {
            return count > 0 ? gpaSum / count : 0;
        }

        public double GetMinGPA()
        {
            return count > 0 ? minGPA : 0;
        }
    }
}
