namespace WinFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentMajor;
        private System.Windows.Forms.TextBox txtStudentGrade;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentMajor;
        private System.Windows.Forms.Label lblStudentGrade;

        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtStudentMajor = new TextBox();
            txtStudentGrade = new TextBox();
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblStudentMajor = new Label();
            lblStudentGrade = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(200, 260);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(100, 30);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "เพิ่มนักศึกษา";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(150, 50);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(200, 27);
            txtStudentID.TabIndex = 1;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(0, 0);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(100, 27);
            txtStudentName.TabIndex = 0;
            // 
            // txtStudentMajor
            // 
            txtStudentMajor.Location = new Point(0, 0);
            txtStudentMajor.Name = "txtStudentMajor";
            txtStudentMajor.Size = new Size(100, 27);
            txtStudentMajor.TabIndex = 0;
            // 
            // txtStudentGrade
            // 
            txtStudentGrade.Location = new Point(0, 0);
            txtStudentGrade.Name = "txtStudentGrade";
            txtStudentGrade.Size = new Size(100, 27);
            txtStudentGrade.TabIndex = 0;
            // 
            // lblStudentID
            // 
            lblStudentID.Location = new Point(0, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(100, 23);
            lblStudentID.TabIndex = 0;
            // 
            // lblStudentName
            // 
            lblStudentName.Location = new Point(0, 0);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(100, 23);
            lblStudentName.TabIndex = 0;
            // 
            // lblStudentMajor
            // 
            lblStudentMajor.Location = new Point(0, 0);
            lblStudentMajor.Name = "lblStudentMajor";
            lblStudentMajor.Size = new Size(100, 23);
            lblStudentMajor.TabIndex = 0;
            // 
            // lblStudentGrade
            // 
            lblStudentGrade.Location = new Point(0, 0);
            lblStudentGrade.Name = "lblStudentGrade";
            lblStudentGrade.Size = new Size(100, 23);
            lblStudentGrade.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 414);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 50);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "ชื่อ-นามสกุล";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "สาขาที่เรียน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 156);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 6;
            label4.Text = "อาจารย์ที่ปรึกษา";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            ClientSize = new Size(1038, 485);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnAddStudent);
            Controls.Add(txtStudentID);
            Name = "Form1";
            Text = "รายชื่อ";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
    }
}
