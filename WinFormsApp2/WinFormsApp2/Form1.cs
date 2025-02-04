using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Student student = new Student(); // ใช้คลาส Student

        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click; // เพิ่ม Event ให้ปุ่ม
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbInputGPA.Text, out double gpa))
            {
                student.SetGPA(gpa);
                tbGPAx.Text = student.GetGPAX().ToString("F2"); // แสดง GPAX
                tbInputGPA.Clear(); // ล้างช่องใส่ GPA
            }
            else
            {
                MessageBox.Show("กรุณาใส่ค่าที่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Button btnAdd;

        private void InitializeComponent()
        {
            btnAdd = new Button();
            tbGPAx = new TextBox();
            tbInputGPA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(444, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 107);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbGPAx
            // 
            tbGPAx.Location = new Point(146, 45);
            tbGPAx.Name = "tbGPAx";
            tbGPAx.Size = new Size(182, 27);
            tbGPAx.TabIndex = 1;
            // 
            // tbInputGPA
            // 
            tbInputGPA.Location = new Point(146, 122);
            tbInputGPA.Name = "tbInputGPA";
            tbInputGPA.Size = new Size(182, 27);
            tbInputGPA.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "ใส่คะแนน GPAx";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 129);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "GPAx";
            // 
            // Form1
            // 
            ClientSize = new Size(579, 253);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbInputGPA);
            Controls.Add(tbGPAx);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox tbGPAx;
        private TextBox tbInputGPA;
        private Label label1;
        private Label label2;
    }
}

