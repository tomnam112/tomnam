using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        // รายชื่อนักศึกษาและอาจารย์ที่ปรึกษา
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();
        }

        // เพิ่มนักศึกษา
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtStudentID.Text);
                string name = txtStudentName.Text;
                string major = txtStudentMajor.Text;
                double grade = double.Parse(txtStudentGrade.Text);

                Student newStudent = new Student(studentID, name, major, grade);
                students.Add(newStudent);

                MessageBox.Show("เพิ่มข้อมูลนักศึกษาเรียบร้อยแล้ว!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}");
            }
        }

        // เพิ่มอาจารย์ที่ปรึกษา
        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            try
            {
                int advisorID = int.Parse(txtAdvisorID.Text);
                string name = txtAdvisorName.Text;
                string major = txtAdvisorMajor.Text;

                Advisor newAdvisor = new Advisor(advisorID, name, major);
                advisors.Add(newAdvisor);

                MessageBox.Show("เพิ่มข้อมูลอาจารย์ที่ปรึกษาเรียบร้อยแล้ว!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}");
            }
        }

        // แสดงนักศึกษาในที่ปรึกษา
        private void btnShowAdvisorStudents_Click(object sender, EventArgs e)
        {
            try
            {
                int advisorID = int.Parse(txtSearchAdvisorID.Text);
                Advisor advisor = advisors.Find(a => a.AdvisorID == advisorID);

                if (advisor != null)
                {
                    dataGridView1.Rows.Clear();
                    foreach (var student in advisor.Students)
                    {
                        dataGridView1.Rows.Add(student.StudentID, student.Name, student.Major, student.Grade);
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบอาจารย์ที่ปรึกษาด้วยรหัสนี้!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}");
            }
        }

        // แสดงนักศึกษาที่ได้เกรดสูงสุด
        private void btnShowTopStudent_Click(object sender, EventArgs e)
        {
            if (students.Count > 0)
            {
                Student topStudent = students[0];
                foreach (var student in students)
                {
                    if (student.Grade > topStudent.Grade)
                    {
                        topStudent = student;
                    }
                }
                MessageBox.Show($"นักศึกษาที่ได้คะแนนเกรดสูงที่สุด: {topStudent.Name}, เกรด: {topStudent.Grade}");
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูลนักศึกษา!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
